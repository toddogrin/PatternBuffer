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

    }
}
