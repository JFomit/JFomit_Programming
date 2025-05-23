namespace _453501_Забережный.Lab2.Menu;

internal sealed record TaskOption(IRunnableTask Task) : IMenuOption
{
    public string Text { get; } = Task.Name;
    public string Description { get; } = Task.Description;
}