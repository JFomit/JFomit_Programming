using _453501_Забережный.Lab5;
using JFomit.Functional.Extensions;

var shop = new Shop();
var jitter = new Customer("Jitter", CustomerStatus.Vip);

shop
    .AddProduct("TV", 1000)
    .SelectMany(_ => shop.AddProduct("Fridge", 2000))
    .SelectMany(_ => shop.AddProduct("Teapot", 500))
    .SelectMany(_ => shop.AddProduct("Teleporter", 100_000))
    .SelectMany(_ => shop.AddProduct("Cooker", 1))
    .SelectMany(_ => shop.RegisterCustomer("Ivan"))
    .SelectMany(_ => shop.RegisterCustomer(jitter))
    .IfError(s => Console.WriteLine($"ERROR: {s}"));

shop
    .PlaceOrder("Jitter", "TV")
    .SelectMany(_ => shop.PlaceOrder("Jitter", "TV"))
    .SelectMany(_ => shop.PlaceOrder("Jitter", "Teleporter"))
    .SelectMany(_ => shop.PlaceOrder("Ivan", "Fridge"))
    .IfError(s => Console.WriteLine($"ERROR: {s}"));

shop
    .GetPlacedOrderProducts("Jitter")
    .Zip(shop.GetPlacedCost("Jitter"), (ps, t) => (products: ps, cost: t))
    .Switch(
        context: "Jitter",
        ok: Utils.PrintCustomerData,
        error: (err, _) => Console.WriteLine($"ERROR: {err}")
    );

shop
    .GetPlacedOrderProducts("Ivan")
    .Zip(shop.GetPlacedCost("Ivan"), (ps, t) => (products: ps, cost: t))
    .Switch(
        context: "Ivan",
        ok: Utils.PrintCustomerData,
        error: (err, _) => Console.WriteLine($"ERROR: {err}")
    );
