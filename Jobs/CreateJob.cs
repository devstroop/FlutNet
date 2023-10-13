
using System.Diagnostics;

namespace Jobs.CreateJob
{
    public class CreateJob
    {
        public CreateJob()
        {

        }
        private Process process;
        private string output;
        public void Execute()
        {
            // Check if .NET is installed
            process = new Process();
            process.StartInfo.FileName = "dotnet";
            process.StartInfo.Arguments = "--version";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            System.Console.WriteLine(output);

            // Check Matching version of .NET is installed if specified in command line
            if (!string.IsNullOrEmpty(DotNetVersion))
            {
                process = new Process();
                process.StartInfo.FileName = "dotnet";
                process.StartInfo.Arguments = "--version";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                System.Console.WriteLine(output);
                
                // Prompt user to install matching version of .NET by taking input from user 'y' or 'n'

                
            }

            // Check if Flutter is installed
            process = new Process();
            process.StartInfo.FileName = "flutter";
            process.StartInfo.Arguments = "--version";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            System.Console.WriteLine(output);

            // Check Matching version of flutter is installed if specified in command line
            if (!string.IsNullOrEmpty(FlutterVersion))
            {
                process = new Process();
                process.StartInfo.FileName = "flutter";
                process.StartInfo.Arguments = "--version";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();
                output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                System.Console.WriteLine(output);
                
                // Prompt user to install matching version of flutter by taking input from user 'y' or 'n'

                
            }

            // Check if Flutter is in PATH
            // Check if .NET is in PATH
            // Execute Flutter create
            // Execute .NET new
            // Execute .NET restore
            // Execute .NET build
            // Execute Flutter build
            // Execute Flutter run
            // Manage path of Flutter and .NET
            // Setup Migrated Build Path

        }

        public string DotNetVersion { get; set; } = string.Empty;

        public string FlutterVersion { get; set; } = string.Empty;

    }
}