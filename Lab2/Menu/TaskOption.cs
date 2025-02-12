namespace _453501_Забережный.Lab2.Menu;

internal sealed record TaskOption(IRunnableTask Task) : ContinuationMenuOption(Task.Name, Task.Description);