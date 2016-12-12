using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using PatternBuffer.Schema;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class PatternBufferSchemaParserTest : BasePatternBufferTest {

        [Test()]
        public void TestASimpleTypeWorks() {
            string s = @"
                // comment
                name MySchema;
                type(123) MyType {
                    [foo.bar = XwhateverX]
	                int a;
                    bool b;
                }
            ";
            s = s.Replace('X', '"');
            PatternBufferSchema schema = this.Parse(s);
            Assert.That(schema.Name, Is.EqualTo("MySchema"));
            Assert.That(schema.Enums.Count, Is.EqualTo(0));
            Assert.That(schema.Types.Count, Is.EqualTo(1));
            Assert.That(schema.Hints.Count, Is.EqualTo(0));
            PatternBufferType t = schema.Types[0];
            Assert.That(t.HintCount, Is.EqualTo(1));
            Assert.That(t.Name, Is.EqualTo("MyType"));
            Assert.That(t.TypeId, Is.EqualTo(123));
            Assert.That(t.Fields.Count, Is.EqualTo(2));
            Assert.That(HasPrimitiveField(t, "a", PrimitiveType.Int), Is.True);
            Assert.That(HasPrimitiveField(t, "b", PrimitiveType.Bool), Is.True);
            Assert.That(HasHint(t, "foo.bar", "whatever"), Is.True);
        }
        
        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestABadTypeNameThrows() {
            string s = @"
                name MySchema;
                type(123) _MyType {
	                int a;
                }
            ";
            s = s.Replace('X', '"');
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        public void TestReferenceFieldWorks() {

            string s = @"
                name MySchema;
                enum MyEnum1 {
	                value1,
	                value2,
	                value3
                }
                type(234) MyObject {
	                MyEnum1 enumValue;
                }
            ";

            s = s.Replace('X', '"');
            PatternBufferSchema schema = this.Parse(s);
            Assert.That(schema.Name, Is.EqualTo("MySchema"));
            Assert.That(schema.Types.Count, Is.EqualTo(1));
            Assert.That(schema.Enums.Count, Is.EqualTo(1));
            Assert.That(schema.Hints.Count, Is.EqualTo(0));
            PatternBufferType t = schema.Types[0];
            Assert.That(t.Name, Is.EqualTo("MyObject"));
            Assert.That(t.TypeId, Is.EqualTo(234));
            Assert.That(t.BaseType, Is.Null);
            Assert.That(HasReferenceField(t, "enumValue", "MyEnum1"), Is.True);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestDuplicateEnumDefinitionThrows() {
            string s = @"
                name MySchema;
                enum E1 {
                    E1A,
                    E1B
                }
                enum E1 {
                    E2A,
                    E2B
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestDuplicateEnumValueThrows() {
            string s = @"
                name MySchema;
                enum E {
                    A,
                    A
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestDuplicateTypeDefinitionThrows() {
            string s = @"
                name MySchema;
                type(1) T1 {
                    int a;
                }
                type(2) T1 {
                    int b;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestDuplicateTypeIdThrows() {
            string s = @"
                name MySchema;
                type(1) T1 {
                    int a;
                }
                type(1) T2 {
                    int b;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestDuplicateTypeAndEnumDefinitionThrows() {
            string s = @"
                name MySchema;
                type(1) T1 {
                    int a;
                }
                enum T1 {
                    foo,
                    bar
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestUndefinedReferenceFieldTypeThrows() {
            string s = @"
                        name MySchema;
                        type(1) T1 {
                            DoesntExist lol;
                        }
                    ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestCircularTypeAncestryThrows() {
            string s = @"
                name MySchema;
                type(1) T1 : T2 {
                    int a;
                }
                type(2) T2 : T3 {
                    int b;
                }
                type(3) T3 : T1 {
                    int c;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestParentingATypeToItselfThrows() {
            string s = @"
                 name MySchema;
                 type(1) T1 : T1 { 
                    int a;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        public void TestFinalFlagIsSetProperly() {
            string s = @"
                 name MySchema;
                 type(1) T1 { 
                    int a;
                 }
                 type(2) T2 : T1 { 
                    int b;
                 }
            ";
            PatternBufferSchema schema = this.Parse(s);
            Assert.That(schema.Name, Is.EqualTo("MySchema"));
            Assert.That(schema.Types.Count, Is.EqualTo(2));
            Assert.That(schema.Enums.Count, Is.EqualTo(0));
            Assert.That(schema.Hints.Count, Is.EqualTo(0));
            Assert.That(schema.GetPatternBufferType("T1").IsFinal, Is.False);
            Assert.That(schema.GetPatternBufferType("T2").IsFinal, Is.True);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestUndefinedAncestorThrows() {
            string s = @"
                name MySchema;
                type(1) T1 : T2 {
                    int a;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestDuplicateFieldNameInATypeThrows() {
            string s = @"
                name MySchema;
                type(1) T1 {
                    int a;
                    int a;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestDuplicateAncestorTypeFieldNameThrows() {
            string s = @"
                name MySchema;
                type(1) T1 : T2 {
                    int a;
                }
                type(2) T2 {
                    int a;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        //[ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestMultipleAbstractObjectDontConflict() {
            string s = @"
                name MySchema;
                type() T1  {
                    int a;
                }
                type(2) T2 : T1 {
                    int b;
                }
                type() S1  {
                    int c;
                }
                type(3) S2 : S1 {
                    int d;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        public void TestEmptyBaseTypeWorks() {
            string s = @"
                name MySchema;
                type() T1  {
                    
                }
                type(2) T2 : T1 {
                    int a;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
            Assert.That(schema.Name, Is.EqualTo("MySchema"));
            Assert.That(schema.Types.Count, Is.EqualTo(2));
            Assert.That(schema.Enums.Count, Is.EqualTo(0));
            Assert.That(schema.Hints.Count, Is.EqualTo(0));
        }

        [Test()]
        public void TestCommentsToEolWork() {
            string s = @"
                // foobara123 90030
                name MySchema;
                // foobarb
                enum E1 { // here
                    // here
                    E1A,
                    // here
                    E1B
                    // here
                } // also here
                // foobarc
            ";
            PatternBufferSchema schema = this.Parse(s);
            Assert.That(schema.Name, Is.EqualTo("MySchema"));
            Assert.That(schema.Types.Count, Is.EqualTo(0));
            Assert.That(schema.Enums.Count, Is.EqualTo(1));
            Assert.That(schema.Hints.Count, Is.EqualTo(0));
            Assert.That(schema.Enums[0].Name, Is.EqualTo("E1"));
            Assert.That(schema.Enums[0].Values[0], Is.EqualTo("E1A"));
            Assert.That(schema.Enums[0].Values[1], Is.EqualTo("E1B"));
        }

        [Test()]
        public void TestCommentsOnTypeFieldToEolWork() {
            string s = @"
                name MySchema;
                type(1) T1  {
                    int a; // foobar1 WRGCJ@(#U@(#3vt#V@ @#TV VT#3tv.t23v.23tv<#$V>
                    int b;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
            Assert.That(schema.Name, Is.EqualTo("MySchema"));
            Assert.That(schema.Types.Count, Is.EqualTo(1));
            Assert.That(schema.Enums.Count, Is.EqualTo(0));
            Assert.That(schema.Hints.Count, Is.EqualTo(0));
            Assert.That(schema.Types[0].Fields.Count, Is.EqualTo(2));
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestUndefinedListArgThrows() {
            string s = @"
                name MySchema;
                type(1) T1  {
                    list<Lol> no;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestEmbeddedAggregateValueArgThrows() {
            string s = @"
                name MySchema;
                type(1) T1  {
                    list<set<int>> no;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestUndefinedSetArgThrows() {
            string s = @"
                name MySchema;
                type(1) T1  {
                    set<Lol> no;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestUndefinedMapKeyArgThrows() {
            string s = @"
                name MySchema;
                type(1) T1  {
                    map<Lol,int> no;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestUndefinedMapValueArgThrows() {
            string s = @"
                name MySchema;
                type(1) T1  {
                    map<int,Lol> no;
                }
            ";
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        [ExpectedException(typeof(PatternBufferSchemaException))]
        public void TestMissingHintQuoteThrows() {
            string s = @"
                name MySchema;
                type(1) T1  {
                    [foobar.schema1=X12345]
                    map<int,Lol> no;
                }
            ";
            s = s.Replace('X', '"');
            PatternBufferSchema schema = this.Parse(s);
        }

        [Test()]
        public void TestAComplexTypeWorks() {

            string s = @"
                // comment
                name MySchema;
                [foobar.schema1=X12345X]
                [foobar.schema2=XABCDEX]
                enum MyEnum1 {
                    [foobar.enum=X12345X]
	                value1,
	                value2,
	                value3
                }

                enum MyEnum2 {
	                valueA,
	                valueB,
	                valueC,
	                valueD
                }
                /*
                 * Comment
                 */
                type(234) MyObject {

                    [foobar.type=X12345X]

	                short shortValue;
	                ushort ushortValue;
	
	                int intValue;
	                uint uintValue;
	
	                long longValue;
	                ulong ulongValue;

	                float floatValue;
	                double doubleValue;

	                bool boolValue;

	                byte byteValue;

	                DerivedObject otherObjectValue;

	                MyEnum1 enumValue;

                    list<int> intList;
                    list<DerivedObject> otherObjectList;
	                list<MyEnum1> myEnumList;

	                set<int> intSet;
	                set<DerivedObject> otherObjectSet;
	                set<MyEnum1> myEnumSet;
	                map<int,string> intStringMap;
                    map<string,DerivedObject> stringOtherObjectMap;
	                map<int,MyEnum1> intMyEnumMap;
                }

                type() AbstractObject {
	                int intValue1;
                }

                type(789) DerivedObject : AbstractObject {
	                int intValue2;
                }
            ";

            s = s.Replace('X', '"');
            PatternBufferSchema schema = this.Parse(s);
            Assert.That(schema.Name, Is.EqualTo("MySchema"));
            Assert.That(schema.Types.Count, Is.EqualTo(3));
            Assert.That(schema.Enums.Count, Is.EqualTo(2));
            Assert.That(schema.Hints.Count, Is.EqualTo(2));

            // Name
            Assert.That(schema.Name, Is.EqualTo("MySchema"));

            // Hints
            Assert.That(schema.Hints.Count, Is.EqualTo(2));
            Assert.That(schema.Hints.ContainsKey("foobar.schema1"), Is.True);
            Assert.That(schema.Hints["foobar.schema1"], Is.EqualTo("12345"));
            Assert.That(schema.Hints.ContainsKey("foobar.schema2"), Is.True);
            Assert.That(schema.Hints["foobar.schema2"], Is.EqualTo("ABCDE"));

            // Enums
            foreach (PatternBufferEnum e in schema.Enums) {
                Assert.IsTrue("MyEnum1".Equals(e.Name) || "MyEnum2".Equals(e.Name));
                if ("MyEnum1".Equals(e.Name)) {
                    Assert.That(e.Values.Count, Is.EqualTo(3));
                    Assert.That(e.Values[0], Is.EqualTo("value1"));
                    Assert.That(e.Values[1], Is.EqualTo("value2"));
                    Assert.That(e.Values[2], Is.EqualTo("value3"));
                    Assert.That(e.HintCount, Is.EqualTo(1));
                    Assert.That(e.GetHint("foobar.enum"), Is.EqualTo("12345"));
                }
                else {
                    Assert.That(e.Values.Count, Is.EqualTo(4));
                    Assert.That(e.Values[0], Is.EqualTo("valueA"));
                    Assert.That(e.Values[1], Is.EqualTo("valueB"));
                    Assert.That(e.Values[2], Is.EqualTo("valueC"));
                    Assert.That(e.Values[3], Is.EqualTo("valueD"));
                    Assert.That(e.HintCount, Is.EqualTo(0));
                }
            }

            // Types
            PatternBufferType abstractObjectPatternBufferType = null;
            foreach (PatternBufferType t in schema.Types) {
                Assert.That("MyObject".Equals(t.Name) || "AbstractObject".Equals(t.Name) || "DerivedObject".Equals(t.Name), Is.True);
                if ("MyObject".Equals(t.Name)) {
                    Assert.That(t.TypeId, Is.EqualTo(234));
                    Assert.That(t.BaseType, Is.Null);
                    Assert.That(t.Fields.Count, Is.EqualTo(21));
                    Assert.That(HasPrimitiveField(t, "shortValue", PrimitiveType.Short), Is.True);
                    Assert.That(HasPrimitiveField(t, "ushortValue", PrimitiveType.UShort), Is.True);
                    Assert.That(HasPrimitiveField(t, "intValue", PrimitiveType.Int), Is.True);
                    Assert.That(HasPrimitiveField(t, "uintValue", PrimitiveType.UInt), Is.True);
                    Assert.That(HasPrimitiveField(t, "longValue", PrimitiveType.Long), Is.True);
                    Assert.That(HasPrimitiveField(t, "ulongValue", PrimitiveType.ULong), Is.True);
                    Assert.That(HasPrimitiveField(t, "floatValue", PrimitiveType.Float), Is.True);
                    Assert.That(HasPrimitiveField(t, "doubleValue", PrimitiveType.Double), Is.True);
                    Assert.That(HasPrimitiveField(t, "boolValue", PrimitiveType.Bool), Is.True);
                    Assert.That(HasPrimitiveField(t, "byteValue", PrimitiveType.Byte), Is.True);
                    Assert.That(HasReferenceField(t, "otherObjectValue", "DerivedObject"), Is.True);
                    Assert.That(HasReferenceField(t, "enumValue", "MyEnum1"), Is.True);
                    Assert.That(HasPrimitiveListField(t, "intList", PrimitiveType.Int), Is.True);
                    Assert.That(HasReferenceListField(t, "otherObjectList", "DerivedObject"), Is.True);
                    Assert.That(HasReferenceListField(t, "myEnumList", "MyEnum1"), Is.True);
                    Assert.That(HasPrimitiveSetField(t, "intSet", PrimitiveType.Int), Is.True);
                    Assert.That(HasReferenceSetField(t, "otherObjectSet", "DerivedObject"), Is.True);
                    Assert.That(HasReferenceSetField(t, "myEnumSet", "MyEnum1"), Is.True);
                    Assert.That(HasMapField(t, "intStringMap", PrimitiveType.Int, PrimitiveType.String), Is.True);
                    Assert.That(HasMapField(t, "stringOtherObjectMap", PrimitiveType.String, "DerivedObject"), Is.True);
                    Assert.That(HasMapField(t, "stringOtherObjectMap", PrimitiveType.Int, "MyEnum1"), Is.True);
                    Assert.That(t.HintCount, Is.EqualTo(1));
                    Assert.That(t.GetHint("foobar.type"), Is.EqualTo("12345"));
                }
                else if ("AbstractObject".Equals(t.Name)) {
                    abstractObjectPatternBufferType = t;
                    Assert.That(t.TypeId, Is.EqualTo(0));
                    Assert.That(t.BaseType, Is.Null);
                    Assert.That(t.Fields.Count, Is.EqualTo(1));
                    Assert.That(HasPrimitiveField(t, "intValue1", PrimitiveType.Int), Is.True);
                    Assert.That(t.HintCount, Is.EqualTo(0));
                }
                else if ("DerivedObject".Equals(t.Name)) {
                    Assert.That(t.TypeId, Is.EqualTo(789));
                    Assert.That(t.BaseType, Is.EqualTo(abstractObjectPatternBufferType));
                    Assert.That(HasPrimitiveField(t, "intValue2", PrimitiveType.Int), Is.True);
                    Assert.That(t.HintCount, Is.EqualTo(0));
                }
            }
        }

        [Test()]
        public void TestVariantTypesWork() {
            string s = @"
                name MySchema;
                type(1) MyType {
                    vushort vushortValue;
                    vint vintValue;    
                    vuint vuintValue;
                    vlong vlongValue;
                    vulong vulongValue;
                }
            ";
            s = s.Replace('X', '"');
            PatternBufferSchema schema = this.Parse(s);
            Assert.That(schema.Name, Is.EqualTo("MySchema"));
            Assert.That(schema.Enums.Count, Is.EqualTo(0));
            Assert.That(schema.Types.Count, Is.EqualTo(1));
            Assert.That(schema.Hints.Count, Is.EqualTo(0));
            PatternBufferType t = schema.Types[0];
            Assert.That(t.HintCount, Is.EqualTo(0));
            Assert.That(t.Name, Is.EqualTo("MyType"));
            Assert.That(t.TypeId, Is.EqualTo(1));
            Assert.That(t.Fields.Count, Is.EqualTo(5));
            Assert.That(HasPrimitiveField(t, "vushortValue", PrimitiveType.VUShort), Is.True);
            Assert.That(HasPrimitiveField(t, "vintValue", PrimitiveType.VInt), Is.True);
            Assert.That(HasPrimitiveField(t, "vuintValue", PrimitiveType.VUInt), Is.True);
            Assert.That(HasPrimitiveField(t, "vlongValue", PrimitiveType.VLong), Is.True);
            Assert.That(HasPrimitiveField(t, "vulongValue", PrimitiveType.VULong), Is.True);
        }

    }
}
