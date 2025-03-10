using JFomit.Functional;
using JFomit.Functional.Extensions;
using JFomit.Functional.Monads;

namespace _453501_Забережный.Lab5;
using Unit = UnitValue;
using static JFomit.Functional.Prelude;

public class Shop
{
    private readonly Dictionary<string, decimal> _products = [];
    private readonly Dictionary<Customer, List<Order>> _placedOrders = [];

    public IEnumerable<Product> Products => _products.Select(kv => new Product(kv.Key, kv.Value));

    public Result<Unit, string> AddProduct(Product product)
        => _products.TryAdd(product.Name, product.Price)
        ? Ok()
        : Error("Can't add the same product twice.");

    public Result<Unit, string> AddProduct(string name, decimal price)
        => AddProduct(new Product(name, price));
    public Result<Unit, string> PlaceOrder(Customer customer, Order order)
    {
        if (_placedOrders.TryGetValue(customer, out var value))
        {
            value.Add(order);
            return Ok();
        }

        return Error("Customer must register first.");
    }
    public Result<Unit, string> PlaceOrder(string surname, string product)
    {
        if (!_products.TryGetValue(product, out var price))
        {
            return Error($"Product `{product}' not found.");
        }

        return PlaceOrder(new Customer(surname), new Order(new Product(product, price)));
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
    public Result<IEnumerable<Product>, string> GetPlacedOrderProducts(string surname)
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
