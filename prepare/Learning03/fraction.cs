class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholenumber)
    {
        _numerator = wholenumber;
        _denominator = 1;
    }

    public string GetFractionString(string numerator, string denominator)
    {
        return ($"{numerator}/{denominator}");
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }

    public int GetNumerator()
    {
        return (_numerator);
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return (_denominator);
    }
    public void SetDenominator(int denominator)
    {
        if(denominator == 0)
        {
            Console.WriteLine("Error - Denominator can't be 0");
            return;
        }
        _denominator = denominator;
    }
}