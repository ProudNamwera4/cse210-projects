using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");

        Console.WriteLine("Enter the details of the verse you wish to memorize:");
       


        string quit = "";
        
        Console.Write("Book:");
        string book = Console.ReadLine();
        Console.Write("Chapter: ");
        string chapter = Console.ReadLine();
        Console.Write("Verse number: ");
        string startVerse = Console.ReadLine();
        Console.Write("Text: ");
        string text = Console.ReadLine();
        //string text = "Length of days is in her right hand; and in her left hand riches and honor.";
        string scripture = $"{book} {chapter}:{startVerse} : {text}";
        Console.Clear();  
        Console.WriteLine($"{scripture}");

        Reference reference1 = new Reference(book,chapter,startVerse);
        Scripture scripture1 = new Scripture(text,reference1);
        
       

       

        Console.Write("\nPress enter to continue or type 'quit' to finish: ");
        quit = Console.ReadLine();
         do{
        if (quit == "quit"){
            break;
        }else if (quit == ""){
            Console.Clear();
            scripture1.HideWords();
            scripture1.GetRenderedText();
            Console.WriteLine("");
            Console.Write("\nPress enter to continue or type 'quit' to finish: ");
            quit = Console.ReadLine();

            
        }
          
        }while(quit == "");

    }
}


/*
To exceed the requirements, I made it possible for the user to enter the details of the
scripture they would like to memorize. Jotting it down also helps to better remember the words of the verse.
*/