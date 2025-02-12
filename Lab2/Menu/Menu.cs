namespace _453501_Забережный.Lab2.Menu;

internal ref struct Menu<T>(string header, string footer, ReadOnlySpan<T> variants)
    where T : IMenuOption
{
    private ReadOnlySpan<T> Variants { get; } = variants;
    private string Header { get; } = header;
    private string Footer { get; } = footer;
    private int CurrentChoice { get; set;  } = 0;
    
    public void Draw()
    {
        Console.Clear();
        Console.ResetColor();
        Console.WriteLine(Header);
        Console.WriteLine();
        for (var i = 0; i < Variants.Length; i++)
        {
            if (i == CurrentChoice)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(Variants[i].Text);
                Console.ResetColor();
                continue;
            }

            Console.WriteLine(Variants[i].Text);
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Variants[CurrentChoice].Description);
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine(Footer);
    }
}