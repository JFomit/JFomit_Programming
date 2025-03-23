using _453501_Забережный.Lab9.Paper;
using _453501_Забережный.Lab9.Head;

namespace _453501_Забережный.Lab9.Printer;

internal abstract class Printer(IPrintingHead head)
{
    protected IPrintingHead Head { get; } = head;
    public abstract PrinterModel Model { get; }
    public PrinterModel GetInfo() => Model;

    public abstract void Print(PaperFormat paper);
}