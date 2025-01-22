using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string name0 = Console.ReadLine();
        Console.Write("What is your last name? ");
        string name1 = Console.ReadLine();
        Console.WriteLine($"\r\nYour name is {name1}, {name0} {name1}.");
    }
}