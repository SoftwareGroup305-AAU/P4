using Antlr4.Runtime.Misc;

namespace P4.TinyCell.Shared.Utilities
{
    public static class TcDirector
    {
        public static void ParseArgs(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Too few arguments provided. Please provide a source file and an output file. Example: tcc <source file>");
                Environment.Exit(0);
            }
            if (args[1] != "-o")
            {
                Console.WriteLine("Invalid argument provided. Please provide a source file and an output file. Example: tcc <source file>");
                foreach (var arg in args)
                {
                    Console.WriteLine(arg);
                }
                Environment.Exit(0);
            }
            string workingDirectory = Environment.CurrentDirectory;
            var sourcceFilePath = args[0];
            var outputFilePath = args[2];
            if (Path.IsPathRooted(sourcceFilePath))
            {
                ArgsConfiguration.SourceFile = sourcceFilePath;
            }
            else
            {
                ArgsConfiguration.SourceFile = Path.Combine(workingDirectory, sourcceFilePath);
            }
            // if (Path.IsPathRooted(outputFilePath))
            // {
               // ArgsConfiguration.OutputFile = outputFilePath;
            // }
            // else
            // {
            //     ArgsConfiguration.outputFile = outputFilePath; //Path.Combine(workingDirectory, outputFilePath);
            // }
        }

        private static void SanitizePaths(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].Contains("\""))
                {
                    args[i] = args[i].Replace("\"", "");
                }
            }
        }
    }
}