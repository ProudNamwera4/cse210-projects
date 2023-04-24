using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
       bool playAgain = false;
        do{
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,100);

            int userGuess = 0;
            int guessCount = 0;
            do{
            Console.Write("what is your guess? ");
            string guess = Console.ReadLine();
            guessCount++;
            userGuess = int.Parse(guess);

            
                if (userGuess < magicNumber){
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber){
                    Console.WriteLine("Lower");
                }
                else{
                    Console.WriteLine($"You guessed it! After {guessCount} tries.");
                }
            }while(userGuess != magicNumber);

            Console.Write("Do you wish to play again? ");
            string play = Console.ReadLine();
            if (play == "yes"){
                playAgain = true;
            }else{
                playAgain = false;
                Console.Write("Thank you for playing.");
                Console.WriteLine();
            }
        }while(playAgain == true);
    }
}