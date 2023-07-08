public abstract class Item{
    private string _productName;
    private float _price;
    private float _vat;

    public virtual float ComputePrice(){
        return _price * _vat;
    }
    public string GetProductName(){
        return _productName;
    }
    public float GetPrice(){
        return _price;
    }

    public virtual void DisplayProduct(){
        Console.WriteLine($"Product: {_productName} Price: {_price}");
    }

    public Item(string productName,float price){
        _productName = productName;
        _price = price;

    }


}