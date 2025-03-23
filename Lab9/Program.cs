
using _453501_Забережный.Lab9;
using _453501_Забережный.Lab9.Builders;
using _453501_Забережный.Lab9.Head;

var genericBuilder = new GenericPrinterBuilder();
var orderingPrinterBuilder = new OrderingPrinterBuilder();
var plotterBuilder = new PlotterBuilder();

var printers = new List<Printer>()
{
    Director.Create3000(new InkjetHead(), genericBuilder),
    Director.CreateInkjet("Jitttttttter", plotterBuilder),
    Director.CreateExperimentalSublimator(plotterBuilder),
    Director.CreateOldDotMatrix(genericBuilder),
    Director.CreateLaser("Zapper", orderingPrinterBuilder)
};

var visitor = new DemonstrationVisitor();
foreach (var item in printers)
{
    Console.WriteLine();
    item.GetInfo();
    Console.WriteLine("***");
    item.Accept(visitor);
}
