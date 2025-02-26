using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            int count = 1500;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int number =0;
            
            if (number<10)
            {
                number++;
            }

            //do
            //{
            //    count++;
            //    Console.WriteLine(count);

            //    isRunning = count < 1000;
            //} while (count < 1000);


        }
    }
}
