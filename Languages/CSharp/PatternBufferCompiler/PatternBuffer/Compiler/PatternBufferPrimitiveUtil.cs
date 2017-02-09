using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBUV = PatternBuffer.PatternBufferUnsignedVariantUtil;
using PB = PatternBuffer.PatternBufferUtil;
using PatternBuffer.Schema;
using PatternBuffer;

namespace PatternBuffer {

    /**
     * This class contains static methods to append code to read/write PatternBuffer primitives.
     */
    public class PatternBufferPrimitiveUtil {

        /**
         * Append C# code to write a primitive based on the given PrimitiveType.
         */
        public static void AppendWritePrimitive(ref string code, string varName, PrimitiveType primitiveType) {
            switch (primitiveType) {
                case PrimitiveType.Bool:
                    AppendWriteByte(ref code, varName);
                    break;
                case PrimitiveType.Byte:
                    AppendWriteByte(ref code, varName);
                    break;
                case PrimitiveType.Double:
                    AppendWriteDouble(ref code, varName);
                    break;
                case PrimitiveType.Float:
                    AppendWriteFloat(ref code, varName);
                    break;
                case PrimitiveType.Int:
                    AppendWriteInt32(ref code, varName);
                    break;
                case PrimitiveType.Long:
                    AppendWriteInt64(ref code, varName);
                    break;
                case PrimitiveType.Short:
                    AppendWriteInt16(ref code, varName);
                    break;
                case PrimitiveType.String:
                    AppendWriteString(ref code, varName);
                    break;
                case PrimitiveType.UInt:
                    AppendWriteUInt32(ref code, varName);
                    break;
                case PrimitiveType.ULong:
                    AppendWriteUInt64(ref code, varName);
                    break;
                case PrimitiveType.UShort:
                    AppendWriteUInt64(ref code, varName);
                    break;
                case PrimitiveType.VInt:
                    AppendWriteVInt32(ref code, varName);
                    break;
                case PrimitiveType.VLong:
                    AppendWriteVInt64(ref code, varName);
                    break;
                case PrimitiveType.VUInt:
                    AppendWriteVUInt32(ref code, varName);
                    break;
                case PrimitiveType.VULong:
                    AppendWriteVUInt64(ref code, varName);
                    break;
                case PrimitiveType.VUShort:
                    AppendWriteVUInt16(ref code, varName);
                    break;
                default:
                    //throw new PatternBufferException();
                    break;
            }
        }

        /**
         * Append C# code to read a primitive based on the given PrimitiveType.
         */
        public static void AppendReadPrimitive(ref string code, string varName, PrimitiveType primitiveType) {
            switch (primitiveType) {
                case PrimitiveType.Bool:
                    AppendReadByte(ref code, varName);
                    break;
                case PrimitiveType.Byte:
                    AppendReadByte(ref code, varName);
                    break;
                case PrimitiveType.Double:
                    AppendReadDouble(ref code, varName);
                    break;
                case PrimitiveType.Float:
                    AppendReadFloat(ref code, varName);
                    break;
                case PrimitiveType.Int:
                    AppendReadInt32(ref code, varName);
                    break;
                case PrimitiveType.Long:
                    AppendReadInt64(ref code, varName);
                    break;
                case PrimitiveType.Short:
                    AppendReadInt16(ref code, varName);
                    break;
                case PrimitiveType.String:
                    AppendReadString(ref code, varName);
                    break;
                case PrimitiveType.UInt:
                    AppendReadUInt32(ref code, varName);
                    break;
                case PrimitiveType.ULong:
                    AppendReadUInt64(ref code, varName);
                    break;
                case PrimitiveType.UShort:
                    AppendReadUInt64(ref code, varName);
                    break;
                case PrimitiveType.VInt:
                    AppendReadVInt32(ref code, varName);
                    break;
                case PrimitiveType.VLong:
                    AppendReadVInt64(ref code, varName);
                    break;
                case PrimitiveType.VUInt:
                    AppendReadVUInt32(ref code, varName);
                    break;
                case PrimitiveType.VULong:
                    AppendReadVUInt64(ref code, varName);
                    break;
                case PrimitiveType.VUShort:
                    AppendReadVUInt16(ref code, varName);
                    break;
                default:
                    //throw new PatternBufferException();
                    break;
            }
        }

