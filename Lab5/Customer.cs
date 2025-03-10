namespace _453501_Забережный.Lab5;

public class Customer(string surname, CustomerStatus status = CustomerStatus.Regular)
    : IEquatable<Customer>
{
    public string Surname { get; } = surname;
    public CustomerStatus Status { get; set; } = status;

    public override bool Equals(object? obj)
        => obj is Customer other && Equals(other);

    public bool Equals(Customer? other)
        => other?.Surname == Surname;

    public override int GetHashCode() => HashCode.Combine(Surname);
}
