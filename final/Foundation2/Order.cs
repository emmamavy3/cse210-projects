class Order
{
    private List<Product> _products;
    private Customer _customerName;
    public Order(Customer customerName)
    {
        _customerName = customerName;
        _products = new List<Product>();
    }
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.GetTotalPrice();
        }
        double shippingCost = _customerName.LiveInUSA() ? 5 : 35;

        return total + shippingCost;
    }
    public string GetPackingLabel()
    {
        string packingLabel = $"Packing Label for {_customerName}:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetPackingInfo()}\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label for {_customerName.GetName()}:\n{_customerName.GetAddress().GetFullAddress()}";
    }
}
