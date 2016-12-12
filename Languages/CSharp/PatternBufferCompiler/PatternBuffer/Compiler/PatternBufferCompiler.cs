using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using PatternBuffer.Schema;
using PatternBufferSchema = PatternBuffer.Schema.PatternBufferSchema;

namespace PatternBuffer.Compiler {

    /**
     * A C# implementation of a PatternBuffer compiler. This class takes in a PatternBufferSchema and 
     * transforms it into multiple C# source files that, once compiled, can serialized all the types
     * defined in the schema.
     */
    public class PatternBufferCompiler {

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

        // Primitives that can be stored in variant (compressed) format.
        private static List<PrimitiveType> variantPrimitiveTypes = new List<PrimitiveType>() {
            PrimitiveType.VInt,
            PrimitiveType.VLong,
            PrimitiveType.VUInt,
            PrimitiveType.VULong,
            PrimitiveType.VUShort
        };

        // Primitives that can be stored in variant (compressed) format.
        private static List<PrimitiveType> signedVariantPrimitiveTypes = new List<PrimitiveType>() {
            PrimitiveType.VInt,
            PrimitiveType.VLong
        };

        // Primitives that can be stored in variant (compressed) format.
        private static List<PrimitiveType> unsignedVariantPrimitiveTypes = new List<PrimitiveType>() {
            PrimitiveType.VUInt,
            PrimitiveType.VULong,
            PrimitiveType.VUShort
        };

        // Maps primitive types to BinaryReader ReadXYZ method names
        private static Dictionary<PrimitiveType, string> primitiveTypeReaderTypeMap = new Dictionary<PrimitiveType, string>() {
            { PrimitiveType.Bool, "Boolean" },
            { PrimitiveType.Byte, "Byte" },
            { PrimitiveType.Double, "Double" },
            { PrimitiveType.Float, "Single" },
            { PrimitiveType.Int, "Int32" },
            { PrimitiveType.Long, "Int64" },
            { PrimitiveType.Short, "Int16" },
            { PrimitiveType.String, "String" },
            { PrimitiveType.UInt, "UInt32" },
            { PrimitiveType.ULong, "UInt64" },
            { PrimitiveType.UShort, "UInt16" },
            { PrimitiveType.VInt, "VInt32" },
            { PrimitiveType.VLong, "VInt64" },
            { PrimitiveType.VUInt, "VUInt32" },
            { PrimitiveType.VULong, "VUInt64" },
            { PrimitiveType.VUShort, "VUInt16" }
        };

        // Returns the ReadXYZ method name for the given primitive type.
        private static string GetReaderType(PrimitiveType primitiveType) {
            return PatternBufferCompiler.primitiveTypeReaderTypeMap[primitiveType];
        }

        // Maps primitive types to their maximum size, in bytes, when serialized.
        private static Dictionary<PrimitiveType, int> primitiveTypeSizeMap = new Dictionary<PrimitiveType, int>() {
            { PrimitiveType.Bool, 1 },
            { PrimitiveType.Byte, 1 },
            { PrimitiveType.Double, 8 },
            { PrimitiveType.Float, 4 },
            { PrimitiveType.Int, 4 },
            { PrimitiveType.VInt, 4 },
            { PrimitiveType.Long, 8 },
            { PrimitiveType.VLong, 8 },
            { PrimitiveType.Short, 2 },
            { PrimitiveType.UInt, 4 },
            { PrimitiveType.VUInt, 4 },
            { PrimitiveType.ULong, 8 },
            { PrimitiveType.VULong, 8 },
            { PrimitiveType.UShort, 2 },
            { PrimitiveType.VUShort, 2 }
        };

        /**
         * Returns the maximum serialized size, in bytes, of the given primitive.
         */
        private static int GetPrimitiveSize(PrimitiveType primitiveType) {
            return PatternBufferCompiler.primitiveTypeSizeMap[primitiveType];
        }

        // A random number generator used for generating C# variable names that don't collide.
        private static Random random = new Random();

        // The C# namespace to use on generated classes.
        private string generatedNamespace;

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

            // Use one byte or two for type ID depending on the largest type ID.
            ushort biggestTypeId = 0;
            foreach (PatternBufferType t in schema.Types) {
                if (t.TypeId > biggestTypeId) {
                    biggestTypeId = t.TypeId;
                }
            }

            // Generate enums
            Console.WriteLine("Compiling "+schema.Enums.Count+" enums...");
            foreach (PatternBufferEnum e in schema.Enums) {
                string csName = this.ToCSharpName(e.Name);
                this.GenerateEnum(results, e);
            }

            // Generate types
            Console.WriteLine("Compiling " + schema.Types.Count + " types...");
            foreach (PatternBufferType t in schema.Types) {
                this.GenerateType(results, t);
            }

            // Generate PatternBuffer
            Console.WriteLine("Compiling pattern buffer...");
            this.GeneratePatternBuffer(results, schema);

            return results;
        }

