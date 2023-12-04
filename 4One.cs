using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        int n = int.Parse(Console.ReadLine());

        int result = 1;
        for (int i = 3; i <= n; i += 3)
        {
            result *= i;
        }

        Console.WriteLine("The product of natural numbers that are multiples of three and do not exceed " + n + ": " + result);
    }
}