using System.Globalization;

namespace _453501_Забережный.Lab2.Tasks;

internal class Task1 : IRunnableTask
{
    public string Name => "Задание 1";
    public string Description => "Вычисляет, кратна ли трем сумма цифр двухзначного числа.";
    
    public void Run()
    {
        Console.WriteLine("Введите двухзначное число:");
        if (int.TryParse(Console.ReadLine(), out var number) && number is >= 10 and <= 99)
        {
            var digitSum = number / 10 + number % 10;
            Console.WriteLine(digitSum % 3 == 0
                ? $"Сумма цифр ({digitSum}) кратна трем."
                : $"Сумма цифр ({digitSum}) не кратна трем.");
        }
        else
        {
            Console.WriteLine("Неверный ввод.");
        }
    }
}