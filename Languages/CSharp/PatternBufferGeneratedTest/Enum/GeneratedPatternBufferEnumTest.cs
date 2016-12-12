using System.Collections.Generic;
using NUnit.Framework;
using Test.Enum;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class GeneratedPatternBufferEnumTest {

        [Test()]
        public void TestEnumObjectSerialization() {
            EnumTestPatternBuffer patternBuffer = new EnumTestPatternBuffer();
            EnumObject u = new EnumObject(SomeEnum.value1);
            byte[] bytes = patternBuffer.Energize(u);
            Assert.AreEqual(2, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is EnumObject);
            Assert.AreEqual(u.SomeEnumValue, ((EnumObject)o).SomeEnumValue);
            Assert.IsFalse(u == o);
        }

        [Test()]
        public void TestEnumListObjectSerialization() {
            EnumTestPatternBuffer patternBuffer = new EnumTestPatternBuffer();
            EnumListObject u = new EnumListObject(new List<SomeEnum>() { SomeEnum.value1, SomeEnum.value3, SomeEnum.value2 });
            byte[] bytes = patternBuffer.Energize(u);
            Assert.AreEqual(5, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is EnumListObject);
            EnumListObject p = (EnumListObject)o;
            Assert.AreEqual(u.SomeEnumListValue.Count, p.SomeEnumListValue.Count);
            Assert.IsFalse(u == o);
            Assert.AreEqual(u.SomeEnumListValue[0], p.SomeEnumListValue[0]);
            Assert.AreEqual(u.SomeEnumListValue[1], p.SomeEnumListValue[1]);
            Assert.AreEqual(u.SomeEnumListValue[2], p.SomeEnumListValue[2]);
        }

        [Test()]
        public void TestEnumSetObjectSerialization() {
            EnumTestPatternBuffer patternBuffer = new EnumTestPatternBuffer();
            EnumSetObject u = new EnumSetObject(new HashSet<SomeEnum>() { SomeEnum.value1, SomeEnum.value3 });
            byte[] bytes = patternBuffer.Energize(u);
            Assert.AreEqual(4, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is EnumSetObject);
            EnumSetObject p = (EnumSetObject)o;
            Assert.AreEqual(2, u.SomeEnumSetValue.Count);
            Assert.AreEqual(2, p.SomeEnumSetValue.Count);
            Assert.IsFalse(u == o);
            Assert.IsTrue(u.SomeEnumSetValue.Contains(SomeEnum.value1));
            Assert.IsTrue(u.SomeEnumSetValue.Contains(SomeEnum.value3));
            Assert.IsTrue(p.SomeEnumSetValue.Contains(SomeEnum.value1));
            Assert.IsTrue(p.SomeEnumSetValue.Contains(SomeEnum.value3));
        }
        [Test()]
        public void TestEnumMapObjectSerialization() {
            EnumTestPatternBuffer patternBuffer = new EnumTestPatternBuffer();
            EnumMapObject u = new EnumMapObject(new Dictionary<int, SomeEnum>() { { 1, SomeEnum.value1 }, { 17, SomeEnum.value3 }, { 69, SomeEnum.value2 } });
            byte[] bytes = patternBuffer.Energize(u);
            // 1 byte       EnumMapObject type ID
            // 1 byte       map key count
            // 12 bytes     map key values (3 invariant ints)
            // 1 byte       map value count
            // 3 bytes      map values (3 enum values)
            Assert.AreEqual(18, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is EnumMapObject);
            EnumMapObject p = (EnumMapObject)o;
            Assert.IsFalse(u == o);
            Assert.AreEqual(u.IntSomeEnumMapValue.Count, p.IntSomeEnumMapValue.Count);
            Assert.AreEqual(u.IntSomeEnumMapValue[1], p.IntSomeEnumMapValue[1]);
            Assert.AreEqual(u.IntSomeEnumMapValue[17], p.IntSomeEnumMapValue[17]);
            Assert.AreEqual(u.IntSomeEnumMapValue[69], p.IntSomeEnumMapValue[69]);
        }

        [Test()]
        public void TestEnumMap2ObjectSerialization() {
            EnumTestPatternBuffer patternBuffer = new EnumTestPatternBuffer();
            EnumMap2Object u = new EnumMap2Object(new Dictionary<SomeEnum, int>() { { SomeEnum.value1, 1 }, { SomeEnum.value3, 17 }, { SomeEnum.value2, 69 } });
            byte[] bytes = patternBuffer.Energize(u);            
            // 1 byte       EnumMapObject type ID
            // 1 byte       map key count
            // 3 bytes      map key values (3 enum values)
            // 1 byte       map value count
            // 12 bytes     map values (3 invariant ints)
            Assert.AreEqual(18, bytes.Length);
            object o = patternBuffer.Energize(bytes);
            Assert.IsTrue(o is EnumMap2Object);
            EnumMap2Object p = (EnumMap2Object)o;
            Assert.IsFalse(u == o);
            Assert.AreEqual(u.SomeEnumIntMapValue.Count, p.SomeEnumIntMapValue.Count);
            Assert.AreEqual(u.SomeEnumIntMapValue[SomeEnum.value1], p.SomeEnumIntMapValue[SomeEnum.value1]);
            Assert.AreEqual(u.SomeEnumIntMapValue[SomeEnum.value3], p.SomeEnumIntMapValue[SomeEnum.value3]);
            Assert.AreEqual(u.SomeEnumIntMapValue[SomeEnum.value2], p.SomeEnumIntMapValue[SomeEnum.value2]);
        }

    }

}