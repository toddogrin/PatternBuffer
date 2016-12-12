using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using PatternBuffer;
using NSubstitute;

namespace PatternBufferTest.Schema {

    public class FakePatternBuffer : AbstractPatternBuffer {
        protected override void RegisterSerializers() {
            IPatternBufferSerializer serializer_10224a236a = Substitute.For<IPatternBufferSerializer>();
            this.typeIdSerializerMap[11] = serializer_10224a236a;
            this.typeSerializerMap[typeof(DateTime)] = serializer_10224a236a;
            this.typeNameSerializerMap["Thing"] = serializer_10224a236a;
        }
        protected override void RegisterEnums() {
            this.enumIndexValueMap["SomeEnum"] = new Dictionary<byte, string>();
            this.enumValueIndexMap["SomeEnum"] = new Dictionary<string, byte>();
            this.enumIndexValueMap["SomeEnum"][1] = "value1";
            this.enumValueIndexMap["SomeEnum"]["value1"] = 1;
            this.enumIndexValueMap["SomeEnum"][2] = "value2";
            this.enumValueIndexMap["SomeEnum"]["value2"] = 2;
            this.enumIndexValueMap["SomeEnum"][3] = "value3";
            this.enumValueIndexMap["SomeEnum"]["value3"] = 3;
        }
    }

    [TestFixture()]
    public class AbstractPatternBufferTest {
        
        [Test]
        [ExpectedException(typeof(PatternBufferException))]
        public void TestGettingUnregisteredEnumValueThrows() {
            FakePatternBuffer b = new FakePatternBuffer();
            b.GetEnumValue("lolno", (byte)0);
        }

        [Test]
        [ExpectedException(typeof(PatternBufferException))]
        public void TestGettingUnregisteredEnumIndexThrows() {
            FakePatternBuffer b = new FakePatternBuffer();
            b.GetEnumIndex("lolno", "whatever");
        }

        [Test]
        [ExpectedException(typeof(PatternBufferException))]
        public void TestGettingEnumValueOutsideIndexRangeThrows() {
            FakePatternBuffer b = new FakePatternBuffer();
            b.GetEnumValue("SomeEnum", (byte)100);
        }

        [Test]
        [ExpectedException(typeof(PatternBufferException))]
        public void TestGettingInvalidEnumIndexThrows() {
            FakePatternBuffer b = new FakePatternBuffer();
            b.GetEnumIndex("SomeEnum", "lolno");
        }

        [Test]
        [ExpectedException(typeof(PatternBufferException))]
        public void TestEnergizingUnregisteredObjectThrows() {
            AbstractPatternBuffer b = Substitute.ForPartsOf<AbstractPatternBuffer>();
            DateTime lol = new DateTime(1000);
            b.Energize(lol);
        }

        [Test]
        [ExpectedException(typeof(PatternBufferException))]
        public void TestEnergizingUnregisteredObjectToBinaryWriterThrows() {
            AbstractPatternBuffer b = Substitute.ForPartsOf<AbstractPatternBuffer>();
            DateTime lol = new DateTime(1000);
            BinaryWriter writer = new BinaryWriter(new MemoryStream());
            b.EnergizeTo(lol, writer);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEnergizingToNullBinaryWriterThrows() {
            FakePatternBuffer b = new FakePatternBuffer();
            DateTime lol = new DateTime(1000);
            b.EnergizeTo(lol, null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEnergizingFromNullBinaryReaderThrows() {
            AbstractPatternBuffer b = Substitute.ForPartsOf<AbstractPatternBuffer>();
            object o = b.EnergizeFrom(null);
        }

    }
}
