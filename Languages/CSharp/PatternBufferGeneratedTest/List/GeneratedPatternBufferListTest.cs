using System;
using System.Collections.Generic;
using NUnit.Framework;
using Test.List;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class GeneratedPatternBufferListTest {

        [Test()]
        public void TestIntListObjectNull() {
            ListTestPatternBuffer patternBuffer = new ListTestPatternBuffer();
            IntListObject o1 = new IntListObject(null);
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       IntListObject type ID
            // 1 byte       list count
            Assert.AreEqual(2, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            IntListObject p1 = (IntListObject)o2;
            Assert.IsTrue(p1 is IntListObject);
            Assert.IsNull(p1.IntListValue);
            Assert.IsFalse(o1 == p1);
        }

        [Test()]
        public void TestIntListObjectSerialization() {
            ListTestPatternBuffer patternBuffer = new ListTestPatternBuffer();
            IntListObject o1 = new IntListObject(new List<int>() { 1, 5, 900, 7038 });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       IntListObject type ID
            // 1 byte       null bits
            // 1 byte       list count
            // 16 bytes     4 invariant ints
            Assert.AreEqual(19, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            IntListObject p1 = (IntListObject)o2;
            Assert.IsTrue(p1 is IntListObject);
            Assert.AreEqual(4, p1.IntListValue.Count);
            Assert.AreEqual(o1.IntListValue.Count, p1.IntListValue.Count);
            Assert.AreEqual(o1.IntListValue[0], p1.IntListValue[0]);
            Assert.AreEqual(o1.IntListValue[1], p1.IntListValue[1]);
            Assert.AreEqual(o1.IntListValue[2], p1.IntListValue[2]);
            Assert.AreEqual(o1.IntListValue[3], p1.IntListValue[3]);
            Assert.IsFalse(o1 == p1);
        }

        [Test()]
        public void TestVIntListObjectSerialization() {
            ListTestPatternBuffer patternBuffer = new ListTestPatternBuffer();
            VIntListObject o1 = new VIntListObject(new List<int>() { 1, 5, 900, 7038 });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       VIntListObject type ID
            // 1 byte       null bits
            // 1 byte       list count
            // 2 bytes      1
            // 2 bytes      5
            // 3 bytes      900
            // 3 bytes      7038
            Assert.AreEqual(13, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            VIntListObject p1 = (VIntListObject)o2;
            Assert.IsTrue(p1 is VIntListObject);
            Assert.AreEqual(4, p1.VintListValue.Count);
            Assert.AreEqual(o1.VintListValue.Count, p1.VintListValue.Count);
            Assert.AreEqual(o1.VintListValue[0], p1.VintListValue[0]);
            Assert.AreEqual(o1.VintListValue[1], p1.VintListValue[1]);
            Assert.AreEqual(o1.VintListValue[2], p1.VintListValue[2]);
            Assert.AreEqual(o1.VintListValue[3], p1.VintListValue[3]);
            Assert.IsFalse(o1 == p1);
        }

        [Test()]
        public void TestStringListObjectSerialization() {
            ListTestPatternBuffer patternBuffer = new ListTestPatternBuffer();
            StringListObject o1 = new StringListObject(new List<string>() { "foo", "bar" });
            byte[] bytes = patternBuffer.Energize(o1);
            Assert.AreEqual(11, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            StringListObject p1 = (StringListObject)o2;
            Assert.IsTrue(p1 is StringListObject);
            Assert.AreEqual(2, p1.StringListValue.Count);
            Assert.IsFalse(o1 == p1);
        }

        [Test()]
        public void TestThingListObjectSerialization() {
            ListTestPatternBuffer patternBuffer = new ListTestPatternBuffer();
            Thing1 t1 = new Thing1(1, 2);
            Thing1 t2 = new Thing1(3, 4);
            Thing1ListObject o1 = new Thing1ListObject(new List<Thing1>() { t1, t2 });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       Thing1ListObject type ID
            // 1 byte       null bits
            // 1 byte       list count
            // 8 bytes      Thing1 (2 invariant ints)
            // 8 bytes      Thing1 (2 invariant ints)
            Assert.AreEqual(19, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            Thing1ListObject p1 = (Thing1ListObject)o2;
            Assert.IsTrue(p1 is Thing1ListObject);
            Assert.AreEqual(2, p1.ThingListValue.Count);
            Assert.IsFalse(o1 == p1);
        }

        [Test()]
        public void TestAbstractThingListObjectSerialization() {
            ListTestPatternBuffer patternBuffer = new ListTestPatternBuffer();
            AbstractThing t1 = new Thing1(1, 2);
            AbstractThing t2 = new Thing2(3, 4);
            AbstractThingListObject o1 = new AbstractThingListObject(new List<AbstractThing>() { t1, t2 });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       AbstractThingListObject type ID
            // 1 byte       null bits
            // 1 byte       list count
            // 1 byte       Thing1 type ID
            // 8 bytes      Thing1 2 invariant ints
            // 1 byte       Thing2 type ID
            // 8 bytes      Thing2 2 invariant ints
            Assert.AreEqual(21, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            AbstractThingListObject p1 = (AbstractThingListObject)o2;
            Assert.IsTrue(p1 is AbstractThingListObject);
            Assert.AreEqual(2, p1.AbstractThingListValue.Count);
            HashSet<int> expected = new HashSet<int>() { 1, 3 };
            foreach (AbstractThing t in p1.AbstractThingListValue) {
                Console.WriteLine(t.IntValue1);
                expected.Remove(t.IntValue1);
            }
            Assert.AreEqual(0, expected.Count);
            Assert.IsFalse(o1 == p1);
        }
    }

}