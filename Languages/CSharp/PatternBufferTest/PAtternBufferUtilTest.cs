using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using PatternBuffer;
using PBUV = PatternBuffer.PatternBufferUnsignedVariantUtil;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace PatternBufferTest.Schema {
    
    /**
     * Mainly a bunch of performance tests to compare various approaches to serialization.
     */
    [TestFixture()]
    public class PatternBufferUtilTest {

        /**
         * Trying to prove which byte-array copying method is fastest. Candidates:
         * 1) Array.Copy
         * 2) Buffer.BlockCopy
         * 3) Marshal.Copy
         * 4) Manual byte assignment
         * 5) (Not here) Unsafe pointer manipulation
         * 
         * Buffer.BlockCopy was the winner.
         */
        [TestCase(1000, 1000)]
        public void TestMemCopy(int byteCount, int seconds) {

            // Test data
            byte[] src = new byte[byteCount];
            new Random().NextBytes(src);

            // Array.Copy
            {
                int count = 0;
                byte[] dst = new byte[byteCount];
                Stopwatch s = Stopwatch.StartNew();
                while (s.ElapsedMilliseconds < seconds) {
                    Array.Copy(src, dst, src.Length);
                    count++;
                }
                s.Stop();
                Console.WriteLine("Array.Copy:         " + count);
            }

            // Buffer.BlockCopy
            {
                int count = 0;
                byte[] dst = new byte[byteCount];
                Stopwatch s = Stopwatch.StartNew();
                while (s.ElapsedMilliseconds < seconds) {
                    Buffer.BlockCopy(src, 0, dst, 0, src.Length);
                    count++;
                }
                s.Stop();
                Console.WriteLine("Buffer.BlockCopy:   " + count);
            }

            // Marshal.Copy
            {
                int count = 0;
                byte[] dst = new byte[byteCount];
                
                unsafe {
                    Stopwatch s = Stopwatch.StartNew();
                    IntPtr intptr = Marshal.AllocHGlobal(dst.Length);
                    while (s.ElapsedMilliseconds < seconds) {
                        Marshal.Copy(src, 0, intptr, src.Length);
                        count++;
                    }
                    s.Stop();
                    Marshal.FreeHGlobal(intptr);
                }
                Console.WriteLine("Marshal.Copy:       " + count);
            }


            // Manual
            {
                int count = 0;
                byte[] dst = new byte[byteCount];
                Stopwatch s = Stopwatch.StartNew();
                while (s.ElapsedMilliseconds < seconds) {
                    this.ArrayCopy(src, dst);
                    count++;
                }
                s.Stop();
                Console.WriteLine("Manual:             " + count);
            }
        }


        public void ArrayCopy(byte[] src, byte[] dst) {
            for (int i = 0; i < src.Length; i++) {
                dst[i] = src[i];
            }
        }

        ///**
        // * Testing out the pregeneration of byte arrays for unsigned variants.
        // */
        //[Test()]
        //public void GenerateUVTable2() {
        //    ulong[] vuBoundaries = new ulong[] {
        //        128,
        //        16384,
        //        2097152,
        //        268435456,
        //        34359738368,
        //        4398046511104,
        //        562949953421312,
        //        72057594037927936,
        //        9223372036854775808
        //    };
        
        //    byte[] precomputedUnsignedVariantBytes;
        //    uint precomputedUnsignedVariantCount = 10000;
        //    uint vuBoundaryIndex = 0;
        //    if (precomputedUnsignedVariantCount > 0) {
        //        uint precomputedUnsignedVariantByteCount = 0;
        //        uint temp = precomputedUnsignedVariantCount;
        //        while (temp > 0) {
        //                ulong bandValueCount = vuBoundaries[vuBoundaryIndex]  - (vuBoundaryIndex > 0 ? vuBoundaries[vuBoundaryIndex-1] : 0);
        //                if (bandValueCount < temp) {
        //                    precomputedUnsignedVariantByteCount += 
        //                        (uint)(
        //                        (vuBoundaryIndex + 1) *         // bytes per value
        //                        vuBoundaries[vuBoundaryIndex] - (vuBoundaryIndex > 0 ? vuBoundaries[vuBoundaryIndex] - vuBoundaries[vuBoundaryIndex-1]: 0)   // number of values
        //                        );
        //                    temp -= (uint)(vuBoundaries[vuBoundaryIndex]);                        
        //                    vuBoundaryIndex++;
        //                }
        //                else {
        //                    precomputedUnsignedVariantByteCount += (vuBoundaryIndex + 1) * precomputedUnsignedVariantCount;
        //                    temp = 0;
        //                }
        //        }
        //        precomputedUnsignedVariantBytes = new byte[precomputedUnsignedVariantByteCount];
        //        int precomputedUnsignedVariantIndex = 0;

        //        MemoryStream stream = new MemoryStream(8);
        //        for (int i = 0; i < precomputedUnsignedVariantCount; i++) {
        //            int size = GetUnsignedVariantSize(i);
        //            stream.Write(BitConverter.GetBytes((ulong)i), 0, 8);
        //            byte[] bytes = new byte[stream.Position];
        //            stream.Position = 0;
        //            stream.Read(bytes, 0, size);
        //            //dict[(ulong)i] = bytes;
        //            //byteCount += size;
        //            for (int j = 0; j < size; j++) {
        //                precomputedUnsignedVariantBytes[precomputedUnsignedVariantIndex++] = bytes[j];
        //            }
        //        }
        //    }
        //}

        /**
         * Testing which is faster:
         * 1) Single += operation
         * 2) Multiple ++ operations
         * 
         * Multiple ++ operations were just as fast, and match what I've done elsewhere in the code.
         */
        [Test()]
        public void ProveUsingIncrementorsIsFaster() {
            byte[] bytes = new byte[8];
            int reps = 1000000000;

            Stopwatch s; 
            {
                s = Stopwatch.StartNew();
                int index = 0;
                long longValue = 38234759238475;
                for (int i = 0; i < reps; i++) {
                    index = 0;
                    bytes[index + 7] = (byte)(longValue & 255);
                    bytes[index + 6] = (byte)((longValue >> 8) & 255);
                    bytes[index + 5] = (byte)((longValue >> 16) & 255);
                    bytes[index + 4] = (byte)((longValue >> 24) & 255);
                    bytes[index + 3] = (byte)((longValue >> 32) & 255);
                    bytes[index + 2] = (byte)((longValue >> 40) & 255);
                    bytes[index + 1] = (byte)((longValue >> 48) & 255);
                    bytes[index] = (byte)((longValue >> 56) & 255);
                    index += 8;
                }
                s.Stop();
                Console.WriteLine("single assignment: " + s.ElapsedMilliseconds);
            }

            {
                s = Stopwatch.StartNew();
                int index = 0;
                long longValue = 38234759238475;
                for (int i = 0; i < reps; i++) {
                    index = 0;
                    bytes[index++] = (byte)((longValue >> 56) & 255);
                    bytes[index++] = (byte)((longValue >> 48) & 255);
                    bytes[index++] = (byte)((longValue >> 40) & 255);
                    bytes[index++] = (byte)((longValue >> 32) & 255);
                    bytes[index++] = (byte)((longValue >> 24) & 255);
                    bytes[index++] = (byte)((longValue >> 16) & 255);
                    bytes[index++] = (byte)((longValue >> 8) & 255);
                    bytes[index++] = (byte)(longValue & 255);
                }
                s.Stop();
                Console.WriteLine(" multi assignment: " + s.ElapsedMilliseconds);
            }

        }

        /**
         * A performance test comparing:
         * 1) Computing the bytes of all unsigned variants at run-time
         * 2) Using pregenerated unsigned byte arrays and indexing.
         * 
         * Pregeneration was actually faster, but it produces diminishing returns the higher
         * the value, because I still have to figure out how many bytes to pull out of the
         * pregenerated array.
         * 
         * The sweet spot is probably to pregenerate up through about 16k, and run-time compute
         * anything higher. This is purely an internal optimization so I'm leaving it as fully
         * computed for now.
         */
        [Test()]
        public void TestGenerateUVTable() {
            //int count = 10000;
            //int byteCount = 0;
            //for (int i = 0; i < count; i++) {
            //    int size = GetUnsignedVariantSize(i);
            //    MemoryStream stream = new MemoryStream(size);
            //    BinaryWriter writer = new BinaryWriter(stream);
            //    WriteVUInt64(writer, (ulong)i);
            //    Console.WriteLine(i + " " + stream.Position);
            //    byteCount += (int)stream.Position;
            //}
            //Console.WriteLine(byteCount);

            ulong[] vuBoundaries = new ulong[] {
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

            int count = 10000;

            Dictionary<ulong, byte[]> dict = new Dictionary<ulong, byte[]>();

            byte[] oneBigArray = new byte[30000];
            int oneBigArrayIndex = 0;
            int byteCount = 0;

            Stopwatch s;

            s = Stopwatch.StartNew();
            MemoryStream stream = new MemoryStream(6);
            for (int i = 0; i < count; i++) {
                int size = GetUnsignedVariantSize(i);
                stream.Write(BitConverter.GetBytes((ulong)i), 0, 8);
                byte[] bytes = new byte[stream.Position];
                stream.Position = 0;
                stream.Read(bytes, 0, size);
                //dict[(ulong)i] = bytes;
                //byteCount += size;
                for (int j = 0; j < size; j++) {
                    oneBigArray[oneBigArrayIndex++] = bytes[j];
                }
            }
            Console.WriteLine("Setup: " + s.ElapsedMilliseconds);
            

            //Console.WriteLine(byteCount + " " + oneBigArrayIndex);
            int reps = 100000000;

            {
                byte[] b = new byte[10];
                s = Stopwatch.StartNew();
                for (int i = 0; i < reps; i++) {
                    // Added this to include time to test if the value is in the pregen table.
                    if (i < reps) { 
                        // 1-byte pregens
                        if (i < 128) {
                            b[0] = oneBigArray[i];
                        }
                        // 2-byte pregens
                        else {
                            b[0] = oneBigArray[(i % count) + 127];
                            b[1] = oneBigArray[(i % count) + 128];
                        }
                    }
                    else {
                        // Computed code would go here
                    }
                }
                s.Stop();
                Console.WriteLine("Array: " + s.ElapsedMilliseconds);
            }

            //{
            //    byte[] b = null;
            //    s = Stopwatch.StartNew();
            //    for (int i = 0; i < reps; i++) {
            //        b = dict[(ulong)(i % count)];
            //    }
            //    s.Stop();
            //    Console.WriteLine("Dict: " + s.ElapsedMilliseconds);
            //}

            {
                byte[] bytes = new byte[1000];
                int index = 0;
                s = Stopwatch.StartNew();
                for (int k = 0; k < reps; k++) {
                    ulong j = (ulong)(k % count);
                    index = 0;
                    uint stringLength_e9iM6PF7xRTY;
                    int guvsi_rxN4BgotTZDA;
                    for (guvsi_rxN4BgotTZDA = 0; guvsi_rxN4BgotTZDA < 2; guvsi_rxN4BgotTZDA++) {
                        if ((ulong)j < vuBoundaries[guvsi_rxN4BgotTZDA]) {
                            stringLength_e9iM6PF7xRTY = (uint)(guvsi_rxN4BgotTZDA + 1);
                            goto guvsgoto_rlPron1k73zR;
                        }
                    }
                    stringLength_e9iM6PF7xRTY = (uint)guvsi_rxN4BgotTZDA + 1;
                guvsgoto_rlPron1k73zR:
                    if (j == 0) {
                        bytes[index++] = (byte)0;
                    }
                    else {
                        ulong value = (ulong)j;
                        for (int i = 0; i < stringLength_e9iM6PF7xRTY; i++) {
                            if (i < stringLength_e9iM6PF7xRTY - 1) {
                                byte b1 = (byte)(value & 127);
                                if (i < stringLength_e9iM6PF7xRTY - 1) {
                                    b1 += 128;
                                }
                                bytes[index++] = b1;
                                value = value >> 7;
                            }
                            else {
                                bytes[index++] = (byte)value;
                                value = value >> 8;
                            }
                        }
                    }
                }
                s.Stop();
                Console.WriteLine("Comp: " + s.ElapsedMilliseconds);
            }
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

        public static void WriteVUInt16(BinaryWriter writer, ushort value) {
            WriteVUInt64(writer, (ulong)value);
        }

        public static void WriteVUInt32(BinaryWriter writer, uint value) {
            WriteVUInt64(writer, (ulong)value);
        }

        public static void WriteVUInt64(BinaryWriter writer, ulong value) {
            if (value == 0) {
                writer.Write((byte)0);
            }
            else {
                int byteCount = GetUnsignedVariantSize(value);
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

        public static ushort ReadVUInt16(BinaryReader reader) {
            return (ushort)ReadVUInt64(reader);
        }

        public static uint ReadVUInt32(BinaryReader reader) {
            return (uint)ReadVUInt64(reader);
        }

        /**
         * Reads an unsigned long value from the given BinaryReader.
         */
        public static ulong ReadVUInt64(BinaryReader reader) {
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
            return GetUnsignedVariantSize(
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
            return GetUnsignedVariantSize(
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
            return GetUnsignedVariantSize(
                (value < 0) ?
                    (ulong)((~value) << 1) + 1 :
                    (ulong)((~-value) << 1),
                9
            );
        }
        public static int GetUnsignedVariantSize(ushort value) {
            return GetUnsignedVariantSize((ulong)value, 3);
        }
        public static int GetUnsignedVariantSize(uint value) {
            return GetUnsignedVariantSize((ulong)value, 5);
        }
        public static int GetUnsignedVariantSize(ulong value) {
            return GetUnsignedVariantSize(value, 9);
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
    }

}
