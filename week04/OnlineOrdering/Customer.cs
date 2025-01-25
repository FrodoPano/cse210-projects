class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCountry(){
        return _address.GetCountry();
    }

    public override string ToString(){
        return $"{_name}\n{_address}";
    }
}