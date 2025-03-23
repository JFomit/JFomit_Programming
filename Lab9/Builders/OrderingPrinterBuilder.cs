using _453501_Забережный.Lab9.Kinds;

namespace _453501_Забережный.Lab9.Builders;

class OrderingPrinterBuilder : PrinterBuilder
{
    public override Printer Build()
    {
        var head = Head.Expect("Printing head is required to produce a working printer!");

        return new OrderingPrinter(head)
        {
            Name = Name,
            Revision = Revision
        };
    }
}