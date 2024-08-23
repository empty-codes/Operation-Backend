# Robotic Interface (75 XP)

With your knowledge of interfaces, you realize you can refine the old robot you found in the mud to use interfaces instead of the original design. Instead of an abstract `RobotCommand` base class, it could become an `IRobotCommand` interface!

Building on your solution to the Old Robot challenge, perform the changes below:

## Objectives:

- Change your abstract `RobotCommand` class into an `IRobotCommand` interface.
- Remove the unnecessary `public` and `abstract` keywords from the `Run` method.
- Change the `Robot` class to use `IRobotCommand` instead of `RobotCommand`.
- Make all of your commands implement this new interface instead of extending the `RobotCommand` class that no longer exists. You will also want to remove the `override` keywords in these classes.
- Ensure your program still compiles and runs.
