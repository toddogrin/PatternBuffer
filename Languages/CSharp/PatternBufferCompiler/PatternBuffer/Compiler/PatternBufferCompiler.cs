using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PatternBuffer.Schema;
using PBUV = PatternBuffer.PatternBufferUnsignedVariantUtil;
using PBP = PatternBuffer.PatternBufferPrimitiveUtil;
using PB = PatternBuffer.PatternBufferUtil;
using PBC = PatternBuffer.PatternBufferCollectionUtil;

namespace PatternBuffer.Compiler {

    /**
     * A C# implementation of a PatternBuffer compiler. This class takes in a PatternBufferSchema and 
     * transforms it into multiple C# source files that, once compiled, can serialized all the types
     * defined in the schema.
     */
    public class PatternBufferCompiler {

        //---------------------------------------------------
        // Constants
        //---------------------------------------------------

        // Goes at the top of every file.
        private const string BOILERPLATE =
            @"
/////////////////////////////////////
// GENERATED CODE -- DO NOT MODIFY //
/////////////////////////////////////

";

        // The name of the default path hint.
        private const string HINT_PB_PATH = "pb.path";

        // The name of the default comment hint.
        private const string HINT_PB_COMMENT = "pb.comment";

        //---------------------------------------------------
        // Bookeeping
        //---------------------------------------------------

        private static Dictionary<ushort, byte[]> typeIdByteMap = new Dictionary<ushort, byte[]>();

        // A random number generator used for generating C# variable names that don't collide.
        private static Random random = new Random();

        // The C# namespace to use on generated classes.
        private string generatedNamespace;


        //---------------------------------------------------
        // Public properties for controlling compiler output
        //---------------------------------------------------
        
        /**
         *  This controls if the compiler generates a threadsafe PatternBuffer implementation.
         *  If true, the compiler will add lock statements to synchronize serialization at the cost of roughly +25% time.
         *  If false (default), the compiler omits lock statements but the generated PatterBuffer class will not be threadsafe.
         *  
         *  NOTE: Threadsafety can also be achieved by pooling multiple PatternBuffer implementations. Be aware that this 
         *        creates multiple internal byte buffers. This is actually probably the most efficient, but the pooling
         *        and instance management is up to you.
         */
        public bool MakeThreadsafe = false;

        /**
         * A string literal to be included at the top of every generated file.
         */
        public string Boilerplate = BOILERPLATE;

        /**
         * Creates a PatternBufferCompiler that generates code with the given C# namespace.
         */
        public PatternBufferCompiler(string generatedNamespace) {
            this.generatedNamespace = generatedNamespace;
        }

        public string GenerateComment(IPatternBufferHinted hinted) {
            string comment = "";
            if (hinted.ContainsHint(PatternBufferCompiler.HINT_PB_COMMENT)) {
                comment += "\r\n";
                comment += "    /**\r\n";
                comment += "     * " + hinted.GetHint(PatternBufferCompiler.HINT_PB_COMMENT);
                comment += "\r\n     */\r\n";
            }
            return comment;
        }

        /**
         * Compiles the given schema into C# source code. A Dictionary is returned whose key values
         * are the paths and file names of the source files generated, and whose values are the
         * generated source code.
         */
        public Dictionary<string,string> Compile(PatternBufferSchema schema) {
            
            Dictionary<string, string> results = new Dictionary<string, string>();

            // Calculate the byte sizes of the type IDs (these don't change, so do it once)
            foreach (PatternBufferType t in schema.Types) {
                typeIdByteMap[t.TypeId] = PBUV.VUInt64ToBytes(t.TypeId);
            }

            // Generate enums
            Console.WriteLine("Compiling "+schema.Enums.Count+" enums...");
            foreach (PatternBufferEnum e in schema.Enums) {
                string csName = PB.ToCSharpName(e.Name);
                this.GenerateEnum(results, e);
            }

            // Generate base type enum
            Console.WriteLine("Compiling " + schema.Name + " domain object interface...");
            this.GenerateISchemaNameObject(results, schema);

            // Generate types
            Console.WriteLine("Compiling " + schema.Types.Count + " types into domain objects...");
            foreach (PatternBufferType t in schema.Types) {
                this.GenerateType(results, t, PB.ToCSharpName(schema.Name));
            }

            // Generate PatternBuffer
            Console.WriteLine("Compiling pattern buffer...");
            this.GeneratePatternBuffer(results, schema);

            // Generate PatternBufferException
            Console.WriteLine("Compiling pattern buffer exception...");
            this.GeneratePatternBufferException(results, schema);

            // Generate Instantiator
            Console.WriteLine("Compiling pattern buffer instantiator...");
            this.GeneratePatternBufferInstantiatorInterface(results, schema);
            this.GeneratePatternBufferDefaultInstantiator(results, schema);

            return results;
        }

        public Dictionary<string, IFieldType> GetInstantiableFields(PatternBufferSchema s) {
            Dictionary<string, IFieldType> instantiableFieldTypes = new Dictionary<string, IFieldType>();
            foreach (PatternBufferType t in s.Types) {
                string typeName = PB.ToCSharpName(t.Name);
                foreach (PatternBufferField f in t.Fields) {
                    IFieldType fieldType = f.FieldType;
                    if (fieldType is ListFieldType) {
                        instantiableFieldTypes[PB.ToCSharpType(fieldType)] = fieldType;
                        ListFieldType listFieldType = (ListFieldType)fieldType;
                        instantiableFieldTypes[PB.ToCSharpType(listFieldType.ElementType)] = listFieldType.ElementType;
                    }
                    else if (fieldType is SetFieldType) {
                        instantiableFieldTypes[PB.ToCSharpType(fieldType)] = fieldType;
                        SetFieldType setFieldType = (SetFieldType)fieldType;
                        instantiableFieldTypes[PB.ToCSharpType(setFieldType.ElementType)] = setFieldType.ElementType;
                    }
                    else if (fieldType is MapFieldType) {
                        instantiableFieldTypes[PB.ToCSharpType(fieldType)] = fieldType;
                        MapFieldType mapFieldType = (MapFieldType)fieldType;
                        instantiableFieldTypes[PB.ToCSharpType(mapFieldType.KeyType)] = mapFieldType.KeyType;
                        instantiableFieldTypes[PB.ToCSharpType(mapFieldType.ValueType)] = mapFieldType.ValueType;
                        IFieldType keyListFieldType = new ListFieldType(mapFieldType.KeyType);
                        IFieldType valueListFieldType = new ListFieldType(mapFieldType.ValueType);
                        instantiableFieldTypes[PB.ToCSharpType(keyListFieldType)] = keyListFieldType;
                        instantiableFieldTypes[PB.ToCSharpType(valueListFieldType)] = valueListFieldType;
                    }
                }
            }
            return instantiableFieldTypes;
        }

