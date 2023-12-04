using System;
using System.IO;

class Program
{
  public static void Main (string[] args) 
  {
     string put = "numsTask2.txt";
      
     Random rnd = new Random();
     Console.WriteLine("Enter the number of numbers: ");
     int n = Convert.ToInt32(Console.ReadLine());
     double[] nums = new double[n];

     for (int i = 0; i < nums.Length; ++i)
     {
         nums[i] = rnd.NextDouble() * (10 + 10) - 10;
     }
    
     string row = string.Join("; ", nums);
     File.AppendAllText(put, row);
     
    

     double sum = 0;
     foreach (double number in nums)
     {
       if (number > 0)
       {
         sum += number;
       }
     }
     Console.WriteLine("The sum of the positive numbers: " + sum);
     string cow = sum.ToString();
     File.AppendAllText(put,"\n" + cow);
  
     Console.ReadKey();
     File.Delete(put);
  }
}