using NUnit.Framework;
using PatternBuffer;
using Test.Primitive;

namespace PatternBufferTest {

    [TestFixture()]
    public class GeneratedPatternBufferPrimitiveTest {

        [Test()]
        public void TestBoolObjectSerialization() {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            BoolObject b = new BoolObject(false);
            byte[] bytes = patternBuffer.Energize(b);
            Assert.AreEqual(2, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is BoolObject);
            Assert.AreEqual(b.boolValue, ((BoolObject)o).boolValue);
            Assert.IsFalse(b == o);
        }

        [Test()]
        public void TestByteObjectSerialization() {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            ByteObject b = new ByteObject(37);
            byte[] bytes = patternBuffer.Energize(b);
            Assert.AreEqual(2, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is ByteObject);
            Assert.AreEqual(b.byteValue, ((ByteObject)o).byteValue);
            Assert.IsFalse(b == o);
        }

        [Test()]
        public void TestDoubleObjectSerialization() {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            DoubleObject o1 = new DoubleObject(1.2929348);
            byte[] bytes = patternBuffer.Energize(o1);
            Assert.AreEqual(9, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is DoubleObject);
            Assert.AreEqual(o1.DoubleValue, ((DoubleObject)o).DoubleValue);
            Assert.IsFalse(o1 == o);
        }

        [Test()]
        public void TestSingleObjectSerialization() {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            DoubleObject o1 = new DoubleObject(1.2929348);
            byte[] bytes = patternBuffer.Energize(o1);
            Assert.AreEqual(9, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is DoubleObject);
            Assert.AreEqual(o1.DoubleValue, ((DoubleObject)o).DoubleValue);
            Assert.IsFalse(o1 == o);
        }

        [TestCase(int.MinValue, 5)]
        [TestCase(122, 5)]
        [TestCase(12345, 5)]
        [TestCase(20000000, 5)]
        [TestCase(int.MaxValue, 5)]
        public void TestIntObjectSerialization(int value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            IntObject intObject = new IntObject(12345);
            byte[] bytes = patternBuffer.Energize(intObject);
            Assert.AreEqual(5, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is IntObject);
            Assert.AreEqual(intObject.intValue, ((IntObject)o).intValue);
            Assert.IsFalse(intObject == o);
        }

        //[TestCase(int.MinValue, 6)]
        //[TestCase(-16384, 4)]
        //[TestCase(-128, 3)]
        //[TestCase(-127, 3)]
        //[TestCase(-1, 2)]
        //[TestCase(0, 2)]
        [TestCase(1, 3)]
        //[TestCase(127, 3)]
        //[TestCase(128, 3)]
        //[TestCase(16384, 4)]
        //[TestCase(1048544, 4)]
        //[TestCase(2097088, 5)]
        //[TestCase(int.MaxValue, 6)]
        public void TestVIntObjectSerialization(int value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            VIntObject l1 = new VIntObject(value);
            byte[] bytes = patternBuffer.Energize(l1);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is VIntObject);
            Assert.AreEqual(l1.vintValue, ((VIntObject)o).vintValue);
            Assert.IsFalse(l1 == o);
        }

