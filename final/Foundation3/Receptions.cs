class Receptions : Event
{
    private string _rsvpEmail;
    public Receptions(string title, string description, string date, string time, string address, string rsvpEmail)
    : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public string GetReceptionDetails()
    {
        return $"RSVP: {_rsvpEmail}";
    }
}