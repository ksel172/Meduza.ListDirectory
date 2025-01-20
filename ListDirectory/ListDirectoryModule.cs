using Agent.ModuleBase;

namespace ListDirectory
{
    public class ListDirectoryModule : IModule
    {
        public string Name => "ListDirectoryModule";

        public string Author => "@reptar";

        public string Description => "A module for listing directories";

        public string FileName => "ListDirectoryModule.dll";

        public string Usage => "ListDirectory - lists directories";

        public List<ICommand> Commands { get; set; } = [];
    }
}
