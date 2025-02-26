using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            Random rnd = new Random();
            int number;

            while (isRunning)
            {
                number = rnd.Next(1, 100);

                Console.WriteLine("Guess my number within 5 turns...");

                for (int i = 0; i < 5; i++)
                {
                    int guess = 0;
                    while(int.TryParse(Console.ReadLine(), out guess)==false)
                    {
                        Console.WriteLine("Please enter a number");
                    }



                    if (guess == number)
                    {
                        Console.WriteLine("Congrats! You guessed correct!");
                        break;
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine("Lower...");
                    }
                    else
                    {
                        Console.WriteLine("higher...");
                    }

                }

                Console.WriteLine("Would you like to play again(Y/N)?");

                string userChoice = Console.ReadLine();
                if (userChoice == "y" || userChoice == "y")
                    isRunning = true;
                else
                    isRunning = false;
            }
            Console.WriteLine("THANK for playing");
            Console.ReadKey();

        }
    }
}
