using System;
using System.IO;

class Program
{
  static void Main () 
  {
     string put = "numsTask3.txt";

     Random rnd = new Random();
     Console.WriteLine("Enter the number of numbers: ");
     int n = Convert.ToInt32(Console.ReadLine());
     int[] nums = new int[n];

     for (int i = 0; i < nums.Length; ++i)
     {
         nums[i] = rnd.Next(-10, 10);
     }

     string row = string.Join(", ", nums);
     File.AppendAllText(put, row);

    int minimum = nums[0], maximum = nums[0];
    for(int i = 0; i < nums.Length; ++i)
    {
      if(nums[i] < minimum)
      {
        minimum = nums[i];
      }
      if(nums[i] > maximum)
      {
         maximum = nums[i];
      }
    }
     double result = (double)minimum/maximum;
     Console.WriteLine("the ratio of the minimum element to the maximum: " + result);
     string cow = result.ToString();
     File.AppendAllText(put,"\n" + "the ratio of the minimum element to the maximum: " + cow);
    
     Console.ReadKey();
     File.Delete(put);
  }
}