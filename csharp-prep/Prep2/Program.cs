using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage: ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
           letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }



        string sign = "";
        int lastDigit = grade % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if(lastDigit < 3)
        {
            sign = "-";
        }
        else{
            sign = "";
        }

        if (grade >= 97 || letter == "F")
        {
            sign = "";
        }



         Console.WriteLine($"Letter grade: {letter}{sign}");
         if (letter == "F" || letter == "D")
         {
            Console.WriteLine("Unfortunately, you did not pass the course. Try again next time.");
         }
         else 
         {
            Console.WriteLine("Congratulations, you passed the course");
         }
    }
}