        /**
         * Append C# code to write a byte to the byte buffer.
         */
        public static void AppendWriteByte(ref string code, string varName) {
            code += "                bytes[index++] = " + varName + ";\r\n";
        }

        /**
         * Append C# code to read a byte from the byte buffer.
         */
        public static void AppendReadByte(ref string code, string varName) {
            code += "                " + varName + " = bytes[index++];\r\n";
        }

        /**
         * Append C# code to write a bool to the byte buffer.
         */
        public static void AppendWriteBool(ref string code, string varName) {
            code += "                bytes[index++] = " + varName + " ? (byte)1 : (byte)0;\r\n";
        }

        /**
         * Append C# code to read a bool from the byte buffer.
         */
        public static void AppendReadBool(ref string code, string varName) {
            code += "                " + varName + " = bytes[index++] == 1;\r\n";
        }

        /**
         * Append C# code to write a signed short to the byte buffer.
         */
        public static void AppendWriteInt16(ref string code, string varName) {
            AppendWriteWhole(ref code, varName, 2);
        }

        /**
         * Append C# code to read a signed short from the byte buffer.
         */
        public static void AppendReadInt16(ref string code, string varName) {
            AppendReadWhole(ref code, varName, 2, "short");
        }

        /**
         * Append C# code to write an unsigned short to the byte buffer.
         */
        public static void AppendWriteUInt16(ref string code, string varName) {
            AppendWriteWhole(ref code, varName, 2);
        }

        /**
         * Append C# code to read an unsigned short from the byte buffer.
         */
        public static void AppendReadUInt16(ref string code, string varName) {
            AppendReadWhole(ref code, varName, 2, "ushort");
        }

        /**
         * Append C# code to write a signed integer to the byte buffer.
         */
        public static void AppendWriteInt32(ref string code, string varName) {
            AppendWriteWhole(ref code, varName, 4);
        }

        /**
         * Append C# code to read an signed int from the byte buffer.
         */
        public static void AppendReadInt32(ref string code, string varName) {
            AppendReadWhole(ref code, varName, 4, "int");
        }

        /**
         * Append C# code to write an unsigned integer to the byte buffer.
         */
        public static void AppendWriteUInt32(ref string code, string varName) {
            AppendWriteInt32(ref code, varName);
        }

        /**
         * Append C# code to read an unsigned integer from the byte buffer.
         */
        public static void AppendReadUInt32(ref string code, string varName) {
            AppendReadWhole(ref code, varName, 4, "uint");
        }

        /**
         * Append C# code to write a signed long to the byte buffer.
         */
        public static void AppendWriteInt64(ref string code, string varName) {
            AppendWriteWhole(ref code, varName, 8);
        }

        /**
         * Append C# code to read an signed long from the byte buffer.
         */
        public static void AppendReadInt64(ref string code, string varName) {
            AppendReadWhole(ref code, varName, 8, "long");
        }

        /**
         * Append C# code to write an unsigned long to the byte buffer.
         */
        public static void AppendWriteUInt64(ref string code, string varName) {
            AppendWriteInt64(ref code, varName);
        }

        /**
         * Append C# code to read an unsigned long from the byte buffer.
         */
        public static void AppendReadUInt64(ref string code, string varName) {
            AppendReadWhole(ref code, varName, 8, "ulong");
        }

        /**
         * Append C# code to write a variable-length unsigned short to the byte buffer.
         */
        public static void AppendWriteVUInt16(ref string code, string varName) {
            AppendWriteVariant(ref code, varName, 2);
        }

        /**
         * Append C# code to read an variable-length unsigned short from the byte buffer.
         */
        public static void AppendReadVUInt16(ref string code, string varName) {
            AppendReadVariant(ref code, varName, null, "ushort", 2);
        }

