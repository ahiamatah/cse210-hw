using System;
using System.Collections.Generic;

// Address class
class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    // Getter methods
    public string GetStreet() => street;
    public string GetCity() => city;
    public string GetStateOrProvince() => stateOrProvince;
    public string GetCountry() => country;

    // Returns true if address is in USA
    public bool IsInUSA()
    {
        return country.Trim().ToLower() == "usa" || country.Trim().ToLower() == "united states" || country.Trim().ToLower() == "united states of america";
    }

    // Returns full address string with new lines
    public override string ToString()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}