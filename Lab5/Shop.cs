using JFomit.Functional;
using JFomit.Functional.Extensions;
using JFomit.Functional.Monads;

namespace _453501_Забережный.Lab5;
using Unit = UnitValue;
using static JFomit.Functional.Prelude;

public class Shop
{
    private readonly HashSet<Product> _products = [];

    private readonly Dictionary<Customer, List<Order>> _placedOrders = [];

    public Result<Unit, string> AddProduct(Product product)
        => _products.Contains(product) ? Error("Can't add the same product twice.") : Ok();
    public Result<Unit, string> PlaceOrder(Customer customer, Order order)
    {
        if (_placedOrders.TryGetValue(customer, out var value))
        {
            value.Add(order);
            return Ok();
        }

        return Error("Customer must register first.");
    }

    public Result<Unit, string> RegisterCustomer(Customer customer)
        => _placedOrders.TryAdd(customer, []) ? Ok() : Error("Customer already exists.");
    public Result<Unit, string> RegisterCustomer(string surname)
        => RegisterCustomer(new Customer(surname));

    public Result<IEnumerable<Product>, string> GetPlacedOrders(Customer customer)
        => _placedOrders
                .GetValue(customer)
                .Flatten()
                .ToResult("Customer not found.")
                .Select(
                    list => list.Select(i => i.Product)
                );
    public Result<IEnumerable<Product>, string> GetPlacvedOrders(string surname)
        => GetPlacedOrders(new Customer(surname));
    public Result<decimal, string> GetPlacedCost(Customer customer)
        => _placedOrders
                .GetValue(customer)
                .Flatten()
                .ToResult("Customer not found.")
                .Select(l => l.Sum(order => order.Product.Price));
    public Result<decimal, string> GetPlacedCost(string surname)
        => GetPlacedCost(new Customer(surname));
}
