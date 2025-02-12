namespace _453501_Забережный.Lab2.Menu;

internal abstract record ContinuationMenuOption(string Text, string Description) : IMenuOption;

internal sealed record ContinueOption() : ContinuationMenuOption("Продолжить", "Перезапускает текущую задачу.");

internal sealed record ExitOption() : ContinuationMenuOption("Закончить", "Завершает программу.");

