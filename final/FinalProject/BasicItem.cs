public class BasicItem: Item{
    public override float GetPrice(){
        return base.GetPrice();

    }

    public override void DisplayProduct(){
        Console.WriteLine($"Prudct: {base.GetProductName()} || Price: ${base.GetPrice()}");
    }

    public BasicItem(string productName,float price): base(productName,price){


    }
    public override string GetStringRepresantation(){
       return $"{base.GetProductName()} , {base.GetPrice()}";
       
    }

}