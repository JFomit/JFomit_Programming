using _453501_Забережный.Lab5;
using JFomit.Functional;
using JFomit.Functional.Extensions;

var shop = new Shop();

shop.AddProduct(new Product("TV", 1000)).Unwrap();
shop.AddProduct(new Product("Fridge", 2000)).Unwrap();

shop.RegisterCustomer(new Customer("Ivan"));
shop.RegisterCustomer(new Customer("Jitter", CustomerStatus.Vip));
