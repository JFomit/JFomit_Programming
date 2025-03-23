using _453501_Забережный.Lab9.Head;
using _453501_Забережный.Lab9.Paper;

namespace _453501_Забережный.Lab9.Kinds;

class GenericPrinter(
    IPrintingHead head,
    string name
) : Printer(head)
{
    public string Name { get; } = name;

    public override PrinterModel Model => new()
    {
        ModelName = Name
    };
    public override string ToString()
        => FormattedName();

    private string FormattedName()
        => $"Generic {Name}";

    public override void Print(PaperFormat paper)
    {
        Console.WriteLine($"{FormattedName()}: printing on {paper} paper.");
        Head.Print(paper);
    }
}