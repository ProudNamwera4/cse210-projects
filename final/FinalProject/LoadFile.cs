public class LoadFile: Files{
    public LoadFile(string filename): base(filename){

    }
    public string LoadCart(){
        return "";
    }
    public string LoadTransactions(){
        return "";
    }
    public void LoadItems(List<Item> Cart,BasicItem bsItem, BulkItem bkItem){
        string[] lines = System.IO.File.ReadAllLines(base.GetFilename());
            
        foreach( string line in lines){
            //lines.Skip(0);
            if (!line.Contains("Product")){
                string[] parts = line.Split(",");
                if (parts.Count() == 2){
                    bsItem.SetProductName(parts[0].ToString());
                    bsItem.setPrice(float.Parse(parts[1]));
                    Cart.Add(bsItem);
                }else if (parts.Count() == 3){
                    bkItem.SetProductName(parts[0].ToString());
                    bkItem.setPrice(float.Parse(parts[1]));
                    bkItem.SetQuantity(int.Parse(parts[2]));
                    Cart.Add(bkItem);
                }
            }
           
            

            
        }
        Console.WriteLine("\nItems Loaded successfully to you current Cart.\n");

    }
    public void ViewTransactions(){
        string filename ="Transactions.txt";
        
        string[] lines = System.IO.File.ReadAllLines(filename);
        if (File.Exists(filename)){
            foreach(string line in lines){
                Console.WriteLine();
                Console.WriteLine(line);
                Console.WriteLine();
            }
          
        }else{
            Console.WriteLine("You have no previous transactions!");
        }
       

    }
}