namespace _453501_Забережный.Lab9.Kinds;

interface IKindVisitor
{
    void Visit(IStandardPrinter printer);
    void Visit(IAreaOrderedPrinter printer);
    void Visit(IPlotter plotter);
}