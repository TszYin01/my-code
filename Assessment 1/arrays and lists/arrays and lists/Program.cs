using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_and_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5];

            myArray[0] = 45;
            myArray[1] = 34;
            myArray[2] = 56;
            myArray[3] = 22;

            Console.WriteLine(myArray[1]);
            Console.WriteLine(myArray[4]);
            Console.WriteLine(myArray[0]);
            Console.WriteLine(myArray[5]);
            Console.ReadKey();
        }

    }
}
