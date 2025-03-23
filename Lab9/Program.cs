using _453501_Забережный.Lab9;
using _453501_Забережный.Lab9.Head;
using _453501_Забережный.Lab9.Paper;
using _453501_Забережный.Lab9.Printer;

var p = new HpLaserJet(new InkjetHead());
p.Print(ISOPaper.B1());

class HpLaserJet(IPrintingHead head) : Printer(head)
{
    public override PrinterModel Model { get; } = new()
    {
        Manufacturer = Manufacturer.Custom,
        ModelName = "XxHash"
    };

    public override string ToString()
        => GetFormattedName();
    private string GetFormattedName()
    {
        return $"{Model.Manufacturer} {Model.ModelName}";
    }

    public override void Print(PaperFormat paper)
    {
        Console.WriteLine($"{GetFormattedName()}: Prinitng on {paper}.");
        Head.Print(paper);
    }
}