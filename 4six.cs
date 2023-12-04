using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the coordinates of the point:");
        Console.Write("a = ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());

        if(a >= -2 && a <= 0)
        { // y = -3 | y = 5x/2 + 2
            if (b >= -3 && b <= (2.5 * a + 2.0))
            {
                Console.WriteLine("the point belongs to the shaded area.");
            }
            else
            {
                Console.WriteLine("the point lies outside the shaded area.");
            }
        }
        else if(a > 0 && a <= 2)
        { // y = -3 | y -5/2x + 2
            if (b >= -3 && b <= (-2.5 * a + 2.0))
            {
                Console.WriteLine("the point belongs to the shaded area.");
            }
            else
            {
                Console.WriteLine("the point lies outside the shaded area.");
            }
        }
        else
        {
            Console.WriteLine("the point lies outside the shaded area.");
        }
    }
}