        [TestCase(long.MinValue, 9)]
        [TestCase(122, 9)]
        [TestCase(12345, 9)]
        [TestCase(20000000, 9)]
        [TestCase(long.MaxValue, 9)]
        public void TestLongObjectSerialization(long value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            LongObject l1 = new LongObject(value);
            byte[] bytes = patternBuffer.Energize(l1);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is LongObject);
            Assert.AreEqual(l1.longValue, ((LongObject)o).longValue);
            Assert.IsFalse(l1 == o);
        }

        [TestCase(long.MinValue, 10)]
        [TestCase(122, 3)]
        [TestCase(12345, 4)]
        [TestCase(20000000, 6)]
        [TestCase(long.MaxValue, 10)]
        public void TestVLongObjectSerialization(long value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            VLongObject l1 = new VLongObject(value);
            byte[] bytes = patternBuffer.Energize(l1);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is VLongObject);
            Assert.AreEqual(l1.vlongValue, ((VLongObject)o).vlongValue);
            Assert.IsFalse(l1 == o);
        }

        [TestCase(short.MinValue, 3)]
        [TestCase(122, 3)]
        [TestCase(12345, 3)]
        [TestCase(20000, 3)]
        [TestCase(short.MaxValue, 3)]
        public void TestShortObjectSerialization(short value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            ShortObject s = new ShortObject(value);
            byte[] bytes = patternBuffer.Energize(s);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is ShortObject);
            Assert.AreEqual(s.shortValue, ((ShortObject)o).shortValue);
            Assert.IsFalse(s == o);
        }

        [Test()]
        public void TestStringObjectSerialization() {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            StringObject stringObject = new StringObject("foobar");
            byte[] bytes = patternBuffer.Energize(stringObject);
            Assert.AreEqual(8, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is StringObject);
            Assert.AreEqual(stringObject.StringValue, ((StringObject)o).StringValue);
            Assert.IsFalse(stringObject == o);
        }

        [TestCase(uint.MinValue, 5)]
        [TestCase((uint)122, 5)]
        [TestCase((uint)12345, 5)]
        [TestCase((uint)20000000, 5)]
        [TestCase(uint.MaxValue, 5)]
        public void TestUIntObjectSerialization(uint value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            UIntObject u = new UIntObject(value);
            byte[] bytes = patternBuffer.Energize(u);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is UIntObject);
            Assert.AreEqual(u.uintValue, ((UIntObject)o).uintValue);
            Assert.IsFalse(u == o);
        }

        [TestCase(uint.MinValue, 2)]
        [TestCase((uint)122, 2)]
        [TestCase((uint)12345, 3)]
        [TestCase((uint)20000000, 5)]
        [TestCase(uint.MaxValue, 6)]
        public void TestVUIntObjectSerialization(uint value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            VUIntObject u = new VUIntObject(value);
            byte[] bytes = patternBuffer.Energize(u);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is VUIntObject);
            Assert.AreEqual(u.vuintValue, ((VUIntObject)o).vuintValue);
            Assert.IsFalse(u == o);
        }

        [TestCase(ulong.MinValue, 9)]
        [TestCase((ulong)122, 9)]
        [TestCase((ulong)12345, 9)]
        [TestCase((ulong)20000000, 9)]
        [TestCase(ulong.MaxValue, 9)]
        public void TestULongObjectSerialization(ulong value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            ULongObject u = new ULongObject(value);
            byte[] bytes = patternBuffer.Energize(u);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is ULongObject);
            Assert.AreEqual(u.ulongValue, ((ULongObject)o).ulongValue);
            Assert.IsFalse(u == o);
        }

        //[TestCase(ulong.MinValue, 2)]
        //[TestCase((ulong)122, 2)]
        //[TestCase((ulong)12345, 3)]
        //[TestCase((ulong)20000000, 5)]
        [TestCase(ulong.MaxValue, 10)]
        public void TestVULongObjectSerialization(ulong value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            VULongObject u = new VULongObject(value);
            byte[] bytes = patternBuffer.Energize(u);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is VULongObject);
            Assert.AreEqual(u.vulongValue, ((VULongObject)o).vulongValue);
            Assert.IsFalse(u == o);
        }

        [TestCase(ushort.MinValue, 3)]
        [TestCase((ushort)122, 3)]
        [TestCase((ushort)12345, 3)]
        [TestCase(ushort.MaxValue, 3)]
        public void TestUShortObjectSerialization(ushort value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            UShortObject u = new UShortObject(value);
            byte[] bytes = patternBuffer.Energize(u);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is UShortObject);
            Assert.AreEqual(u.ushortValue, ((UShortObject)o).ushortValue);
            Assert.IsFalse(u == o);
        }

        [TestCase(ushort.MinValue, 2)]
        [TestCase((ushort)122, 2)]
        [TestCase((ushort)12345, 3)]
        [TestCase(ushort.MaxValue, 4)]
        public void TestVUShortObjectSerialization(ushort value, int byteCount) {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            VUShortObject u = new VUShortObject(value);
            byte[] bytes = patternBuffer.Energize(u);
            Assert.AreEqual(byteCount, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is VUShortObject);
            Assert.AreEqual(u.vushortValue, ((VUShortObject)o).vushortValue);
            Assert.IsFalse(u == o);
        }

        [Test()]
        public void TestEquals() {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            UShortObject u = new UShortObject(12345);
            StringObject s = new StringObject("12345");
            Assert.IsFalse(u.Equals(s));
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferException))]
        public void TestSizeOfBadArgument() {
            PrimitiveTestPatternBuffer patternBuffer = new PrimitiveTestPatternBuffer();
            StringObject u = new StringObject("abcde");
            IPatternBufferSerializer s = new UShortObjectSerializer(patternBuffer);
            s.SizeOf(u);
        }

    }

}