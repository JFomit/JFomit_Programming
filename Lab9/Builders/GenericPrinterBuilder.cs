using _453501_Забережный.Lab9.Kinds;

namespace _453501_Забережный.Lab9.Builders;

class GenericPrinterBuilder : PrinterBuilder
{
    public override Printer Build()
    {
        var head = Head.Expect("Printing head is required to produce a working printer!");

        return new GenericPrinter(head)
        {
            Name = Name,
            Revision = Revision
        };
    }
}