namespace _453501_Забережный.Lab9.Paper;

internal static class ISOPaper
{
    public static PaperFormat A0() => new(841, 1_189, "A0");
    public static PaperFormat A1() => new(594, 841, "A1");
    public static PaperFormat A2() => new(420, 594, "A2");
    public static PaperFormat A3() => new(297, 420, "A3");
    public static PaperFormat A4() => new(210, 297, "A4");
    public static PaperFormat A5() => new(148, 210, "A5");

    public static PaperFormat B0() => new(1_028, 1_456, "B0");
    public static PaperFormat B1() => new(707, 1_000, "B1");
    public static PaperFormat B2() => new(514, 728, "B2");
    public static PaperFormat B3() => new(364, 514, "B3");
    public static PaperFormat B4() => new(257, 364, "B4");
    public static PaperFormat B5() => new(182, 257, "B5");
}