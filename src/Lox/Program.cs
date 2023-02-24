namespace Lox;
class Lox
{
    static void Main(string[] args)
    {
        if (args.Length > 1)
        {
            Console.WriteLine("LoxC only supports interactive mode or single file compilation");
            Environment.Exit(1);
            return;
        }
        else if (args.Length == 1) 
        {
            var file = new FileInfo(args[0]);
            RunFile(file);
        }
        else
        {
            RunPrompt();
        }
    }

    private static void Run(string source)
    {
        Console.WriteLine($"Running source code:{Environment.NewLine}{source}");
    }

    private static void RunFile(FileInfo file)
    {
        var source = File.ReadAllText(file.FullName);
        Run(source);
    }

    private static void RunPrompt()
    {
        while(true){
            var line = Console.ReadLine();
            if (line is null)
            {
                break;
            }

            Run(line);
        }
    }
}