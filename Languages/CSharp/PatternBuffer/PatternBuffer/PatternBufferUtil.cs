using System;
using System.Collections.Generic;
using System.IO;

namespace PatternBuffer {

    /**
     * A class with several static methods that implement various PatternBuffer
     * helper functionality/
     */
    public static class PatternBufferUtil {
        
        //-------------------------------------------------------------------
        // SIGNED VARIANTS
        //-------------------------------------------------------------------

        internal static byte GetSignedVariantSize(ulong value) {
            for (int i = 56; i >= 0; i -= 8) {
                if (((255UL << i) & value) > 0) {
                    return (byte)(i / 8 + 2);
                }
            }
            return 2;
        }

        public static int GetSignedVariantSize(int value) {
            return GetSignedVariantSize(SignedToULong(value));
        }

        public static int GetSignedVariantSize(long value) {
            return GetSignedVariantSize(SignedToULong(value));
        }

        internal static ulong SignedToULong(long value) {

            // Swap MAX in for MIN
            if (value == long.MinValue) {
                value = long.MaxValue;
            }
            else {
                // If positive, negate
                if (value > 0) {
                    value = -value;
                }
                // Add offset
                value -= 1;
            }
            // Invert
            value = ~value;

            return (ulong)value;
        }

        public static void WriteVInt32(this BinaryWriter writer, int value) {
            writer.WriteVInt64((long)value);
        }

        public static void WriteVInt64(this BinaryWriter writer, long value) {

            // Make ulong
            ulong ulv = SignedToULong(value);

            // Get size
            byte size = (byte)(GetSignedVariantSize(ulv) - 1);

            // First byte
            writer.Write((byte)((byte)(size << 1) | (byte)(value > 0 ? 0 : 1)));

            // Remaining bytes
            for (int i = 0; i < size; i++) {
                writer.Write((byte)(ulv & 255));
                ulv = ulv >> 8;
            }
        }

        public static int ReadVInt32(this BinaryReader reader) {
            return (int)reader.ReadVInt64();
        }

        public static long ReadVInt64(this BinaryReader reader) {
            // First byte
            byte b = reader.ReadByte();

            // Sign
            byte sign = (byte)(b & 1);
            // Size
            byte size = (byte)(b >> 1);

            // Remaining bytes
            ulong v = 0;
            for (int i = 0; i < size; i++) {
                v = v | (((ulong)reader.ReadByte() << (8 * i)));
            }

            // Make long
            long result = (long)v;

            // Invert
            result = ~result;

            // Swap in MIN for MAX
            if (result == long.MaxValue) {
                result = long.MinValue;
            }
            else {
                // Add offset
                result += 1;

                // If positive, negate
                if (sign == 0) {
                    result = -result;
                }
            }
            return result;
        }

        //-------------------------------------------------------------------
        // UNSIGNED VARIANTS
        //-------------------------------------------------------------------

        /**
         * Writes an unsigned variant value to the given BinaryWriter. An unsigned variant
         * is a whole number (int, long, etc.) that is written using the least
         * possible number of bytes.
         * 
         * For example, values less than 128 are written in 1 byte. Values less than 16K
         * are written in 2 bytes.
         */

        public static void WriteVUInt16(this BinaryWriter writer, ushort value) {
            writer.WriteVUInt64((ulong)value);
        }

        public static void WriteVUInt32(this BinaryWriter writer, uint value) {
            writer.WriteVUInt64((ulong)value);
        }

        public static void WriteVUInt64(this BinaryWriter writer, ulong value) {
            if (value == 0) {
                writer.Write((byte)0);
            }
            else {
                int byteCount = PatternBufferUtil.GetUnsignedVariantSize(value);
                for (int i = 0; i < byteCount; i++) {
                    if (i < byteCount - 1) {
                        byte b = (byte)(value & 127);
                        if (i < byteCount - 1) {
                            b += 128;
                        }
                        writer.Write(b);
                        value = value >> 7;
                    }
                    else {
                        writer.Write((byte)value);
                        value = value >> 8;
                    }
                }
            }
        }

        public static ushort ReadVUInt16(this BinaryReader reader) {
            return (ushort)reader.ReadVUInt64();
        }

        public static uint ReadVUInt32(this BinaryReader reader) {
            return (uint)reader.ReadVUInt64();
        }