        /**
         * Append C# code to write a variable-length unsigned integer to the byte buffer.
         */
        public static void AppendWriteVUInt32(ref string code, string varName) {
            AppendWriteVariant(ref code, varName, 4);
        }

        /**
         * Append C# code to read an variable-length unsigned integer from the byte buffer.
         */
        public static void AppendReadVUInt32(ref string code, string varName) {
            AppendReadVariant(ref code, varName, null, "uint", 4);
        }

        /**
         * Append C# code to write a variable-length unsigned long to the byte buffer.
         */
        public static void AppendWriteVUInt64(ref string code, string varName) {
            AppendWriteVariant(ref code, varName, 8);
        }

        /**
         * Append C# code to read an variable-length unsigned long from the byte buffer.
         */
        public static void AppendReadVUInt64(ref string code, string varName) {
            AppendReadVariant(ref code, varName, null, "ulong", 8);
        }

        /**
         * Append C# code to write a variable-length signed integer to the byte buffer.
         */
        public static void AppendWriteVInt32(ref string code, string varName) {
            AppendWriteVInt64(ref code, varName);
        }

        /**
         * Append C# code to read an variable-length integer from the byte buffer.
         */
        public static void AppendReadVInt32(ref string code, string varName) {
            AppendReadVInt(ref code, varName, "int");
        }

        /**
         * Append C# code to write a variable-length signed long to the byte buffer.
         */
        public static void AppendWriteVInt64(ref string code, string varName) {
            // Make ulong
            code += "    //// AppendSignedToULong(" + varName+ ")\r\n";
            string signedToULongFieldName = AppendSignedToULong(ref code, varName);

            // Get size
            code += "    //// AppendGetSignVariantSize(" + signedToULongFieldName + ")\r\n";
            string signedVariantSizeFieldName = AppendGetSignVariantSize(ref code, signedToULongFieldName);

            // First byte
            code += "    bytes[index++] = (byte)((byte)(" + signedVariantSizeFieldName + " << 1) | (byte)(" + varName + " > 0 ? 0 : 1));\r\n";

            // Remaining bytes
            string i = PB.CreateRandomFieldName("vi");
            code += "    for (int " + i + " = 0; " + i + " < " + signedVariantSizeFieldName + " - 1; " + i + "++) {\r\n";
            code += "        bytes[index++] = (byte)(" + signedToULongFieldName + " & 255);\r\n";
            code += "        " + signedToULongFieldName + " = " + signedToULongFieldName + " >> 8;\r\n";
            code += "    }\r\n";
        }

        /**
         * Append C# code to read an variable-length signed long from the byte buffer.
         */
        public static void AppendReadVInt64(ref string code, string varName) {
            AppendReadVInt(ref code, varName, "long");
        }

        /**
         * Append C# code to write a variable-length signed whole number to the byte buffer.
         */

        public static void AppendReadVInt(ref string code, string varName, string typeName) {
            // First byte
            string byteFieldName = PB.CreateRandomFieldName("rv"+typeName+"_b");
            code += "    byte " + byteFieldName + " = bytes[index++];\r\n";
            // Sign
            string signFieldName = PB.CreateRandomFieldName("rv" + typeName + "_sign");
            code += "    byte " + signFieldName + " = (byte)(" + byteFieldName + " & 1);\r\n";
            // Size
            string sizeFieldName = PB.CreateRandomFieldName("rv" + typeName + "_size");
            code += "    byte " + sizeFieldName + " = (byte)(" + byteFieldName + " >> 1);\r\n";
            // Remaining bytes
            string remainingFieldName = PB.CreateRandomFieldName("rv" + typeName + "_remaining");
            code += "    ulong " + remainingFieldName + " = 0;\r\n";
            string i = PB.CreateRandomFieldName("i");
            code += "    for (int " + i + " = 0; " + i + " < " + sizeFieldName + " - 1; " + i + "++) {\r\n";
            code += "        " + remainingFieldName + " = " + remainingFieldName + " | (((ulong)bytes[index++] << (8 * " + i + ")));\r\n";
            code += "    }\r\n";
            // Make long
            string resultFieldName = PB.CreateRandomFieldName("rv" + typeName + "_result");
            code += "    " + typeName + " " + resultFieldName + " = (" + typeName + ")" + remainingFieldName + ";\r\n";
            // Invert
            code += "    " + resultFieldName + " = ~" + resultFieldName + ";\r\n";
            // Swap in MIN for MAX
            code += "    if (" + resultFieldName + " == " + typeName + ".MaxValue) {\r\n";
            code += "        " + resultFieldName + " = " + typeName + ".MinValue;\r\n";
            code += "    }\r\n";
            code += "    else {\r\n";
            code += "        // Add offset\r\n";
            code += "        " + resultFieldName + " += 1;\r\n";
            // If positive, negate
            code += "        if (" + signFieldName + " == 0) {\r\n";
            code += "            " + resultFieldName + " = -" + resultFieldName + ";\r\n";
            code += "        }\r\n";
            code += "    }\r\n";
            code += "    " + varName + " = " + resultFieldName + ";\r\n";

        }

