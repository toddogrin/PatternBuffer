using System;
using System.Collections.Generic;
using NUnit.Framework;
using Test.Map;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class GeneratedPatternBufferMapTest {

        [Test()]
        public void IntStringMapObjectNull() {
            MapTestPatternBuffer patternBuffer = new MapTestPatternBuffer();
            IntStringMapObject o1 = new IntStringMapObject(null);
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       EnumIntMapObject type ID
            // 1 byte       null bits
            Assert.AreEqual(2, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            Assert.IsTrue(o2 is IntStringMapObject);
            IntStringMapObject p1 = (IntStringMapObject)o2;
            Assert.IsNull(o1.IntStringMap);
            Assert.IsNull(((IntStringMapObject)o2).IntStringMap);
        }

        [Test()]
        public void IntStringMapObjectSerialization() {
            MapTestPatternBuffer patternBuffer = new MapTestPatternBuffer();
            IntStringMapObject o1 = new IntStringMapObject(new Dictionary<int, string> { { 321, "foo" }, { 654, "bar" } });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       EnumIntMapObject type ID
            // 1 byte       null bits
            // 1 byte       key count
            // 1 byte       value count
            // 8 bytes      keys (2 invariant ints)
            // 8 bytes      values (6 characters total, 2 lengths)
            Assert.AreEqual(20, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            Assert.IsTrue(o2 is IntStringMapObject);
            IntStringMapObject p1 = (IntStringMapObject)o2;
            Assert.AreEqual(o1.IntStringMap.Count, p1.IntStringMap.Count);
            Assert.IsTrue(p1.IntStringMap.ContainsKey(321));
            Assert.IsTrue(p1.IntStringMap.ContainsKey(654));
            Assert.AreEqual(o1.IntStringMap[321], p1.IntStringMap[321]);
            Assert.AreEqual(o1.IntStringMap[654], p1.IntStringMap[654]);
            Assert.IsFalse(o1 == p1);
        }

        [Test()]
        public void EnumIntMapObjectSerialization() {
            MapTestPatternBuffer patternBuffer = new MapTestPatternBuffer();
            EnumIntMapObject o1 = new EnumIntMapObject(new Dictionary<MyEnum, int> { { MyEnum.value3, 123 }, { MyEnum.value1, 456 } });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       EnumIntMapObject type ID
            // 1 byte       null bits
            // 1 byte       key count
            // 1 byte       value count
            // 2 bytes      keys (2 enum values)
            // 8 bytes      values (2 invariant ints)
            Assert.AreEqual(14, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            Assert.IsTrue(o2 is EnumIntMapObject);
            EnumIntMapObject p1 = (EnumIntMapObject)o2;
            Assert.AreEqual(o1.EnumIntMap.Count, p1.EnumIntMap.Count);
            Assert.IsTrue(p1.EnumIntMap.ContainsKey(MyEnum.value1));
            Assert.IsTrue(p1.EnumIntMap.ContainsKey(MyEnum.value3));
            Assert.AreEqual(o1.EnumIntMap[MyEnum.value1], p1.EnumIntMap[MyEnum.value1]);
            Assert.AreEqual(o1.EnumIntMap[MyEnum.value3], p1.EnumIntMap[MyEnum.value3]);
            Assert.IsFalse(o1 == p1);
        }

        //[Test()]
        //public void VIntVLongMapObjectSerialization() {
        //    MapTestPatternBuffer patternBuffer = new MapTestPatternBuffer();
        //    VIntVLongMapObject o1 = new VIntVLongMapObject(new Dictionary<int, long> { { 1, 1000000 }, { 2, 2000000 } });
        //    byte[] bytes = patternBuffer.Energize(o1);
        //    // 1 byte       EnumIntMapObject type ID
        //    // 1 byte       key count
        //    // 1 byte       value count
        //    // 4 bytes      keys (2 variant ints)
        //    // 8 bytes      values (2 variant longs)
        //    Assert.AreEqual(15, bytes.Length);
        //    object o2 = patternBuffer.Energize(bytes);
        //    Assert.IsTrue(o2 is VIntVLongMapObject);
        //    VIntVLongMapObject p1 = (VIntVLongMapObject)o2;
        //    Assert.AreEqual(o1.VintVlongMap.Count, p1.VintVlongMap.Count);
        //    Assert.IsTrue(p1.VintVlongMap.ContainsKey(1));
        //    Assert.IsTrue(p1.VintVlongMap.ContainsKey(2));
        //    Assert.AreEqual(o1.VintVlongMap[1], p1.VintVlongMap[1]);
        //    Assert.AreEqual(o1.VintVlongMap[2], p1.VintVlongMap[2]);
        //    Assert.IsFalse(o1 == p1);
        //}

        [Test()]
        public void IntThingMapObjectSerialization() {
            MapTestPatternBuffer patternBuffer = new MapTestPatternBuffer();
            Thing t1 = new Thing(true, 123);
            Thing t2 = new Thing(true, 456);
            IntThingMapObject o1 = new IntThingMapObject(new Dictionary<int, Thing> { { 321, t1 }, { 654, t2 } });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       IntThingMapObject type ID
            // 1 byte       null bits
            // 1 byte       key count
            // 1 byte       value count
            // 8 bytes      keys (2 invariant ints)
            // 8 bytes      values (2 Things, each with 1 invariant int)
            Assert.AreEqual(22, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            Assert.IsTrue(o2 is IntThingMapObject);
            IntThingMapObject p1 = (IntThingMapObject)o2;
            Assert.AreEqual(o1.IntThingMap.Count, p1.IntThingMap.Count);
            Assert.IsTrue(p1.IntThingMap.ContainsKey(321));
            Assert.IsTrue(p1.IntThingMap.ContainsKey(654));
            Assert.AreEqual(t1.IntValue, p1.IntThingMap[321].IntValue);
            Assert.AreEqual(t2.IntValue, p1.IntThingMap[654].IntValue);
            Assert.IsFalse(o1 == p1);
        }

        [Test()]
        public void ThingIntMapObjectSerialization() {
            MapTestPatternBuffer patternBuffer = new MapTestPatternBuffer();
            Thing t1 = new Thing(true, 123);
            Thing t2 = new Thing(true, 456);
            ThingIntMapObject o1 = new ThingIntMapObject(new Dictionary<Thing, int> { { t1, 321 }, { t2, 654 } });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       ThingIntMapObject type ID
            // 1 byte       null bits
            // 1 byte       key count
            // 1 byte       value count
            // 8 bytes      keys (2 Things, each with 1 invariant int)
            // 8 bytes      values (2 invariant ints)
            Assert.AreEqual(22, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            Assert.IsTrue(o2 is ThingIntMapObject);
            ThingIntMapObject p1 = (ThingIntMapObject)o2;
            Assert.AreEqual(o1.ThingIntMap.Count, p1.ThingIntMap.Count);
            Assert.IsTrue(p1.ThingIntMap.ContainsValue(321));
            Assert.IsTrue(p1.ThingIntMap.ContainsValue(654));
            HashSet<int> thingValues = new HashSet<int>() { 123, 456 };
            foreach (Thing thing in p1.ThingIntMap.Keys) {
                thingValues.Remove(thing.IntValue);
            }
            Assert.AreEqual(0, thingValues.Count);
            Assert.IsFalse(o1 == p1);
        }

        [Test()]
        public void ThingThingMapObjectSerialization() {
            MapTestPatternBuffer patternBuffer = new MapTestPatternBuffer();
            Thing k1 = new Thing(true, 123);
            Thing v1 = new Thing(true, 124);

            Thing k2 = new Thing(true, 456);
            Thing v2 = new Thing(true, 457);

            Dictionary<Thing, Thing> d = new Dictionary<Thing, Thing>();
            d[k1] = v1;
            d[k2] = v2;
            ThingThingMapObject o1 = new ThingThingMapObject(d);
            Assert.AreEqual(o1.ThingThingMap, d);
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       ThingIntMapObject type ID
            // 1 byte       null bits
            // 1 byte       key count
            // 1 byte       value count
            // 8 bytes      keys (2 Things, each with 1 invariant int)
            // 8 bytes      values (2 Things, each with 1 invariant int)
            Assert.AreEqual(24, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            Assert.IsTrue(o2 is ThingThingMapObject);
            ThingThingMapObject p1 = (ThingThingMapObject)o2;

            Assert.AreEqual(o1.ThingThingMap.Count, p1.ThingThingMap.Count);

            HashSet<int> thingKeys = new HashSet<int>() { 123, 456 };
            HashSet<int> thingValues = new HashSet<int>() { 124, 457 };
            foreach (Thing thingKey in p1.ThingThingMap.Keys) {
                thingKeys.Remove(thingKey.IntValue);
                thingValues.Remove(p1.ThingThingMap[thingKey].IntValue);
            }
            Assert.AreEqual(0, thingKeys.Count);
            Assert.AreEqual(0, thingValues.Count);
            Assert.IsFalse(o1 == p1);
        }
    }

}