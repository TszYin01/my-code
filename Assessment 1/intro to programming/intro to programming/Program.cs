using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro_to_programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example();
            string givenNamefirst;

            Console.WriteLine("what is your First name?");

            givenNamefirst = Console.ReadLine();
            string givenNameLast;
            Console.WriteLine("what is your last Name");
            givenNameLast = Console.ReadLine();
            Console.WriteLine($"Hello {givenNamefirst} {givenNameLast}");
            Console.ReadKey();


        }
        static void Example()
        {
            Console.WriteLine("Hello");
            Console.Write("how are you? \n");


        } 
        
            
    }
}
