class Customer
{
    private string _name;
    private string _address;
    public Customer(string name, string address)
    {
        _name = name;
        _address = address;
    }
    public void LiveInUSA()
    {
        if (_address == "USA")
        {
            true;
            return;
        }
        else
        {
            false; 
            return;
        }
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address;
    }
}