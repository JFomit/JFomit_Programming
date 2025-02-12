namespace _453501_Забережный.Lab2.Menu;

internal static class ConsoleMenu<T>
    where T : IMenuOption
{
    public static T Show(params ReadOnlySpan<T> span)
    {
        return span switch
        {
            [] => throw new ArgumentException(nameof(span)),
            [_] => WaitForConfirmation(span),
            _ => Choose(span)
        };
    }

    private static T Choose(ReadOnlySpan<T> variants)
    {
        var currentChoice = 0;
        var key = ConsoleKey.None;
            
        while (key != ConsoleKey.Enter)
        {
            DrawMenu(currentChoice, variants: variants);
            
            key = Console.ReadKey().Key;
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    currentChoice -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    currentChoice += 1;
                    break;
            }

            currentChoice = Math.Clamp(currentChoice, 0, variants.Length - 1);
        }

        CloseMenu();
        return variants[currentChoice];
    }

    private static void CloseMenu()
    {
        Console.Clear();
    }

    private static void DrawMenu(int currentChoice,
        string prompt = "\u2191 и \u2193 для навигации, <Enter> для выбора",
        params ReadOnlySpan<T> variants)
    {
        
    }

    private static T WaitForConfirmation(T result)
    {
        DrawMenu(0, "Для продолжения нажмите любую клавишу...", result);
        Console.ReadKey();
        CloseMenu();
        
        return result;
    }
}