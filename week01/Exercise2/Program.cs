using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your grade? ");
        string x = Console.ReadLine();
        
        int grade = int.Parse(x);
        string letter = "x";
        if (grade >= 90 && grade <= 100)
        {
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }
        else if (grade < 60 && grade >= 0)
        {
            letter = "F";
        }
        else
        {
            letter = "What kind of grade is that??";
        }
        
        Console.Write($"\r\n{letter}");
        if (grade >= 70 && grade <= 100)
        {
            Console.Write("! You Passed Bozo!!");
        }
        else if (grade < 70 && grade >= 0)
        {
            Console.Write("! Better luck next time champ.");
        }
        else
        {
            Console.Write(" How did you even get that?!?");
        }
    }
}