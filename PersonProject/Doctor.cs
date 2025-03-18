class Doctor : Person
{
    private string _specification;
    public Doctor (string specification, string first, string last, int age)
    :base(first, last, age)
    {
        _specification = specification;
    }
    public string DisplayDoctorInfo()
    {
        return $"{_specification}, {DisplayPersonInfo()}";
    }
}