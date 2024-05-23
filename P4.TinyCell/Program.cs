using System.Runtime.InteropServices;
using Antlr4.Runtime;
using P4.TinyCell;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.CodeGen;
using P4.TinyCell.Shared.Language.Typechecking;
using P4.TinyCell.Shared.Utilities;

// dotnet publish -c Release -r win-x64 --self-contained true
// dotnet publish -c Release -r linux-x64 --self-contained true
// dotnet publish -c Release -r osx-x64 --self-contained true
// dotnet publish -c Release -r osx-arm64 --self-contained true

// dotnet add package SharpZipLib --version 1.3.3

internal class Program
{
    private static async Task Main(string[] args)
    {
        string workingDirectory = Environment.CurrentDirectory;
        string projectDirectory = new DirectoryInfo(workingDirectory).FullName;
        //TcDirector.ParseArgs(args);

        //string fileContent = File.ReadAllText(ArgsConfiguration.SourceFile);

        string fileContent = File.ReadAllText("test.tc");

        var antlrInputStream = new AntlrInputStream(fileContent);

        var lexer = new TinyCellLexer(antlrInputStream);

        var tokenStream = new CommonTokenStream(lexer);

        tokenStream.Fill();

        var tokens = tokenStream.GetTokens();

        foreach (var token in tokens)
        {
            int tokenType = token.Type - 1;
            string ruleName = tokenType >= 0 && tokenType < TinyCellLexer.ruleNames.Length ? TinyCellLexer.ruleNames[tokenType] : "Unknown";
            Console.WriteLine(token + " | " + ruleName + " | " + token.Text);
        }

        var parser = new TinyCellParser(tokenStream);

        parser.AddErrorListener(new ParserHelper.NoErrorListener());

        var tree = parser.document();

        Console.WriteLine("\n=================================================\n");
        Console.WriteLine("Tokens:");

        foreach (var token in tokens)
        {
            int tokenType = token.Type - 1;
            string ruleName = tokenType >= 0 && tokenType < TinyCellLexer.ruleNames.Length ? TinyCellLexer.ruleNames[tokenType] : "Unknown";
            Console.WriteLine(token + " | " + ruleName + " | " + token.Text);
        }

        Console.WriteLine("\n=================================================\n");
        Console.WriteLine("Parse Tree:");

        ParserHelper.PrintTree(tree);

        AstBuilderVisitor astBuilderVisitor = new();
        AstNode abcd = astBuilderVisitor.Visit(tree);

        Console.WriteLine(abcd.ToString());

        var typeChecker = new TypeCheckerVisitor();
        typeChecker.Visit(abcd);

        TestAstVisitor test = new();
        test.VisitRootNode((RootNode)abcd);

        CGeneratorVisitor cGeneratorVisitor = new();
        string ccode = cGeneratorVisitor.Visit(abcd);

        try
        {
            string arduinoDir = "Arduino";
            if (!Directory.Exists(arduinoDir))
            {
                Directory.CreateDirectory(arduinoDir);
                Console.WriteLine("Created directory: Arduino");
            }

            //using StreamWriter sw = File.CreateText($"Arduino/{ArgsConfiguration.OutputFile}.ino");
            using StreamWriter sw = File.CreateText($"Arduino/Arduino.ino");
            sw.Write(ccode);
            Console.WriteLine(ccode);

            string arduinoCliDir = "Arduino-CLI";
            if (!Directory.Exists(arduinoCliDir))
            {
                Directory.CreateDirectory(arduinoCliDir);
                Console.WriteLine("Created directory: Arduino-CLI");
            }

            string fileName = ProgramHelper.GetCliFileName();
            string cliFilePath = Path.Combine(arduinoCliDir, fileName);
            if (!File.Exists(cliFilePath))
            {
                Console.WriteLine("Arduino CLI not found, downloading...");
                string downloadUrl = await ProgramHelper.FetchLatestArduinoCliDownloadUrlAsync();
                await ProgramHelper.DownloadFileAsync(downloadUrl, cliFilePath);
                Console.WriteLine("Arduino CLI downloaded successfully!");

                ProgramHelper.ExtractFile(cliFilePath, arduinoCliDir);
                Console.WriteLine("Arduino CLI extracted successfully!");

                if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    CLIRunner.AddExecutePermission("Arduino-CLI/arduino-cli");
                    Console.WriteLine("Execute permission added to Arduino CLI.");
                }
            }
            else
            {
                Console.WriteLine("Arduino CLI already exists.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            CLIRunner.ExecuteCommand("compile ./Arduino/Arduino.ino -b arduino:samd:mkrwifi1010 --build-path ArduinoCompiled");
            CLIRunner.ExecuteCommand("upload -p COM3 --fqbn arduino:samd:mkrwifi1010 Arduino.ino --input-dir ArduinoCompiled");
        }
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
        {
            CLIRunner.ExecuteCommand("compile ./Arduino/Arduino.ino -b arduino:samd:mkrwifi1010 --build-path ArduinoCompiled");
            CLIRunner.ExecuteCommand("upload -p /dev/ttyACM0 --fqbn arduino:samd:mkrwifi1010 Arduino.ino --input-dir ArduinoCompiled");
            CLIRunner.ExecuteCommand("cat -p /dev/ttyACM0");
        }
        if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
        {
            CLIRunner.ExecuteCommand("compile ./Arduino/Arduino.ino -b arduino:samd:mkrwifi1010 --build-path ArduinoCompiled");
            CLIRunner.ExecuteCommand("upload -p /dev/cu.usbmodem21301 --fqbn arduino:samd:mkrwifi1010 Arduino.ino --input-dir ArduinoCompiled");
        }

    }
}
