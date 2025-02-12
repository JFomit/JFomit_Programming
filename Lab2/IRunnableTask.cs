namespace _453501_Забережный.Lab2;

internal interface IRunnableTask
{
    string Name { get; }
    string Description { get; }
    
    void Run();
}