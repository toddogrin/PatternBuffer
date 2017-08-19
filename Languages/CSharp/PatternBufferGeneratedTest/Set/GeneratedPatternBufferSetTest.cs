using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using Test.Set;

namespace PotionTest.Schema {

    [TestFixture()]
    public class GeneratedPatternBufferSetTest {

        [Test()]
        public void TestIntSetObjectSerialization() {
            SetTestPatternBuffer patternBuffer = new SetTestPatternBuffer();
            IntSetObject o1 = new IntSetObject(new HashSet<int>() { 1, 5, 900, 7038 });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte     IntSetObject type ID
            // 1 byte     null bits
            // 1 byte     set count
            // 4*4 bytes  4 invariant ints
            Assert.AreEqual(19, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            IntSetObject p1 = (IntSetObject)o2;
            Assert.That(p1 is IntSetObject, Is.True);
            Assert.That(p1.IntSetValue.Count, Is.EqualTo(4));
            Assert.That(p1.IntSetValue.Count, Is.EqualTo(o1.IntSetValue.Count));
            Assert.That(o1.IntSetValue.Contains(1), Is.True);
            Assert.That(p1.IntSetValue.Contains(1), Is.True);
            Assert.That(o1.IntSetValue.Contains(5), Is.True);
            Assert.That(p1.IntSetValue.Contains(5), Is.True);
            Assert.That(o1.IntSetValue.Contains(900), Is.True);
            Assert.That(p1.IntSetValue.Contains(900), Is.True);
            Assert.That(o1.IntSetValue.Contains(7038), Is.True);
            Assert.That(p1.IntSetValue.Contains(7038), Is.True);
            Assert.That(o1 == p1, Is.False);
        }

        //[Test()]
        //public void TestVIntSetObjectSerialization() {
        //    SetTestPatternBuffer patternBuffer = new SetTestPatternBuffer();
        //    VIntSetObject o1 = new VIntSetObject(new HashSet<int>() { 1, 5, 900, 7038 });
        //    byte[] bytes = patternBuffer.Energize(o1);
        //    // 1 byte       VIntSetObject type ID
        //    // 1 byte       set count
        //    // 2 bytes      1
        //    // 2 bytes      5
        //    // 3 bytes      900
        //    // 3 bytes      7038
        //    Assert.That(bytes.Length, Is.EqualTo(12));
        //    object o2 = patternBuffer.Energize(bytes);
        //    VIntSetObject p1 = (VIntSetObject)o2;
        //    Assert.That(p1 is VIntSetObject, Is.True);
        //    Assert.That(p1.VintSetValue.Count, Is.EqualTo(4));
        //    Assert.That(p1.VintSetValue.Count, Is.EqualTo(o1.VintSetValue.Count));
        //    Assert.That(o1.VintSetValue.Contains(1), Is.True);
        //    Assert.That(p1.VintSetValue.Contains(1), Is.True);
        //    Assert.That(o1.VintSetValue.Contains(5), Is.True);
        //    Assert.That(p1.VintSetValue.Contains(5), Is.True);
        //    Assert.That(o1.VintSetValue.Contains(900), Is.True);
        //    Assert.That(p1.VintSetValue.Contains(900), Is.True);
        //    Assert.That(o1.VintSetValue.Contains(7038), Is.True);
        //    Assert.That(p1.VintSetValue.Contains(7038), Is.True);
        //    Assert.That(o1 == p1, Is.False);
        //}

        [Test()]
        public void TestStringSetObjectSerialization() {
            SetTestPatternBuffer patternBuffer = new SetTestPatternBuffer();
            StringSetObject o1 = new StringSetObject(new HashSet<string>() { "foo", "bar" });
            byte[] bytes = patternBuffer.Energize(o1);
            Assert.That(bytes.Length, Is.EqualTo(11));
            object o2 = patternBuffer.Energize(bytes);
            StringSetObject p1 = (StringSetObject)o2;
            Assert.That(p1 is StringSetObject, Is.True);
            Assert.That(p1.StringSetValue.Count, Is.EqualTo(2));
            Assert.That(o1 == p1, Is.False);
        }

        [Test()]
        public void TestThingSetObjectSerialization() {
            SetTestPatternBuffer patternBuffer = new SetTestPatternBuffer();
            Thing1 t1 = new Thing1(1, 2);
            Thing1 t2 = new Thing1(3, 4);
            Thing1SetObject o1 = new Thing1SetObject(new HashSet<Thing1>() { t1, t2 });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte   - Thing1SetObject type ID
            // 1 byte   - set count
            // 8 bytes  - 2 invariant ints
            // 8 bytes  - 2 invariant ints
            Assert.That(bytes.Length, Is.EqualTo(19));
            object o2 = patternBuffer.Energize(bytes);
            Thing1SetObject p1 = (Thing1SetObject)o2;
            Assert.That(p1 is Thing1SetObject, Is.True);
            Assert.That(p1.ThingSetValue.Count, Is.EqualTo(2));
            Assert.That(o1 == p1, Is.False);
        }

        [Test()]
        public void TestAbstractThingSetObjectSerialization() {
            SetTestPatternBuffer patternBuffer = new SetTestPatternBuffer();
            AbstractThing t1 = new Thing1(1, 2);
            AbstractThing t2 = new Thing2(3, 4);
            AbstractThingSetObject o1 = new AbstractThingSetObject(new HashSet<AbstractThing>() { t1, t2 });
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       AbstractThingSetObject type ID
            // 1 byte       null bits
            // 1 byte       set count
            // 1 byte       Thing1 type ID
            // 8 bytes      Thing1 2 invariant ints
            // 1 byte       Thing2 type ID
            // 8 bytes      Thing2 2 invariant ints
            Assert.That(bytes.Length, Is.EqualTo(21));
            object o2 = patternBuffer.Energize(bytes);
            AbstractThingSetObject p1 = (AbstractThingSetObject)o2;
            Assert.That(p1 is AbstractThingSetObject, Is.True);
            Assert.That(p1.AbstractThingSetValue.Count, Is.EqualTo(2));
            HashSet<int> expected = new HashSet<int>() { 1, 3 };
            foreach (AbstractThing t in p1.AbstractThingSetValue) {
                Console.WriteLine(t.IntValue1);
                expected.Remove(t.IntValue1);
            }
            Assert.That(expected.Count, Is.EqualTo(0));
            Assert.That(o1 == p1, Is.False);
        }

    }

}