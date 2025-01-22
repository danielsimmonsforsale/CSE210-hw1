using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        List<int> nums = new List<int>();
        int x = 1;
        float sum = 0;
        int bigBoi = 0;
        while (x != 0)
        {
            Console.Write("Enter Number: ");
            x = int.Parse(Console.ReadLine());
            if (x > 0 || x < 0)
            {
                nums.Add(x);
            }
        }

        foreach (int num in nums)
        {
            sum = sum + num;
            if (num > bigBoi)
            {
                bigBoi = num;
            }
        }
        
        Console.WriteLine($"\r\nThe sum of the list is {sum}");

        float average = sum / nums.Count;
        
        Console.WriteLine($"The average of the list is {average}");

        Console.WriteLine($"The largest number is {bigBoi}.");

    }
}