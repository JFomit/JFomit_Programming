
using _453501_Забережный.Lab9.Head;
using _453501_Забережный.Lab9.Paper;

namespace _453501_Забережный.Lab9.Kinds;

class OrderingPrinter(IPrintingHead head) : Printer(head), IAreaOrderedPrinter
{
    public override void GetInfo()
    {
        var name = GetFormattedName();
        Console.WriteLine($"This is a smart area sorting printer, model is {name}-{Revision}");
    }

    private string GetFormattedName() => Name.UnwrapOr("Generic Sort-Tech");

    public void PrintOrderedByArea(IEnumerable<PaperFormat> papers)
    {
        foreach (var item in papers.OrderBy(paper => paper.Width * paper.Height))
        {
            Console.WriteLine($"{GetFormattedName()}: web-printing on {item} paper");
            Head.Print(item);
        }
    }
    public override void Accept(IKindVisitor visitor) => visitor.Visit(this);
}