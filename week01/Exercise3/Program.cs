using System;

class Program
{
    static void Main(string[] args)
    {
        int play = 1;
        int checkNum = 0;    
        while (play != 0)
        {
            int guesses = 0;       
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 100);
            Console.Write("What's the Magic Number? ");
            while (checkNum != magicNum)
            {
                guesses = guesses+1;
                checkNum = int.Parse(Console.ReadLine());
                    if (checkNum == magicNum)
                    {
                        Console.WriteLine("\r\nCorrect!");
                        Console.WriteLine($"You guessed {guesses} times.");
                    }
                    else if (checkNum > magicNum)
                    {
                        Console.WriteLine("\r\nLower!");
                    }
                    else
                    {
                        Console.WriteLine("\r\nHigher!");
                    }
            }
            Console.WriteLine("Press 0 to quit\r\nPress 1 to keep playing");
            play = int.Parse(Console.ReadLine());
        }
    }
}