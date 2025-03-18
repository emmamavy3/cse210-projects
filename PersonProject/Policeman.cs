class Policeman : Person
{
    private string _weapons;
    public Policeman(string weapons, string first, string last, int age)
    : base(first, last, age)
    {
        _weapons = weapons;
        _height = 80;
    }
    public string DisplayPoliceinfo()
    {
        return $"{_weapons}, {DisplayPersonInfo()}";
    }
}