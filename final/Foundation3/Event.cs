class Event
{
    private string _eventType;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;
    public Event(string eventType, string title, string description, string date, string time, string address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetEventDetails()
    {
        return $"{_title}, {_description}, {_date}, {_time}, {_address}";
    }
    public string GetFullEventDetails()
    {
        return $"{_eventType}, {_title}, {_description}, {_date}, {_time}, {_address}";
    }
    public string GetShortDetails()
    {
        return $"{_eventType}, {_title}, {_date}";
    }


}