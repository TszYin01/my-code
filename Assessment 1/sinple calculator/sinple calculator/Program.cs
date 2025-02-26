using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1;
            float num2;
            string userOperation;

            Console.WriteLine("enter first number");
            num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            num2 = float.Parse(Console.ReadLine());

           Console.WriteLine("enter operation: + - / *");
            userOperation = Console.ReadLine();

            float result = 0;

            switch (userOperation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;

            }
            Console.WriteLine("result is " + result);
            Console.ReadKey();
        }
    }
}
