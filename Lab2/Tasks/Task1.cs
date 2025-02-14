using System.Globalization;

namespace _453501_Забережный.Lab2.Tasks;

internal class Task1 : IRunnableTask
{
    public string Name => "Задание 1";
    public string Description => "Вычисляет, кратна ли трем сумма цифр двухзначного числа.";

    public void Run()
    {
        Console.WriteLine("Введите двухзначное число:");
        if (int.TryParse(Console.ReadLine(), out var number)
            && TwoDigitNumber.TryCreate(number, out var twoDigitNumber))
        {
            Console.WriteLine(twoDigitNumber.IsDigitSumDivisibleBy3()
                ? $"Сумма цифр кратна трем."
                : $"Сумма цифр не кратна трем.");
        }
        else
        {
            Console.WriteLine("Неверный ввод.");
        }
    }
}