// Build: Release, Debug


using McMaster.Extensions.CommandLineUtils;

namespace FlutNet.Commands
{
    public class BuildCommand : CommandLineApplication
    {
        public BuildCommand()
        {
            Name = "run";
            Description = "Run the project";
            HelpOption("-?|-h|--help");

            OnExecute(() =>
            {
                try
                {
                    // RunJob job = new RunJob();
                    // job.Execute();
                    return 0;
                }
                catch(System.Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return 1;
                }
            });
        }
    }
}   