        public void GeneratePatternBufferInstantiatorInterface(Dictionary<string, string> results, PatternBufferSchema s) {
            string code = this.Boilerplate;
            string schemaName = PB.ToCSharpName(s.Name);
            code += "using System.Collections.Generic;\r\n";
            code += "namespace " + this.generatedNamespace + " {\r\n";
            code += "    public interface I" + schemaName + "Instantiator {\r\n";

            foreach (PatternBufferType t in s.Types) {
                string typeName = PB.ToCSharpName(t.Name);
                code += "        " + typeName + " Acquire" + typeName + "();\r\n";
                code += "        void Discard" + typeName + "(" + typeName+ " o);\r\n";
            }
            code += "\r\n";

            // Add aggregate field types
            Dictionary<string, IFieldType> instantiableFieldTypes = this.GetInstantiableFields(s);
            foreach (IFieldType fieldType in instantiableFieldTypes.Values) {
                if (fieldType is ListFieldType) {
                    string listTypeName = PB.ToCSharpType(fieldType);
                    string elementTypeName = PB.ToCapitalizedCSharpType(((ListFieldType)fieldType).ElementType);
                    code += "        " + listTypeName + " AcquireListOf" + elementTypeName + "();\r\n";
                    code += "        void DiscardListOf" + elementTypeName + "(" + listTypeName + " o);\r\n";
                }
                else if (fieldType is SetFieldType) {
                    string listTypeName = PB.ToCSharpType(fieldType);
                    string elementTypeName = PB.ToCapitalizedCSharpType(((SetFieldType)fieldType).ElementType);
                    code += "        " + listTypeName + " AcquireHashSetOf" + elementTypeName + "();\r\n";
                    code += "        void DiscardHashSetOf" + elementTypeName + "(" + listTypeName + " o);\r\n";
                }
                else if (fieldType is MapFieldType) {
                    string mapTypeName = PB.ToCSharpType(fieldType);
                    string keyTypeName = PB.ToCapitalizedCSharpType(((MapFieldType)fieldType).KeyType);
                    string valueTypeName = PB.ToCapitalizedCSharpType(((MapFieldType)fieldType).ValueType);
                    code += "        " + mapTypeName + " AcquireDictionaryOf" + keyTypeName + "To" + valueTypeName + "();\r\n";
                    code += "        void DiscardDictionaryOf" + keyTypeName + "To" + valueTypeName + "(" + mapTypeName + " o);\r\n";
                }
            }
            code += "\r\n";

            code += "        byte[] AcquireByteArray(int size);\r\n";
            code += "        void DiscardByteArray(byte[] bytes);\r\n";
            code += "\r\n";
                        code += "    }\r\n";
            code += "}\r\n";
            results["I" + schemaName + "Instantiator.cs"] = code;
        }

        public void GeneratePatternBufferDefaultInstantiator(Dictionary<string, string> results, PatternBufferSchema s) {
            string code = this.Boilerplate;
            string schemaName = PB.ToCSharpName(s.Name);
            code += "using System.Collections.Generic;\r\n";
            code += "namespace " + this.generatedNamespace + " {\r\n";
            code += "    public class Default" + schemaName + "Instantiator : I" + schemaName + "Instantiator {\r\n";

            foreach (PatternBufferType t in s.Types) {
                string typeName = PB.ToCSharpName(t.Name);
                code += "        public " + typeName + " Acquire" + typeName + "() {\r\n";
                code += "            return new " + typeName + "();\r\n";
                code += "        }\r\n";
                code += "        public void Discard" + typeName + "(" + typeName + " o) {\r\n";
                code += "            // Dispose?\r\n";
                code += "        }\r\n";
            }
            code += "\r\n";

            // Add aggregate field types
            Dictionary<string, IFieldType> instantiableFieldTypes = this.GetInstantiableFields(s);
            foreach (IFieldType fieldType in instantiableFieldTypes.Values) {
                if (fieldType is ListFieldType) {
                    string listTypeName = PB.ToCSharpType(fieldType);
                    string elementTypeName = PB.ToCapitalizedCSharpType(((ListFieldType)fieldType).ElementType);
                    code += "        public " + listTypeName + " AcquireListOf" + elementTypeName + "() {\r\n";
                    code += "            return new " + listTypeName + "();\r\n";
                    code += "        }\r\n";
                    code += "        public void DiscardListOf" + elementTypeName + "(" + listTypeName + " o) {\r\n";
                    code += "            // Dispose?\r\n";
                    code += "        }\r\n";
                }
                else if (fieldType is SetFieldType) {
                    string listTypeName = PB.ToCSharpType(fieldType);
                    string elementTypeName = PB.ToCapitalizedCSharpType(((SetFieldType)fieldType).ElementType);
                    code += "        public " + listTypeName + " AcquireHashSetOf" + elementTypeName + "() {\r\n";
                    code += "            return new " + listTypeName + "();\r\n";
                    code += "        }\r\n";
                    code += "        public void DiscardHashSetOf" + elementTypeName + "(" + listTypeName + " o) {\r\n";
                    code += "            // Dispose?\r\n";
                    code += "        }\r\n";
                }
                else if (fieldType is MapFieldType) {
                    string mapTypeName = PB.ToCSharpType(fieldType);
                    string keyTypeName = PB.ToCapitalizedCSharpType(((MapFieldType)fieldType).KeyType);
                    string valueTypeName = PB.ToCapitalizedCSharpType(((MapFieldType)fieldType).ValueType);
                    code += "        public " + mapTypeName + " AcquireDictionaryOf" + keyTypeName + "To" + valueTypeName + "() {\r\n";
                    code += "            return new " + mapTypeName + "();\r\n";
                    code += "        }\r\n";
                    code += "        public void DiscardDictionaryOf" + keyTypeName + "To" + valueTypeName + "(" + mapTypeName + " o) {\r\n";
                    code += "            // Dispose?\r\n";
                    code += "        }\r\n";
                }
            }
            code += "\r\n";

            code += "        public byte[] AcquireByteArray(int size) {\r\n";
            code += "            return new byte[size];\r\n";
            code += "        }\r\n";
            code += "        public void DiscardByteArray(byte[] bytes) {\r\n";
            code += "            // Dispose?\r\n";
            code += "        }\r\n";

            code += "    }\r\n";
            code += "}\r\n";
            results["Default" + schemaName + "Instantiator.cs"] = code;
        }


        /**
         * Generates the interface implemented by all domain objects generated from the .pb. This
         * is for type switching on abstract references in lists, sets, etc.
         */
        public void GenerateISchemaNameObject(Dictionary<string, string> results, PatternBufferSchema s) {
            string code = this.Boilerplate;
            string schemaName = PB.ToCSharpName(s.Name);
            code += "namespace " + this.generatedNamespace + " {\r\n";
            code += "    public interface " + PB.ToSchemaObjectTypeName(s) + " {\r\n";
            code += "        ushort TypeId { get; }\r\n";
            code += "    }\r\n";
            code += "}\r\n";
            results["I" + schemaName + "Object.cs"] = code;
        }

        /**
         * Generates the C# enum file corresponding to a PatternBufferEnum.
         */
        protected void GenerateEnum(Dictionary<string, string> results, PatternBufferEnum e) {
            string enumName = PB.ToCSharpName(e.Name);
            string code = this.Boilerplate;
            code += "namespace "+this.generatedNamespace+" {\r\n";
            code += this.GenerateComment(e);
            code += "    public enum "+enumName+" {\r\n";
            for (int i = 0; i < e.Values.Count; i++) {
                code += "        "+e.Values[i]+(i < e.Values.Count - 1 ? "," : "")+"\r\n";
            }
            code += "    }\r\n";
            code += "}\r\n";
            
            results[this.GetPath(e) + enumName + ".cs"] = code;
        }

