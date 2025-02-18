using System;

public class Robot 
{
    private const int TableSize = 5;
    private bool _isPlaced = false;
    private int _x,_y;
    private Direction _direction;

    public void Place(int x, int y, Direction direction)
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

    public void Move()
    {
        if (!_isPlaced) return;

        int newX = _x, newY = _y;
        switch (_direction)
        {
            case Direction.NORTH: newY++; break;
            case Direction.EAST: newX++; break;
            case Direction.SOUTH: newY--; break;
            case Direction.WEST: newX--; break;
        }

        if (!ValidPosition(newX, newY))
        {
            Console.WriteLine("Robot could not move further, it will fall!");
            return;
        }

        _x = newX;
        _y = newY;
    }

  
    public void Left()
    {
        if (!_isPlaced)
        {
            Console.WriteLine("Robot is not yet placed.");
            return;
        }

        //There might be shorter solution than this, but I think this will work for now :D
        switch (_direction)
        {
            case Direction.NORTH: _direction = Direction.WEST; break;
            case Direction.WEST: _direction = Direction.SOUTH; break;
            case Direction.SOUTH: _direction = Direction.EAST; break;
            case Direction.EAST: _direction = Direction.NORTH; break;
        }
    }

   
    public void Right()
    {
        if (!_isPlaced)
        {
            Console.WriteLine("Robot is not yet placed.");
            return;
        }

        //There might be shorter solution than this, but I think this will work for now :D
        switch (_direction)
        {
            case Direction.NORTH: _direction = Direction.EAST; break;
            case Direction.EAST: _direction = Direction.SOUTH; break;
            case Direction.SOUTH: _direction = Direction.WEST; break;
            case Direction.WEST: _direction = Direction.NORTH; break;
        }
    }

    public string Report()
     {
        return _isPlaced ? $"X={_x},Y={_y},DIRECTION={_direction}" : "Robot not placed.";
     }

    private bool ValidPosition(int x, int y)
    {
        return x >= 0 && x < TableSize && y >= 0 && y < TableSize;
    }


}