using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Welcome to the Journal Program");
        int quit = 1;
        Journal journal = new Journal();
        File file = new File();
        do{
        Entry entry = new Entry();
        
        entry.DisplayMenu();
        Console.Write("What would you like to do? ");
        entry._userChoice = int.Parse(Console.ReadLine());
        PromptGenerator prompt = new PromptGenerator();
        
        
        if (entry._userChoice == 1){
            entry._prompt = prompt.Prompt();
            Console.WriteLine(entry._prompt);
            entry._userResponse = Console.ReadLine();
            entry._date = entry.GetCurrentDate();
            
            journal.AddEntry(entry,journal._entries);
        
        }else if (entry._userChoice == 2){
            journal.DisplayEntries();
        }else if(entry._userChoice == 4){
           file.SaveToFile(journal._entries);
           
        }else if(entry._userChoice == 3){
            file.LoadFromFile();
        }else{
            Console.WriteLine("You have quit the program!");
            quit = 5;
        }
        }while(quit != 5);
    }
}

/* To exceed the minimum requiments, I modified the Prompt class adding a 
    list variable numbers to
    which I add every randomly generated number. The I have a loop which 
    generates a number corresponding to a prompt which has not already 
    been generated. This way, no prompt can be be generated if it already 
    has been during the launch of the program.*/
