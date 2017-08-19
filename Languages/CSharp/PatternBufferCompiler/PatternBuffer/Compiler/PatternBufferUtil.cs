using System;
using System.Collections.Generic;
using PatternBuffer.Schema;


namespace PatternBuffer {

    /**
     * This class contains static methods to perform several utility functions needed in order to compile a .pb
     * file into runnable C# code.
     */
    public static class PatternBufferUtil {

        public static Random random = new Random();

        // Primitives that can be stored in variant (compressed) format.
        public static List<PrimitiveType> variantPrimitiveTypes = new List<PrimitiveType>() {
            PrimitiveType.VInt,
            PrimitiveType.VLong,
            PrimitiveType.VUInt,
            PrimitiveType.VULong,
            PrimitiveType.VUShort
        };

        // Primitives that can be stored in variant (compressed) format.
        public static List<PrimitiveType> signedVariantPrimitiveTypes = new List<PrimitiveType>() {
            PrimitiveType.VInt,
            PrimitiveType.VLong
        };

        // Primitives that can be stored in variant (compressed) format.
        public static List<PrimitiveType> unsignedVariantPrimitiveTypes = new List<PrimitiveType>() {
            PrimitiveType.VUInt,
            PrimitiveType.VULong,
            PrimitiveType.VUShort
        };

