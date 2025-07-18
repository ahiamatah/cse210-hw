// Customer class
class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName() => name;
    public Address GetAddress() => address;

    // Returns true if customer lives in USA
    public bool LivesInUSA()
    {
        return address.IsInUSA();
    }
}