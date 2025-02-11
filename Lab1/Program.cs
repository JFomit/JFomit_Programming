Console.WriteLine("Введите делимое и делитель:");
if (!TryReadDouble2(out var dividend, out var divisor))
{
    Console.WriteLine("Некорректный ввод.");
    return 1;
}

var quotient = dividend / divisor;
Console.WriteLine($"Частное: {quotient}.");
return 0;

static bool TryReadDouble2(out double a, out double b)
{
    (a, b) = (0, 0);
    return double.TryParse(Console.ReadLine(), out a)
           && double.TryParse(Console.ReadLine(), out b);
}