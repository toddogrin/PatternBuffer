using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;
using PatternBuffer.Schema;
using CommandLine;
using System.IO;
using PatternBuffer.Compiler;
using System.Text.RegularExpressions;

namespace PatternBuffer.Compiler {

    /**
     * A command line application that can be invoked to compile one or more ".pb" schema files into
     * PatternBuffer implementation classes.
     */
    class PatternBufferCompilerProgram {

        /**
         * The main method that performs cues up the compiler args, gathers files, and feeds it all
         * to the actual compiler object.
         */
        static void Main(string[] args) {

            // For timing purposes. It's like totally fast, though, don't worry.
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Gather the command line args
            PatternBufferCompilerCommandLine commandLine = new PatternBufferCompilerCommandLine(args);
            if (commandLine.DoPrintUsage || commandLine.HasMissingRequiredCommandLineOptions) {
                Environment.Exit(0);
            }

            // Load the specified file(s)
            IList<string> schemaFiles = GatherSchemaFiles(commandLine);
            if (schemaFiles.Count == 0) {
                Console.WriteLine("No input file(s) found.");
                Environment.Exit(1);
            }

            // Verify the output path exists
            string outputDirectory = commandLine.OutputDirectory;
            if (commandLine.OutputDirectory == null) {
                outputDirectory = "./";
            }
            else if (Directory.Exists(commandLine.OutputDirectory)) {
                outputDirectory = commandLine.OutputDirectory;
            }
            else { 
                Console.WriteLine("Specified output directory does not exist.");
                Environment.Exit(1);
            }

            // Append a directory separator if it's missing
            if ( ! (outputDirectory.EndsWith(""+Path.AltDirectorySeparatorChar) || outputDirectory.EndsWith("" + Path.DirectorySeparatorChar))) {
                outputDirectory += Path.AltDirectorySeparatorChar;
            }

            // Concatenate all the schema files
            string schemaText = "";
            // A little flag to ignore multiple "name" directives.
            bool nameFound = false;
            foreach (string file in schemaFiles) {
                Console.WriteLine(file);
                string[] allLines = File.ReadAllLines(file);
                foreach (string line in allLines) {
                    string temp = line.Trim();
                    
                    // Remember the schema name if you haven't seen one yet.
                    if (temp.StartsWith("name")) {
                        if (!nameFound) {
                            schemaText += line;
                            schemaText += "\r\n";
                            nameFound = true;
                        }
                    }
                    // Otherwise, not a name line... append and move on.
                    else {
                        schemaText += line;
                        schemaText += "\r\n";
                    }
                }
            }

            // Load the schema
            PatternBufferSchemaParser loader = new PatternBufferSchemaParser();
            PatternBufferSchema schema = loader.Parse(schemaText);

            // Create a compiler with the proper namespace
            string @namespace = 
                commandLine.CSharpNamespace != null ? 
                commandLine.CSharpNamespace : 
                schema.Name;
            PatternBufferCompiler compiler = new PatternBufferCompiler(@namespace);

            // Compile
            Dictionary<string, string> files = compiler.Compile(schema);

            // Save all the files.
            foreach (string fileName in files.Keys) {
                Console.WriteLine("writing to " + outputDirectory + fileName);
                if (fileName.Contains("/")) {
                    string subdirectory = outputDirectory + fileName;
                    subdirectory = subdirectory.Substring(0, subdirectory.LastIndexOf("/"));
                    if ( ! Directory.Exists(subdirectory)) {
                        Console.WriteLine("creating " + subdirectory);
                        Directory.CreateDirectory(subdirectory);
                    }
                }
                File.WriteAllText(outputDirectory + fileName, files[fileName]);
            }

            stopwatch.Stop();
            Console.WriteLine("\nCompiled " + files.Count + " files in " + stopwatch.ElapsedMilliseconds + " ms.");
        }

        /**
         * Consults the command line arguments for instructions on how and where to locate schema files,
         * reads those files in, and returns them.
         */
        static IList<string> GatherSchemaFiles(PatternBufferCompilerCommandLine commandLine) {
            // Load the specified file(s)
            IList<string> schemaFiles = new List<string>();
            Console.WriteLine(commandLine.Input);

            // Is it a directory?
            if (Directory.Exists(commandLine.Input)) {

                // Collect all the files from the directory (and subdirectories if requested)
                string[] patternBufferFiles =
                    Directory.GetFiles(
                        commandLine.Input,
                        "*.pb",
                        commandLine.DoRecurseSubdirectories ?
                            SearchOption.AllDirectories :
                            SearchOption.TopDirectoryOnly
                    );

                // Add them to the list
                foreach (string patternBufferFile in patternBufferFiles) {
                    schemaFiles.Add(patternBufferFile);
                }
            }

            // Is it a file?
            else if (File.Exists(commandLine.Input)) {
                schemaFiles.Add(commandLine.Input);
            }

            return schemaFiles;
        }

    }


}
