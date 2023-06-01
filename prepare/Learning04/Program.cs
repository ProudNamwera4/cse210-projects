using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
    
        Assignment assignment = new Assignment("Proud", "Mathematics");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("7.3","8-19","Proud Namwera","Fractions");
        Console.WriteLine($"{mathAssignment.GetSummary()} \n{mathAssignment.GetHomeworkList()}");

        WritingAssignment writingAssignment = new WritingAssignment("Proud Namwera","European History","The Causes of World War II");
        Console.WriteLine($"{writingAssignment.GetSummary()} \n{writingAssignment.GetWritingInformation()}");
    
    }
}