class Order
{
    private List<Product> _products;
    private string _customerName;
    public Order(string customerName)
    {
        _customerName = customerName;
        _products = new List<Product>();
    }
    public int CalculateTotalPrice()
    {
        int totalPrice = 0;
        foreach (var product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }
        return totalPrice;
    }
    public string GetPackingLabel()
    {
        string packingLabel = $"Packing Label for {_customerName}:\n";
        foreach (var product in _products)
        {
            packingLabel += product.GetProductDetails() + "\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Label for {_customerName}";
    }
}
