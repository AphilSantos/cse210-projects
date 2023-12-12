namespace Foundation2

{

public class Order

{
    private Customer _customer;
    private List <Product> _listOfProducts = new List<Product> ();

    const int _USAshippingCost = 5;
    const int _OutsideShippingCost = 35;


    public void SetOrder(string productName, string productID, int productPrice, int productQuantity)
    {
        Product product = new Product ();
        product.SetProductName(productName);
        product.SetProductID(productID);
        product.SetProductPrice(productPrice);
        product.SetProductQuantity(productQuantity);
       
        _listOfProducts.Add(product);
    }
    public void SetCustomer(string customerName, string customerAddress)
    {
        _customer = new Customer();
        
        _customer.SetName(customerName);
        _customer.SetAddress(customerAddress);

    }

    public int CalculateCostOfOrder()
    {
        int cost = 0;
        foreach (Product product in _listOfProducts)
        {

            cost = cost + product.CalculatePrice();

        }

        // Customer customer = new Customer();

        if (_customer.CheckInUSA())
        {
            cost = cost + _USAshippingCost;
        }
        else
        {
            cost = cost + _OutsideShippingCost;
        }
        return cost;
    }
    

    public string PackingLabel()
    {
        Console.WriteLine("Packing Label:\n");
        List <string> productNameAndCode = new List <string>();
        foreach (Product product in _listOfProducts)
        {
            string printform = product.GetName() + " " + product.GetProductID();
            productNameAndCode.Add(printform);
        }
        return _customer.GetName() +"\n" + string.Join("\n",productNameAndCode);
    }

    public string ShippingLabel()
    {
        Console.WriteLine("Shipping Label:\n");
        return _customer.GetName() + "\n" + _customer.GetAddress();
    }

}
}