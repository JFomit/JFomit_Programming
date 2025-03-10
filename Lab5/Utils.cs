namespace _453501_Забережный.Lab5;

public static class Utils
{
    public static void Discard<T>(this T obj) => _ = obj;

    public static void PrintCustomerData((IEnumerable<Product> products, decimal cost) tuple, string name)
    {
        var (enumerable, cost) = tuple;
        var products = enumerable.ToArray();
        Console.WriteLine($"{name}'s orders:");

        var message = products switch
        {
        [] => "No orders placed",
        [var one] => $"{one.Name} for {one.Price}",
            _ => products
                .Select(p => p.Name)
                .Aggregate((p, n) => $"{p}, {n}") + $" for {cost} total"
        };

        Console.WriteLine(message);
    }
}