        /**
         * Generates an exception class for this generated PatternBuffer
         */
        protected void GeneratePatternBufferException(Dictionary<string, string> results, PatternBufferSchema schema) {
            string schemaName = PB.ToCSharpPropertyName(schema.Name);
            string code = "";
            code += "using System;\r\n";
            code += "namespace PatternBuffer {\r\n";
            code += "    public class " + schemaName + "PatternBufferException : Exception {\r\n";
            code += "        public " + schemaName + "PatternBufferException(string message) : base(message) { }\r\n";
            code += "    }\r\n";
            code += "}\r\n";
            results[schemaName + "PatternBufferException.cs"] = code;
        }

        /**
         * Generates the C# source code for a PatternBufferType's class file.
         */
        protected void GenerateType(Dictionary<string, string> results, PatternBufferType t, string schemaName) {

            string className = PB.ToCSharpName(t.Name);
            string code = this.Boilerplate;
            code += "using PatternBuffer;\r\n";
            code += "using System;\r\n";
            code += "using System.Collections.Generic;\r\n";
            code += "namespace "+this.generatedNamespace+" {\r\n";
            code += this.GenerateComment(t);
            code += "    public class " + className + " : ";
            bool hasBaseType = t.BaseType != null;
            if (hasBaseType) {
                code += PB.ToCSharpName(t.BaseType.Name) + ", ";
            }
            code += "I" + schemaName + "Object, ";
            code += "IEquatable<"+ className + ">";
            code += " {\r\n";
            code += "\r\n";
            code += "        public " + (hasBaseType ? "new " : "") + "const ushort TYPE_ID = " + t.TypeId + ";\r\n";
            code += "        public " + (hasBaseType ? "new " : "") + "ushort TypeId {\r\n";
            code += "            get { return TYPE_ID; }\r\n";
            code += "        }\r\n";
        
            // Get all the fields in this type's hierarchy
            List<PatternBufferField> allFields = PB.GetAllFields(t);

            if (allFields.Count > 0) {
                code += "\r\n";
                // This type's fields
                foreach (PatternBufferField field in t.Fields) {
                    string fieldName = PB.ToCSharpPropertyName(field.Name);
                    string fieldTypeName = PB.ToCSharpType(field.FieldType);
                    string fieldPropertyName = PB.ToCSharpPropertyName(field.Name);
                    code += "        public " + fieldTypeName + " " + fieldName + "; // (" + (PB.IsOptional(field.FieldType) ? "optional" : "required") + ")\r\n";
                }
                code += "\r\n";
            }

            // No args constructor
            code += "        public "+className+"() {\r\n";
            foreach (PatternBufferField field in allFields) {
                string fieldName = PB.ToCSharpPropertyName(field.Name);
                string fieldTypeName = PB.ToCSharpType(field.FieldType);
                code += "            this."+fieldName+" = default("+fieldTypeName+");\r\n";
            }
            code += "        }\r\n\r\n";

            // Do we have fields?
            if (allFields.Count > 0) {

                // All args constructor
                code += "        public " + className + "(\r\n";
                foreach (PatternBufferField field in allFields) {
                    string fieldName = PB.ToCSharpName(field.Name);
                    string fieldTypeName = PB.ToCSharpType(field.FieldType);
                    code += "            " + fieldTypeName + " " + fieldName + (field == allFields[allFields.Count - 1] ? "" : ",") + "\r\n";
                }
                code += "        ) {\r\n";
                foreach (PatternBufferField field in allFields) {
                    string fieldName = PB.ToCSharpName(field.Name);
                    string fieldTypeName = PB.ToCSharpType(field.FieldType);
                    code += "            this." + PB.ToCSharpPropertyName(fieldName) + " = " + fieldName + ";\r\n";
                }
                code += "        }\r\n\r\n";
            }

            // Equals methods
            code += "        public bool Equals(" + className + " other) {\r\n";
            code += "            return this.Equals((object)other);\r\n";
            code += "        }\r\n";
            code += "        public override bool Equals(object other) {;\r\n";
            //code += "            if (other == null) { return false; }\r\n";
            code += "            if (Object.ReferenceEquals(this, other)) { return true; }\r\n";
            code += "            if ( ! (other is " + className  + ")) { return false; }\r\n";
            code += "            " + className + " that = (" + className + ")other;\r\n";
            code += "            if (this.GetHashCode() != that.GetHashCode()) return false;\r\n";
            foreach (PatternBufferField field in t.Fields) {
                string fieldName = PB.ToCSharpPropertyName(field.Name);
                string fieldTypeName = PB.ToCSharpType(field.FieldType);
                string fieldPropertyName = PB.ToCSharpPropertyName(field.Name);
                code += "            // " + fieldName + (PB.IsOptional(field.FieldType) ? " (optional)" : " (required)") + "\r\n";
                if (field.FieldType is PrimitiveFieldType || field.FieldType is ReferenceFieldType) {
                    this.AppendTypeClassEqualsValue(ref code, field.FieldType, "this."+fieldName, "that." + fieldName);
                }
                else if (field.FieldType is ListFieldType) {
                    ListFieldType listFieldType = (ListFieldType)field.FieldType;
                    this.AppendTypeClassEqualsCollection(ref code, listFieldType, PB.ToCSharpType(listFieldType.ElementType), "this." + fieldName, "that." + fieldName);
                }
                else if (field.FieldType is SetFieldType) {
                    SetFieldType setFieldType = (SetFieldType)field.FieldType;
                    this.AppendTypeClassEqualsCollection(ref code, setFieldType, PB.ToCSharpType(setFieldType.ElementType), "this." + fieldName, "that." + fieldName);
                }
                else if (field.FieldType is MapFieldType) {
                    MapFieldType mapFieldType = (MapFieldType)field.FieldType;
                    string keyTypeName = PB.ToCSharpType(mapFieldType.KeyType);
                    // Verify key/value counts are equal
                    this.AppendTypeClassEqualsMutualNullCheck(ref code, "this." + fieldName, "that." + fieldName);
                    code += "            if (that." + fieldName + ".Count != this." + fieldName + ".Count) { return false; }\r\n";
                    // Loop to verify keys exist and values match
                    code += "            foreach (" + keyTypeName + " key in this." + fieldName + ".Keys) {\r\n";
                    code += "                if ( ! that." + fieldName+".ContainsKey(key)) { return false; }\r\n";
// TODO null check                    
                    this.AppendTypeClassEqualsValue(ref code, field.FieldType, "this." + fieldName + "[key]", "that." + fieldName + "[key]");
                    code += "            }\r\n";
                }
            }
            code += "            return true;\r\n";
            code += "        }\r\n\r\n";
            this.AppendTypeClassGetHashCode(ref code, t);
            code += "    }\r\n";
            code += "}\r\n";

            results[this.GetPath(t) + className + ".cs"] = code;
        }

