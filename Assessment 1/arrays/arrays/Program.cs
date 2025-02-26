using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 10;

            int[] numbers = { 10, 3, 5, 6, 8, 250, 10, 10, 3, 5};

            Console.WriteLine(numbers[9]);

            Console.WriteLine(numbers.Length);

            List<int> listOfNumberd = new List<int>();

            listOfNumberd.Add(40);
            listOfNumberd.Add(25);
            listOfNumberd.Add(30);
            listOfNumberd.Add(25);
            listOfNumberd.Add(25);

            Console.WriteLine(listOfNumberd[1]);

        }
    }
}
