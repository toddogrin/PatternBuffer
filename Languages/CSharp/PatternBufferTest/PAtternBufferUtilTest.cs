using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using PatternBuffer;
using NSubstitute;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class PatternBufferUtilTest {

        [TestCase(int.MinValue, 5)]
        [TestCase(-16384, 3)]
        [TestCase(-128, 2)]
        [TestCase(-1, 2)]
        [TestCase(1, 2)]
        [TestCase(128, 2)]
        [TestCase(16384, 3)]
        [TestCase(int.MaxValue, 5)]
        public void TestWriteReadVInt32(int value, int byteCount) {
            // Write the integral value into a stream
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.WriteVInt32(value);

            // Verify the correct number of bytes are serialized
            Assert.That(stream.Position, Is.EqualTo(byteCount));
            stream.Position = 0;
            byte[] bytes = stream.ToArray();
            Assert.That(bytes.Length, Is.EqualTo(byteCount));

            // Verify the value can be read back in
            BinaryReader reader = new BinaryReader(stream);
            int integral = reader.ReadVInt32();
            Assert.That(integral, Is.EqualTo(value));
        }

        [TestCase(long.MinValue, 9)]
        [TestCase(-3000000, 4)]
        [TestCase(-16384, 3)]
        [TestCase(-128, 2)]
        [TestCase(-1, 2)]
        [TestCase(0, 2)]
        [TestCase(1, 2)]
        [TestCase(128, 2)]
        [TestCase(3000000, 4)]
        [TestCase(long.MaxValue, 9)]
        public void TestWriteReadVInt64(long value, int byteCount) {
            // Write the integral value into a stream
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.WriteVInt64(value);

            // Verify the correct number of bytes are serialized
            Assert.That(stream.Position, Is.EqualTo(byteCount));
            stream.Position = 0;
            byte[] bytes = stream.ToArray();
            Assert.That(bytes.Length, Is.EqualTo(byteCount));

            // Verify the value can be read back in
            BinaryReader reader = new BinaryReader(stream);
            long integral = reader.ReadVInt64();
            Assert.That(integral, Is.EqualTo(value));
        }


        [TestCase((ushort)0, 1)]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)127, 1)]
        [TestCase((ushort)128, 2)]
        [TestCase((ushort)16383, 2)]
        [TestCase((ushort)16384, 3)]
        [TestCase(ushort.MaxValue, 3)]
        public void TestWriteReadVUInt16(ushort value, int byteCount) {

            // Write the integral value into a stream
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.WriteVUInt16(value);

            // Verify the correct number of bytes are serialized
            Assert.That(stream.Position, Is.EqualTo(byteCount));
            stream.Position = 0;
            byte[] bytes = stream.ToArray();
            Assert.That(bytes.Length, Is.EqualTo(byteCount));

            // Verify the value can be read back in
            BinaryReader reader = new BinaryReader(stream);
            ushort integral = reader.ReadVUInt16();
            Assert.That(integral, Is.EqualTo(value));
        }

        [TestCase((uint)0, 1)]
        [TestCase((uint)1, 1)]
        [TestCase((uint)127, 1)]
        [TestCase((uint)128, 2)]
        [TestCase((uint)16383, 2)]
        [TestCase((uint)16384, 3)]
        [TestCase((uint)2097151, 3)]
        [TestCase((uint)2097152, 4)]
        [TestCase((uint)268435455, 4)]
        [TestCase((uint)268435456, 5)]
        [TestCase(uint.MaxValue, 5)]
        public void TestWriteReadVUInt32(uint value, int byteCount) {

            // Write the integral value into a stream
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.WriteVUInt32(value);

            // Verify the integral size computes correctly
            Assert.That(PatternBufferUtil.GetUnsignedVariantSize(value), Is.EqualTo(byteCount));

            // Verify the correct number of bytes are serialized
            Assert.That(stream.Position, Is.EqualTo(byteCount));
            stream.Position = 0;
            byte[] bytes = stream.ToArray();
            Assert.That(bytes.Length, Is.EqualTo(byteCount));

            // Verify the value can be read back in
            BinaryReader reader = new BinaryReader(stream);
            uint integral = reader.ReadVUInt32();
            Assert.That(integral, Is.EqualTo(value));
        }

        [TestCase((ulong)0, 1)]
        [TestCase((ulong)1, 1)]
        [TestCase((ulong)127, 1)]
        [TestCase((ulong)128, 2)]
        [TestCase((ulong)16383, 2)]
        [TestCase((ulong)16384, 3)]
        [TestCase((ulong)2097151, 3)]
        [TestCase((ulong)2097152, 4)]
        [TestCase((ulong)268435455, 4)]
        [TestCase((ulong)268435456, 5)]
        [TestCase((ulong)34359738367, 5)]
        [TestCase((ulong)34359738368, 6)]
        [TestCase((ulong)4398046511103, 6)]
        [TestCase((ulong)4398046511104, 7)]
        [TestCase((ulong)562949953421311, 7)]
        [TestCase((ulong)562949953421312, 8)]
        //[TestCase(ulong.MaxValue, 9)]
        public void TestWriteReadVUInt64(ulong value, int byteCount) {

            // Write the integral value into a stream
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.WriteVUInt64((ulong)value);

            // Verify the integral size computes correctly
            Assert.That(PatternBufferUtil.GetUnsignedVariantSize(value), Is.EqualTo(byteCount));

            // Verify the correct number of bytes are serialized
            Assert.That(stream.Position, Is.EqualTo(byteCount));
            stream.Position = 0;
            byte[] bytes = stream.ToArray();
            Assert.That(bytes.Length, Is.EqualTo(byteCount));

            // Verify the value can be read back in
            BinaryReader reader = new BinaryReader(stream);
            ulong integral = reader.ReadVUInt64();
            Assert.That(integral, Is.EqualTo(value));
        }


        [TestCase("00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000000", (ulong)0)]
        [TestCase("00000000 00000000 00000000 00000000 00000000 00000000 00000000 00000001", (ulong)1)]
        [TestCase("00000000 00000000 00000000 00000000 00000000 00000000 00000000 01111111", (ulong)127)]
        [TestCase("00000000 00000000 00000000 00000000 00000000 00000000 00000001 10000000", (ulong)128)]
        [TestCase("00000000 00000000 00000000 00000000 00000000 00000000 01111111 11111111", (ulong)16383)]
        [TestCase("00000000 00000000 00000000 00000000 00000000 00000001 10000000 10000000", (ulong)16384)]
        [TestCase("00000000 00000000 00000000 00000000 00000000 01111111 11111111 11111111", (ulong)2097151)]
        [TestCase("00000000 00000000 00000000 00000000 00000001 10000000 10000000 10000000", (ulong)2097152)]
        [TestCase("00000000 00000000 00000000 00000000 01111111 11111111 11111111 11111111", (ulong)268435455)]
        [TestCase("00000000 00000000 00000000 00000001 10000000 10000000 10000000 10000000", (ulong)268435456)]
        [TestCase("00000000 00000000 00000000 01111111 11111111 11111111 11111111 11111111", (ulong)34359738367)]
        [TestCase("00000000 00000000 00000001 10000000 10000000 10000000 10000000 10000000", (ulong)34359738368)]
        [TestCase("00000000 00000000 01111111 11111111 11111111 11111111 11111111 11111111", (ulong)4398046511103)]
        [TestCase("00000000 00000001 10000000 10000000 10000000 10000000 10000000 10000000", (ulong)4398046511104)]
        [TestCase("00000000 01111111 11111111 11111111 11111111 11111111 11111111 11111111", (ulong)562949953421311)]
        [TestCase("00000001 10000000 10000000 10000000 10000000 10000000 10000000 10000000", (ulong)562949953421312)]
        public void TestVUInt64ToString(string expected, ulong value) {
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.WriteVUInt64(value);
            stream.Position = 0;
            ulong integral = BitConverter.ToUInt64(stream.GetBuffer(), 0);
            string s = PatternBufferUtil.ToString(integral);
            Console.WriteLine("(" + PatternBufferUtil.GetUnsignedVariantSize(value) + " bytes) " + s + " = " + value);
            Assert.That(s, Is.EqualTo(expected));
        }

        [TestCase(int.MinValue, 5)]
        [TestCase((int)-16385, 3)]
        [TestCase((int)-16384, 3)]
        [TestCase((int)-16383, 3)]
        [TestCase((int)-512, 3)]
        [TestCase((int)-128, 2)]
        [TestCase((int)-127, 2)]
        [TestCase((int)-1, 2)]
        [TestCase((int)0, 2)]
        [TestCase((int)1, 2)]
        [TestCase((int)127, 2)]
        [TestCase((int)128, 2)]
        [TestCase((int)512, 3)]
        [TestCase((int)16383, 3)]
        [TestCase((int)16384, 3)]
        [TestCase((int)16385, 3)]
        [TestCase(int.MaxValue, 5)]
        public void TestGetVInt32Size(int value, int expected) {
            Assert.That(PatternBufferUtil.GetSignedVariantSize(value), Is.EqualTo(expected));
        }

        [TestCase(long.MinValue, 9)]
        [TestCase((long)-72057594037927936, 9)]
        [TestCase((long)-72057594037927935, 8)]
        [TestCase((long)-562949953421312, 8)]
        [TestCase((long)-562949953421311, 8)]
        [TestCase((long)-16385, 3)]
        [TestCase((long)-16384, 3)]
        [TestCase((long)-16383, 3)]
        [TestCase((long)-512, 3)]
        [TestCase((long)-128, 2)]
        [TestCase((long)-127, 2)]
        [TestCase((long)-1, 2)]
        [TestCase((long)0, 2)]
        [TestCase((long)1, 2)]
        [TestCase((long)127, 2)]
        [TestCase((long)128, 2)]
        [TestCase((long)512, 3)]
        [TestCase((long)16383, 3)]
        [TestCase((long)16384, 3)]
        [TestCase((long)16385, 3)]
        [TestCase((long)562949953421311, 8)]
        [TestCase((long)562949953421312, 8)]
        [TestCase((long)72057594037927935, 8)]
        [TestCase((long)72057594037927936, 9)]
        [TestCase(long.MaxValue, 9)]
        public void TestGetVInt64Size(long value, int expected) {
            Assert.That(PatternBufferUtil.GetSignedVariantSize(value), Is.EqualTo(expected));
        }

        [TestCase((ushort)0, 1)]
        [TestCase((ushort)1, 1)]
        [TestCase((ushort)127, 1)]
        [TestCase((ushort)128, 2)]
        [TestCase((ushort)512, 2)]
        [TestCase((ushort)16383, 2)]
        [TestCase((ushort)16384, 3)]
        [TestCase((ushort)16385, 3)]
        [TestCase(ushort.MaxValue, 3)]
        public void TestGetVUInt16Size(ushort value, int expected) {
            Assert.That(PatternBufferUtil.GetUnsignedVariantSize(value), Is.EqualTo(expected));
        }

        [TestCase((uint)0, 1)]
        [TestCase((uint)1, 1)]
        [TestCase((uint)127, 1)]
        [TestCase((uint)128, 2)]
        [TestCase((uint)512, 2)]
        [TestCase((uint)16383, 2)]
        [TestCase((uint)16384, 3)]
        [TestCase((uint)16385, 3)]
        [TestCase(uint.MaxValue, 5)]
        public void TestGetVUInt32Size(uint value, int expected) {
            Assert.That(PatternBufferUtil.GetUnsignedVariantSize(value), Is.EqualTo(expected));
        }

        [TestCase((ulong)0, 1)]
        [TestCase((ulong)1, 1)]
        [TestCase((ulong)127, 1)]
        [TestCase((ulong)128, 2)]
        [TestCase((ulong)512, 2)]
        [TestCase((ulong)16383, 2)]
        [TestCase((ulong)16384, 3)]
        [TestCase((ulong)16385, 3)]
        [TestCase((ulong)562949953421311, 7)]
        [TestCase((ulong)562949953421312, 8)]
        [TestCase((ulong)72057594037927935, 8)]
        [TestCase((ulong)72057594037927936, 9)]
        [TestCase((ulong)9223372036854775807, 9)]
        [TestCase(ulong.MaxValue, 9)]
        public void TestGetVUInt64Size(ulong value, int expected) {
            Assert.That(PatternBufferUtil.GetUnsignedVariantSize(value), Is.EqualTo(expected));
        }

    }

}
