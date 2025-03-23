using _453501_Забережный.Lab9.Paper;
using _453501_Забережный.Lab9.Head;
using JFomit.Functional.Monads;
using static JFomit.Functional.Prelude;
using _453501_Забережный.Lab9.Kinds;

namespace _453501_Забережный.Lab9;

internal abstract class Printer(IPrintingHead head)
{
    protected IPrintingHead Head { get; } = head;
    public Option<string> Name { get; init; } = None;
    public int Revision { get; init; }

    public abstract void GetInfo();
    public abstract void Accept(IKindVisitor visitor);
}