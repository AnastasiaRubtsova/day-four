using System;
using System.IO;

class Program 
{
  static void Main ()
  {
    string put = "numsTask4.txt";

     Random rnd = new Random();
     Console.WriteLine("Enter the number of numbers:");
     int n = Convert.ToInt32(Console.ReadLine());
     int[] nums = new int[n];

     for (int i = 0; i < nums.Length; ++i)
     {
         nums[i] = rnd.Next(-10, 10);
     }

     string row = string.Join(" ", nums);
     File.AppendAllText(put, row);

     int count = 0;
     for (int i = 0; i < nums.Length - 1; ++i)
     {
      if (nums[i] == nums[i + 1])
       {
         
         ++count;
       }
      
     }
     Console.WriteLine("The number of pairs of identical numbers standing next to each other"  + "\n" + count);
     string cow = count.ToString();
    File.AppendAllText(put,"\n" + "The number of pairs of identical numbers standing next to each other" + "\n" + cow);

      Console.ReadKey();
      File.Delete(put);
  }
}