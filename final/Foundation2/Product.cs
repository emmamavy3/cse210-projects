using System.Dynamic;

class Product
{
    private string _name;
    private string _product;
    private int _price;
    private int _quantity;

    public Product(string name, string product, int price, int quantity)
    {
        _name = name;
        _product = product;
        _price = price;
        _quantity = quantity;
    }
    public void GetTotalPrice()
    {
        float totalPrice = _price * _quantity;
    }
    public string GetProductDetails()
    {
        return $"Product Name: {_name}, Product Type: {_product}, Price: {_price}, Quantity: {_quantity}";
    }
}