using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myVariable = 5;
            Console.WriteLine("value of variable before:" + myVariable); 
            
            int myRemainder = myVariable % 3;

            myVariable /= 3;

            Console.WriteLine("value of variable after:" + myVariable + "with" + myRemainder + ".");


            int health = 90;
            int healBonus = 10;
            Console.WriteLine("You have " +  health + " health.");
            health = health + healBonus;
            Console.WriteLine("You have " + health + " health.");

            int myNumberIsThis = 5;

            float myFloat = 5.4f;

            myNumberIsThis = 10;

            string greeting = "hello user!";
            int playerScore = 0;
            int pointValue = 5;
            int comboMult = 2;

            string displayScore = "your score currently is " + playerScore + ".";

            Console.WriteLine(greeting);
            Console.WriteLine(displayScore);

            playerScore += pointValue * comboMult;
            displayScore = "your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);

            comboMult ++;

            playerScore += pointValue * comboMult;
            displayScore = "your score is now " + playerScore + ".";
            Console.WriteLine(displayScore);

        }
    }
}
