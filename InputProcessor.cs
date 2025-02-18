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
                var values = inputParts[1].Split(',');
                if (values.Length == 3 &&
                    int.TryParse(values[0], out int x) &&
                    int.TryParse(values[1], out int y) &&
                    Enum.TryParse(values[2].ToUpper(), out Direction direction))
                {
                    robot.Place(x, y, direction);
                }
                break;
            case "MOVE" :
                robot.Move();
                break;
            case "LEFT" :
                robot.Left();
                break;
            case "RIGHT" :
                robot.Right();
                break;
            case "REPORT" :
                Console.WriteLine(robot.Report());
                break;
            default:
                Console.WriteLine($"Invalid input.");
                break;

        }
    }

}