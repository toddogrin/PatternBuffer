using System;
using System.Collections.Generic;
using System.IO;
using PatternBuffer.Schema;
using PatternBuffer.Compiler;
using NUnit.Framework;

namespace PatternBufferTest {

    [TestFixture()]
    public class PatternBufferGeneratorTest {

        [Test()]
        public void TestGenerateEnum() {
            this.Generate("Enum");
        }

        [Test()]
        public void TestGenerateList() {
            this.Generate("List");
        }

        [Test()]
        public void TestGeneratePrimitive() {
            this.Generate("Primitive");
        }

        [Test()]
        public void TestGenerateReference() {
            this.Generate("Reference");
        }

        [Test()]
        public void TestGenerateSet() {
            this.Generate("Set");
        }

        [Test()]
        public void TestGenerateMap() {
            this.Generate("Map");

        }
        protected void Generate(string name) {
            PatternBufferSchemaParser loader = new PatternBufferSchemaParser(@"..\..\..\..\..\PatternBuffer.cgt");
            string pbFile = @"..\..\Generation\" + name + @".pb";
            string schemaSource = File.ReadAllText(pbFile);
            PatternBufferSchema schema = loader.Parse(schemaSource);
            Console.WriteLine(schema.Name);
            PatternBufferCompiler compiler = new PatternBufferCompiler("Test." + name);
            Dictionary<string, string> files = compiler.Compile(schema);

            Console.WriteLine(files.Count + " files generated");

            string directory = @"..\..\..\PatternBufferGeneratedTest\" + name + @"\Generated";
            if (Directory.Exists(directory)) {
                Directory.Delete(directory, true);
            }
            Directory.CreateDirectory(directory);
            foreach (string fileName in files.Keys) {
                Console.WriteLine("writing to " + fileName);
                File.WriteAllText(directory + @"\" + fileName, files[fileName]);
            }
        }

    }

}