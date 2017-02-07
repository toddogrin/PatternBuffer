using System;
using System.IO;
using CommandLine;

namespace PatternBuffer.Compiler {

    /**
     * Defines the command line options for the C# PatternBuffer compiler.
     */
    [CommandLineUsage("pbc", "PatternBuffer Compiler v1.0", null)]
    public class PatternBufferCompilerCommandLine : AbstractCommandLine {
        
        [CommandLineOption("The C# namespace to apply to all generated files", false, 'n', "namespace")]
        public string CSharpNamespace { get; protected set; }

        [CommandLineOption(".pb file or directory", true)]
        public string Input { get; protected set; }

        [CommandLineOption("Recursively delve subdirectories", false, 'r', "recurse", "false")]
        public bool DoRecurseSubdirectories { get; protected set; }

        [CommandLineOption("Directory location where all generated filed should be saved", true, 'o', "output")]
        public string OutputDirectory { get; protected set; }

        [CommandLineOption("If true, generated code will include lock statements to ensure thread safety", false, 't', "threadsafe", "false")]
        public bool MakeThreadsafe { get; protected set; }

        [CommandLineOption("Path to a file containing custom boilerplate comment text", true, 'b', "boilerplate", null)]
        public string BoilerplateFilePath { get; protected set; }
        /**
         * Creates an instance of PatternBufferCompilerCommandLine and parses the given args into the 
         * fields defined above.
         */
        public PatternBufferCompilerCommandLine(String[] args) : base(args) { }

        /**
         * Creates an instance of PatternBufferCompilerCommandLine and parses the given args into the 
         * fields defined above.
         * 
         * Any problems encountered are written to the given TextWriter.
         */
        public PatternBufferCompilerCommandLine(String[] args, TextWriter writer) 
        : base(args, writer)
        { }
    }
}