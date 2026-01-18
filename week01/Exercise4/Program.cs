using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine(""); 
        List<int> nums = new List<int>();
        Console.WriteLine("Enter a list of numbers and type 0 when finished. "); 
        Console.WriteLine("Enter a number: ");
        string str = Console.ReadLine();
        int input = int.Parse(str);
        
        while (input != 0)
        {
            nums.Add(input);
            Console.WriteLine("Enter a number: ");
            str = Console.ReadLine();
            input = int.Parse(str);
            
        }
        int sum = 0;
        foreach (int num in nums)
        {
            sum = sum + num; 
        }
        int max = -2000;
        foreach (int com in nums)
        {
            if (com >= max)
            {
                max = com;
            }
        }
        

        Console.WriteLine($"The total is {sum} ");
        double sum1 = Convert.ToDouble(sum);
        double avg = sum1/(nums.Count()); 
        Console.WriteLine($"The average is {avg.ToString("F5")} ");
        Console.WriteLine($"The largest number is {max} ");
    }
}
