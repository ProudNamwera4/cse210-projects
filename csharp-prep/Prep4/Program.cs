using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int number = 0;

        Console.WriteLine("Enter a lsit of numbers, type 0 when finished.");
        do{
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            numbers.Add(number);
        }while(number !=0 );
        numbers.Remove(0);

        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        
        Console.WriteLine($"The average is: {average}");

        int largestNumber = number;
        for (int i =0; i < numbers.Count; i++){
            if (numbers[i] > largestNumber){
                largestNumber = numbers[i];
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
        int largestPositiveNumber =largestNumber;
        for (int i =0; i< numbers.Count; i++){
            if (numbers[i] < largestPositiveNumber && numbers[i] > 0){
            largestPositiveNumber = numbers[i];
            }
        }
        Console.WriteLine($"The largest positive number is: {largestPositiveNumber}");
        
        numbers.Sort();
        foreach (int num in numbers){
            Console.WriteLine("The sorted list is:");
            Console.WriteLine(num);
        }
    }
}