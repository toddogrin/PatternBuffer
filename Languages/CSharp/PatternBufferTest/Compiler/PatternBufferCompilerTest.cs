using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NUnit.Framework;
using PatternBuffer.Schema;
//using PatternBuffer.Compiler;

namespace PatternBufferTest.Schema {

    [TestFixture()]
    public class PatternBufferCompilerTest : BasePatternBufferTest {

        [Test()]
        public void TestCompilingAComplexSchemaWorks() {

//            string s = @"
//                // comment
//                name MySchema;
//                
//                enum MyEnum1 {
//                    [pb.path = XEnums1X]
//	                value1,
//	                value2,
//	                value3
//                }
//
//                enum MyEnum2 {
//                    [pb.path=XEnums2X]
//	                valueA,
//	                valueB,
//	                valueC,
//	                valueD
//                }
//                /*
//                 * Comment
//                 */
//                type(234) MyObject {
//
//                    [pb.path=XObjects1X]
//
//	                short shortValue;
//	                ushort ushortValue;
//	
//	                int intValue;
//	                uint uintValue;
//	
//	                long longValue;
//	                ulong ulongValue;
//
//	                float floatValue;
//	                double doubleValue;
//
//	                bool boolValue;
//
//	                byte byteValue;
//
//	                DerivedObject otherObjectValue;
//
//	                MyEnum1 enumValue;
//
//                    list<int> intList;
//                    list<DerivedObject> otherObjectList;
//	                list<MyEnum1> myEnumList;
//
//	                set<int> intSet;
//	                set<DerivedObject> otherObjectSet;
//	                set<MyEnum1> myEnumSet;
//	                map<int,string> intStringMap;
//                    map<string,DerivedObject> stringOtherObjectMap;
//	                map<int,MyEnum1> intMyEnumMap;
//                }
//
//                type() AbstractObject {
//                    [pb.path=XObjects2X]
//	                int intValue1;
//                }
//
//                type(789) DerivedObject : AbstractObject {
//                    [pb.path=XObjects3X]
//	                int intValue2;
//                }
//            ";

//            s = s.Replace('X', '"');

//            // Basic schema validation (don't need to check the whole thing, just verify path hints)

//            PatternBufferSchema schema = this.Parse(s);
//            Assert.That(schema.Name, Is.EqualTo("MySchema"));
//            Assert.That(schema.Types.Count, Is.EqualTo(3));
//            Assert.That(schema.Enums.Count, Is.EqualTo(2));
//            Assert.That(schema.Hints.Count, Is.EqualTo(0));

//            // Enums
//            foreach (PatternBufferEnum e in schema.Enums) {
//                Assert.IsTrue("MyEnum1".Equals(e.Name) || "MyEnum2".Equals(e.Name));
//                if ("MyEnum1".Equals(e.Name)) {
//                    Assert.That(e.HintCount, Is.EqualTo(1));
//                    Assert.That(e.GetHint("pb.path"), Is.EqualTo("Enums1"));
//                }
//                else {
//                    Assert.That(e.HintCount, Is.EqualTo(1));
//                    Assert.That(e.GetHint("pb.path"), Is.EqualTo("Enums2"));
//                }
//            }

//            // Types
//            PatternBufferType abstractObjectPatternBufferType = null;
//            foreach (PatternBufferType t in schema.Types) {
//                Assert.IsTrue("MyObject".Equals(t.Name) || "AbstractObject".Equals(t.Name) || "DerivedObject".Equals(t.Name));
//                if ("MyObject".Equals(t.Name)) {
//                    Assert.That(t.HintCount, Is.EqualTo(1));
//                    Assert.That(t.GetHint("pb.path"), Is.EqualTo("Objects1"));
//                }
//                else if ("AbstractObject".Equals(t.Name)) {
//                    abstractObjectPatternBufferType = t;
//                    Assert.That(t.HintCount, Is.EqualTo(1));
//                    Assert.That(t.GetHint("pb.path"), Is.EqualTo("Objects2"));
//                }
//                else if ("DerivedObject".Equals(t.Name)) {
//                    Assert.That(t.HintCount, Is.EqualTo(1));
//                    Assert.That(t.GetHint("pb.path"), Is.EqualTo("Objects3"));
//                }
//            }

//            // Now compile
//            PatternBufferCompiler compiler = new PatternBufferCompiler("Test.Whatever");
//            Dictionary<string,string> results = compiler.Compile(schema);

//            // Verify which files were created
//            List<string> expectedFiles = new List<string>() {
//                "Enums1/MyEnum1.cs",
//                "Enums2/MyEnum2.cs",
//                "Objects1/IMyObject.cs",
//                "Objects1/MyObject.cs",
//                "Objects1/MyObjectSerializer.cs",
//                "Objects2/IAbstractObject.cs",
//                "Objects2/AbstractObject.cs",
//                "Objects3/IDerivedObject.cs",
//                "Objects3/DerivedObject.cs",
//                "Objects3/DerivedObjectSerializer.cs",
//                "MySchemaPatternBuffer.cs"
//            };
            
//            foreach (string filePath in results.Keys) {
//                // Make sure the generated path/file was expected.
//                Assert.That(expectedFiles.Contains(filePath), Is.True);
//                expectedFiles.Remove(filePath);
//            }
//            // Make sure all expected files were there.
//            Assert.That(expectedFiles.Count, Is.EqualTo(0));
        }


    }
}