        /**
         * Reads an unsigned long value from the given BinaryReader.
         */
        public static ulong ReadVUInt64(this BinaryReader reader) {
            ulong value = 0;
            for (int i = 0; i < 9; i++) {
                byte b = reader.ReadByte();
                //Console.WriteLine("r, i: " + i + "=" + b);
                if (i < 8) {
                    value += (((ulong)b & (ulong)127) << (7 * i));
                    if ((int)(b & 128) == 0) {
                        break;
                    }
                }
                else {
                    value += (ulong)b << (7 * i);
                    break;
                }
            }
            return value;
        }

        /**
         * Defines variant byte size boundaries. Packaged like this, here, to do a binary search.
         */
        private static readonly ulong[] boundaries = new ulong[] {
            (ulong)Math.Pow(2,7),
            (ulong)Math.Pow(2,14),
            (ulong)Math.Pow(2,21),
            (ulong)Math.Pow(2,28),
            (ulong)Math.Pow(2,35),
            (ulong)Math.Pow(2,42),
            (ulong)Math.Pow(2,49),
            (ulong)Math.Pow(2,56),
            (ulong)Math.Pow(2,63),
        };

        /**
         * Returns the number of bytes the given value would consume when written as an 
         * unsigned variant value.
         */
        public static int GetUnsignedVariantSize(short value) {
            if (value == short.MaxValue) {
                value = 0;
            }
            else if (value >= 0) {
                value += 1;
            }
            return PatternBufferUtil.GetUnsignedVariantSize(
                (value < 0) ?
                  (ulong)((~value) << 1) + 1 :
                  (ulong)((~-value) << 1), 
                3
            );
        }
        public static int GetUnsignedVariantSize(int value) {
            if (value == int.MaxValue) {
                value = 0;
            }
            else if (value >= 0) {
                value += 1;
            }
            return PatternBufferUtil.GetUnsignedVariantSize(
                (value < 0) ?
                  (ulong)((~value) << 1) + 1 :
                  (ulong)((~-value) << 1),
                5
            );
        }
        public static int GetUnsignedVariantSize(long value) {
            if (value == long.MaxValue) {
                value = 0;
            }
            else if (value >= 0) {
                value += 1;
            }
            return PatternBufferUtil.GetUnsignedVariantSize(
                (value < 0) ?
                    (ulong)((~value) << 1) + 1 :
                    (ulong)((~-value) << 1),
                9
            );
        }   
        public static int GetUnsignedVariantSize(ushort value) {
            return PatternBufferUtil.GetUnsignedVariantSize((ulong)value, 3);
        }
        public static int GetUnsignedVariantSize(uint value) {
            return PatternBufferUtil.GetUnsignedVariantSize((ulong)value, 5);
        }
        public static int GetUnsignedVariantSize(ulong value) {
            return PatternBufferUtil.GetUnsignedVariantSize(value, 9);
        }
        internal static int GetUnsignedVariantSize(ulong value, int maxBytes) {
            int position = Array.BinarySearch(boundaries, value);
            return Math.Min(position < 0 ? -position : position + 2, maxBytes);
        }