        protected void AppendTypeClassEqualsValue(ref string code, IFieldType fieldType, string fieldName1, string fieldName2) {
            if (fieldType is PrimitiveFieldType) {
                PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)fieldType;
                if (primitiveFieldType.PrimitiveType == PrimitiveType.String) {
                    this.AppendTypeClassEqualsMutualNullCheck(ref code, fieldName1, fieldName1);
                    code += "            if ( ! " + fieldName1 + ".Equals(" + fieldName2 + ")) { return false; }\r\n";
                }
                else {
                    code += "            if (" + fieldName1 + " != " + fieldName2 + ") { return false; }\r\n";
                }
            }
            else if (fieldType is ReferenceFieldType) {
                ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                if (referenceFieldType.Referrable is PatternBufferEnum) {
                    PatternBufferEnum patternBufferEnum = (PatternBufferEnum)referenceFieldType.Referrable;
                    code += "            if ( " + fieldName1 + " != " + fieldName2 + ") { return false; }\r\n";
                }
                else if (referenceFieldType.Referrable is PatternBufferType) {
                    code += "            if ( ! (" + fieldName1 + " == null && " + fieldName2 + " == null)) {\r\n";
                    this.AppendTypeClassEqualsMutualNullCheck(ref code, fieldName1, fieldName2);
                    PatternBufferType patternBufferType = (PatternBufferType)referenceFieldType.Referrable;
                    code += "            if ( ! " + fieldName1 + ".Equals(" + fieldName2 + ")) { return false; }\r\n";
                    code += "            }\r\n";
                }
            }
        }

        protected void AppendTypeClassEqualsCollection(ref string code, IFieldType collectionType, string fieldTypeName, string fieldName1, string fieldName2) {
            List<int> x = new List<int>();
            this.AppendTypeClassEqualsMutualNullCheck(ref code, fieldName1, fieldName2);
            code += "            if (" + fieldName1 + " != null && " + fieldName2 + " != null) {\r\n";
            code += "                if (" + fieldName1 + ".Count != " + fieldName2 + ".Count) { return false; }\r\n";
            string field1EnumeratorName = PB.CreateRandomFieldName("enumerator");
            string collectionTypeName = null;
            IFieldType elementType = null;
            if (collectionType is ListFieldType) {
                collectionTypeName = "List";
                elementType = ((ListFieldType)collectionType).ElementType;
            }
            else {
                collectionTypeName = "HashSet";
                elementType = ((SetFieldType)collectionType).ElementType;
            }
            code += "                " + collectionTypeName + "<"+ fieldTypeName + ">.Enumerator "+ field1EnumeratorName + " = " + fieldName1 + ".GetEnumerator();\r\n";
            string field2EnumeratorName = PB.CreateRandomFieldName("enumerator");
            code += "                " + collectionTypeName + "<" + fieldTypeName + ">.Enumerator " + field2EnumeratorName + " = " + fieldName2 + ".GetEnumerator();\r\n";
            code += "                while(true) {\r\n";
            code += "                     if ( ! " + field1EnumeratorName + ".MoveNext()) { break; }\r\n";
            code += "                    " + field2EnumeratorName + ".MoveNext();\r\n";
            this.AppendTypeClassEqualsValue(ref code, elementType, field1EnumeratorName+".Current", field2EnumeratorName + ".Current");
            code += "                }\r\n";
            code += "            }\r\n";
        }

        /**
         * Appends a mutual null check into the C# code.
         */
        protected void AppendTypeClassEqualsMutualNullCheck(ref string code, string fieldName1, string fieldName2) {
            code += "                if (" + fieldName1 + " == null && " + fieldName2 + " != null) { return false; }\r\n";
            code += "                if (" + fieldName2 + " != null && " + fieldName1 + " == null) { return false; }\r\n";
        }

        /**
         * Appends C# code to compute a type's hash code.
         */
        protected void AppendTypeClassGetHashCode(ref string code, PatternBufferType patternBufferType) {
            code += "        public override int GetHashCode() {\r\n";
            code += "            unchecked {\r\n";
            code += "                int hash = 27;\r\n";
            List<PatternBufferField> allFields = PB.GetAllFields(patternBufferType);
            foreach (PatternBufferField field in allFields) {
                IFieldType fieldType = field.FieldType;
                string fieldName = PB.ToCSharpPropertyName(field.Name);
                if (fieldType is ReferenceFieldType) {
                    ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                    if (referenceFieldType.Referrable is PatternBufferEnum) {
                        code += "                hash = (13*hash) + this." + fieldName + ".GetHashCode();\r\n";
                    }
                    else if (referenceFieldType.Referrable is PatternBufferType) {
                        code += "                hash = (13*hash) + (this." + fieldName + " == null ? 0 : this." + fieldName + ".GetHashCode());\r\n";
                    }
                }
                else if (fieldType is PrimitiveFieldType) {
                    code += "                hash = (13*hash) + this." + fieldName + ".GetHashCode();\r\n";
                }
                else {
                    code += "                hash = (13*hash) + (this." + fieldName + " == null ? 0 : this." + fieldName + ".GetHashCode());\r\n";
                }
            }
            code += "                return hash;\r\n";
            code += "            }\r\n";
            code += "        }\r\n";
        }

