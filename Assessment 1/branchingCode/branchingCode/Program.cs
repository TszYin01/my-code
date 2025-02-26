using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace branchingCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHealth = 100;
            int monsterDamage = 90;

            //Monster hits player
            playerHealth -= monsterDamage;

            Console.WriteLine("monster attacked for " + monsterDamage + "damage");

            bool checkHealth = playerHealth <= 0;

            if (checkHealth)
            {
                Console.WriteLine("You died. Game Over");
            }

            else if (playerHealth > 0)
            {
                Console.WriteLine("you have" + playerHealth + " health left");
                Console.WriteLine("the monster prepares to attack again!");

            }
            if (monsterDamage > 50)
            {
                Console.WriteLine("The Monster is very stong");
            }
        }
    }
}
