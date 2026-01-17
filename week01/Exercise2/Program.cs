using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine(""); 
        Console.WriteLine("Please enter your grade percent: "); 
        string percent = Console.ReadLine(); 
        int num = int.Parse(percent); 

        if (num < 60)
        {
            Console.WriteLine("Your grade letter is F"); 
        }
        else if (num >= 90)
        {
            Console.WriteLine("Your grade letter is A");
        }
        else if (num >= 80)
        {
            Console.WriteLine("Your grade letter is B");
        }
        else if (num >= 70)
        {
            Console.WriteLine("Your grade letter is C");
        }
        else if (num >= 60)
        {
            Console.WriteLine("Your grade letter is D");
        }
    }
}