        /**
         * Generates the FromBytes method for a PatternBufferType serializer class.
         */
        protected void AppendSerializerFromBytes(ref string code, string typeClassName, PatternBufferType t) {

            if (t.HasNullableFields) {
                code += "                // NULL FLAGS\r\n";
                int nullFlagsBytes = (t.NullableFieldCount / 8) + 1;
                code += "                int nullFlagsIndex = index - 1;\r\n";
                code += "                index += " + nullFlagsBytes + ";\r\n";
            }
            int nullableFieldFlagPlace = -1;

            code += "                "+typeClassName+" o = this.instantiator.Acquire"+typeClassName+"();\r\n";
            List<PatternBufferField> allFields = PB.GetAllFields(t);
            foreach (PatternBufferField field in allFields) {

                if (t.HasNullableFields && nullableFieldFlagPlace < 0) {
                    nullableFieldFlagPlace = 7;
                    code += "                nullFlagsIndex++;\r\n";
                }

                IFieldType fieldType = field.FieldType;
                string fieldTypeName = PB.ToCSharpType(field.FieldType);
                string fieldName = PB.ToCSharpPropertyName(field.Name);
                if (fieldType is PrimitiveFieldType) {
                    PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)fieldType;
                    code += "                // PRIMITIVE: " + fieldName + "\r\n";
                    if (primitiveFieldType.PrimitiveType == PrimitiveType.Bool) {
                        PBP.AppendReadBool(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Byte) {
                        PBP.AppendReadByte(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Double) {
                        PBP.AppendReadDouble(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Float) {
                        PBP.AppendReadFloat(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Int) {
                        PBP.AppendReadInt32(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Long) {
                        PBP.AppendReadInt64(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Short) {
                        PBP.AppendReadInt16(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.String) {
                        PBP.AppendReadString(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.UInt) {
                        PBP.AppendReadUInt32(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.ULong) {
                        PBP.AppendReadUInt64(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.UShort) {
                        PBP.AppendReadUInt16(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VInt) {
                        PBP.AppendReadVInt32(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VLong) {
                        PBP.AppendReadVInt64(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VUInt) {
                        PBP.AppendReadVUInt32(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VULong) {
                        PBP.AppendReadVUInt64(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VUShort) {
                        PBP.AppendReadVUInt16(ref code, "o." + fieldName);
                    }
                }
                else if (fieldType is ReferenceFieldType) {
                    code += "                // REFERENCE: " + fieldName+"\r\n";
                    ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                    if (referenceFieldType.Referrable is PatternBufferType) {
                        code += "                if ((bytes[nullFlagsIndex] & (byte)" + (1 << nullableFieldFlagPlace--) + ") > 0) {\r\n";
                        PB.AppendReadReference(ref code, (PatternBufferType)referenceFieldType.Referrable, "o." + fieldName);
                        code += "                }\r\n";
                    }
                    else {
                        string enumName = PB.ToCSharpName(referenceFieldType.ReferrableName);
                        //code += "                ////o." + fieldName + " = (" + enumName + ")System.Enum.Parse(typeof(" + enumName + "), this.patternBuffer.GetEnumValue(\""+ enumName + "\", reader.ReadByte()));\r\n";
                        string enumValueFieldName = PB.CreateRandomFieldName("enumValue");
                        code += "                byte " + enumValueFieldName + ";\r\n";
                        PBP.AppendReadByte(ref code, enumValueFieldName);
                        code += "                o." + fieldName + " = (" + enumName + ")System.Enum.Parse(typeof(" + enumName + "), enumIndexValueMap[\"" + referenceFieldType.ReferrableName + "\"][" + enumValueFieldName + "]);\r\n";
                    }
                }
                else if (fieldType is ListFieldType) {
                    ListFieldType listFieldType = (ListFieldType)fieldType;
                    IFieldType elementType = listFieldType.ElementType;
                    code += "                // LIST: " + fieldName+"\r\n";
                    code += "                if ((bytes[nullFlagsIndex] & (byte)" + (1 << nullableFieldFlagPlace--) + ") > 0) {\r\n";
                    PBC.AppendSerializerReadCollection(ref code, "o."+fieldName, elementType, "List");
                    code += "                }\r\n";
                }
                else if (fieldType is MapFieldType) {
                    code += "                // MAP: " + fieldName+"\r\n";
                    code += "                if ((bytes[nullFlagsIndex] & (byte)" + (1 << nullableFieldFlagPlace--) + ") > 0) {\r\n";
                    MapFieldType mapFieldType = (MapFieldType)fieldType;
                    string keyTypeName = PB.ToCSharpType(mapFieldType.KeyType);
                    string valueTypeName = PB.ToCSharpType(mapFieldType.ValueType);
                    string cappedKeyTypeName = PB.ToCapitalizedCSharpType(mapFieldType.KeyType);
                    string cappedValueTypeName = PB.ToCapitalizedCSharpType(mapFieldType.ValueType);

                    string mapFieldName = PB.ToCSharpPropertyName(field.Name);
                    string mapKeysFieldName = PB.ToCSharpName(field.Name) + "Keys";
                    string mapValuesFieldName = PB.ToCSharpName(field.Name) + "Values";
                    code += "                    List<" + keyTypeName + "> " + mapKeysFieldName + " = this.instantiator.AcquireListOf" + cappedKeyTypeName + "();\r\n";
                    code += "                    List<" + valueTypeName + "> " + mapValuesFieldName + " = this.instantiator.AcquireListOf" + cappedValueTypeName + "();\r\n";
                    PBC.AppendSerializerReadCollection(ref code, mapKeysFieldName, mapFieldType.KeyType, "List", "Keys");
                    PBC.AppendSerializerReadCollection(ref code, mapValuesFieldName, mapFieldType.ValueType, "List", "Values");
                    code += "                    o." + mapFieldName + " = this.instantiator.AcquireDictionaryOf" + PB.ToCapitalizedCSharpType(mapFieldType.KeyType) + "To" + PB.ToCapitalizedCSharpType(mapFieldType.ValueType) + "();\r\n";
                    string i = PB.CreateRandomFieldName("i");
                    code += "                    for (int " + i + " = 0; " + i + " < " + mapKeysFieldName + ".Count; " + i + "++) {\r\n";
                    code += "                        o." + mapFieldName + "[" + mapKeysFieldName + "[" + i + "]] = " + mapValuesFieldName + "[" + i + "];\r\n";
                    code += "                    }\r\n";
                    code += "                    this.instantiator.DiscardListOf" + cappedKeyTypeName + "(" + mapKeysFieldName + ");\r\n";
                    code += "                    this.instantiator.DiscardListOf" + cappedValueTypeName + "(" + mapValuesFieldName + ");\r\n";
                    code += "                    " + mapKeysFieldName + " = null;\r\n";
                    code += "                    " + mapValuesFieldName + " = null;\r\n";
                    code += "                }\r\n";
                }
                else if (fieldType is SetFieldType) {
                    SetFieldType setFieldType = (SetFieldType)fieldType;
                    IFieldType elementType = setFieldType.ElementType;
                    code += "                // SET: " + fieldName + "\r\n";
                    code += "                if ((bytes[nullFlagsIndex] & (byte)" + (1 << nullableFieldFlagPlace--) + ") > 0) {\r\n";
                    PBC.AppendSerializerReadCollection(ref code, "o." + fieldName, elementType, "HashSet");
                    code += "                }\r\n";
                }
            }
        }

        /**
         * Generates the ToBytes method for a PatternBufferType serializer class.
         */
        protected void AppendSerializerToBytes(ref string code, string typeClassName, PatternBufferType t, string schemaObjectTypeName) {
            List<PatternBufferField> allFields = PB.GetAllFields(t);

            if (t.HasNullableFields) {
                code += "                // NULL FLAGS\r\n";
                code += "                int nullFlagsIndex = index - 1;\r\n";
                int nullFlagsBytes = (t.NullableFieldCount / 8) + 1;
                for (int i = 0; i < nullFlagsBytes; i++) {
                    code += "                bytes[index++] = 0;\r\n";
                }
            }
            int nullableFieldFlagPlace = -1;

            foreach (PatternBufferField field in allFields) {

                if (t.HasNullableFields && nullableFieldFlagPlace < 0) {
                    nullableFieldFlagPlace = 7;
                    code += "                nullFlagsIndex++;\r\n";
                }

                IFieldType fieldType = field.FieldType;
                string fieldTypeName = PB.ToCSharpType(field.FieldType);
                string fieldName = PB.ToCSharpPropertyName(field.Name);
                if (fieldType is PrimitiveFieldType) {
                    PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)fieldType;
                    code += "                // PRIMITIVE: " + fieldName + "\r\n";
                    if (primitiveFieldType.PrimitiveType == PrimitiveType.Bool) {
                        PBP.AppendWriteBool(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Byte) {
                        PBP.AppendWriteByte(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Double) {
                        PBP.AppendWriteDouble(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Float) {
                        PBP.AppendWriteFloat(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Int) {
                        PBP.AppendWriteInt32(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Long) {
                        PBP.AppendWriteInt64(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.Short) {
                        PBP.AppendWriteInt16(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.String) {
                        PBP.AppendWriteString(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.UInt) {
                        PBP.AppendWriteUInt32(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.ULong) {
                        PBP.AppendWriteUInt64(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.UShort) {
                        PBP.AppendWriteUInt16(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VInt) {
                        PBP.AppendWriteVInt32(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VLong) {
                        PBP.AppendWriteVInt64(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VUInt) {
                        PBP.AppendWriteVUInt32(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VULong) {
                        PBP.AppendWriteVUInt64(ref code, "o." + fieldName);
                    }
                    else if (primitiveFieldType.PrimitiveType == PrimitiveType.VUShort) {
                        PBP.AppendWriteVUInt16(ref code, "o." + fieldName);
                    }
                }
                else if (fieldType is ReferenceFieldType) {
                    ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                    code += "                // REFERENCE: " + fieldName + "\r\n";
                    if (referenceFieldType.Referrable is PatternBufferType) {
                        code += "                if (o." + fieldName + " != null) {\r\n";
                        code += "                    bytes[nullFlagsIndex] |= (byte)("  + (1 << nullableFieldFlagPlace--) + ");\r\n";
                        PB.AppendWriteReference(ref code, (PatternBufferType)referenceFieldType.Referrable, "o." + fieldName, schemaObjectTypeName);
                        code += "                }\r\n";
                    }
                    else {
                        PBP.AppendWriteByte(ref code, "enumValueIndexMap[\"" + referenceFieldType.ReferrableName + "\"][o." + fieldName + ".ToString()];\r\n");
                    }
                }
                else if (fieldType is ListFieldType) {
                    ListFieldType listFieldType = (ListFieldType)fieldType;
                    IFieldType elementType = listFieldType.ElementType;
                    code += "                // LIST: " + fieldName+"\r\n";
                    code += "                if (o." + fieldName + " != null) {\r\n";
                    code += "                    bytes[nullFlagsIndex] |= (byte)(" + (1 << nullableFieldFlagPlace--) + ");\r\n";
                    PBC.AppendSerializerWriteCollection(ref code, fieldName, elementType, schemaObjectTypeName);
                    code += "                }\r\n";
                }
                else if (fieldType is MapFieldType) {
                    code += "                // MAP: " + fieldName+"\r\n";
                    code += "                if (o." + fieldName + " != null) {\r\n";
                    code += "                    bytes[nullFlagsIndex] |= (byte)(" + (1 << nullableFieldFlagPlace--) + ");\r\n";
                    MapFieldType mapFieldType = (MapFieldType)fieldType;
                    string keyTypeName = PB.ToCSharpType(mapFieldType.KeyType);
                    string valueTypeName = PB.ToCSharpType(mapFieldType.ValueType);
                    PBC.AppendSerializerWriteCollection(ref code, fieldName, mapFieldType.KeyType, "Keys", schemaObjectTypeName);
                    PBC.AppendSerializerWriteCollection(ref code, fieldName, mapFieldType.ValueType, "Values", schemaObjectTypeName);
                    code += "                }\r\n";
                }
                else if (fieldType is SetFieldType) {
                    SetFieldType setFieldType = (SetFieldType)fieldType;
                    IFieldType elementType = setFieldType.ElementType;
                    code += "                // SET: " + fieldName+"\r\n";
                    code += "                if (o." + fieldName + " != null) {\r\n";
                    code += "                    bytes[nullFlagsIndex] |= (byte)(" + (1 << nullableFieldFlagPlace--) + ");\r\n";
                    PBC.AppendSerializerWriteCollection(ref code, fieldName, elementType, schemaObjectTypeName);
                    code += "                }\r\n";
                }
            }
        }

        /**
         * Generates the C# source code for the overall PatternBuffer implementation class that knows how to read and
         * write all PatternBuffer types, which is the whole damn point of this thing.
         */
        protected void GeneratePatternBuffer(Dictionary<string, string> results, PatternBufferSchema s) {

            string patternBufferClassName = PB.ToCSharpName(s.Name) + "PatternBuffer";
            string code = this.Boilerplate;

            code += "using PatternBuffer;\r\n";
            code += "using System.Text;\r\n";
            code += "using System;\r\n";
            code += "using System.Collections.Generic;\r\n\r\n";
            code += "namespace "+this.generatedNamespace+" {\r\n";
            code += "    public class "+patternBufferClassName+" {\r\n";

            // Defines variant byte size boundaries. Packaged like this, here, to do a linear search.
            code += "        private static readonly ulong[] vuBoundaries = new ulong[] {\r\n";
            code += "            128,\r\n"; //2^7
            code += "            16384,\r\n"; //2^14
            code += "            2097152,\r\n"; //2^21
            code += "            268435456,\r\n"; //2^28
            code += "            34359738368,\r\n"; // 2^35
            code += "            4398046511104,\r\n"; // 2^42
            code += "            562949953421312,\r\n"; // 2^49
            code += "            72057594037927936,\r\n"; // 2^56
            code += "            9223372036854775808\r\n"; // 2^63
            code += "        };\r\n";
            
            if (s.Enums.Count > 0) {

                // Maps enum names to an index:value map
                code += "        public static readonly Dictionary<string, Dictionary<byte, string>> enumIndexValueMap = new Dictionary<string, Dictionary<byte, string>>() {";
                for (int i = 0; i < s.Enums.Count; i++) {
                    PatternBufferEnum e = s.Enums[i];
                    code += "            {\r\n";
                    code += "                \"" + e.Name + "\",\r\n";
                    code += "                new Dictionary<byte,string>() {\r\n";
                    for (int v = 0; v < e.Values.Count; v++) {
                        code += "                    {(byte)" + (v + 1) + ", \"" + e.Values[v] + "\"}" + (v < e.Values.Count - 1 ? "," : "") + "\r\n";
                    }
                    code += "                }\r\n";
                    code += "            }" + (i < s.Enums.Count - 1 ? "," : "") + "\r\n";
                }
                code += "        };\r\n";

                // Maps enum names to an value:index map
            
                code += "        public static readonly Dictionary<string, Dictionary<string, byte>> enumValueIndexMap = new Dictionary<string, Dictionary<string, byte>> {\r\n";
                for (int i = 0; i < s.Enums.Count; i++) {
                    PatternBufferEnum e = s.Enums[i];
                    code += "            {\r\n";
                    code += "                \"" + e.Name + "\",\r\n";
                    code += "                new Dictionary<string,byte>() {\r\n";
                    for (int v = 0; v < e.Values.Count; v++) {
                        code += "                    {\"" + e.Values[v] + "\", (byte)" + (v + 1) + "}" + (v < e.Values.Count - 1 ? "," : "") + "\r\n";
                    }
                    code += "                }\r\n";
                    code += "            }" + (i < s.Enums.Count - 1 ? "," : "") + "\r\n";
                }
                code += "        };\r\n";
            }

            // Set up the byte buffer.
            code += "        private byte[] bytes;\r\n";

            // The instantiator
            code += "        private I" + PB.ToCSharpName(s.Name) + "Instantiator instantiator;\r\n";

            // Allow users to configure it.
            code += "        public " + patternBufferClassName + "() : this(4096, new Default" + PB.ToCSharpName(s.Name) + "Instantiator()) { }\r\n";
            code += "        public " + patternBufferClassName + "(uint bufferSize) : this (bufferSize, new Default" + PB.ToCSharpName(s.Name) + "Instantiator()) { }\r\n";
            code += "        public " + patternBufferClassName + "(I" + PB.ToCSharpName(s.Name) + "Instantiator instantiator) : this (4096, instantiator) { }\r\n";
            code += "        public " + patternBufferClassName + "(uint bufferSize, I" + PB.ToCSharpName(s.Name) + "Instantiator instantiator) {\r\n";
            code += "            this.bytes = new byte[bufferSize];\r\n";
            code += "            this.instantiator = instantiator;\r\n";
            code += "        }\r\n";

            // Append energizers
            this.AppendSerializerEnergizers(ref code, s);

            // Append reclaimers
            this.AppendSerializerReclaimers(ref code, s);

            code += "    }\r\n";
            code += "}\r\n";
            results[patternBufferClassName + ".cs"] = code;
        }

        /**
         * Returns the file path for a hinted schema element, if any.
         */
        public string GetPath(IPatternBufferHinted hinted) {
            // Check for the path hint
            string path = "";
            if (hinted.ContainsHint(HINT_PB_PATH)) {
                path = hinted.GetHint(HINT_PB_PATH);
                if (!path.EndsWith("/")) {
                    path += "/";
                }
            }
            return path;
        }

        protected void AppendSerializerEnergizerWriteTypeId(ref string code, PatternBufferType type) {
            byte[] typeIdBytes = typeIdByteMap[type.TypeId];
            foreach (byte b in typeIdBytes) {
                code += "            bytes[index++] = " + b + ";\r\n";
            }
        }

        protected void AppendLockStart(ref string code) {
            if (this.MakeThreadsafe) {
                code += "            lock(this) { \r\n";
            }
        }
        protected void AppendLockEnd(ref string code) {
            if (this.MakeThreadsafe) {
                code += "            }\r\n";
            }
        }

        protected void AppendSerializerReclaimers(ref string code, PatternBufferSchema schema) {

            string schemaObjectTypeName = PB.ToSchemaObjectTypeName(schema);
            string exceptionTypeName = PB.ToSchemaExceptionName(schema);

            if (schema.Types.Count > 0) {
                PB.AppendComment(ref code, "RECLAIM", true);
                for (int i = 0; i < schema.Types.Count; i++) {
                    PatternBufferType type = schema.Types[i];
                    string typeName = PB.ToCSharpName(type.Name);
                    code += "        public void Reclaim(" + typeName + " o) {\r\n";
                    code += "            if (o != null) {\r\n";
                    if (schema.DirectDerivatives.ContainsKey(type)) {
                        bool first = true;
                        HashSet<PatternBufferType> directDerivatives = schema.DirectDerivatives[type];
                        foreach (PatternBufferType derivative in directDerivatives) {
                            string derivativeName = PB.ToCSharpName(derivative.Name);
                            code += "                " + (first ? "" : "else ") + "if (o is " + derivativeName + ") {\r\n";
                            code += "                    this.Reclaim((" + derivativeName + ")o);\r\n";
                            code += "                }\r\n";
                            first = false;
                        }
                    }

                    foreach (PatternBufferField field in type.Fields) {
                        IFieldType fieldType = field.FieldType;
                        string fieldTypeName = PB.ToCSharpType(fieldType);
                        string cappedFieldTypeName = PB.ToCapitalizedCSharpType(fieldType);
                        string fieldName = PB.ToCSharpPropertyName(field.Name);
                        if (fieldType is PrimitiveFieldType) {
                            PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)fieldType;
                            code += "                o." + fieldName + " = default(" + PB.ToCSharpType(primitiveFieldType) + ");\r\n";
                        }
                        else if (fieldType is ReferenceFieldType) {
                            ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                            if (referenceFieldType.Referrable is PatternBufferType) {
                                code += "                if (o." + fieldName + " != null) {\r\n";
                                code += "                    this.Reclaim(o." + fieldName + ");\r\n";
                                code += "                }\r\n";
                            }
                            code += "                o." + fieldName + " = default(" + PB.ToCSharpName(referenceFieldType.Referrable.Name) + ");\r\n";
                        }
                        else if (fieldType is ListFieldType) {
                            ListFieldType listFieldType = (ListFieldType)fieldType;
                            IAggregateableFieldType aggType = listFieldType.ElementType;
                            if (aggType is ReferenceFieldType) {
                                if (((ReferenceFieldType)aggType).Referrable is PatternBufferType) {
                                    string elementTypeName = PB.ToCSharpType(listFieldType.ElementType);
                                    code += "                if (o." + fieldName + " != null) {\r\n";
                                    code += "                    foreach (" + elementTypeName + " e in o." + fieldName + ") {\r\n";
                                    code += "                        this.Reclaim(e);\r\n";
                                    code += "                    }\r\n";
                                    code += "                    o." + fieldName + ".Clear();\r\n";
                                    code += "                    this.instantiator.DiscardListOf" + PB.ToCapitalizedCSharpType(aggType) + "((" + PB.ToCSharpType(listFieldType) + ")o." + fieldName + ");\r\n";
                                    code += "                }\r\n";
                                }
                            }
                        }
                        else if (fieldType is SetFieldType) {
                            SetFieldType setFieldType = (SetFieldType)fieldType;
                            IAggregateableFieldType aggType = setFieldType.ElementType;
                            if (aggType is ReferenceFieldType) {
                                if (((ReferenceFieldType)aggType).Referrable is PatternBufferType) {
                                    string elementTypeName = PB.ToCSharpType(setFieldType.ElementType);
                                    code += "                if (o." + fieldName + " != null) {\r\n";
                                    code += "                    foreach (" + elementTypeName + " e in o." + fieldName + ") {\r\n";
                                    code += "                        this.Reclaim(e);\r\n";
                                    code += "                    }\r\n";
                                    code += "                    this.instantiator.DiscardHashSetOf" + PB.ToCapitalizedCSharpType(aggType) + "((" + PB.ToCSharpType(setFieldType) + ")o." + fieldName + ");\r\n";
                                    code += "                }\r\n";
                                }
                            }
                        }
                        else if (fieldType is MapFieldType) {
                            code += "                if (o." + fieldName + " != null) {\r\n";
                            MapFieldType mapFieldType = (MapFieldType)fieldType;
                            IAggregateableFieldType keyFieldType = mapFieldType.KeyType;
                            if (keyFieldType is ReferenceFieldType) {
                                if (((ReferenceFieldType)keyFieldType).Referrable is PatternBufferType) {
                                    string keyTypeName = PB.ToCSharpType(mapFieldType.KeyType);
                                    code += "                    foreach (" + keyTypeName + " k in o." + fieldName + ".Keys) {\r\n";
                                    code += "                        this.Reclaim(k);\r\n";
                                    code += "                    }\r\n";
                                }
                            }
                            IAggregateableFieldType valueFieldType = mapFieldType.ValueType;
                            if (valueFieldType is ReferenceFieldType) {
                                if (((ReferenceFieldType)valueFieldType).Referrable is PatternBufferType) {
                                    string valueTypeName = PB.ToCSharpType(mapFieldType.ValueType);

                                    code += "                    foreach (" + valueTypeName + " v in o." + fieldName + ".Values) {\r\n";
                                    code += "                        this.Reclaim(v);\r\n";
                                    code += "                    }\r\n";
                                }
                            }
                            code += "                    this.instantiator.DiscardDictionaryOf" + PB.ToCapitalizedCSharpType(keyFieldType) + "To" + PB.ToCapitalizedCSharpType(valueFieldType) + "((" + PB.ToCSharpType(mapFieldType) + ")o." + fieldName + ");\r\n";

                            code += "                }\r\n";
                        }
                    }
                    if (type.IsFinal) {
                        code += "                this.instantiator.Discard" + typeName + "(o);\r\n";
                    }

                    code += "            }\r\n";

                    code += "        }\r\n";

                }

            }
        }

        //protected void AppendSerializerReclaimReferenceField(ref string code, ReferenceFieldType referenceFieldType, string fieldTypeName, string fieldName, PatternBufferSchema schema) {
        //    //ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
        //    if (referenceFieldType.Referrable is PatternBufferType) {
        //        PatternBufferType referrableType = (PatternBufferType)referenceFieldType.Referrable;
        //        if (referrableType.IsFinal) {
        //            code += "                    this.Reclaim((" + fieldTypeName + ")o." + fieldName + ");\r\n";
        //        }
        //        else {
        //            code += "                    switch(o." + fieldName + ".TypeId) {\r\n";
        //            foreach (PatternBufferType derivative in schema.Derivatives[referrableType]) {
        //                code += "                        case " + derivative.TypeId + ":\r\n";
        //                code += "                            this.Reclaim((" + PB.ToCSharpPropertyName(derivative.Name) + ")o." + fieldName + ");\r\n";
        //                code += "                            break;\r\n";
        //            }
        //            code += "                        default:\r\n";
        //            code += "                            // what?\r\n";
        //            code += "                            break;\r\n";
        //            code += "                    }\r\n";
        //        }
        //    }
        //}

        protected void AppendSerializerEnergizers(ref string code, PatternBufferSchema schema) {

            string schemaObjectTypeName = PB.ToSchemaObjectTypeName(schema);
            string exceptionTypeName = PB.ToSchemaExceptionName(schema);

            if (schema.Types.Count > 0) {
                PB.AppendComment(ref code, "TO BYTES", true);
                for (int i = 0; i < schema.Types.Count; i++) {
                    PatternBufferType type = schema.Types[i];
                    if (type.TypeId > 0) {
                        string typeName = PB.ToCSharpName(type.Name);
                        code += "        public byte[] Energize(" + typeName + " o) {\r\n";
                        this.AppendLockStart(ref code);
                        code += "            int index = 0;\r\n";
                        code += "            Energize(o, bytes, ref index, true);\r\n";
                        code += "            byte[] result = this.instantiator.AcquireByteArray(index);\r\n";
                        code += "            Buffer.BlockCopy(bytes, 0, result, 0, index);\r\n";
                        code += "            return result;\r\n";
                        this.AppendLockEnd(ref code);
                        code += "        }\r\n";
                    }
                }

                for (int i = 0; i < schema.Types.Count; i++) {
                    PatternBufferType type = schema.Types[i];
                    if (type.TypeId > 0) {
                        string typeName = PB.ToCSharpPropertyName(type.Name);
                        code += "        public void Energize(" + typeName + " o, byte[] bytes, ref int index, bool writeTypeId) {\r\n";
                        this.AppendLockStart(ref code);
                        // Write the type ID.
                        code += "            if (writeTypeId) {\r\n";
                        AppendSerializerEnergizerWriteTypeId(ref code, type);
                        code += "            }\r\n";

                        // Write the serializer methods for the type.
                        this.AppendSerializerToBytes(ref code, type.Name, type, PB.ToSchemaObjectTypeName(schema));
                        this.AppendLockEnd(ref code);
                        code += "        }\r\n";
                    }
                }

                // This bit of code is only needed if there are abstract types in the schema.
                code += "        public void Energize(" + schemaObjectTypeName + " o, byte[] bytes, ref int index, bool writeTypeId) {\r\n";
                code += "            switch (o.TypeId) {\r\n";
                foreach (PatternBufferType type in schema.Types) {
                    if (type.TypeId > 0) {
                        code += "                case " + type.TypeId + ":\r\n";
                        // TODO unspool this into an Append()
                        code += "                    Energize((" + PB.ToCSharpName(type.Name) + ")o, bytes, ref index, writeTypeId);\r\n";
                        code += "                    break;\r\n";
                    }
                }
                code += "                default:\r\n";
                code += "                    throw new " + exceptionTypeName + "(\"Unrecognized type ID: \"+o.TypeId+\" \");\r\n";
                code += "            }\r\n";
                code += "        }\r\n";

                PB.AppendComment(ref code, "FROM BYTES", true);
                code += "        public object Energize(byte[] bytes) {\r\n";
                code += "            int index = 0;\r\n";
                PBP.AppendReadVariant(ref code, "typeId", "ushort", "ushort", 2);
                this.AppendSerializerEnergizeFromBytesInner(ref code, schema);
                code += "        }\r\n";
                code += "        public object Energize(byte[] bytes, ref int index) {\r\n";
                PBP.AppendReadVariant(ref code, "typeId", "ushort", "ushort", 2);
                this.AppendSerializerEnergizeFromBytesInner(ref code, schema);
                code += "        }\r\n";
                code += "        public object Energize(byte[] bytes, ref int index, ushort typeId) {\r\n";
                this.AppendSerializerEnergizeFromBytesInner(ref code, schema);
                code += "        }\r\n";

                PB.AppendComment(ref code, "FROM BYTES (TYPED)", true);
                code += "        public TYPE Energize< TYPE > (byte[] bytes) {\r\n";
                // TODO unspool this one too
                code += "            object o = this.Energize(bytes);\r\n";
                code += "            if (!(o is TYPE)) {\r\n";
                code += "                throw new " + exceptionTypeName + "(\"Deserialized type (\" + o.GetType().Name + \") does not match expected type (\" + typeof(TYPE).Name + \").\");\r\n";
                code += "            }\r\n";
                code += "            return (TYPE)o;\r\n";
                code += "        }\r\n";
            }
        }

        protected void AppendSerializerEnergizeFromBytesInner(ref string code, PatternBufferSchema schema) {
            string exceptionTypeName = PB.ToSchemaExceptionName(schema);
            code += "            switch (typeId) {\r\n";
            for (int i = 0; i < schema.Types.Count; i++) {
                PatternBufferType type = schema.Types[i];
                if (type.TypeId > 0) {
                    code += "            case " + type.TypeId + ":\r\n";
                    code += "                {\r\n";
                    this.AppendSerializerFromBytes(ref code, type.Name, type);
                    code += "                    return o;\r\n";
                    code += "                }\r\n";
                }
            }
            code += "                default:\r\n";
            code += "                    throw new " + exceptionTypeName + "(\"Unrecognized type ID: \"+typeId+\" \");\r\n";
            code += "            }\r\n";
        }

    }
}