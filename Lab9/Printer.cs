using _453501_Забережный.Lab9.Paper;
using _453501_Забережный.Lab9.Head;
using JFomit.Functional.Monads;
using Unit = JFomit.Functional.UnitValue;

namespace _453501_Забережный.Lab9.Printer;

internal abstract class Printer(IPrintingHead head)
{
    public IPrintingHead Head { get; } = head;

    public abstract PrinterModel GetInfo();
    public abstract Result<Unit, string> Print(PaperFormat paper);
}