using _453501_Забережный.Lab9.Head;
using static JFomit.Functional.Prelude;

namespace _453501_Забережный.Lab9.Builders;

static class Director
{
    public static Printer Create3000(IPrintingHead head, PrinterBuilder builder) => builder
        .WithHead(head)
        .WithName(None)
        .WithRevision(3000)
        .Build();
    public static Printer CreateLaser(string name, PrinterBuilder builder) => builder
        .WithHead(new LaserHead())
        .WithName(name)
        .WithRevision(1)
        .Build();
    public static Printer CreateInkjet(string name, PrinterBuilder builder) => builder
        .WithHead(new InkjetHead())
        .WithName(name)
        .WithRevision(1)
        .Build();
    public static Printer CreateExperimentalSublimator(PrinterBuilder builder) => builder
        .WithHead(new DyeSublimationHead())
        .WithName("Experiment")
        .WithRevision(0)
        .Build();
    public static Printer CreateOldDotMatrix(PrinterBuilder builder) => builder
        .WithHead(new DotMatrixHead())
        .WithName("Old")
        .WithRevision(100)
        .Build();
}