public class File{
    public Journal _journal = new Journal();
    public string _fileName ;

    public void SaveToFile(List<Entry> entries){ 
        Console.Write("What is the filename? ");
        string _fileName = Console.ReadLine();
        

        using (StreamWriter outputFile = new StreamWriter(_fileName)){
           foreach (Entry entry in entries){
                outputFile.WriteLine($"{entry._date} - Prompt: {entry._prompt} \n{entry._userResponse}");
           }
            
        }
        Console.WriteLine("File save successfully!");
    
    }


    public void LoadFromFile(){

        Console.Write("What is the filename? ");
        string _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines){
            Console.Write($"\n{line}");
}

    }

}