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

    public static void ExecuteCommand(string command)
    {
        var processInfo = new ProcessStartInfo("Arduino-CLI/arduino-cli", command)
        {
            CreateNoWindow = true,
            UseShellExecute = false,
            RedirectStandardError = true,
            RedirectStandardOutput = true
        };

        var process = Process.Start(processInfo);

        process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
            Console.WriteLine("output>>" + e.Data);
        process.BeginOutputReadLine();

        process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
            Console.WriteLine("error>>" + e.Data);
        process.BeginErrorReadLine();

        process.WaitForExit();

        Console.WriteLine("ExitCode: {0}", process.ExitCode);
        process.Close();
    }
}