// Order class
class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Calculate total order cost (sum product costs + shipping)
    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product p in products)
        {
            totalCost += p.GetTotalCost();
        }

        // Shipping cost: $5 if USA, $35 otherwise
        totalCost += customer.LivesInUSA() ? 5 : 35;
        return totalCost;
    }

    // Return packing label: list product name and id
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in products)
        {
            label += $"{p.GetName()} (ID: {p.GetProductId()})\n";
        }
        return label;
    }

    // Return shipping label: customer name and full address
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().ToString()}";
    }
}