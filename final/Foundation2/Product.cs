namespace Foundation2
{
public class Product

{
    private string _name;
    private string _productID;
    private int _price;
    private int _quantity;

    public Product ()
    {
        _name = "NA";
        _productID= "NA";
        _price = 0;
        _quantity = -1;
    }
    public Product(string name, string productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public void SetProductName(string name)
    {
        _name = name;
    }

    public void SetProductID(string ID)
    {
        _productID = ID;
    }

    public void SetProductPrice(int price)
    {
        _price = price;
    }

    public void SetProductQuantity(int quantity)
    {
        _quantity = quantity;   
    }
    public int CalculatePrice()
    {
        return _price*_quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public int GetPrice()
    {
        return _price;
    }

    public int GetOrderPrice()
    {
        return _price*_quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

}
}