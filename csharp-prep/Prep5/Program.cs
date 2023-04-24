using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int squredNum = SquareNumber(favNum);
        DisplayResult(name,squredNum);

    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber(){
         Console.Write("Please enter your favorite number: ");
         string favoriteNumber = Console.ReadLine();
         int favNum = int.Parse(favoriteNumber);

         return favNum;
    }

    static int SquareNumber(int integer){
        int squaredNum = integer * integer;
        return squaredNum;
    }

    static void DisplayResult(string name, int squaredNumber){
        Console.WriteLine($"{name} the square of your number is {squaredNumber}");
    }
}