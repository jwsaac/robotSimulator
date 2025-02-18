var processor = new InputProcessor();


//If no arguments passed, run interactive mode
if (args.Length == 0)
{
    Console.WriteLine("Enter commands ('EXIT' to quit)");
    while (true)
    {
        var input = Console.ReadLine();
        input = input?.Trim();
        if (input?.ToUpper() == "EXIT") break;
        processor.Execute(input);
    }
}
else 
{
    var file = args[0];

    if (!File.Exists(file))
    {
        Console.WriteLine("File does not exist.");
        return;
    }

    var lines = File.ReadAllLines(file);
    foreach (var line in lines)
    {
        if (line.ToUpper() == "EXIT") break;
        processor.Execute(line);
    }
}

