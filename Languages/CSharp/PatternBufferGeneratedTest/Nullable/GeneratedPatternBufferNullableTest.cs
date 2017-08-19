using System;
using System.Collections.Generic;
using NUnit.Framework;
using Test.Nullable;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class GeneratedPatternBufferNullableTest {

        [Test()]
        public void TestNullableFields() {
            
            NullableTestPatternBuffer pb = new NullableTestPatternBuffer(4096);

            ThingContainer tc1 = new ThingContainer();
            tc1.Thing1 = new Thing(1);
            tc1.Thing2 = new Thing(2);
            tc1.Thing3 = new Thing(3);
            tc1.Thing4 = new Thing(4);
            tc1.Thing5 = new Thing(5);
            tc1.Thing6 = new Thing(6);
            tc1.Thing7 = new Thing(7);
            tc1.Thing8 = new Thing(8);
            tc1.Thing9 = new Thing(9);
            tc1.Thing10 = new Thing(10);
            tc1.IntValue1 = 1;
            tc1.IntValue2 = 2;

            byte[] bytes1 = pb.Energize(tc1);
            Assert.AreEqual(1 + 2 + 4 * 10 + 2 * 4, bytes1.Length);

            tc1.Thing3 = null;
            tc1.Thing8 = null;
            byte[] bytes2 = pb.Energize(tc1);
            Assert.AreEqual(1 + 2 + 4 * 8 + 2 * 4, bytes2.Length);

            tc1.Thing1 = null;
            tc1.Thing2 = null;
            tc1.Thing3 = null;
            tc1.Thing4 = null;
            tc1.Thing5 = null;
            tc1.Thing6 = null;
            tc1.Thing7 = null;
            tc1.Thing8 = null;
            tc1.Thing9 = null;
            tc1.Thing10 = null;
            byte[] bytes3 = pb.Energize(tc1);
            Assert.AreEqual(1 + 2 + 2 * 4, bytes3.Length);
        }

        [Test()]
        public void TestAncestralNullableFields() {
            NullableTestPatternBuffer pb = new NullableTestPatternBuffer(4096);
            ThingContainer3 tc3 = new ThingContainer3();
            
            tc3.Thing1 = new Thing(1);
            tc3.Thing2 = new Thing(2);
            tc3.Thing3 = new Thing(3);
            byte[] bytes1 = pb.Energize(tc3);
            Assert.AreEqual(1 + 1 + 4 * 3, bytes1.Length);

            tc3.Thing1 = null;
            tc3.Thing2 = null;
            tc3.Thing3 = null; 
            byte[] bytes2 = pb.Energize(tc3);
            Assert.AreEqual(1 + 1, bytes2.Length);
        }

        [Test()]
        public void TestAncestralNullableFieldsSerialization() {
            NullableTestPatternBuffer pb = new NullableTestPatternBuffer(4096);
            ThingContainer3 tc3 = new ThingContainer3();

            tc3.Thing1 = new Thing(1);
            tc3.Thing2 = new Thing(2);
            tc3.Thing3 = new Thing(3);
            byte[] bytes1 = pb.Energize(tc3);
            Assert.AreEqual(1 + 1 + 4 * 3, bytes1.Length);

            ThingContainer3 tc3_a = pb.Energize<ThingContainer3>(bytes1);
            Assert.IsNotNull(tc3_a);
            Assert.IsNotNull(tc3_a.Thing1);
            Assert.IsNotNull(tc3_a.Thing2);
            Assert.IsNotNull(tc3_a.Thing3);
            Assert.AreEqual(1, tc3_a.Thing1.Value);
            Assert.AreEqual(2, tc3_a.Thing2.Value);
            Assert.AreEqual(3, tc3_a.Thing3.Value);

            tc3.Thing1 = null;
            tc3.Thing2 = null;
            tc3.Thing3 = null;
            byte[] bytes2 = pb.Energize(tc3);
            Assert.AreEqual(1 + 1, bytes2.Length);

            ThingContainer3 tc3_b = pb.Energize<ThingContainer3>(bytes2);
            Assert.IsNotNull(tc3_b);
            Assert.IsNull(tc3_b.Thing1);
            Assert.IsNull(tc3_b.Thing2);
            Assert.IsNull(tc3_b.Thing3);
        }

        [Test()]
        public void TestAncestralAbstractNullableFieldsSerialization() {
            NullableTestPatternBuffer pb = new NullableTestPatternBuffer(4096);
            BaseTypeContainer btc = new BaseTypeContainer();
            btc.Value1 = new DerivedType1(true, 123L);
            btc.Value2 = new DerivedType2(true, (byte)67);
            byte[] bytes1 = pb.Energize(btc);
            Assert.AreEqual(
                1 + // btc type ID
                1 + // btc nullable flags
                1 + // Value1 type ID
                1 + // Value 1 boolean
                8 + // Value 1 long
                1 + // Value2 type ID
                1 + // Value2 boolean
                1,  // Value 2 byte
                bytes1.Length
            );
            BaseTypeContainer btc_1 = pb.Energize<BaseTypeContainer>(bytes1);
            Assert.IsNotNull(btc_1);
            Assert.IsNotNull(btc_1.Value1);
            Assert.AreEqual(true, btc_1.Value1.BooleanValue);
            Assert.IsInstanceOf(typeof(DerivedType1), btc_1.Value1);
            Assert.AreEqual(123L, ((DerivedType1)btc_1.Value1).LongValue);
            Assert.IsNotNull(btc_1.Value2);
            Assert.AreEqual(true, btc_1.Value1.BooleanValue);
            Assert.IsInstanceOf(typeof(DerivedType2), btc_1.Value2);
            Assert.AreEqual((byte)67, ((DerivedType2)btc_1.Value2).ByteValue);

            btc.Value2 = null;
            byte[] bytes2 = pb.Energize(btc);
            Assert.AreEqual(
                1 + // btc type ID
                1 + // btc nullable flags
                1 + // Value1 type ID
                1 + // Value 1 boolean
                8,   // Value 1 long
                bytes2.Length
            );
            BaseTypeContainer btc_2 = pb.Energize<BaseTypeContainer>(bytes2);
            Assert.IsNotNull(btc_2);
            Assert.IsNotNull(btc_2.Value1);
            Assert.AreEqual(true, btc_2.Value1.BooleanValue);
            Assert.IsInstanceOf(typeof(DerivedType1), btc_2.Value1);
            Assert.AreEqual(123L, ((DerivedType1)btc_2.Value1).LongValue); 
            Assert.IsNull(btc_2.Value2);

            btc.Value1 = null;
            byte[] bytes3 = pb.Energize(btc);
            Assert.AreEqual(
                1 + // btc type ID
                1,  // btc nullable flags
                bytes3.Length
            );
            BaseTypeContainer btc_3 = pb.Energize<BaseTypeContainer>(bytes3);
            Assert.IsNotNull(btc_3);
            Assert.IsNull(btc_3.Value1);
            Assert.IsNull(btc_3.Value2);

        }

        [Test()]
        public void TestNullableBitFlags() {
            //bool[] isNull = new bool[]{true, false, true, true, false, false};
            //bool[] isNull = new bool[] { false, false, false, false, false, false };
            //bool[] isNull = new bool[] { true, true, true, true, true, true };
            //bool[] referenceExists = new bool[] { true, false, false, false, false, false, false, true };
            bool[] referenceExists = new bool[] { true };
            //bool[] referenceExists = new bool[] { 
            //    true, false, false, false, false, false, false, true,
            //    true, false, false, false, false, false, false, true 
            //};

            byte[] bytes = new byte[] { 0, 0, 0 };
            int index = -1;
            int place = 7;

            for (int b = 0; b < referenceExists.Length; b++) {
                if (b % 8 == 0) {
                    bytes[++index] = 0;
                    place = 7;
                }
                if (referenceExists[b]) {
                    bytes[index] |= (byte)(1 << place);
                }
                place--;
            }

            Console.WriteLine(bytes[0] + "," + bytes[1]);
        }

        [Test()]
        public void TestNullableList() {
            NullableTestPatternBuffer pb = new NullableTestPatternBuffer(4096);
            ListContainer lc = new ListContainer();
            lc.IntList = null;
            byte[] bytes1 = pb.Energize(lc);
            Assert.AreEqual(2, bytes1.Length);

            lc.IntList = new List<int>() {1, 2, 3, 4, 5, 6};
            byte[] bytes2 = pb.Energize(lc);
            Assert.AreEqual(
                1 +     // ListContainer type ID
                1 +     // nullable fields flags
                1 +     // list count
                4 * 6,  // integers
                bytes2.Length
            );

        }

        [Test()]
        public void TestNullableSet() {
            NullableTestPatternBuffer pb = new NullableTestPatternBuffer(4096);
            SetContainer sc = new SetContainer();
            sc.IntSet = null;
            byte[] bytes1 = pb.Energize(sc);
            Assert.AreEqual(2, bytes1.Length);

            sc.IntSet = new HashSet<int>() { 1, 2, 3, 4, 5, 6 };
            byte[] bytes2 = pb.Energize(sc);
            Assert.AreEqual(
                1 +     // ListContainer type ID
                1 +     // nullable fields flags
                1 +     // set count
                4 * 6,  // integers
                bytes2.Length
            );

        }

        [Test()]
        public void TestNullableMap() {
            NullableTestPatternBuffer pb = new NullableTestPatternBuffer(4096);
            MapContainer mc = new MapContainer();
            mc.IntShortMap = null;
            byte[] bytes1 = pb.Energize(mc);
            Assert.AreEqual(2, bytes1.Length);

            mc.IntShortMap = new Dictionary<int, short>();
            mc.IntShortMap[1] = (short)10;
            mc.IntShortMap[2] = (short)20;
            mc.IntShortMap[3] = (short)30;
            byte[] bytes2 = pb.Energize(mc);
            Assert.AreEqual(
                1 +     // MapContainer type ID
                1 +     // nullable fields flags
                1 +     // map key count
                4 * 3 +  // integers
                1 +     // map value count
                2 * 3,  // shorts
                bytes2.Length
            );

        }

        [Test()]
        public void TestIntThingContainerMap() {
            NullableTestPatternBuffer pb = new NullableTestPatternBuffer(4096);
            IntThingContainerMap mc = new IntThingContainerMap();
            mc.TheMap = null;
            byte[] bytes1 = pb.Energize(mc);
            Assert.AreEqual(2, bytes1.Length);

            mc.TheMap = new Dictionary<int, ThingContainer>();
            mc.TheMap[1] = new ThingContainer();
            mc.TheMap[1].Thing1 = new Thing(1);
            mc.TheMap[2] = new ThingContainer();
            mc.TheMap[3] = new ThingContainer();
            mc.TheMap[3].Thing1 = new Thing(3);
            byte[] bytes2 = pb.Energize(mc);
            Assert.AreEqual(
                1 +     // IntThingContainerMap type ID
                1 +     // IntThingContainerMap fields flags
                1 +     // map key count
                4 * 3 + // ints

                1 +     // map value count
                2 +     // IntThingContainerMap[1] fields flags
                4*2 +   // IntThingContainerMap[1] ints
                4 +     // IntThingContainerMap[1].Thing1
                
                2 +     // IntThingContainerMap[2] fields flags
                4 * 2 + // IntThingContainerMap[2] ints
                0 +     // IntThingContainerMap[2].Thing1

                2 +     // IntThingContainerMap[3] fields flags
                4 * 2 + // IntThingContainerMap[3] ints
                4,      // IntThingContainerMap[3].Thing1

                
                bytes2.Length
            );

        }

    }

}