namespace _453501_Забережный.Lab2.Tasks;

public class Task2 : IRunnableTask
{
    public string Name => "Задание 2";
    public string Description
        => "Определяет, находится ли точка в области, ограниченной графиком функции y=|x| и прямой y = 12.";
    public void Run()
    {
        Console.WriteLine("Введите точку плоскости:");
        if (!Point.TrReadPoint(out var point))
        {
            Console.WriteLine("Некорректный ввод.");
            return;
        }

        var response = (point.Y.CompareTo(12), point.Y.CompareTo(Math.Abs(point.X))) switch
        {
            (0, _) or (_, 0) => "На границе",
            (< 0, > 0) => "Да",
            _ => "Нет"
        };

        Console.WriteLine(response);
    }
}