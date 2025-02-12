using System.Diagnostics.CodeAnalysis;

namespace _453501_Забережный.Lab2.Tasks;

internal record Point(double X, double Y)
{
    public static bool TrReadPoint([MaybeNullWhen(false)] out Point result)
    {
        if (TryReadDouble2(out var coords))
        {
            result = new Point(coords.first, coords.second);
            return true;
        }

        result = null;
        return false;
        
        static bool TryReadDouble2(out (double first, double second) tuple)
        {
            tuple = (0, 0);
            return double.TryParse(Console.ReadLine(), out tuple.first)
                   && double.TryParse(Console.ReadLine(), out tuple.second);
        }
    }
}