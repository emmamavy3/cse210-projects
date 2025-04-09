class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity)
    : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public string GetLectureDetails()
    {
        return $"{GetStandardDetails}Event Type: Lecture, Speaker: {_speaker}, Capacity: {_capacity}";
    }
}