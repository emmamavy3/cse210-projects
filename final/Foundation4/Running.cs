class Running : Activity
{
    private double _distance;
    public Running(string name, int minutes, double distance) 
    : base(name, minutes)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetMinutes() / 60.0; 
    }
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
    public override string GetActivityType()
    {
        return "Running";
    }
}