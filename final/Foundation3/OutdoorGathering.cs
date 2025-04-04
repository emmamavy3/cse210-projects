class OutdoorGathering : Event
{
    private string _weatherForecast;
    public OutdoorGathering(string title, string description, string date, string time, string address, string weatherForecast)
    : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }
    public string GetOutdoorGatheringDetails()
    {
        return $" Weather: {_weatherForecast}";
    }
}