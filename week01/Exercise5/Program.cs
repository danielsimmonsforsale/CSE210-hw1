using System;

class Program
{
    static void Welcome()
    {
        Console.WriteLine("Welcome to the program.");
    }

    static string Name()
    {
        Console.Write("What is your Name: ");
        string name = Console.ReadLine();
        return name;
    }
    static void DisplayResult(int number, string noun)
    {
        Console.WriteLine($"{noun}, the square of your number is {number}." );
    }
    static int Digits()
    {
        Console.Write("Please enter a number: ");
        int jarlballing = int.Parse(Console.ReadLine());
        return jarlballing;
    }
    static int Squared(int number)
    {
        number = number*number;
        return number;
    }
    static void Main(string[] args)
    {
        Welcome();
        string name = Name();
        int favNum = Digits();
        int square = Squared(favNum);
        DisplayResult(square,name);
    }
}