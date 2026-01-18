using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 21);

        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine(""); 
        Console.WriteLine("Okay! Let's play the number game! Are you ready? Start guessing! ");
        string guess1 = Console.ReadLine(); 
        int guess = int.Parse(guess1); 

        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Lower!");
                Console.WriteLine("Guess again! ");
                guess1 = Console.ReadLine(); 
                guess = int.Parse(guess1);
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher!"); 
                Console.WriteLine("Guess again! "); 
                guess1 = Console.ReadLine(); 
                guess = int.Parse(guess1);
            }
            else if (number == guess)
            {
                Console.WriteLine("Correct! You win!!!! ");
            }
        }
        Console.WriteLine("Correct! You win!!!! ");
    }
}
