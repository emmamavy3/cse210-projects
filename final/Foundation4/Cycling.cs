class Cycling : Activity
{
    private double _speed; 

    public Cycling(string type, int minutes, string date, double speed)
    : base(type, minutes, date)
    {
        _speed = speed;
    }
    public override int GetDistance()
    {
        return (int)(_speed * minutes / 60); // Convert speed to miles per minute and multiply by minutes
    }
    public override double GetSpeed()
    {
        return _speed; // Speed is already in mph
    }
    public override double GetPace()
    {
        return 60 / _speed; // Pace is the inverse of speed (minutes per mile)
    }
}