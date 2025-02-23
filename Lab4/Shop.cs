namespace _453501_Забережный.Lab4;

public sealed class Shop
{
    public static Lazy<Shop> Instance { get; } = new(() => new Shop()
    {
        Tv = new Television()
        {
            Cost = 100,
            Name = "Some cool TV"
        },
        Name = "Some cool shop"
    });
    public required Television Tv { get; init; }
    public required string Name { get; init; }
    public decimal TvCost => Tv.Cost;
    
    public int SalesCount { get; private set; }

    public void Purchase() => SalesCount++;

    /// <summary>
    /// Will break if cost is changed after first purchases are made. 
    /// </summary>
    public decimal TotalGains => SalesCount * Tv.Cost;
    
    public void IncreaseCost(decimal increaseAmount)
    {
        if (SalesCount == 0)
            Tv.IncreaseCost(increaseAmount);
        else
            throw new NotSupportedException();
    }

    public void DecreaseCost(decimal decreaseAmount)
    {
        if (SalesCount == 0)
            Tv.DecreaseCost(decreaseAmount);
        else
            throw new NotSupportedException();
    }
}