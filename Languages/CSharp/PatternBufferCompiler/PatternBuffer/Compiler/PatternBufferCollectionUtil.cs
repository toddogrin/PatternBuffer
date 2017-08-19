using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBUV = PatternBuffer.PatternBufferUnsignedVariantUtil;
using PB = PatternBuffer.PatternBufferUtil;
using PBP = PatternBuffer.PatternBufferPrimitiveUtil;
using PatternBuffer.Schema;

namespace PatternBuffer {

    /**
     * This class contains static methods to append code to read/write PatternBuffer collections.
     */
    public class PatternBufferCollectionUtil {

        /**
         * Appends C# code to serialize a C# list into bytes.
         */
        public static  void AppendSerializerWriteCollection(ref string code, string fieldName, IFieldType elementType, string schemaObjectTypeName) {
            AppendSerializerWriteCollection(ref code, fieldName, elementType, null, schemaObjectTypeName);
        }

        /**
         * Appends C# code to serialize a C# list into bytes.
         */
        public static void AppendSerializerWriteCollection(ref string code, string fieldName, IFieldType elementType, string subfieldName, string schemaObjectTypeName) {
            string subfield = "";
            if (subfieldName != null) {
                subfield = "." + subfieldName;
            }

            // Deal with list lengths
            string targetList = "o." + fieldName + subfield;
            code += "            if (o." + fieldName + " == null || " + targetList + " == null || " + targetList + ".Count == 0) {\r\n";
            PBP.AppendWriteByte(ref code, "0");
            code += "            }\r\n";
            code += "            else { \r\n";
            PBP.AppendWriteVUInt16(ref code, targetList + ".Count");

            if (elementType is PrimitiveFieldType) {
                PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)elementType;
                code += "                foreach (" + PB.ToCSharpType(primitiveFieldType) + " primitive in " + targetList + ") {\r\n";
                PBP.AppendWritePrimitive(ref code, "primitive", primitiveFieldType.PrimitiveType);
                code += "                }\r\n";
            }
            else if (elementType is ReferenceFieldType) {
                ReferenceFieldType referenceFieldType = (ReferenceFieldType)elementType;
                // list<enum>
                if (referenceFieldType.Referrable is PatternBufferEnum) {
                    PatternBufferEnum patternBufferEnum = (PatternBufferEnum)referenceFieldType.Referrable;
                    code += "                foreach (" + PB.ToCSharpName(patternBufferEnum.Name) + " enumValue in " + targetList + ") {\r\n";
                    PBP.AppendWriteByte(ref code, "enumValueIndexMap[\"" + referenceFieldType.ReferrableName + "\"][enumValue.ToString()];\r\n");
                    code += "                }\r\n";
                }
                // list<something>
                else if (referenceFieldType.Referrable is PatternBufferType) {
                    PatternBufferType patternBufferType = (PatternBufferType)referenceFieldType.Referrable;
                    // All objects in the list are the same type; do not write type IDs for each item
                    if (patternBufferType.IsFinal) {
                        code += "                foreach (" + PB.ToCSharpName(patternBufferType.Name) + " finalObject in " + targetList + ") {\r\n";
                        code += "                    Energize(finalObject, bytes, ref index, false);\r\n";
                        code += "                }\r\n";
                    }
                    // The objects in the list may be of different types; write the type ID for each item
                    else {
                        code += "                foreach (" + schemaObjectTypeName + " abstractObject in " + targetList + ") {\r\n";
                        code += "                    Energize((" + schemaObjectTypeName + ")abstractObject, bytes, ref index, true);\r\n";
                        code += "                }\r\n";
                    }
                }
                else {
                    // what
                }
            }
            code += "            }\r\n";
        }

        /**
         * Appends C# code to read a collection of serialized objects into the appropriate collection type.
         */
        public static  void AppendSerializerReadCollection(ref string code, string fieldName, IFieldType elementType, string collectionTypeName) {
            AppendSerializerReadCollection(ref code, fieldName, elementType, collectionTypeName, null);
        }

