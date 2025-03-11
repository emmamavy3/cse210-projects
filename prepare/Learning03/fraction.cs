class Fraction 
{
    private int numerator;
    private int denominator;

    public string GetFractionString()
    {
        Console.WriteLine("Chose a numerator: ");
        string numerator = Console.ReadLine();
        Console.WriteLine("Chose a denominator: ");
        string denominator = Console.ReadLine();
        return ($"{numerator}/{denominator}");
    }

    public double GetDecimalValue(int numerator, int denominator)
    {
        float decimalValue = numerator / denominator;
    }
}