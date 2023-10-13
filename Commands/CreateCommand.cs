using Jobs.CreateJob;
using McMaster.Extensions.CommandLineUtils;

namespace FlutNet.Commands
{
    public class CreateCommand : CommandLineApplication
    {
        public CreateCommand()
        {
            Name = "create";
            Description = "Create a new project";
            HelpOption("-?|-h|--help");

            OnExecute(() =>
            {
                try
                {
                    CreateJob job = new CreateJob();
                    job.DotNetVersion = DotNetVersion;
                    job.FlutterVersion = FlutterVersion;
                    job.Execute();
                    return 0;
                }
                catch(System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return 1;
                }
            });
        }

        [Option("--dotnet-version", Description = ".NET version to use")]
        public string DotNetVersion { get; set; } = string.Empty;

        [Option("--flutter-version", Description = "Flutter version to use")]
        public string FlutterVersion { get; set; } = string.Empty;
    }
}
