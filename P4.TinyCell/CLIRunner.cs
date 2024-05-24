using P4.TinyCell.Shared.Utilities;
using System.Diagnostics;
using System.Runtime.InteropServices;

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
        
        switch (command)
        {
            case "compile":
                Console.WriteLine("tcc>> What board would you like to target? (Unsure? Use a board that appears under the 'board list' command)\n");
                board = Console.ReadLine();
                CLIRunner.ExecuteCommand($"compile ./Arduino/{ArgsConfiguration.OutputFile} -b {board} --build-path ArduinoCompiled");
                break;
            case "upload":
                Console.WriteLine("tcc>> What board would you like to target? (Unsure? Use a board that appears under the 'board list' command)\n");
                board = Console.ReadLine();
                Console.WriteLine("tcc>> Which port would you like to target? (Unsure? Use one that is connected to your board)\n");
                port = Console.ReadLine();
                CLIRunner.ExecuteCommand($"upload -p {port} --fqbn {board} {ArgsConfiguration.OutputFile} --input-dir ArduinoCompiled");
                break;
            case "monitor":
                Console.WriteLine("tcc>> Which board (port) would you like to listen to?");
                port = Console.ReadLine();
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    CLIRunner.ExecuteCommand($"cat -p {port}");
                }
                else
                {
                    CLIRunner.ExecuteCommand($"monitor -p {port}");

                }
                break;
            default:
                ExecuteCommand(command);
                break;
        }

        CLIEnv();
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