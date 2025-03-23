using _453501_Забережный.Lab9.Head;
using _453501_Забережный.Lab9.Paper;

namespace _453501_Забережный.Lab9.Kinds;

class GenericPrinter(IPrintingHead head) : Printer(head), IStandardPrinter
{
    public override void GetInfo()
    {
        Console.WriteLine($"This is a your standard printer, version {Revision}, model name {GetFormattedName()}");
    }

    private string GetFormattedName() => Name.UnwrapOr("Generic");

    public void Print(PaperFormat paper)
    {
        Console.WriteLine($"{GetFormattedName()}: printing on {paper} paper.");
        Head.Print(paper);
    }
    public override void Accept(IKindVisitor visitor) => visitor.Visit(this);
}