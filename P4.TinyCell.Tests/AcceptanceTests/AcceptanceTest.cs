using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace P4.TinyCell.Tests.AcceptanceTests;

public class AcceptanceTest
{
    [Fact]
    [Description("Tests the full compilation flow from executing the TinyCell compiler to generating Arduino C code")]
    public void CompilerExecution()
    {
        string workingDirectory = Environment.CurrentDirectory;
        string netDirectory = new DirectoryInfo(workingDirectory).FullName;

        Assert.True(Directory.Exists(netDirectory));

        string arduinoFolder = "Arduino";
        string arduinoCliFolder = "Arduino-CLI";

        string executableFileName = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? "tcc.exe" : "tcc";

        string tccExecutablePath = Path.Combine(netDirectory, executableFileName);

        string sourceFilePath = Path.Combine(netDirectory, "Test.tc");

        string expectedOutputPath = Path.Combine(netDirectory, arduinoFolder);

        File.WriteAllText(sourceFilePath, @"
            include default.tcl;
            dpin ledPin = 6;

            setup {
                set ledPin to OUTPUT;
            }

            update {
                write HIGH to ledPin;
                delay(1000);
                write LOW to ledPin;
                delay(1000);
            }
        ");

        ProcessStartInfo startInfo = new ProcessStartInfo()
        {
            FileName = tccExecutablePath,
            Arguments = $"\"{sourceFilePath}\" -o \"output\"",
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process process = Process.Start(startInfo);
        process.WaitForExit();

        Assert.True(Directory.Exists(arduinoFolder));
        Assert.True(Directory.Exists(arduinoCliFolder));

        Assert.True(File.Exists(Path.Combine(expectedOutputPath, "output.ino")));

        string outputContent = File.ReadAllText(Path.Combine(expectedOutputPath, "output.ino"));
        Assert.Contains("pinMode(ledPin, OUTPUT);", outputContent);
        Assert.Contains("digitalWrite(ledPin, HIGH);", outputContent);

        File.Delete(sourceFilePath);

        Directory.Delete(arduinoFolder, recursive: true);
        Directory.Delete(arduinoCliFolder, recursive: true);
    }
}