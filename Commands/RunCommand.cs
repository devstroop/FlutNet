using McMaster.Extensions.CommandLineUtils;

namespace FlutNet.Commands{
    public class RunCommand : CommandLineApplication
    {
        public RunCommand(){
            Name = "run";
            Description = "Run the project";
            HelpOption("-?|-h|--help");
        }
    }
}