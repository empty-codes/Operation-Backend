# The Old Robot (200 XP)

While exploring, you find an old mechanical automaton with "Property of Dynamak" etched into it. After removing the mud, you realize that the automaton seems programmable with the right commands. The automaton appears to be structured as follows:

```csharp
public class Robot
{
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }
    public RobotCommand?[] Commands { get; } = new RobotCommand?[3];

    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}
```

Your task is to recreate the missing `RobotCommand` class and extend it to allow the robot to move in different directions and be powered on or off.

## Objectives

1. **Create the RobotCommand Class**:
   - Copy the code above into a new project.
   - Create a `RobotCommand` class with a public and abstract `void Run(Robot robot)` method. The provided code should compile after this step.

2. **OnCommand and OffCommand Classes**:
   - Create `OnCommand` and `OffCommand` classes that inherit from `RobotCommand` and override the `Run` method to turn the robot on or off by modifying the `IsPowered` property.

3. **Movement Command Classes**:
   - Create the following classes that inherit from `RobotCommand` and move the robot:
     - `NorthCommand`: Moves the robot 1 unit in the +Y direction.
     - `SouthCommand`: Moves the robot 1 unit in the -Y direction.
     - `WestCommand`: Moves the robot 1 unit in the -X direction.
     - `EastCommand`: Moves the robot 1 unit in the +X direction.
   - Ensure that these movement commands only work if the robot’s `IsPowered` property is `true`.

4. **Main Method Implementation**:
   - Modify the main method to collect three commands from the console window.
   - Generate new `RobotCommand` objects based on the text entered (e.g., "on", "north", "west").
   - After filling the robot’s command set with these `RobotCommand` objects, use the robot’s `Run` method to execute them, displaying the robot’s state after each command.

Example Console Output:
```
on
north
west
[0 0 True]
[0 1 True]
[-1 1 True]
```

---