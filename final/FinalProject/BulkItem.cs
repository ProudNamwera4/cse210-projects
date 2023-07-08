public class BulkItem: Item{
    private int _quantity;

    public BulkItem(string productName,float price, int quantity):base(productName, price){
        _quantity = quantity;
    }

    public override void DisplayProduct(){
        Console.WriteLine($"Product: {base.GetProductName()} Price: {base.GetPrice()} Quantity: {_quantity}");
    }

}