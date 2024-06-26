using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Antlr4.Runtime;
using P4.TinyCell.Shared.Language.AbstractSyntaxTree;
using P4.TinyCell.Shared.Language.CodeGen;
using P4.TinyCell.Shared.Language.Typechecking;
using P4.TinyCell.Shared.Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace P4.TinyCell;

public class CLIRunner
{
    public static void AddExecutePermission(string filePath)
    {
        var startInfo = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            Arguments = $"-c \"chmod +x {filePath}\"",
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
        };

        using (var process = new Process { StartInfo = startInfo })
        {
            process.Start();
            process.WaitForExit();

            if (process.ExitCode != 0)
            {
                var errorMessage = process.StandardError.ReadToEnd();
                throw new Exception($"Failed to add execute permission: {errorMessage}");
            }
        }
    }

    public void CLIEnv()
    {
        string board = "";
        string port = "";

        string command = Console.ReadLine();
        Console.WriteLine("\n");
        switch (command)
        {
            case "compile":
                
                Console.WriteLine(
                    "tcc>> What board would you like to target? (Unsure? Use a board that appears under the 'board list' command)\n");
                board = Console.ReadLine();
                CompileTC(board);
                CLIRunner.ExecuteCommand($"compile ./Arduino/Arduino.ino -b {board} --build-path ArduinoCompiled");
                Thread.Sleep(2500);
                CLIRunner.ExecuteCommand("");
                break;
            case "upload":
                Console.WriteLine(
                    "tcc>> What board would you like to target? (Unsure? Use the FQBN that appears under the 'board list' command)\n");
                board = Console.ReadLine();
                CompileTC(board);
                Console.WriteLine(
                    "tcc>> Which port would you like to target? (Unsure? Use one that is connected to your board)\n");
                port = Console.ReadLine();
                CLIRunner.ExecuteCommand(
                    $"upload -p {port} --fqbn {board} ./Arduino/Arduino.ino --input-dir ArduinoCompiled");
                Thread.Sleep(2500);
                CLIRunner.ExecuteCommand("");
                break;
            case "monitor":
                Console.WriteLine("tcc>> Which board (port) would you like to listen to?");
                port = Console.ReadLine();
                CLIRunner.ExecuteCommand($"monitor -p {port}");
                break;
            default:
                ExecuteCommand(command);
                break;
        }

        CLIEnv();
    }
    public Task<string> FindLibs(string fc, string board)
    { //todo add 
        string includePattern = @"include\s[A-Za-z0-9]+\;";
        MatchCollection matches;

        Regex defaultRegex = new Regex(includePattern);
        matches = defaultRegex.Matches(fc);
        List<string> matchStrings = new List<string>();
        for (int i = 0; i < matches.Count; i++)
        {
            //don't blame me :(
            matchStrings.Add(matches[i].ToString().Insert(matches[i].ToString().Length - 1, ".h").Replace("include ", "").Replace(";", ""));
        }
        return Task.FromResult(IncludeLibs(matchStrings, board));
    }
    public string IncludeLibs(List<string> libraries, string board)
    {
        string includeDirs = "";
        //Assumes default install could not find correct username??
        Console.WriteLine();

        //Works on linux
        string libLocation = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/.arduino15/libraries";//First pass For standard installed
        for (int i = 0; i < libraries.Count; i++)
        {
            var files = Directory.EnumerateFiles(libLocation, "*.h", SearchOption.AllDirectories).Where(file => Path.GetFileName(file).Equals(libraries[i], StringComparison.OrdinalIgnoreCase));
            //TODO: REPORT AN ERROR IF NO MATCH IS FOUND -> THE LIBRARY IS NOT INSTALLED
            includeDirs += "\n#include \"" + files.First() + "\"\n";
            if (files.Count() == 0)
            {
                Console.WriteLine($"tcc > ERROR: The library {libraries[i]} is not installed!");
            }
            if (files.Count() != 0)
            {
                libraries.RemoveAt(i);
                i--; //Decrement incase we remove an index
            }
        }
        
        //second pass for other standard libs .arduino15/ WE MIGHT NOT NEED THIS PASS
        libLocation = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + $"/.arduino15/packages/arduino/hardware/{board.Split(":")[1]}/1.8.14/libraries";//second pass for other standard installed
        for (int i = 0; i < libraries.Count; i++)
        {
            var files = Directory.EnumerateFiles(libLocation, "*.h", SearchOption.AllDirectories).Where(file => Path.GetFileName(file).Equals(libraries[i], StringComparison.OrdinalIgnoreCase));
            //TODO: REPORT AN ERROR IF NO MATCH IS FOUND -> THE LIBRARY IS NOT INSTALLED
            
            includeDirs += "\n#include \"" + files.First() + "\"\n";
            if (files.Count() == 0)
            {
                Console.WriteLine($"tcc > ERROR: The library {libraries[i]} is not installed!");
            }
            if (files.Count() != 0)
            {
                libraries.RemoveAt(i);
                i--; //Decrement incase we remove an index
            }
        }
        //third pass for custom installed
        //might be for windows
        //string libLocation = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) + "Users\\" + Environment.UserName + "\\Documents\\Arduino\\libraries";
        libLocation = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/Arduino/libraries";
        for (int i = 0; i < libraries.Count; i++)
        {
            var files = Directory.EnumerateFiles(libLocation, "*.h", SearchOption.AllDirectories).Where(file => Path.GetFileName(file).Equals(libraries[i], StringComparison.OrdinalIgnoreCase));
            //TODO: REPORT AN ERROR IF NO MATCH IS FOUND -> THE LIBRARY IS NOT INSTALLED
            includeDirs += "\n#include \"" + files.First() + "\"\n";
            if (files.Count() == 0)
            {
                Console.WriteLine($"tcc > ERROR: The library {libraries[i]} is not installed!");
            }
            if (files.Count() != 0)
            {
                libraries.RemoveAt(i);
                i--; //Decrement incase we remove an index
            }
        }
        return includeDirs;
       // return includeDirs;
        //Console.WriteLine(file)
    }
    //I'm working in here, at line 191 is the issue, it originally was matchContent.Add( matches[i].Value.Trim()+"\r\n");
    private static async Task<List<string>> UpdateIncludes(string includes)
    {
        string[] includeFiles = includes.TrimEnd().TrimStart().Replace("\"", "").Replace("#include ", "").Split('\n');
        //THIS PATTERN IS NOT DONE
        string headerPatterns = @"([A-Za-z]+\(\);)|[ A-Za-z_*1-9]+\s[A-Za-z]+\([^)]*\);";
        string classPattern = @"class [a-zA-Z0-9_]+";
        MatchCollection matches;
        MatchCollection ClassMatches;
        List<string> matchContent = new List<string>();
        List<string> ClassContent = new List<string>();

        int counter = 0;
        foreach (var file in includeFiles)
        {
            string headerContents = File.ReadAllText(file);
            matches = Regex.Matches(headerContents, headerPatterns, RegexOptions.Multiline);
            
            ClassMatches = Regex.Matches(headerContents, classPattern, RegexOptions.Multiline);
            for (int i = 0; i < ClassMatches.Count; i++)
            {
                ClassContent.Add(ClassMatches[i].Value.Replace("class ", "").Trim()+"\r\n");
                Console.WriteLine(ClassContent[i]);
            }
            for (int i = 0; i < matches.Count; i++)
            {
                int insertAt = matches[i].Value.IndexOf(" ");
                matchContent.Add( matches[i].Value.Trim().Insert(insertAt, ClassContent[counter].ToLower() + ".")+"\r\n");
            }

            counter++;
        }
        
        //defaults + all found
        string include = "void print(string text);\r\nvoid initSerial(int BaudRate);\r\nvoid delay(int ms);\r\nint millis();\r\n";
        
        include += string.Join("", matchContent.Where(s => !string.IsNullOrEmpty(s)));
        include = await EnsureCompatability(include);
        await File.WriteAllTextAsync("default.tcl", include);
        return ClassContent;
    }

    /*Converts datatypes*/
    private static async Task<string> EnsureCompatability(string include)
    {
        //testing
        include = include.Replace(";\r\nStepper(int number_of_steps, int motor_pin_1, int motor_pin_2);\r\nStepper(int number_of_steps, int motor_pin_1, int motor_pin_2,\n                                 int motor_pin_3, int motor_pin_4);\r\nStepper(int number_of_steps, int motor_pin_1, int motor_pin_2,\n                                 int motor_pin_3, int motor_pin_4,\n                                 int motor_pin_5);",";");
        //works
        include = include.Replace("(void)", "()");//This can be nothing, cause some weird library authors thinks func(void); is okay to do :(
        include = include.Replace("word", "int"); //An int of at least 16 bits
        include = include.Replace("unsigned int", "int");   
        include = include.Replace("byte", "int");//Not the same
        include = include.Replace("double", "float");//Not the same
        include = include.Replace("unsigned long", "int");
        include = include.Replace("long", "int");//Not the same
        include = include.Replace("short", "int");//This should not be that common they seem to actually be the same according to the docs?
        include = include.Replace("size_t", "int");//Not the same
        include = include.Replace("unsigned char", "string");//A one byte char
        include = include.Replace("char", "string");//Not the same but should actually be valid


        return include;
    }
        