        /**
         * Appends C# code to read a collection of serialized objects into the appropriate collection type.
         */
        public static  void AppendSerializerReadCollection(ref string code, string fieldName, IFieldType elementType, string collectionTypeName, string subfieldName) {

            // Read the list item count
            code += "            // Read list item count\r\n";
            string countFieldName = PB.CreateRandomFieldName("count");
            code += "            ushort " + countFieldName + ";\r\n";
            PBP.AppendReadVUInt16(ref code, countFieldName);

            // Continue if the bytes indicate more than zero items.
            code += "            // Read list items\r\n";
            code += "            if (" + countFieldName + " > 0) {\r\n";

            // The element size is constant if:
            // 1) It's a primitive field
            // 2) It's not a variant primitive
            // 3) It's not a string
            // Serialize constant-sized primitives
            if ((elementType is PrimitiveFieldType)) {
                PrimitiveFieldType primitiveFieldType = (PrimitiveFieldType)elementType;
                string cappedElementName = PB.ToCapitalizedCSharpType(primitiveFieldType);
                code += "                " + fieldName + " = this.instantiator.Acquire" + collectionTypeName + "Of" + cappedElementName + "();\r\n";
                string tempFieldName = PB.CreateRandomFieldName("listValue");
                code += "                " + PB.ToCSharpType(primitiveFieldType) + " " + tempFieldName + ";\r\n";
                string i = PB.CreateRandomFieldName("i");
                code += "                for (int " + i + " = 0; " + i + " < " + countFieldName + "; " + i + "++) {\r\n";
                code += "                    // Read " + primitiveFieldType.PrimitiveType + " list item\r\n";
                PBP.AppendReadPrimitive(ref code, tempFieldName, primitiveFieldType.PrimitiveType);
                code += "                    " + fieldName + ".Add(" + tempFieldName + ");\r\n";
                code += "                }\r\n";
            }

            // Serialize variable size list elements (incl. references, enums, strings)
            else {
                ReferenceFieldType referenceFieldType = (ReferenceFieldType)elementType;
                // list<enum>
                if (referenceFieldType.Referrable is PatternBufferEnum) {
                    PatternBufferEnum e = (PatternBufferEnum)referenceFieldType.Referrable;
                    string enumName = PB.ToCSharpName(e.Name);
                    string cappedElementName = PB.ToCapitalizedCSharpType(referenceFieldType);
                    code += "                " + fieldName + " = this.instantiator.Acquire" + collectionTypeName + "Of" + cappedElementName + "();\r\n";
                    string i = PB.CreateRandomFieldName("i");
                    code += "                for (int " + i + " = 0; " + i + " < " + countFieldName + "; " + i + "++) {\r\n";
                    code += "                    " + fieldName + ".Add((" + enumName + ")System.Enum.Parse(typeof(" + enumName + "), enumIndexValueMap[\"" + referenceFieldType.ReferrableName + "\"][bytes[index++]]));\r\n";
                    code += "                }\r\n";
                }
                // list<something>
                else if (referenceFieldType.Referrable is PatternBufferType) {
                    PatternBufferType patternBufferType = (PatternBufferType)referenceFieldType.Referrable;
                    string elementTypeName = PB.ToCSharpType(referenceFieldType);
                    string cappedElementName = PB.ToCapitalizedCSharpType(referenceFieldType);
                    code += "                " + fieldName + " = this.instantiator.Acquire" + collectionTypeName + "Of" + cappedElementName + "();\r\n";
                    string i = PB.CreateRandomFieldName("li");
                    // All objects in the list are the same type
                    if (patternBufferType.IsFinal) {
                        code += "                for (int " + i + " = 0; " + i + " < " + countFieldName + "; " + i + "++) {\r\n";
                        code += "                    " + fieldName + ".Add((" + elementTypeName + ")Energize(bytes, ref index, " + patternBufferType.TypeId + "));\r\n";
                        code += "                }\r\n";
                    }
                    // The objects in the list may be of different types
                    else {
                        code += "                for (int " + i + " = 0; " + i + " < " + countFieldName + "; " + i + "++) {\r\n";
                        code += "                    " + fieldName + ".Add((" + elementTypeName + ")Energize(bytes, ref index));\r\n";
                        code += "                }\r\n";
                    }
                }
                else {
                    // what
                }
            }
            code += "            }\r\n";
        }

    }
}
