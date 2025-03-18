class Person
{
    private string _first;
    private string _last;
    private int _age;
    protected int _height;

    public Person(string first, string last, int age)
    {
        _first = first;
        _last = last;
        _age = age;
        _height = 0;
    }
    public string DisplayPersonInfo()
    {
        return $"Information: {_first} {_last} {_age}";
    }

    public int GetHeight()
    {
        return _height;
    }

    public void SetHeight(int height)
    {
        _height = height;
    }

}