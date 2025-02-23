namespace _453501_Забережный.Lab4;

public class Television
{
    public required string Name { get; init; }

    public required decimal Cost
    {
        get => _cost;
        set
        {
            ArgumentOutOfRangeException.ThrowIfNegative(value);
            _cost = value;
        }
    }
    private decimal _cost;

    public void IncreaseCost(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(amount);
        Cost += amount;
    }
    public void DecreaseCost(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(amount);
        Cost -= amount;
    }
}