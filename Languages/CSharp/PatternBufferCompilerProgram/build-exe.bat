ilmerge /lib:"." /target:winexe /closed /v4 /out:pbc-cs.exe PatternBufferCompilerProgram.exe CalithaLib.dll GoldParserEngine.dll CommandLine.dll
copy "pbc-cs.exe" "..\..\_Dist\pbc-cs.exe"