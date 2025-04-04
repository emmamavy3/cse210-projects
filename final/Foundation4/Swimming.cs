class Swimming : Activity
{
    private int _laps;
    public Swimming(string type, int minutes, string date, int laps) 
    : base(type, minutes, date)
    {
        _laps = laps;
    }
    public override int GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / minutes * 60; 
    }   
    public override double GetPace()
    {
        return minutes / GetDistance(); 
}