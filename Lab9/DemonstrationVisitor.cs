using _453501_Забережный.Lab9.Kinds;
using _453501_Забережный.Lab9.Paper;

namespace _453501_Забережный.Lab9;

class DemonstrationVisitor : IKindVisitor
{
    public void Visit(IStandardPrinter printer)
    {
        printer.Print(ISOPaper.A4());
    }

    public void Visit(IAreaOrderedPrinter printer)
    {
        printer.PrintOrderedByArea([ISOPaper.A0(), AnsiPaper.Legal(), AnsiPaper.E(), ISOPaper.B2()]);
    }

    public void Visit(IPlotter plotter)
    {
        plotter.Plot(ISOPaper.A0());
    }
}