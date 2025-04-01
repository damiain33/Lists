public class Product
{
    // Właściwości
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double UnitPrice { get; set; }


    public Product() { }


    public Product(string name, int quantity, double unitPrice)
    {
        Name = name;
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
}

