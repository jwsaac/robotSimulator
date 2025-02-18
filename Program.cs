var processor = new InputProcessor();

if(args.Length > 0 && File.Exists(args[0]))
{

}
else 
{
    Console.WriteLine("Enter commands ('EXIT' to quit)");
    while(true)
    {
        var input = Console.ReadLine();
        input = input?.Trim();
        if(input?.ToUpper() == "EXIT") break;
        processor.Execute(input);
    }
}