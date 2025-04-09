class Receptions : Event
{
    private string _rsvpEmail;
    public Receptions(string title, string description, string date, string time, Address address, string rsvpEmail)
    : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }
    public string GetReceptionDetails()
    {
        return $" {GetStandardDetails()} EventType: Reception, RSVP: {_rsvpEmail}";
    }
}