        /**
         * Appends C# code to compute a signed variant's byte size.
         */
        private static string AppendGetSignVariantSize(ref string code, string varName) {
            string resultFieldName = PB.CreateRandomFieldName("vr");
            string v = PB.CreateRandomFieldName("v");
            code += "    byte " + resultFieldName + " = 1;\r\n";
            code += "    for (int " + v + " = 56; " + v + " >= 0; " + v + " -= 8) {\r\n";
            code += "        if (((255UL << " + v + ") & " + varName + ") > 0) {\r\n";
            code += "            " + resultFieldName + " = (byte)(" + v + " / 8 + 2);\r\n";
            code += "            break;\r\n";
            code += "        }\r\n";
            code += "    }\r\n";
            return resultFieldName;
        }

        /**
         * Appends C# code to convert a signed integer or long to variant ulong form.
         */
        private static string AppendSignedToULong(ref string code, string varName) {
            //internal static ulong SignedToULong(long value) {
            string tempFieldName = PB.CreateRandomFieldName("s2ultemp");
            string resultFieldName = PB.CreateRandomFieldName("s2ulresult");
            code += "    long " + tempFieldName + " = " + varName + ";\r\n";
            // Swap MAX in for MIN
            code += "    if (" + tempFieldName + " == long.MinValue) {\r\n";
            code += "        " + tempFieldName + " = long.MaxValue;\r\n";
            code += "    }\r\n";
            code += "    else {\r\n";
            // If positive, negate
            code += "        if (" + tempFieldName + " > 0) {\r\n";
            code += "            " + tempFieldName + " = -" + tempFieldName + ";\r\n";
            code += "        }\r\n";
            // Add offset
            code += "        " + tempFieldName + " -= 1;\r\n";
            code += "    }\r\n";
            // Invert
            code += "    " + tempFieldName + " = ~" + tempFieldName + ";\r\n";
            code += "    ulong " + resultFieldName + " = (ulong)" + tempFieldName + ";\r\n";
            return resultFieldName;
        }

        /**
         * Append C# code to write a float to the byte buffer.
         */
        public static void AppendWriteFloat(ref string code, string varName) {
            string floatFieldName = PB.CreateRandomFieldName("float");
            string floatAsUintFieldName = PB.CreateRandomFieldName("floatAsUInt");
            code += "                float " + floatFieldName + " = " + varName + ";\r\n";
            code += "                uint " + floatAsUintFieldName + ";\r\n";
            code += "                unsafe {\r\n";
            code += "                    " + floatAsUintFieldName + " = *((uint*)&(" + floatFieldName + "));\r\n";
            code += "                }\r\n";
            AppendWriteWhole(ref code, floatAsUintFieldName, 4);
        }