public async void CompileTC(string board)
{
    string workingDirectory = Environment.CurrentDirectory;

    string fileContent = File.ReadAllText(ArgsConfiguration.SourceFile);
    string includes = await FindLibs(fileContent, board);
    
    List<string> classList = await UpdateIncludes(includes);
    
    string replacePattern = @"include\s[A-Za-z0-9]+\;";

    Regex defaultRegex = new Regex(replacePattern);
    fileContent = defaultRegex.Replace(fileContent, "");

    var antlrInputStream = new AntlrInputStream(fileContent);

    var lexer = new TinyCellLexer(antlrInputStream);

    var tokenStream = new CommonTokenStream(lexer);

    tokenStream.Fill();

    var tokens = tokenStream.GetTokens();
#if DEBUG
    foreach (var token in tokens)
    {
        int tokenType = token.Type - 1;
        string ruleName = tokenType >= 0 && tokenType < TinyCellLexer.ruleNames.Length
            ? TinyCellLexer.ruleNames[tokenType]
            : "Unknown";
        Console.WriteLine(token + " | " + ruleName + " | " + token.Text);
    }

#endif
    var parser = new TinyCellParser(tokenStream);

    parser.AddErrorListener(new ParserHelper.NoErrorListener());

    var tree = parser.document();
#if DEBUG
    Console.WriteLine("\n=================================================\n");
    Console.WriteLine("Tokens:");

    foreach (var token in tokens)
    {
        int tokenType = token.Type - 1;
        string ruleName = tokenType >= 0 && tokenType < TinyCellLexer.ruleNames.Length
            ? TinyCellLexer.ruleNames[tokenType]
            : "Unknown";
        Console.WriteLine(token + " | " + ruleName + " | " + token.Text);
    }

    Console.WriteLine("\n=================================================\n");
    Console.WriteLine("Parse Tree:");

    ParserHelper.PrintTree(tree);
#endif
    AstBuilderVisitor astBuilderVisitor = new();
    AstNode abcd = astBuilderVisitor.Visit(tree);
#if DEBUG
    Console.WriteLine(abcd.ToString());
#endif
    var typeChecker = new TypeCheckerVisitor();
    typeChecker.Visit(abcd);

    TestAstVisitor test = new();
    test.VisitRootNode((RootNode)abcd);

    CGeneratorVisitor cGeneratorVisitor = new();

    string ccode = cGeneratorVisitor.Visit(abcd);
    ccode = ccode.Insert(20, includes);
    try
    {
        string arduinoDir = "Arduino";
        if (!Directory.Exists(arduinoDir))
        {
            Directory.CreateDirectory(arduinoDir);
            Console.WriteLine("Created directory: Arduino");
        }

        using StreamWriter sw = File.CreateText($"Arduino/Arduino.ino");
        sw.Write(ccode);
#if DEBUG
        Console.WriteLine(ccode);
#endif
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An error occurred: {ex.Message}");
    }
}

public static void ExecuteCommand(string command)
{
    Console.WriteLine("\n");
    var processInfo = new ProcessStartInfo("Arduino-CLI/arduino-cli", command)
    {
        CreateNoWindow = true,
        UseShellExecute = false,
        RedirectStandardError = true,
        RedirectStandardOutput = true
    };
    //processInfo.WorkingDirectory = Environment.CurrentDirectory+"/Arduino-CLI/";
    var process = Process.Start(processInfo);

    process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
        Console.WriteLine("tcc> " + e.Data);
    process.BeginOutputReadLine();

    process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
        Console.WriteLine("tcc error> " + e.Data);
    process.BeginErrorReadLine();

    process.WaitForExit();

    process.Close();
    Console.WriteLine("\n");
}
}