        public static string ToString(ulong variant) {
            string s = "";
            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++) {
                    s = (variant & 1) + s;
                    variant = variant >> 1;
                }
                if (i < 7) {
                    s = " " + s;
                }
            }
            return s;
        }

        //-------------------------------------------------------------------
        // ABSTRACT REFERENCE
        //-------------------------------------------------------------------
        
        /**
         * Helper function that writes an abstract reference object to the BinaryWriter.
         */
        public static void WriteAbstractReference<REFERRED>(this BinaryWriter writer, IPatternBuffer patternBuffer, string referredName, REFERRED referred) {
            IPatternBufferSerializer serializer = patternBuffer.GetSerializerByTypeName(referredName);
            if (serializer != null) {
                WriteVUInt64(writer, (ulong)serializer.TypeId);
                serializer.ToBytes(writer, referred);
            }
        }

        /**
         * Hepler function to read an abstract reference object from the given BinaryReader.
         */
        public static REFERRED ReadAbstractReference<REFERRED>(this BinaryReader reader, IPatternBuffer patternBuffer, string referredName) {
            REFERRED referred = default(REFERRED);
            ushort typeId = (ushort)ReadVUInt64(reader);
            IPatternBufferSerializer serializer = patternBuffer.GetSerializerByTypeId(typeId);
            if (serializer != null) {
                referred = (REFERRED)serializer.FromBytes(reader);
            }
            return referred;
        }

        //-------------------------------------------------------------------
        // ENUM COLLECTION
        //-------------------------------------------------------------------

        /**
         * Helper function to write a collection of enum values to the BinaryWriter.
         */
        public static void WriteEnumCollection<ENUM>(this BinaryWriter writer, IPatternBuffer patternBuffer, string enumName, ICollection<ENUM> enums) {
            if (enums != null) {
                writer.WriteVUInt64((ulong)enums.Count);
                foreach (ENUM e in enums) {
                    writer.Write(patternBuffer.GetEnumIndex(enumName, e.ToString()));
                }
            }
            else {
                writer.Write((ushort)0);
            }
        }

        /**
         * Helper function to read a collection of enum values from the BinaryReader.
         */
        public static COLLECTION ReadEnumCollection<COLLECTION,ENUM>(this BinaryReader reader, IPatternBuffer patternBuffer, string enumName)
            where COLLECTION : ICollection<ENUM>
            {
            COLLECTION collection = default(COLLECTION);
            ushort count = (ushort)reader.ReadVUInt64();
            if (count > 0) {
                collection = Activator.CreateInstance<COLLECTION>();
                for (int i = 0; i < count; i++) {
                    collection.Add((ENUM)Enum.Parse(typeof(ENUM), patternBuffer.GetEnumValue(enumName, reader.ReadByte())));
                }
            }
            return collection;
        }

        //-------------------------------------------------------------------
        // FINAL OBJECT COLLECTION
        //-------------------------------------------------------------------

        /**
         * Helper function to write a collection of final (not abstract) objects to the BinaryWriter.
         */
        public static void WriteFinalObjectCollection<FINALOBJECT>(this BinaryWriter writer, IPatternBufferSerializer serializer, ICollection<FINALOBJECT> finalObjects) {
            if (finalObjects == null || finalObjects.Count == 0) {
                WriteVUInt64(writer, (ulong)0);
            }
            else {
                WriteVUInt64(writer, (ulong)finalObjects.Count);
                foreach (FINALOBJECT finalObject in finalObjects) {
                    if (serializer != null) {
                        serializer.ToBytes(writer, finalObject);
                    }
                }
            }
        }

        /**
         * Helper function to read a collection of final (not abstract) objects from the BinaryReader.
         */
        public static COLLECTION ReadFinalObjectCollection<COLLECTION,FINALOBJECT>(this BinaryReader reader, IPatternBufferSerializer serializer)
            where COLLECTION : ICollection<FINALOBJECT>
            {
            COLLECTION collection = default(COLLECTION);
            int count = (int)ReadVUInt64(reader);
            if (count > 0) {
                collection = Activator.CreateInstance<COLLECTION>();
                for (int i = 0; i < count; i++) {
                    collection.Add((FINALOBJECT)serializer.FromBytes(reader));
                }
            }
            return collection;
        }

        //-------------------------------------------------------------------
        // ABSTRACT OBJECT COLLECTION
        //-------------------------------------------------------------------

        /**
         * Helper function to write a collection of abstract (not final) objects to the BinaryWriter.
         */
        public static void WriteAbstractObjectCollection<ABSTRACTOBJECT>(this BinaryWriter writer, IPatternBuffer patternBuffer, ICollection<ABSTRACTOBJECT> abstractObjects) {
            if (abstractObjects == null || abstractObjects.Count == 0) {
                WriteVUInt64(writer, (ulong)0);
            }
            else {
                WriteVUInt64(writer, (ulong)abstractObjects.Count);
                foreach (ABSTRACTOBJECT abstractObject in abstractObjects) {
                    IPatternBufferSerializer serializer = patternBuffer.GetSerializerFor(abstractObject);
                    if (serializer != null) {
                        WriteVUInt64(writer, serializer.TypeId);
                        serializer.ToBytes(writer, abstractObject);
                    }
                }
            }
        }

        /**
         * Helper function to read a collection of abstract (not final) objects from the BinaryReader.
         */
        public static COLLECTION ReadAbstractObjectCollection<COLLECTION,ABSTRACTOBJECT>(this BinaryReader reader, IPatternBuffer patternBuffer)
            where COLLECTION : ICollection<ABSTRACTOBJECT>
            {
            COLLECTION collection = default(COLLECTION);
            int count = (int)ReadVUInt64(reader);
            if (count > 0) {
                collection = Activator.CreateInstance<COLLECTION>();
                for (int i = 0; i < count; i++) {
                    ushort typeId = (ushort)ReadVUInt64(reader);
                    IPatternBufferSerializer serializer = patternBuffer.GetSerializerByTypeId(typeId);
                    collection.Add((ABSTRACTOBJECT)serializer.FromBytes(reader));
                }
            }
            return collection;
        }
    }
}
