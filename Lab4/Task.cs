namespace _453501_Забережный.Lab4;

public static class Task
{
    public static void Run()
    {
        Console.WriteLine($"Current cost is {Shop.Instance.Value.TvCost}.");
        Shop.Instance.Value.IncreaseCost(10);
        Shop.Instance.Value.DecreaseCost(5);
        Console.WriteLine($"Current cost is {Shop.Instance.Value.TvCost}.");

        Shop.Instance.Value.Purchase();
        Shop.Instance.Value.Purchase();
        Shop.Instance.Value.Purchase();
        Shop.Instance.Value.Purchase();

        Console.WriteLine(
            $"{Shop.Instance.Value.Name} report:\n" +
            $"{Shop.Instance.Value.Tv.Name} was bought {Shop.Instance.Value.SalesCount} times " +
            $"for {Shop.Instance.Value.TvCost}, totalling of {Shop.Instance.Value.TotalGains}.");
    }
}