        // Maps primitive types to their maximum size, in bytes, when serialized.
        public static Dictionary<PrimitiveType, int> primitiveTypeSizeMap = new Dictionary<PrimitiveType, int>() {
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

        // Maps primitive types to their maximum size, in bytes, when serialized.
        public static Dictionary<PrimitiveType, int> constantSizePrimitivesMap = new Dictionary<PrimitiveType, int>() {
            { PrimitiveType.Bool, 1 },
            { PrimitiveType.Byte, 1 },
            { PrimitiveType.Double, 8 },
            { PrimitiveType.Float, 4 },
            { PrimitiveType.Int, 4 },
            { PrimitiveType.Long, 8 },
            { PrimitiveType.Short, 2 },
            { PrimitiveType.UInt, 4 },
            { PrimitiveType.ULong, 8 },
            { PrimitiveType.UShort, 2 }
        };

        // Defines the characters than can be used in the random part of randomly generated variable names.
        private const string randomFieldNameChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        
        /**
         * Creates a random field name
         */
        public static string CreateRandomFieldName(string prefix) {
            string name = randomFieldNameChars.Substring(random.Next(26), 1);
            for (int i = 0; i < 11; i++) {
                name += randomFieldNameChars.Substring(random.Next(randomFieldNameChars.Length), 1);
            }
            return (prefix != null ? prefix + "_" : "") + name;
        }

        /**
         * Creates a random field name with no prefix.
         */
        public static string CreateRandomFieldName() {
            return CreateRandomFieldName(null);
        }

        /**
         * Converts a schema's name into the schema object type name.
         */
        public static string ToSchemaObjectTypeName(PatternBufferSchema schema) {
            return "I" + ToCSharpPropertyName(schema.Name) + "Object";
        }

        /**
         * Converts a schema's name into the PatternBuffer's exception name.
         */
        public static string ToSchemaExceptionName(PatternBufferSchema schema) {
            return ToCSharpPropertyName(schema.Name) + "PatternBufferException";
        }

        /**
         * Converts a schem name into a C# variable name.
         */
        public static string ToCSharpName(string name) {
            return name;
        }

        /**
         * Converts a schema name into a C# property name.
         */
        public static string ToCSharpPropertyName(string name) {
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
        public static string ToCSharpPrimitiveType(PrimitiveType primitiveType) {
            if (variantPrimitivesMap.ContainsKey(primitiveType)) {
                return variantPrimitivesMap[primitiveType];
            }
            else {
                return primitiveType.ToString().ToLower();
            }
        }

        /**
         * Converts a field type into a C# field type name string.
         */
        public static string ToCSharpType(IFieldType fieldType) {
            if (fieldType is PrimitiveFieldType) {
                PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)fieldType;
                return ToCSharpPrimitiveType(primitiveFieldType.PrimitiveType);
            }
            else if (fieldType is ReferenceFieldType) {
                ReferenceFieldType referenceFieldType = (ReferenceFieldType)fieldType;
                if (referenceFieldType.Referrable is PatternBufferEnum) {
                    return ToCSharpName(((ReferenceFieldType)fieldType).ReferrableName);
                }
                else {
                    return ToCSharpName(((ReferenceFieldType)fieldType).ReferrableName);
                }
            }
            else if (fieldType is ListFieldType) {
                return "List<" + ToCSharpType(((ListFieldType)fieldType).ElementType) + ">";
            }
            else if (fieldType is SetFieldType) {
                return "HashSet<" + ToCSharpType(((SetFieldType)fieldType).ElementType) + ">";
            }
            else if (fieldType is MapFieldType) {
                return "Dictionary<" + ToCSharpType(((MapFieldType)fieldType).KeyType) + "," + ToCSharpType(((MapFieldType)fieldType).ValueType) + ">";
            }
            return "WHATEVS";
        }

        public static string ToCapitalizedCSharpType(IFieldType fieldType) {
            string s = ToCSharpType(fieldType);
            return s.Substring(0, 1).ToUpper() + s.Substring(1);
        }

        /**
         * Appends C# code to write a comment into the code.
         */
        public static void AppendComment(ref string code, string comment, bool box) {
            if (box) {
                code += "///////////////////////////////////////\r\n";
            }
            code += "// " + comment + "\r\n";
            if (box) {
                code += "///////////////////////////////////////\r\n";
            }
        }

        /**
         * Appends C# code to read a referenced object from the byte buffer.
         */
        public static void AppendReadReference(ref string code, PatternBufferType patternBufferType, string varName) {
            if (patternBufferType.IsFinal) {
                code += "                " + varName + " = (" + ToCSharpName(patternBufferType.Name) + ")Energize(bytes, ref index, " + patternBufferType.TypeId + ");\r\n";
            }
            else {
                code += "                " + varName + " = (" + ToCSharpName(patternBufferType.Name) + ")Energize(bytes, ref index);\r\n";
            }
        }

        /**
         * Appends C# code to write a referenced object to the byte buffer.
         */
        public static void AppendWriteReference(ref string code, PatternBufferType patternBufferType, string varName, string schemaObjectTypeName) {
            if (patternBufferType.IsFinal) {
                code += "                Energize(" + varName + ", bytes, ref index, false);\r\n";
            }
            else {
                code += "                Energize((" + schemaObjectTypeName + ")" + varName + ", bytes, ref index, true);\r\n";
            }
        }

        /**
         * Returns a list of all the fields in a PatterBufferType's type hierarchy. The returned list
         * will contains the fields of all the given type's ancestors with the eldest (highest) ancestor's
         * fields first and the given type's fields last, along with all intermediate ancestors in between.
         * Fields are returned in the order defined in the schema file.
         */
        public static List<PatternBufferField> GetAllFields(PatternBufferType type) {
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
         * Returns a list of all optional fields on the type, including fields in the type's
         * ancestors.
         */
        public static List<PatternBufferField> GetAllOptionalFields(PatternBufferType type) {
            List<PatternBufferField> allFields = GetAllFields(type);
            List<PatternBufferField> optionalFields = new List<PatternBufferField>();
            foreach (PatternBufferField field in allFields) {
                if (IsOptional(field.FieldType)) {
                    optionalFields.Add(field);
                }
            }
            return optionalFields;
        }

        /**
         * Returns true if the field type is optional.
         */
        public static bool IsOptional(IFieldType fieldType) {
            bool isOptional = false;
            if (fieldType != null && fieldType is INullableFieldType) {
                isOptional = ((INullableFieldType)fieldType).IsNullable;
            }
            return isOptional;
        }

        /**
         * Appends optiona bit flag bytes into the output.
         */
        public static void AppendWriteOptionalFieldFlags(ref string code, PatternBufferType type, string varName) {
            List<PatternBufferField> optionalFields = GetAllOptionalFields(type);
            if (optionalFields.Count > 0) {
                code += "            //\r\n";
                code += "            //\r\n";
                code += "            //\r\n";
                code += "            //\r\n";
                code += "            //\r\n";
                code += "            // you know what do this in the main field serialization loop it already checks nulls\r\n";
                code += "            //\r\n";
                code += "            //\r\n";
                code += "            //\r\n";
                code += "            //\r\n";
                code += "            \r\n";
                code += "            // OPTIONAL FIELD FLAGS\r\n";
                code += "            index--;\r\n";
                int place = 7;
                for (int b = 0; b < optionalFields.Count; b++) {
                    if (b % 8 == 0) {
                        code += "            bytes[++index] = 0;\r\n";
                        place = 7;
                    }
                    PatternBufferField optionalField = optionalFields[b];
                    //code += "            if (" + varName + "." + ToCSharpPropertyName(optionalField.Name) + " != null) {\r\n";
                    //code += "                bytes[index] |= (byte)(1 << " + place + ");\r\n";
                    //code += "            }\r\n";
                    code += "            bytes[index] |= (byte)((" + varName + "." + ToCSharpPropertyName(optionalField.Name) + " != null ? 1 : 0) << " + place + ");\r\n";
                    place--;
                }
                code += "            index++;\r\n";
            }
        }




    }
}
