public class InputProcessor 
{
    private readonly Robot robot = new Robot();

    public void Execute(string input)
    {
        var inputParts = input.Split(' ');
        
        if(inputParts.Length == 0)
        {
            Console.WriteLine($"Invalid input.");
            return;
        }

        switch(inputParts[0].ToUpper())
        {
            case "PLACE" : 
                Console.WriteLine($"PLACE");
                break;
            case "MOVE" : 
                Console.WriteLine($"MOVE");
                break;
            case "LEFT" :
                Console.WriteLine($"LEFT");
                break;
            case "RIGHT" :
                Console.WriteLine($"RIGHT");
                break;
            case "REPORT" :
                Console.WriteLine($"REPORT");
                break;

        }
    }

}