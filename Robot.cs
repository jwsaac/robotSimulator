using System;

public class Robot 
{
    private const int TableSize = 5;
    private bool _isPlaced = false;
    private int _x,_y;
    private Direction _direction;

    private void Place(int x, int y, Direction direction)
    {
        
        if(!ValidPosition(x,y)){
            Console.WriteLine($"Invalid position. Table size is {TableSize}x{TableSize}.");
            return;
        }

        _x = x;
        _y = y;
        _direction = direction;
        _isPlaced = true;
        
    }

     public string Report()
     {
        return _isPlaced ? $"{_x},{_y},{_direction}" : "Robot not placed.";
     }

    private bool ValidPosition(int x, int y)
    {
        return x >= 0 && x < TableSize && y >= 0 && y < TableSize;
    }


}