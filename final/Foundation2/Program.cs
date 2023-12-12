using System;

namespace Foundation2

{
class Program
{
    static void Main(string[] args)
    {
        List <Order> l1 = new List <Order> ();

        Order o1 = new Order();
        o1.SetCustomer("Grazelle Sanchez","34 South Drive,Saltlake City,Utah,USA");
        o1.SetOrder("Spoon", "100XD", 1,1);
        o1.SetOrder("Table","200TX",1,1);
        l1.Add(o1);

        Order o2 = new Order();
        o2.SetCustomer("Somie Sanchez", "22 St Peter Steet,Orem,Utah,USA");
        o2.SetOrder("Pen", "310PN", 1,1);
        o2.SetOrder("J-tube","320GH", 1,2);
        l1.Add(o2);

        foreach (Order o in l1)
        {

        Console.WriteLine();
        string packingLabel = o.PackingLabel();
        
        Console.WriteLine(packingLabel);
        Console.WriteLine();


        string shippingLabel = o.ShippingLabel();
        
        Console.WriteLine (shippingLabel);

        Console.WriteLine($"The total price of the order is: {o.CalculateCostOfOrder()}\n");
        }


    }
}
}