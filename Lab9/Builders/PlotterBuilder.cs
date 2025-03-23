namespace _453501_Забережный.Lab9.Builders;

class PlotterBuilder : PrinterBuilder
{
    public override Printer Build()
    {
        var head = Head.Expect("Printing head is required to produce a working printer!");

        return new Plotter(head)
        {
            Name = Name,
            Revision = Revision
        };
    }
}