        /**
         * Generates the C# enum file corresponding to a PatternBufferEnum.
         */
        protected void GenerateEnum(Dictionary<string, string> results, PatternBufferEnum e) {
            string enumName = this.ToCSharpName(e.Name);
            string code = BOILERPLATE;
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
         * Generates the C# class file(s) corresponding to a PatternBufferType. PatternBufferTypes generate
         * to three specific C# files:
         * 1) A type interface
         * 2) A class implementing that type interface (this is the real domain object)
         * 3) A serializer class that knows how to read/write the domain object from/to byte arrays
         */
        protected void GenerateType(Dictionary<string, string> results, PatternBufferType t) {
            this.GenerateTypeInterface(results, t);
            this.GenerateTypeClass(results, t);
            this.GenerateTypeSerializer(results, t);
        }

        /**
         * Generates the C# source code for a PatternBufferType's interface file.
         */
        protected void GenerateTypeInterface(Dictionary<string, string> results, PatternBufferType t) {

            string interfaceName = "I" + this.ToCSharpName(t.Name);
            string code = BOILERPLATE;
            code += "using System.Collections.Generic;\r\n";
            code += "namespace "+this.generatedNamespace+" {\r\n";
            code += this.GenerateComment(t);
            code += "    public interface "+interfaceName;
            if (t.BaseType != null) {
                code += " : "+"I" + this.ToCSharpName(t.BaseType.Name);
            }
            code += " {\r\n";
            for (int i = 0; i < t.Fields.Count; i++) {
                PatternBufferField field = t.Fields[i];
                code += "        "+this.ToCSharpType(field.FieldType)+" "+this.ToCSharpPropertyName(field.Name)+" { get; set; }\r\n";
            }
            code += "    }\r\n";
            code += "}\r\n";
            results[this.GetPath(t) + interfaceName + ".cs"] = code;
        }

        /**
         * Generates the C# source code for a PatternBufferType's class file.
         */
        protected void GenerateTypeClass(Dictionary<string, string> results, PatternBufferType t) {

            string className = this.ToCSharpName(t.Name);
            string code = BOILERPLATE;
            code += "using System;\r\n";
            code += "using System.Collections.Generic;\r\n";
            code += "namespace "+this.generatedNamespace+" {\r\n";
            code += this.GenerateComment(t);
            code += "    public class " + className + " : ";
            if (t.BaseType != null) {
                code += this.ToCSharpName(t.BaseType.Name) + ", ";
            }
            code += "IEquatable <"+ className + ">, "+"I"+className;
            code += " {\r\n";

            // Get all the fields in this type's hierarchy
            List<PatternBufferField> allFields = this.GetAllFields(t);

            // No args constructor
            code += "        public "+className+"() {\r\n";
            foreach (PatternBufferField field in allFields) {
                string fieldName = this.ToCSharpName(field.Name);
                string fieldTypeName = this.ToCSharpType(field.FieldType);
                code += "            this."+fieldName+" = default("+fieldTypeName+");\r\n";
            }
            code += "        }\r\n\r\n";

            // Do we have fields?
            if (allFields.Count > 0) {
                // All args constructor
                code += "        public " + className + "(\r\n";
                foreach (PatternBufferField field in allFields) {
                    string fieldName = this.ToCSharpName(field.Name);
                    string fieldTypeName = this.ToCSharpType(field.FieldType);
                    code += "            " + fieldTypeName + " " + fieldName + (field == allFields[allFields.Count - 1] ? "" : ",") + "\r\n";
                }
                code += "        ) {\r\n";
                foreach (PatternBufferField field in allFields) {
                    string fieldName = this.ToCSharpName(field.Name);
                    string fieldTypeName = this.ToCSharpType(field.FieldType);
                    code += "            this." + fieldName + " = " + fieldName + ";\r\n";
                }
                code += "        }\r\n\r\n";

                // This type's fields
                foreach (PatternBufferField field in t.Fields) {
                    string fieldName = this.ToCSharpName(field.Name);
                    string fieldTypeName = this.ToCSharpType(field.FieldType);
                    string fieldPropertyName = this.ToCSharpPropertyName(field.Name);
                    code += "        internal " + fieldTypeName + " " + fieldName + ";\r\n";
                    code += "        public " + fieldTypeName + " " + fieldPropertyName + " {\r\n";
                    code += "            get { return this." + fieldName + "; }\r\n";
                    code += "            set { this." + fieldName + " = value; }\r\n";
                    code += "        }\r\n\r\n";
                }
            }

            // Equals methods
            code += "        public bool Equals(" + className + " other) {\r\n";
            code += "            return this.Equals((object)other);\r\n";
            code += "        }\r\n";
            code += "        public override bool Equals(object other) {;\r\n";
            code += "            if (other == null) { return false; }\r\n";
            code += "            if ( ! (other is " + className  + ")) { return false; }\r\n";
            code += "            " + className + " that = (" + className + ")other;\r\n";
            code += "            if (this.GetHashCode() != that.GetHashCode()) return false;\r\n";
            foreach (PatternBufferField field in t.Fields) {
                string fieldName = this.ToCSharpName(field.Name);
                string fieldTypeName = this.ToCSharpType(field.FieldType);
                string fieldPropertyName = this.ToCSharpPropertyName(field.Name);
                code += "            // "+fieldName+"\r\n";
                if (field.FieldType is PrimitiveFieldType || field.FieldType is ReferenceFieldType) {
                    this.AppendTypeClassEqualsValue(ref code, field.FieldType, "this."+fieldName, "that." + fieldName);
                }
                else if (field.FieldType is ListFieldType) {
                    ListFieldType listFieldType = (ListFieldType)field.FieldType;
                    this.AppendTypeClassEqualsCollection(ref code, listFieldType, this.ToCSharpType(listFieldType.ElementType), "this." + fieldName, "that." + fieldName);
                }
                else if (field.FieldType is SetFieldType) {
                    SetFieldType setFieldType = (SetFieldType)field.FieldType;
                    this.AppendTypeClassEqualsCollection(ref code, setFieldType, this.ToCSharpType(setFieldType.ElementType), "this." + fieldName, "that." + fieldName);
                }
                else if (field.FieldType is MapFieldType) {
                    MapFieldType mapFieldType = (MapFieldType)field.FieldType;
                    string keyTypeName = this.ToCSharpType(mapFieldType.KeyType);
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
                    this.AppendTypeClassEqualsMutualNullCheck(ref code, fieldName1, fieldName2);
                    PatternBufferType patternBufferType = (PatternBufferType)referenceFieldType.Referrable;
                    code += "            if ( ! " + fieldName1 + ".Equals(" + fieldName2 + ")) { return false; }\r\n";
                }
            }
        }

        protected void AppendTypeClassEqualsCollection(ref string code, IFieldType collectionType, string fieldTypeName, string fieldName1, string fieldName2) {
            List<int> x = new List<int>();
            this.AppendTypeClassEqualsMutualNullCheck(ref code, fieldName1, fieldName2);
            code += "            if (" + fieldName1 + ".Count != " + fieldName2 + ".Count) { return false; }\r\n";
            string field1EnumeratorName = CreateRandomFieldName("enumerator");
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
            code += "            " + collectionTypeName + "<"+ fieldTypeName + ">.Enumerator "+ field1EnumeratorName + " = " + fieldName1 + ".GetEnumerator();\r\n";
            string field2EnumeratorName = CreateRandomFieldName("enumerator");
            code += "            " + collectionTypeName + "<" + fieldTypeName + ">.Enumerator " + field2EnumeratorName + " = " + fieldName2 + ".GetEnumerator();\r\n";
            code += "            while(true) {\r\n";
            code += "                if ( ! " + field1EnumeratorName + ".MoveNext()) { break; }\r\n";
            code += "                " + field2EnumeratorName + ".MoveNext();\r\n";
            this.AppendTypeClassEqualsValue(ref code, elementType, field1EnumeratorName+".Current", field2EnumeratorName + ".Current");
            code += "            }\r\n";
        }

        /**
         * Appends a primitive type check into the C# code.
         */
        protected void AppendTypeClassEqualsPrimitive(ref string code, string fieldName, string fieldPropertyName, PrimitiveFieldType primitiveFieldType) {
            if (primitiveFieldType.PrimitiveType == PrimitiveType.String) {
                code += "            if ( ! other." + fieldName + ".Equals(this." + fieldName + ")) { return false; }\r\n";
            }
            else {
                code += "            if ( other." + fieldPropertyName + " != this." + fieldName + ") { return false; }\r\n";
            }
        }

        /**
         * Appends a mutual null check into the C# code.
         */
        protected void AppendTypeClassEqualsMutualNullCheck(ref string code, string fieldName1, string fieldName2) {
            code += "            if (" + fieldName1 + " == null && " + fieldName2 + " != null) { return false; }\r\n";
            code += "            if (" + fieldName2 + " != null && " + fieldName1 + " == null) { return false; }\r\n";
        }

        /**
         * Appends C# code to compute a type's hash code.
         */
        protected void AppendTypeClassGetHashCode(ref string code, PatternBufferType patternBufferType) {

            code += "        public override int GetHashCode() {\r\n";
            code += "            unchecked {\r\n";
            code += "                int hash = 27;\r\n";
            List<PatternBufferField> allFields = this.GetAllFields(patternBufferType);
            foreach (PatternBufferField field in allFields) {
                IFieldType fieldType = field.FieldType;
                string fieldName = this.ToCSharpName(field.Name);
                if (fieldType is ReferenceFieldType) {
                    ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                    if (referenceFieldType.Referrable is PatternBufferEnum) {
                        code += "                hash = (13*hash) + " + fieldName + ".GetHashCode();\r\n";
                    }
                    else if (referenceFieldType.Referrable is PatternBufferType) {
                        code += "                hash = (13*hash) + (" + fieldName + " == null ? 0 : " + fieldName + ".GetHashCode());\r\n";
                    }
                }
                else if (fieldType is PrimitiveFieldType) {
                    code += "                hash = (13*hash) + " + fieldName + ".GetHashCode();\r\n";
                }
                else {
                    code += "                hash = (13*hash) + (" + fieldName + " == null ? 0 : " + fieldName + ".GetHashCode());\r\n";
                }
            }
            code += "                return hash;\r\n";
            code += "            }\r\n";
            code += "        }\r\n";
        }

        /**
         * Generates the C# source code for a PatternBufferType's serializer file.
         */
        protected void GenerateTypeSerializer(Dictionary<string, string> results, PatternBufferType t) {
            if (t.TypeId > 0) {
                string typeClassName = this.ToCSharpName(t.Name);
                string serializerClassName = typeClassName + "Serializer";
                string code = BOILERPLATE;
                code += "using System.IO;\r\n";
                code += "using System.Collections.Generic;\r\n";
                code += "using PatternBuffer;\r\n";
                code += "namespace "+this.generatedNamespace+" {\r\n";
                code += this.GenerateComment(t);
                code += "    public class "+serializerClassName+" : IPatternBufferSerializer {\r\n";
                code += "        private IPatternBuffer patternBuffer;\r\n";
                code += "        public "+serializerClassName+ "(IPatternBuffer patternBuffer) {\r\n";
                code += "            this.patternBuffer = patternBuffer;\r\n";
                code += "            this.TypeId = " + t.TypeId + ";\r\n";
                code += "            this.TypeName = \"" + t.Name + "\";\r\n";
                code += "        }\r\n";
                code += "        private ushort typeId;\r\n";
                code += "        public ushort TypeId {\r\n";
                code += "            get { return this.typeId; }\r\n";
                code += "            protected set { this.typeId = value; }\r\n";
                code += "        }\r\n";
                code += "        private string typeName;\r\n";
                code += "        public string TypeName {\r\n";
                code += "            get { return this.typeName; }\r\n";
                code += "            protected set { this.typeName = value; }\r\n";
                code += "        }\r\n";
                this.AppendSerializerFromBytes(ref code, typeClassName, t);
                this.AppendSerializerToBytes(ref code, typeClassName, t);
                this.AppendSerializerSizeOf(ref code, t);
                code += "    }\r\n";
                code += "}\r\n";
                results[this.GetPath(t) + serializerClassName + ".cs"] = code;
            }
        }

        /**
         * Appends the SizeOf method to a serializer's C# source code.
         */
        protected void AppendSerializerSizeOf(ref string code, PatternBufferType t) {
            string typeClassName = this.ToCSharpName(t.Name);
            code += "        public uint SizeOf(object o) {\r\n";
            code += "            if (!(o is "+typeClassName+")) {\r\n";
            code += "                throw new PatternBufferException(\"Cannot size type \"+o.GetType().Name+\" using serializer \"+this.GetType().Name +\".\");\r\n";
            code += "            }\r\n";
            code += "            "+typeClassName+" item = ("+typeClassName+")o;\r\n";
            code += "            uint size = 0;\r\n";
            List<PatternBufferField> allFields = this.GetAllFields(t);
            int primitiveByteCount = 0;
            foreach (PatternBufferField field in allFields) {
                IFieldType fieldType = field.FieldType;
                if (fieldType is PrimitiveFieldType) {
                    PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)fieldType;
                    if (primitiveFieldType.PrimitiveType == PrimitiveType.String) {
                        code += "            // " + field.Name + "\r\n";
                        code += "            size += (uint)(PatternBufferUtil.GetUnsignedVariantSize((ulong)item." + field.Name + ".Length) + item." + field.Name + ".Length);\r\n";
                    }
                    else if (PatternBufferCompiler.variantPrimitiveTypes.Contains(primitiveFieldType.PrimitiveType)) {
                        code += "            // " + field.Name+ "\r\n";
                        if (PatternBufferCompiler.signedVariantPrimitiveTypes.Contains(primitiveFieldType.PrimitiveType)) {
                            code += "            size += (uint)PatternBufferUtil.GetSignedVariantSize(item." + field.Name + ");\r\n";
                        }
                        else {
                            code += "            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item." + field.Name + ");\r\n";
                        }
                    }
                    else {
                        code += "            // " + field.Name + " = " + PatternBufferCompiler.GetPrimitiveSize(primitiveFieldType.PrimitiveType) + " bytes\r\n";
                        primitiveByteCount += PatternBufferCompiler.GetPrimitiveSize(primitiveFieldType.PrimitiveType);
                    }
                }
                else if (fieldType is ReferenceFieldType) {
                    ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                    code += "            // " + field.Name + "\r\n";
                    if (referenceFieldType.Referrable is PatternBufferType) {
                        PatternBufferType patternBufferType = (PatternBufferType)referenceFieldType.Referrable;
                        if (patternBufferType.IsFinal) {
                            code += "            size += (uint)this.patternBuffer.GetSerializerByTypeName(\"" + referenceFieldType.ReferrableName + "\").SizeOf(item." + field.Name + ");\r\n";
                        }
                        else {
                            string serializerName = CreateRandomFieldName("serializer");
                            code += "            IPatternBufferSerializer " + serializerName + " = this.patternBuffer.GetSerializerFor(item." + this.ToCSharpPropertyName(field.Name)+");\r\n";
                            code += "            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)" + serializerName + ".TypeId);\r\n";
                            code += "            size += (uint)"+ serializerName + ".SizeOf(item." + field.Name + ");\r\n";
                        }
                    }
                    else {
                        code += "            size += (uint)1;\r\n";
                    }
                }
                else if (fieldType is ListFieldType || fieldType is SetFieldType) {
                    code += "            // "+field.Name+"\r\n";
                    IFieldType elementType = fieldType is ListFieldType ? ((ListFieldType)fieldType).ElementType : ((SetFieldType)fieldType).ElementType;
                    this.AppendSerializerComputeListSize(ref code, field.Name, elementType);
                }
                else if (fieldType is MapFieldType) {
                    code += "            // "+field.Name+"\r\n";
                    MapFieldType mapFieldType = (MapFieldType)fieldType;
                    this.AppendSerializerComputeListSize(ref code, field.Name + ".Keys", mapFieldType.KeyType);
                    this.AppendSerializerComputeListSize(ref code, field.Name + ".Values", mapFieldType.ValueType);
                }
            }
            if (primitiveByteCount > 0) {
                code += "            size += " + primitiveByteCount + "; // all primitives\r\n";
            }
            else {
                code += "            // all primitives = 0 bytes\r\n";
            }
            code += "            return size;\r\n";
            code += "        }\r\n";
        }

        /**
         * Appends C# code to compute the size of a list and its contents (which may individually vary in size).
         */
        protected void AppendSerializerComputeListSize(ref string code, string fieldName, IFieldType elementType) {
            code += "            size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)item." + fieldName + ".Count);\r\n";
            if (elementType is PrimitiveFieldType) {
                PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)elementType;
                if (primitiveFieldType.PrimitiveType == PrimitiveType.String) {
                    code += "            foreach (string s in item." + fieldName + ") {\r\n";
                    code += "                size += (uint)(PatternBufferUtil.GetUnsignedVariantSize((ulong)s.Length) + s.Length);\r\n";
                    code += "            }\r\n";
                }
                else if (PatternBufferCompiler.variantPrimitiveTypes.Contains(primitiveFieldType.PrimitiveType)) {
                    code += "            foreach ("+this.ToCSharpType(primitiveFieldType) +" variant in item." + fieldName + ") {\r\n";
                    if (PatternBufferCompiler.signedVariantPrimitiveTypes.Contains(primitiveFieldType.PrimitiveType)) {
                        code += "                size += (uint)PatternBufferUtil.GetSignedVariantSize(variant);\r\n";
                    }
                    else {
                        code += "                size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)variant);\r\n";
                    }
                    code += "            }\r\n";
                }
                else {
                    code += "            size += (uint)(item." + fieldName + ".Count * " + PatternBufferCompiler.GetPrimitiveSize(primitiveFieldType.PrimitiveType) + ");\r\n";
                }
            }
            else {
                ReferenceFieldType referenceFieldType = (ReferenceFieldType)elementType;
                IPatternBufferReferrable referrable = referenceFieldType.Referrable;
                if (referrable is PatternBufferEnum) {
                    code += "            size += (uint)item." + fieldName + ".Count;\r\n";
                }
                else if (referrable is PatternBufferType && ((PatternBufferType)referrable).IsFinal) {
                    string serializerName = CreateRandomFieldName("serializer");
                    code += "            IPatternBufferSerializer "+ serializerName + " = this.patternBuffer.GetSerializerByTypeName(\"" + referenceFieldType.ReferrableName + "\");\r\n";
                    code += "            foreach (" + this.ToCSharpName(referenceFieldType.ReferrableName) + " s in item." + fieldName + ") {\r\n";
                    code += "                size += (uint)" + serializerName + ".SizeOf(s);\r\n";
                    code += "            }\r\n";
                }
                else {
                    string serializerName = CreateRandomFieldName("serializer");
                    code += "            foreach (" + this.ToCSharpName(referrable.Name) + " a in item." + fieldName + ") {\r\n";
                    code += "                IPatternBufferSerializer " + serializerName + " = this.patternBuffer.GetSerializerFor(a);\r\n";
                    code += "                size += (uint)PatternBufferUtil.GetUnsignedVariantSize((ulong)"+ serializerName + ".TypeId);\r\n";
                    code += "                size += (uint)" + serializerName + ".SizeOf(a);\r\n";
                    code += "            }\r\n";
                }
            }
        }

        /**
         * Generates the FromBytes method for a PatternBufferType serializer class.
         */
        protected void AppendSerializerFromBytes(ref string code, string typeClassName, PatternBufferType t) {
            code += "        public object FromBytes(BinaryReader reader) {\r\n";
            code += "            "+typeClassName+" item = new "+typeClassName+"();\r\n";
            List<PatternBufferField> allFields = this.GetAllFields(t);
            foreach (PatternBufferField field in allFields) {
                IFieldType fieldType = field.FieldType;
                string fieldTypeName = this.ToCSharpType(field.FieldType);
                string fieldName = this.ToCSharpName(field.Name);
                if (fieldType is PrimitiveFieldType) {
                    PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)fieldType;
                    code += "            // PRIMITIVE: " + fieldName + "\r\n";
                    if (PatternBufferCompiler.variantPrimitiveTypes.Contains(primitiveFieldType.PrimitiveType)) {
                        code += "            item." + fieldName + " = ("+this.ToCSharpType(primitiveFieldType)+")reader.Read"+PatternBufferCompiler.primitiveTypeReaderTypeMap[primitiveFieldType.PrimitiveType]+"();\r\n";
                    }
                    else {
                        string readerType = PatternBufferCompiler.GetReaderType(((PrimitiveFieldType)fieldType).PrimitiveType);
                        code += "            item." + fieldName + " = reader.Read" + readerType + "();\r\n";
                    }
                }
                else if (fieldType is ReferenceFieldType) {
                    code += "            // REFERENCE: "+fieldName+"\r\n";
                    ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                    if (referenceFieldType.Referrable is PatternBufferType) {
                        PatternBufferType patternBufferType = (PatternBufferType)referenceFieldType.Referrable;
                        if (patternBufferType.IsFinal) {
                            code += "            item." + fieldName + " = (" + this.ToCSharpType(referenceFieldType) + ")this.patternBuffer.GetSerializerByTypeName(\"" + referenceFieldType.ReferrableName + "\").FromBytes(reader);\r\n";
                        }
                        else {
                            code += "            item." + fieldName + " = reader.ReadAbstractReference<" + this.ToCSharpType(referenceFieldType) + ">(this.patternBuffer, \"" + referenceFieldType.ReferrableName + "\");\r\n";
                        }
                    }
                    else {
                        string enumName = this.ToCSharpName(referenceFieldType.ReferrableName);
                        code += "            item." + fieldName + " = (" + enumName + ")System.Enum.Parse(typeof(" + enumName + "), this.patternBuffer.GetEnumValue(\""+ enumName + "\", reader.ReadByte()));\r\n";
                    }
                }
                else if (fieldType is ListFieldType) {
                    ListFieldType listFieldType = (ListFieldType)fieldType;
                    IFieldType elementType = listFieldType.ElementType;
                    code += "            // LIST: "+fieldName+"\r\n";
                    this.AppendSerializerReadCollection(ref code, "item."+fieldName, elementType, "List");
                }
                else if (fieldType is MapFieldType) {
                    code += "            // MAP: "+fieldName+"\r\n";
                    MapFieldType mapFieldType = (MapFieldType)fieldType;
                    string keyTypeName = this.ToCSharpType(mapFieldType.KeyType);
                    string valueTypeName = this.ToCSharpType(mapFieldType.ValueType);
                    string mapFieldName = this.ToCSharpName(field.Name);
                    string mapKeysFieldName = this.ToCSharpName(field.Name) + "Keys";
                    string mapValuesFieldName = this.ToCSharpName(field.Name) + "Values";
                    //code += "            int count = " + mapFieldName + ".Count;\r\n";
                    code += "            IList<" + keyTypeName + "> " + mapKeysFieldName + " = new List<" + keyTypeName + ">();\r\n";
                    code += "            IList<" + valueTypeName + "> " + mapValuesFieldName + " = new List<" + valueTypeName + ">();\r\n";
                    this.AppendSerializerReadCollection(ref code, mapKeysFieldName, mapFieldType.KeyType, "List", "Keys");
                    this.AppendSerializerReadCollection(ref code, mapValuesFieldName, mapFieldType.ValueType, "List", "Values");
                    code += "            item." + mapFieldName + " = new Dictionary<"+keyTypeName+","+valueTypeName+ ">("+mapKeysFieldName+".Count);\r\n";
                    code += "            for (int i = 0; i < " + mapKeysFieldName + ".Count; i++) {\r\n";
                    code += "                item."+ mapFieldName + "[" + mapKeysFieldName + "[i]] = " + mapValuesFieldName + "[i];\r\n";
                    code += "            }\r\n";
               }
                else if (fieldType is SetFieldType) {
                    SetFieldType setFieldType = (SetFieldType)fieldType;
                    IFieldType elementType = setFieldType.ElementType;
                    code += "            // SET: " + fieldName + "\r\n";
                    this.AppendSerializerReadCollection(ref code, "item." + fieldName, elementType, "HashSet");
                }
            }
            code += "            return item;\r\n";
            code += "        }\r\n";
        }

        /**
         * Generates the ToBytes method for a PatternBufferType serializer class.
         */
        protected void AppendSerializerToBytes(ref string code, string typeClassName, PatternBufferType t) {
            code += "        public void ToBytes(BinaryWriter writer, object o) {\r\n";
            code += "            "+typeClassName+" item = ("+typeClassName+")o;\r\n";
            List<PatternBufferField> allFields = this.GetAllFields(t);
            foreach (PatternBufferField field in allFields) {
                IFieldType fieldType = field.FieldType;
                string fieldTypeName = this.ToCSharpType(field.FieldType);
                string fieldName = this.ToCSharpName(field.Name);
                if (fieldType is PrimitiveFieldType) {
                    PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)fieldType;
                    code += "            // PRIMITIVE: " + fieldName + "\r\n";
                    if (PatternBufferCompiler.variantPrimitiveTypes.Contains(primitiveFieldType.PrimitiveType)) {
                        code += "            writer.Write"+ PatternBufferCompiler.primitiveTypeReaderTypeMap[primitiveFieldType.PrimitiveType] + "(item." + fieldName + ");\r\n";
                    }
                    else {
                        code += "            writer.Write((" + fieldTypeName + ")item." + fieldName + ");\r\n";
                    }
                }
                else if (fieldType is ReferenceFieldType) {
                    ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                    code += "            // REFERENCE: " + fieldName + "\r\n";
                    if (referenceFieldType.Referrable is PatternBufferType) {
                        PatternBufferType patternBufferType = (PatternBufferType)referenceFieldType.Referrable;
                        if (patternBufferType.IsFinal) {
                            code += "            this.patternBuffer.GetSerializerByTypeName(\"" + referenceFieldType.ReferrableName + "\").ToBytes(writer, item." + fieldName + ");\r\n";
                        }
                        else {
                            string serializerName = CreateRandomFieldName("serializer");
                            code += "            IPatternBufferSerializer " + serializerName + " = this.patternBuffer.GetSerializerFor(item." + fieldName + ");\r\n";
                            code += "            writer.WriteAbstractReference<" + this.ToCSharpType(referenceFieldType) + ">(this.patternBuffer, " + serializerName + ".TypeName, item." + fieldName + ");\r\n";
                        }
                    }
                    else {
                        code += "            writer.Write(this.patternBuffer.GetEnumIndex(\""+ referenceFieldType.ReferrableName + "\", item."+fieldName+".ToString()));\r\n";
                    }
                }
                else if (fieldType is ListFieldType) {
                    ListFieldType listFieldType = (ListFieldType)fieldType;
                    IFieldType elementType = listFieldType.ElementType;
                    code += "            // LIST: "+fieldName+"\r\n";
                    this.AppendSerializerWriteList(ref code, fieldName, elementType);
                }
                else if (fieldType is MapFieldType) {
                    code += "            // MAP: "+fieldName+"\r\n";
                    MapFieldType mapFieldType = (MapFieldType)fieldType;
                    string keyTypeName = this.ToCSharpType(mapFieldType.KeyType);
                    string valueTypeName = this.ToCSharpType(mapFieldType.ValueType);
                    this.AppendSerializerWriteList(ref code, fieldName, mapFieldType.KeyType, "Keys");
                    this.AppendSerializerWriteList(ref code, fieldName, mapFieldType.ValueType, "Values");
                }
                else if (fieldType is SetFieldType) {
                    SetFieldType setFieldType = (SetFieldType)fieldType;
                    IFieldType elementType = setFieldType.ElementType;
                    code += "            // SET: "+fieldName+"\r\n";
                    this.AppendSerializerWriteList(ref code, fieldName, elementType);
                }
            }
            code += "        }\r\n";
        }

        /**
         * Appends C# code to serialize a C# list into bytes.
         */
        protected void AppendSerializerWriteList(ref string code, string fieldName, IFieldType elementType) {
            this.AppendSerializerWriteList(ref code, fieldName, elementType, null);
        }

        /**
         * Appends C# code to serialize a C# list into bytes.
         */
        protected void AppendSerializerWriteList(ref string code, string fieldName, IFieldType elementType, string subfieldName) {
            string subfield = "";
            if (subfieldName != null) {
                subfield = "." + subfieldName;
            }
            if (elementType is PrimitiveFieldType) {
                PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)elementType;
                
                string listFieldName = "item." + fieldName + subfield;
                code += "            if ("+listFieldName+" != null) {\r\n";
                //code += "                writer.Write(("+typeIdType+")"+listFieldName+".Count);\r\n";
                code += "                writer.WriteVUInt64((ulong)" + listFieldName+".Count);\r\n";
                code += "                foreach ("+this.ToCSharpType(primitiveFieldType)+" primitive in "+listFieldName+") {\r\n";
                if (PatternBufferCompiler.variantPrimitiveTypes.Contains(primitiveFieldType.PrimitiveType)) {
                    code += "                    writer.Write" + PatternBufferCompiler.GetReaderType(primitiveFieldType.PrimitiveType) + "(primitive);\r\n";
                }
                else {
                    code += "                    writer.Write(primitive);\r\n";
                }
                code += "                }\r\n";
                code += "            }\r\n";
                code += "            else {\r\n";
                code += "                writer.WriteVUInt64(0);\r\n";
                code += "            }\r\n";
            }
            else if (elementType is ReferenceFieldType) {
                ReferenceFieldType referenceFieldType = (ReferenceFieldType)elementType;
                // list<enum>
                if (referenceFieldType.Referrable is PatternBufferEnum) {
                    PatternBufferEnum patternBufferEnum = (PatternBufferEnum)referenceFieldType.Referrable;
                    code += "            writer.WriteEnumCollection<" + referenceFieldType.ReferrableName+ ">(this.patternBuffer, \""+ patternBufferEnum.Name + "\", item." + fieldName+subfield+");\r\n";
                }
                // list<something>
                else if (referenceFieldType.Referrable is PatternBufferType) {
                    PatternBufferType patternBufferType = (PatternBufferType)referenceFieldType.Referrable;
                    // All objects in the list are the same type
                    if (patternBufferType.IsFinal) {
                        code += "            writer.WriteFinalObjectCollection<" + this.ToCSharpType(referenceFieldType)+">(this.patternBuffer.GetSerializerByTypeName(\"" + referenceFieldType.ReferrableName+"\")"+", item."+fieldName+subfield+");\r\n";
                    }
                    // The objects in the list may be of different types
                    else {
                        code += "            writer.WriteAbstractObjectCollection<" + this.ToCSharpType(referenceFieldType)+ ">(this.patternBuffer, item." + fieldName+subfield+");\r\n";
                    }
                }
                else {
                    // what
                }
            }
        }

        /**
         * Appends C# code to read a collection of serialized objects into the appropriate collection type.
         */
        protected void AppendSerializerReadCollection(ref string code, string fieldName, IFieldType elementType, string collectionTypeName) {
            this.AppendSerializerReadCollection(ref code, fieldName, elementType, collectionTypeName, null);
        }

        /**
         * Appends C# code to read a collection of serialized objects into the appropriate collection type.
         */
        protected void AppendSerializerReadCollection(ref string code, string fieldName, IFieldType elementType, string collectionTypeName, string subfieldName) {
            if (elementType is PrimitiveFieldType) {
                PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)elementType;
                string readerType = PatternBufferCompiler.GetReaderType(primitiveFieldType.PrimitiveType);
                string countName = CreateRandomFieldName("count");
                code += "            int "+ countName + " = (int)reader.ReadVUInt64();\r\n";
                code += "            if (" + countName + " > 0) {\r\n";
                code += "                "+fieldName+" = new "+collectionTypeName+"<"+this.ToCSharpType(primitiveFieldType)+ ">();\r\n";
                code += "                for (int i = 0; i < " + countName + "; i++) {\r\n";
                if (PatternBufferCompiler.variantPrimitiveTypes.Contains(primitiveFieldType.PrimitiveType)) {
                    if (PatternBufferCompiler.unsignedVariantPrimitiveTypes.Contains(primitiveFieldType.PrimitiveType)) {
                        code += "                    " + fieldName + ".Add((" + this.ToCSharpType(primitiveFieldType) + ")reader.Read" + readerType + "());\r\n";
                    }
                    else {
                        code += "                    " + fieldName + ".Add((" + this.ToCSharpType(primitiveFieldType) + ")reader.Read" + readerType + "());\r\n";
                    }
                }
                else {
                    code += "                    " + fieldName + ".Add(reader.Read" + readerType + "());\r\n";
                }
                code += "                }\r\n";
                code += "            }\r\n";
            }
            else if (elementType is ReferenceFieldType) {
                ReferenceFieldType referenceFieldType = (ReferenceFieldType)elementType;
                // list<enum>
                if (referenceFieldType.Referrable is PatternBufferEnum) {
                    PatternBufferEnum potionEnum = (PatternBufferEnum)referenceFieldType.Referrable;
                    string enumName = this.ToCSharpName(potionEnum.Name);
                    code += "            "+fieldName+ " = reader.ReadEnumCollection<" + collectionTypeName + "<"+ enumName + ">," + enumName+ ">(this.patternBuffer, \"" + enumName+"\");\r\n";
                }
                // list<something>
                else if (referenceFieldType.Referrable is PatternBufferType) {
                    PatternBufferType patternBufferType = (PatternBufferType)referenceFieldType.Referrable;
                    string elementTypeName = this.ToCSharpType(referenceFieldType);
                    // All objects in the list are the same type
                    if (patternBufferType.IsFinal) {
                        code += "            " + fieldName + " = reader.ReadFinalObjectCollection<"+collectionTypeName+"<"+ elementTypeName + ">," + elementTypeName + ">(this.patternBuffer.GetSerializerByTypeName(\""+ referenceFieldType.ReferrableName+ "\"));\r\n";
                    }
                    // The objects in the list may be of different types
                    else {
                        code += "            " + fieldName + " = reader.ReadAbstractObjectCollection<" + collectionTypeName + "<"+ elementTypeName + ">," + elementTypeName + ">(this.patternBuffer);\r\n";
                    }
                }
                else {
                    // what
                }
            }
        }

        /**
         * Generates the C# source code for the overall PatternBuffer implementation class that knows how to read and
         * write all PatternBuffer types, which is the whole damn point of this thing.
         */
        protected void GeneratePatternBuffer(Dictionary<string, string> results, PatternBufferSchema s) {

            string potionClassName = this.ToCSharpName(s.Name) + "PatternBuffer";
            string code = BOILERPLATE;

            code += "using PatternBuffer;\r\n\r\n";
            code += "using System.Collections.Generic;\r\n\r\n";
            code += "namespace "+this.generatedNamespace+" {\r\n";
            code += "    public class "+potionClassName+" : AbstractPatternBuffer {\r\n";
            code += "        protected override void RegisterSerializers() {\r\n\r\n";
            foreach (PatternBufferType type in s.Types) {
                if (type.TypeId != 0) {
                    string serializerClassName = this.ToCSharpName(type.Name) + "Serializer";
                    string serializerName = CreateRandomFieldName("serializer");
                    code += "            " + serializerClassName + " " + serializerName + " = new " + serializerClassName + "(this);\r\n";
                    code += "            this.typeIdSerializerMap["+type.TypeId+"] = " + serializerName + ";\r\n";
                    code += "            this.typeSerializerMap[typeof("+this.ToCSharpName(type.Name)+ ")] = " + serializerName + ";\r\n";
                    code += "            this.typeNameSerializerMap[\""+type.Name+ "\"] = " + serializerName + ";\r\n";
                    code += "\r\n";
                }
            }
            code += "        }\r\n";

            code += "        protected override void RegisterEnums() {\r\n\r\n";
            foreach (PatternBufferEnum e in s.Enums) {
                code += "            this.enumIndexValueMap[\"" + e.Name + "\"] = new Dictionary<byte,string>();\r\n";
                code += "            this.enumValueIndexMap[\"" + e.Name + "\"] = new Dictionary<string,byte>();\r\n";
                for (int v = 0; v < e.Values.Count; v++) {
                    code += "            this.enumIndexValueMap[\""+e.Name+"\"]["+(v+1)+"] = \""+e.Values[v]+"\";\r\n";
                    code += "            this.enumValueIndexMap[\""+e.Name+"\"][\""+e.Values[v]+"\"] = "+(v+1)+";\r\n";
                }
                code += "\r\n";
            }
            code += "        }\r\n";

            code += "    }\r\n";
            code += "}\r\n";
            results[potionClassName + ".cs"] = code;
        }

        /**
         * Converts a schem name into a C# variable name.
         */
        protected string ToCSharpName(string name) {
            return name;
        }

        /**
         * Converts a schema name into a C# property name.
         */
        protected string ToCSharpPropertyName(string name) {
            return name.Substring(0, 1).ToUpper() + name.Substring(1);
        }

        private static Dictionary<PrimitiveType, string> variantPrimitivesMap = new Dictionary<PrimitiveType, string>() {
            { PrimitiveType.VInt, "int" },
            { PrimitiveType.VLong, "long" },
            { PrimitiveType.VUInt, "uint" },
            { PrimitiveType.VULong, "ulong" },
            { PrimitiveType.VUShort, "ushort" }
        };

        /**
         * Converts a PrimitiveType to a CSharp primitive type name
         */
        protected string ToCSharpPrimitiveType(PrimitiveType primitiveType) {
            if (PatternBufferCompiler.variantPrimitivesMap.ContainsKey(primitiveType)) {
                return PatternBufferCompiler.variantPrimitivesMap[primitiveType];
            }
            else {
                return primitiveType.ToString().ToLower();
            }
        }

        /**
         * Converts a field type into a C# field type name string.
         */
        protected string ToCSharpType(IFieldType fieldType) {
            if (fieldType is PrimitiveFieldType) {
                PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)fieldType;
                return this.ToCSharpPrimitiveType(primitiveFieldType.PrimitiveType);
            }
            else if (fieldType is ReferenceFieldType) {
                ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                if (referenceFieldType.Referrable is PatternBufferEnum) {
                    return this.ToCSharpName(((ReferenceFieldType)fieldType).ReferrableName);
                }
                else {
                    return "I" + this.ToCSharpName(((ReferenceFieldType)fieldType).ReferrableName);
                }
            }
            else if (fieldType is ListFieldType) {
                return "List<" + this.ToCSharpType(((ListFieldType)fieldType).ElementType) + ">";
            }
            else if (fieldType is SetFieldType) {
                return "HashSet<" + this.ToCSharpType(((SetFieldType)fieldType).ElementType) + ">";
            }
            else if (fieldType is MapFieldType) {
                return "Dictionary<" + this.ToCSharpType(((MapFieldType)fieldType).KeyType) + "," + this.ToCSharpType(((MapFieldType)fieldType).ValueType) + ">";
            }
            return "WHATEVS";
        }

        /**
         * Returns a list of all the fields in a PatterBufferType's type hierarchy. The returned list
         * will contains the fields of all the given type's ancestors with the eldest (highest) ancestor's
         * fields first and the given type's fields last, along with all intermediate ancestors in between.
         * Fields are returned in the order defined in the schema file.
         */
        protected List<PatternBufferField> GetAllFields(PatternBufferType type) {
            // Collect the hierarchy
            List<PatternBufferType> hierarchy = new List<PatternBufferType>();
            PatternBufferType current = type;
            while (current != null) {
                hierarchy.Insert(0, current);
                current = current.BaseType;
            }

            // Collect the fields
            List<PatternBufferField> fields = new List<PatternBufferField>();
            foreach (PatternBufferType t in hierarchy) {
                foreach (PatternBufferField f in t.Fields) {
                    fields.Add(f);
                }
            }

            return fields;
        }

        /**
         * Creates a random field name
         */
        protected static string CreateRandomFieldName(string prefix) {
            string guid = Guid.NewGuid().ToString().Substring(0,11);
            return prefix + "_" + guid.Replace("{", "").Replace("}", "").Replace("-", ""); 
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

    }

}


