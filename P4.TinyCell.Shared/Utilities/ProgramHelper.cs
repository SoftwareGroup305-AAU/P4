using System.Diagnostics;

namespace P4.TinyCell.Shared.Utilities;

public class ProgramHelper
{
    public void GenerateAntlr()
    {
        try
        {
            string javaCommand = "java";
            string arguments = "-jar ../P4.TinyCell.Shared/Antlr.jar -Dlanguage=CSharp ../P4.TinyCell.Shared/TinycellAntlr/TinyCell.g4 -visitor -listener";

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = javaCommand,
                    Arguments = arguments,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string errors = process.StandardError.ReadToEnd();

            process.WaitForExit();

            Console.WriteLine(output);
            if (!string.IsNullOrEmpty(errors))
            {
                Console.WriteLine("Errors:");
                Console.WriteLine(errors);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred:");
            Console.WriteLine(ex.Message);
        }
    }
}
