using Meduza.Agent.ModuleBase;

namespace ListDirectory
{
    public class ListDirectoryModule : IModule
    {
        public string Name => "ListDirectoryModule";

        public List<ICommand> Commands { get; set; } = new List<ICommand>();
    }
}
