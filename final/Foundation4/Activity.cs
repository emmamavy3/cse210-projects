class Activity
{
    private string _type;
    private int _minutes;
    private string _date;
    public Activity(string type, int minutes, string date)
    {
        _type = type;
        _minutes = minutes;
        _date = date;
    }
    public int GetDistance()
    {
        return 0;
    }
    public double GetSpeed()
    {
        return 0;
    }
    public double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return $"{_date} {_type} ({_minutes} minutes) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
