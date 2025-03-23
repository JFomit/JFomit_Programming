using _453501_Забережный.Lab9.Head;
using JFomit.Functional.Monads;
using static JFomit.Functional.Prelude;

namespace _453501_Забережный.Lab9.Builders;

abstract class PrinterBuilder
{
    protected Option<IPrintingHead> Head { get; set; } = None;
    protected Option<string> Name { get; set; } = None;
    protected int Revision { get; set; } = 0;

    public PrinterBuilder WithHead(IPrintingHead head)
    {
        Head = Some(head);
        return this;
    }
    public PrinterBuilder WithName(string name)
    {
        Name = Some(name);
        return this;
    }
    public PrinterBuilder WithName(Option<string> name)
    {
        Name = name;
        return this;
    }
    public PrinterBuilder WithRevision(int revision)
    {
        Revision = revision;
        return this;
    }

    public abstract Printer Build();
}