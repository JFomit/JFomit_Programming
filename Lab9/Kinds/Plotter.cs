
using _453501_Забережный.Lab9;
using _453501_Забережный.Lab9.Head;
using _453501_Забережный.Lab9.Kinds;
using _453501_Забережный.Lab9.Paper;

class Plotter(IPrintingHead head) : Printer(head), IPlotter
{
    public override void GetInfo()
    {
        Console.WriteLine($"This is a plotter, specifically a {GetFormattedName()} v{Revision}");
    }
    private string GetFormattedName() => Name.UnwrapOr("Super-Plotter");

    public void Plot(PaperFormat paper)
    {
        Console.WriteLine($"{GetFormattedName()}: plotting on {paper} paper.");
        Head.Print(paper);
    }
    public override void Accept(IKindVisitor visitor) => visitor.Visit(this);
}