
using System.Diagnostics;
using _453501_Забережный.Lab2.Menu;

namespace _453501_Забережный.Lab2;

internal class TaskRunner(params IRunnableTask[] tasks)
{
    private TaskOption[] Tasks { get; } = tasks.Select(task => new TaskOption(task)).ToArray();

    public void Run()
    {
        while (true)
        {
            ChooseTask().Run();
            
            Console.WriteLine();
            Console.WriteLine("Задание завершено, нажмите любую клавишу...");
            Console.ReadKey();

            if (ShouldExit())
            {
                return;
            }
        }
    }

    private IRunnableTask ChooseTask()
    {
        var menu = ConsoleMenu.CreateBuilder<TaskOption>(Tasks)
            .WithHeader("Выберите задание")
            .Build();
        return menu.SelectAndClose().Task;
    }

    private static bool ShouldExit()
    {
        return ConsoleMenu.CreateBuilder<ContinuationMenuOption>(new ContinueOption(),
                    new ExitOption())
                .WithHeader("Продолжать?")
                .Build()
                .SelectAndClose() switch
            {
                ContinueOption => false,
                ExitOption => true,
                _ => throw new UnreachableException()
            };
    }
}