        /**
         * Append C# code to read a float from the byte buffer.
         */
        public static void AppendReadFloat(ref string code, string varName) {
            string floatFieldName = PB.CreateRandomFieldName("float");
            string floatAsUintFieldName = PB.CreateRandomFieldName("floatAsUInt");
            AppendReadWhole(ref code, "uint " + floatAsUintFieldName, 4, "uint");
            code += "                float " + floatFieldName + ";\r\n";
            code += "                unsafe {\r\n";
            code += "                    " + floatFieldName + " = *((float*)&(" + floatAsUintFieldName + "));\r\n";
            code += "                }\r\n";
            code += "                " + varName + " = " + floatFieldName + ";\r\n";
        }

        /**
         * Append C# code to write a double to the byte buffer.
         */
        public static void AppendWriteDouble(ref string code, string varName) {
            string doubleFieldName = PB.CreateRandomFieldName("double");
            string doubleAsULongFieldName = PB.CreateRandomFieldName("doubleAsULong");
            code += "                double " + doubleFieldName + " = " + varName + ";\r\n";
            code += "                ulong " + doubleAsULongFieldName + ";\r\n";
            code += "                unsafe {\r\n";
            code += "                    " + doubleAsULongFieldName + " = *((ulong*)&(" + doubleFieldName + "));\r\n";
            code += "                }\r\n";
            AppendWriteWhole(ref code, doubleAsULongFieldName, 8);
        }

        /**
         * Append C# code to read a double from the byte buffer.
         */
        public static void AppendReadDouble(ref string code, string varName) {
            string doubleFieldName = PB.CreateRandomFieldName("double");
            string doubleAsUintFieldName = PB.CreateRandomFieldName("doubleAsUInt");
            AppendReadWhole(ref code, "ulong " + doubleAsUintFieldName, 8, "ulong");
            code += "                double " + doubleFieldName + ";\r\n";
            code += "                unsafe {\r\n";
            code += "                    " + doubleFieldName + " = *((double*)&(" + doubleAsUintFieldName + "));\r\n";
            code += "                }\r\n";
            code += "                " + varName + " = " + doubleFieldName + ";\r\n";
        }

        /**
         * Append C# code to write a whole number to the byte buffer.
         */
        public static void AppendWriteWhole(ref string code, string varName, int byteCount) {
            int shift = ((byteCount - 1) * 8);
            code += "                bytes[index++] = (byte)((" + varName + " >> " + shift + ") & 255);\r\n";
            for (int b = 1; b < byteCount - 1; b++) {
                shift -= 8;
                code += "                bytes[index++] = (byte)((" + varName + " >> " + shift + ") & 255);\r\n";
            }
            code += "                bytes[index++] = (byte)(" + varName + " & 255);\r\n";
            //code += "                index += " + byteCount + ";\r\n";
        }

        /**
         * Append C# code to read a whole number from the byte buffer.
         */
        public static void AppendReadWhole(ref string code, string varName, int byteCount, string typeName) {
            code += "                " + varName + " =\r\n";
            code += "                    (" + typeName + ")(\r\n";
            int shift = (byteCount - 1) * 8;
            while (shift > 0) {
                code += "                        ((" + typeName + ")bytes[index++] << " + shift + ") |\r\n";
                shift -= 8;
            }
            code += "                        (" + typeName + ")bytes[index++]\r\n";
            code += "                    );\r\n";
        }

        /**
         * Appends C# code to write a string to the byte buffer.
         */
        public static void AppendWriteString(ref string code, string varName) {
            string sizeFieldName = PB.CreateRandomFieldName("stringLength");
            code += "                uint " + sizeFieldName + ";\r\n";
            PBUV.AppendGetUnsignedVariantSize(ref code, varName + ".Length", sizeFieldName, "uint", 2);
            AppendWriteString(ref code, varName, sizeFieldName);
        }

        /**
         * Append C# code to write a UTF-8 string to the byte buffer.
         */
        public static void AppendWriteString(ref string code, string varName, string sizeFieldName) {
            AppendWriteVariant(ref code, varName + ".Length", sizeFieldName);
            code += "                index += Encoding.UTF8.GetBytes(" + varName + ", 0, " + varName + ".Length, bytes, index);\r\n";
        }

