namespace _453501_Забережный.Lab9.Paper;

internal static class AnsiPaper
{
    public static PaperFormat BusinessCard() => new(85.6, 53.98, "Business card");
    public static PaperFormat Executive() => new(190.5, 254, "Executive");
    public static PaperFormat JrLegal() => new(203.2, 127, "Jr. Legal");
    /// <summary>
    /// Also known as ANSI A paper.
    /// </summary>
    public static PaperFormat Letter() => new(215.9, 279.4, "Letter");
    /// <summary>
    /// Also known as legal paper.
    /// </summary>
    public static PaperFormat A() => new(215.9, 279.4, "Lagal / Ansi A");
    public static PaperFormat Legal() => new(215.9, 355.6, "Legal / Ansi A");
    /// <summary>
    /// Also known as ANSI B paper.
    /// </summary>
    public static PaperFormat Tabloid() => new(279.4, 431.8, "Tabloid / Ansi B");
    /// <summary>
    /// Also known as tabloid paper.
    /// </summary>
    public static PaperFormat B() => new(279.4, 431.8, "Tabloid / Ansi B");
    public static PaperFormat C() => new(432, 559, "Ansi C");
    public static PaperFormat D() => new(559, 864, "Ansi D");
    public static PaperFormat E() => new(1_118, 864, "Ansi E");
}