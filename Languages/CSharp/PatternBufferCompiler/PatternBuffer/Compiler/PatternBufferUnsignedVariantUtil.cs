using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PB = PatternBuffer.PatternBufferUtil;

namespace PatternBuffer {

    /**
     * This class contains static methods to compute and encode unsigned variant values. This is used mainly to 
     * encode unsigned variant values into the generated source code, for example, to encode type IDs that are known
     * at compile time and which can be included directly into the generated code (rather that performing lookups at
     * runtime).
     */
    public static class PatternBufferUnsignedVariantUtil {

        /**
         * Defines unsigned variant boundary values.
         */
        private static readonly ulong[] vuBoundaries = new ulong[] {
            128,
            16384,
            2097152,
            268435456,
            34359738368,
            4398046511104,
            562949953421312,
            72057594037927936,
            9223372036854775808
        };

        /**
         * Returns the serialized size (in bytes) of the given ulong value.
         */
        public static int GetUnsignedVariantSize(ulong value) {
            return GetUnsignedVariantSize(value, 9);
        }

        /**
         * Returns the serialized size (in bytes) of the given ulong value. Limits the byte length
         * to the maximum given.
         */
        public static int GetUnsignedVariantSize(ulong value, int maxBytes) {
            int limit = maxBytes < vuBoundaries.Length ? maxBytes : vuBoundaries.Length;
            int i;
            for (i = 0; i < limit; i++) {
                if (value < vuBoundaries[i]) {
                    return i + 1;
                }
            }
            return i;
        }

        /**
         * An empty byte array, to prevent repeated allocations.
         */
        private static readonly byte[] EMPTY = new byte[1]{0};

        /**
         * Converts a ulong value into a byte array.
         */
        public static byte[] VUInt64ToBytes(ulong value) {
            if (value == 0) {
                return EMPTY;
            }
            else {
                int byteCount = GetUnsignedVariantSize(value);
                byte[] bytes = new byte[byteCount];
                int byteIndex = 0;
                for (int i = 0; i < byteCount; i++) {
                    if (i < byteCount - 1) {
                        byte b = (byte)(value & 127);
                        if (i < byteCount - 1) {
                            b += 128;
                        }
                        bytes[byteIndex++] = b;
                        value = value >> 7;
                    }
                    else {
                        bytes[byteIndex++] = (byte)value;
                        value = value >> 8;
                    }
                }
                return bytes;
            }
        }

        /**
         * Appends C# code to compute an unsigned variant's size at runtime.
         */
        public static void AppendGetUnsignedVariantSize(ref string code, string varName, string sizeVarName, string sizeVarType, int maxBytes) {
            string gotoLabel = PB.CreateRandomFieldName("guvsgoto");
            string i = PB.CreateRandomFieldName("i");
            code += "                int " + i + ";\r\n";
            code += "                for (" + i + " = 0; " + i + " < " + Math.Min(maxBytes, 9) + "; " + i + "++) {\r\n";
            code += "                    if ((ulong)" + varName + " < vuBoundaries[" + i + "]) {\r\n";
            code += "                       " + sizeVarName + " = (" + sizeVarType + ")(" + i + " + 1);\r\n";
            code += "                       goto " + gotoLabel + ";\r\n";
            code += "                    }\r\n";
            code += "                }\r\n";
            code += "                " + sizeVarName + " = (" + sizeVarType + ")" + i + " + 1;\r\n";
            code += "                " + gotoLabel + ":\r\n";
        }

    }
}
