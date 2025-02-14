namespace _453501_Забережный.Lab2.Tasks;

internal readonly struct TwoDigitNumber
{
    public int Number { get; }
    public int FirstDigit => Number / 10;
    public int LastDigit => Number % 10;

    private TwoDigitNumber(int number)
    {
        Number = number;
    }

    public static bool TryCreate(int number, out TwoDigitNumber twoDigitNumber)
    {
        if (number is >= 10 and <= 99)
        {
            twoDigitNumber = new(number);
            return true;
        }

        twoDigitNumber = default;
        return false;
    }

    public bool IsDigitSumDivisibleBy3()
        => (FirstDigit + LastDigit) % 3 == 0;
}
