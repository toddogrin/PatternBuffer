using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using NUnit.Framework;
using Test.Reference;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class GeneratedPatternBufferReferenceTest {

        [Test()]
        public void TestFinalObjectSerialization() {
            ReferenceTestPatternBuffer patternBuffer = new ReferenceTestPatternBuffer();
            Thing t1 = new Thing(123);
            FinalObject o1 = new FinalObject(t1);
            byte[] bytes = patternBuffer.Energize(o1);
            // 1 byte       FinalObject type ID
            // 1 byte       null fields
            // 4 bytes      Thing invariant int
            Assert.AreEqual(6, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            FinalObject p1 = (FinalObject)o2;
            Assert.IsTrue(p1 is FinalObject);
            Assert.IsTrue(t1.Equals(p1.ThingValue));
            Assert.IsFalse(o1 == p1);
        }
        
        [Test()]
        public void TestAbstractObjectSerialization() {
            ReferenceTestPatternBuffer patternBuffer = new ReferenceTestPatternBuffer();
            FinalThing1 t1 = new FinalThing1(123, 456);
            AbstractReferenceObject aro1 = new AbstractReferenceObject(t1);
            byte[] bytes = patternBuffer.Energize(aro1);
            // 1 byte       AbstractReferenceObject type ID
            // 1 byte       null fields
            // 1 byte       abstract reference type ID
            // 8 bytes      FinalThing1's 2 invariant ints
            Assert.AreEqual(11, bytes.Length);
            object o2 = patternBuffer.Energize(bytes);
            Assert.IsTrue(o2 is AbstractReferenceObject);
            AbstractReferenceObject aro2 = (AbstractReferenceObject)o2;
            Assert.AreEqual(aro1.Thing.IntValue1, aro2.Thing.IntValue1);
            Assert.IsTrue(aro1.Thing is FinalThing1);
            Assert.IsTrue(aro2.Thing is FinalThing1);
            Assert.IsFalse(aro1 == aro2);
        }
    }

}