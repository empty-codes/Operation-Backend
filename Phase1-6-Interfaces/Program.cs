int commandCount = 0;
Robot robot = new Robot();
Console.WriteLine("You are to enter 3 commands out of the options: on, off, north, south, west, east");

while (commandCount < 3)
{
    Console.Write($"Enter command {commandCount + 1}: ");
    string input = Console.ReadLine();

    switch (input)
    {
        case "on":
            robot.Commands[commandCount] = new OnCommand();
            break;
        case "off":
            robot.Commands[commandCount] = new OffCommand();
            break;
        case "north":
            robot.Commands[commandCount] = new NorthCommand();
            break;
        case "south":
            SouthCommand south = new SouthCommand();
            robot.Commands[commandCount] = south;
            break;
        case "west":
            WestCommand west = new WestCommand();
            robot.Commands[commandCount] = west;
            break;
        case "east":
            EastCommand east = new EastCommand();
            robot.Commands[commandCount] = east;
            break;
        default:
            Console.WriteLine("Error, enter commands: on, off, north, south, west or east only");
            break;
    }
    commandCount++;
}


robot.Run();

Console.ReadLine();

public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; } = false;
    public IRobotCommand?[] Commands { get; } = new IRobotCommand?[3];
    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public interface IRobotCommand
{
    void Run(Robot robot);
}

public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}
public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}
public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered) robot.Y += 1;
    }
}
public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered) robot.Y -= 1;
    }
}
public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered) robot.X -= 1;
    }
}
public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (robot.IsPowered) robot.X += 1;
    }
}