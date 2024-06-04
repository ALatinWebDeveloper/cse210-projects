using System;

public class Customer
{
    public string _name;
    public Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string getName()
    {
        return $"{_name}";
    }

    public bool usResidency()
    {
        bool usResidency = true;
        if (_address._country.Contains("EE. UU."))
        {
            usResidency = true;
        }
        else
        {
            usResidency = false;
        }

        return usResidency;
        
    }
}