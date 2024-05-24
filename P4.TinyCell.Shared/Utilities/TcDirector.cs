using Antlr4.Runtime.Misc;

namespace P4.TinyCell.Shared.Utilities
{
    public static class TcDirector
    {
        public static void ParseArgs(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Too few arguments provided. Please provide a source file and an output file. Example: tcc <source file> -c <board>");
                Environment.Exit(0);
            }
            
            if (args[1] == "-c")
            {
                if (args.Length > 3)
                {
                    Console.WriteLine("Too many arguments provided. Please provide the following arguments: <source file> -c <board>");
                }

                ArgsConfiguration.Action = "compile";
                ArgsConfiguration.Board = args[2];
            }
            if (args[1] == "-u")
            {
                if (args.Length > 4)
                {
                    Console.WriteLine("Too many arguments provided. Please provide the following arguments: <source file> -u <board> <port>");
                }
                ArgsConfiguration.Action = "upload";
                ArgsConfiguration.Board = args[2];
                ArgsConfiguration.Port = args[3];
            }
            if (args.Length > 4)
            {
                Console.WriteLine("Too many arguments provided. Please provide a source file and optionally -c (compile) or -u (upload). Example: tcc <source file> -u <board> <port>");
                Environment.Exit(0);
            }

            
            
            string workingDirectory = Environment.CurrentDirectory;
            var sourcceFilePath = args[0];

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
        
    }
}