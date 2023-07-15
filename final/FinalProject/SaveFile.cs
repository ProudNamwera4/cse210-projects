public class SaveFile: Files {
    public SaveFile(string filename): base(filename){

    }
    public void SaveItems(List<Item> Cart){      
        using (StreamWriter outputFile = new StreamWriter(base.GetFilename())){
            outputFile.WriteLine($"Product \t Price \t Quantity");
            for(int i = 0; i< Cart.Count();i++){
            outputFile.WriteLine($"{Cart[i].GetStringRepresantation()}");
            }
        }
        Console.WriteLine($"Items Successfully saved in {base.GetFilename()}.");
        Console.WriteLine("");

    }
    public void SaveTransaction(float totalCost, string timeOfTransaction){
        using (StreamWriter outputFile = new StreamWriter("Transactions.txt")){
            outputFile.WriteLine($"You payed a list of items costing {totalCost} on {timeOfTransaction}");
        }
    }
}