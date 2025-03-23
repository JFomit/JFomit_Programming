namespace _453501_Забережный.Lab9.Paper;

/// <summary>
/// Represents a printing paper format.
/// </summary>
/// <param name="width">Width of the sheet, in mm.</param>
/// <param name="height">Height of the sheet, in mm.</param>
/// <param name="formatName">Name of the format.</param>
internal class PaperFormat(double width, double height, string formatName)
    : IEquatable<PaperFormat>
{
    public double Width { get; } = width;
    public double Height { get; } = height;

    public string FormatName { get; } = formatName;

    public bool Equals(PaperFormat? other)
        => other is not null &&
            Width == other.Width &&
            Height == other.Height;

    public override bool Equals(object? obj)
        => obj is PaperFormat other && Equals(other);
    public override int GetHashCode()
        => HashCode.Combine(Width, Height);

    public override string ToString()
        => $"{FormatName} ({Width}mm x {Height}mm)";
}