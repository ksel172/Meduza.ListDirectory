using Agent.ModuleBase;

namespace ListDirectory
{
    public class ListDirectoryCommand : ICommand
    {
        public string Name => "ListDirectory";

        public string Description => "ListDirectory <dir>\nLists the directory given or the current directory if no args.";

        public Stream OutputStream { get; set; } = new MemoryStream();

        public string Execute(string[] args = null)
        {
            var directory = string.Empty;

            if (args is null || args.Length < 1)
            {
                directory = Directory.GetCurrentDirectory();
            }
            else
            {
                directory = args[0];
            }

            // Set up for the output using the stream
            // You have to copy this block of code all the way to "do work here"
            TextWriter realStdOut = Console.Out;
            TextWriter realStdErr = Console.Error;
            StreamWriter stdOutWriter = new StreamWriter(OutputStream);
            StreamWriter stdErrWriter = new StreamWriter(OutputStream);
            stdOutWriter.AutoFlush = true;
            stdErrWriter.AutoFlush = true;
            Console.SetOut(stdOutWriter);
            Console.SetError(stdErrWriter);

            // Do work here
            // You do not have to copy this block of code
            // Any console.writeline here is being queued up and is published to the stream when flushed
            var directoryListing = new List<string>();
            foreach (var dir in Directory.GetDirectories(directory))
            {
                directoryListing.Add(dir);
            }
            foreach (var file in Directory.GetFiles(directory))
            {
                directoryListing.Add(file);
            }

            foreach (var listing in directoryListing)
            {
                Console.WriteLine(listing);
            }

            // Tear down and pushing the data to the stream, then redirecting stdout
            // You have to copy this block of code all the way to the end of the method
            Console.Out.Flush();
            Console.Error.Flush();
            Console.SetOut(realStdOut);
            Console.SetError(realStdErr);

            OutputStream.Close();
            return string.Empty;
        }
    }
}
