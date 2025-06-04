// Product class
class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetName() => name;
    public string GetProductId() => productId;
    public double GetPrice() => price;
    public int GetQuantity() => quantity;

    // Calculate total cost for this product
    public double GetTotalCost()
    {
        return price * quantity;
    }
}
