class Activity
{
    private int _minutes;
    private string _date;
    public Activity(string date, int minutes)
    {
        _minutes = minutes;
        _date = date;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetActivityType()
    {
        return "Activity";
    }
    public string GetSummary()
    {
        return $"{_date} {GetActivityType()} ({_minutes} minutes) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
    public int GetMinutes()
    {
        return _minutes;
    }
}
