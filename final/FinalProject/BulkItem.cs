public class BulkItem: Item{
    private int _quantity;

    public BulkItem(string productName,float price, int quantity):base(productName, price){
        _quantity = quantity;
    }
    public void SetQuantity(int quantity){
        _quantity = quantity;
    }

    public override void DisplayProduct(){
        Console.WriteLine($"Product: {base.GetProductName()} || Price: ${base.GetPrice()} || Quantity: {_quantity}");
    }
    public override float GetPrice(){
        return base.GetPrice() * _quantity;
    }
    public int Getquantity(){
        return _quantity;
    }
    public override string GetStringRepresantation(){
       return $"{base.GetProductName()} , {base.GetPrice()} , {_quantity}";
       
    }

}