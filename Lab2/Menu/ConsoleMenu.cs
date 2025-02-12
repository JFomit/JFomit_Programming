namespace _453501_Забережный.Lab2.Menu;

internal static class ConsoleMenu
{
    public static ConsoleMenu<T>.Builder CreateBuilder<T>(params T[] variants)
        where T : IMenuOption => new(variants);
}

internal ref struct ConsoleMenu<T>(string? header, string? footer, ReadOnlySpan<T> variants)
    where T : IMenuOption
{
    private ReadOnlySpan<T> Variants { get; } = variants;
    private string? Header { get; } = header;
    private string? Footer { get; } = footer;

    private int Current { get; set; }
    
    public T SelectAndClose()
    {
        var key = ConsoleKey.None;
        Draw();
        while (key != ConsoleKey.Enter)
        {
            key = Console.ReadKey().Key;
            
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    SelectPrevious();
                    break;
                case ConsoleKey.DownArrow:
                    SelectNext();
                    break;
            }
        }

        Close();
        return Variants[Current];
    }
    
    private void Draw()
    {
        Console.Clear();
        Console.ResetColor();
        
        ShowHeader();
        
        for (var i = 0; i < Variants.Length; i++)
        {
            ShowVariant(Variants[i], i == Current);
        }

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Variants[Current].Description);
        Console.ResetColor();
        
        ShowFooter();
    }
    private void Close()
    {
        Console.Clear();
    }
    private void SelectNext()
    {
        Current = Math.Clamp(Current + 1, 0, Variants.Length - 1);
        Draw();
    }
    private void SelectPrevious()
    {
        Current = Math.Clamp(Current - 1, 0, Variants.Length - 1);
        Draw();
    }

    private void ShowVariant(T variant, bool isHighlighted = false)
    {
        if (isHighlighted)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        Console.WriteLine(variant.Text);
        Console.ResetColor();
    }
    private void ShowHeader()
    {
        if (Header is null)
        {
            return;
        }
        Console.WriteLine(Header);
        Console.WriteLine();
    }
    private void ShowFooter()
    {
        if (Footer is null)
        {
            return;
        }
        Console.WriteLine();
        Console.WriteLine(Footer);
    }
    
    internal ref struct Builder(params T[] variants)
    {
        private string? Header { get; set; } = "Меню";
        private string? Footer { get; set; } = "\u2191 и \u2193 для навигации, <Enter> для выбора";
        private ReadOnlySpan<T> Variants { get; } = variants;

        public Builder WithHeader(string? header)
        {
            Header = header;
            return this;
        }

        public Builder WithFooter(string? footer)
        {
            Footer = footer;
            return this;
        }

        public ConsoleMenu<T> Build() => new(Header, Footer, Variants);
    }
}