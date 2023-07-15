public abstract class Item{
    private string _productName;
    private float _price;
   

    public void SetProductName(string productName){
        _productName = productName;
    }
    public void setPrice(float price){
        _price = price;
    }
    public string GetProductName(){
        return _productName;
    }
    public virtual float GetPrice(){
        return _price;
    }
    public abstract string GetStringRepresantation();

    public virtual void DisplayProduct(){
        Console.WriteLine($"Product: {_productName} || Price: ${_price}");
    }

    public Item(string productName,float price){
        _productName = productName;
        _price = price;

    }


}