        /**
         * Append C# code to read a UTF-8 string from the byte buffer.
         */
        public static void AppendReadString(ref string code, string varName) {
            string stringLengthFieldName = PB.CreateRandomFieldName("stringLength");
            AppendReadVariant(ref code, stringLengthFieldName, "ushort", "ushort", 2);
            code += "                " + varName + " = Encoding.UTF8.GetString(bytes, index, " + stringLengthFieldName + ");\r\n";
            code += "                index += " + stringLengthFieldName + ";\r\n";
        }

        /**
         * Appends C# code to write a variable-length whole value to the byte buffer.
         */
        public static void AppendWriteVariant(ref string code, string varName, int maxBytes) {
            code += "                if (" + varName + " == 0) {\r\n";
            code += "                    bytes[index++] = (byte)0;\r\n";
            code += "                }\r\n";
            code += "                else {\r\n";
            code += "                    int byteCount;\r\n";
            code += "                    ulong value = (ulong)" + varName + ";\r\n";
            PBUV.AppendGetUnsignedVariantSize(ref code, varName, "byteCount", "int", maxBytes);
            AppendWriteVariantInner(ref code, "byteCount");
            code += "                }\r\n";
        }

        /**
         * Appends C# code to write a variable-length whole value to the byte buffer, given a precomputed byte length.
         */
        public static void AppendWriteVariant(ref string code, string varName, string sizeVarName) {
            code += "                if (" + varName + " == 0) {\r\n";
            code += "                    bytes[index++] = (byte)0;\r\n";
            code += "                }\r\n";
            code += "                else {\r\n";
            code += "                    ulong value = (ulong)" + varName + ";\r\n";
            AppendWriteVariantInner(ref code, sizeVarName);
            code += "                }\r\n";
        }

        /**
         * Appends C# code to write a variable-length whole value to the byte buffer. Shared across multiple types.
         */
        public static void AppendWriteVariantInner(ref string code, string byteCountVarName) {
            string i = PB.CreateRandomFieldName("i");
            code += "                    for (int " + i + " = 0; " + i + " < " + byteCountVarName + "; " + i + "++) {\r\n";
            code += "                        if (" + i + " < " + byteCountVarName + " - 1) {\r\n";
            code += "                            byte b = (byte)(value & 127);\r\n";
            code += "                            if (" + i + " < " + byteCountVarName + " - 1) {\r\n";
            code += "                                b += 128;\r\n";
            code += "                            }\r\n";
            code += "                            bytes[index++] = b;\r\n";
            code += "                            value = value >> 7;\r\n";
            code += "                        }\r\n";
            code += "                        else {\r\n";
            code += "                            bytes[index++] = (byte)value;\r\n";
            code += "                            value = value >> 8;\r\n";
            code += "                        }\r\n";
            code += "                    }\r\n";
        }

        /**
         * Reads an unsugned variant of type "type" and max byte size "maxBytes" into a variable named "varName".
         */
        public static void AppendReadVariant(ref string code, string varName, string type, string castTo, int maxBytes) {
            string readVariantTemp = PB.CreateRandomFieldName("vuread");
            code += "                    ulong " + readVariantTemp + " = 0;\r\n";
            string i = PB.CreateRandomFieldName("i");
            code += "                    for (int " + i + " = 0; " + i + " < 9; " + i + "++) {\r\n";
            code += "                        byte b = bytes[index++];\r\n";
            code += "                        if (" + i + " < 8) {\r\n";
            code += "                            " + readVariantTemp + " += (((ulong)b & (ulong)127) << (7 * " + i + "));\r\n";
            code += "                            if ((int)(b & 128) == 0) {\r\n";
            code += "                                break;\r\n";
            code += "                            }\r\n";
            code += "                        }\r\n";
            code += "                        else {\r\n";
            code += "                            " + readVariantTemp + " += (ulong)b << (7 * " + i + ");\r\n";
            code += "                            break;\r\n";
            code += "                        }\r\n";
            code += "                    }\r\n";
            code += "                    " + (type != null ? type + " " : "") + varName + " = " + (castTo != null ? "(" + castTo + ")" : "") + readVariantTemp + ";\r\n";
        }

    }
}
