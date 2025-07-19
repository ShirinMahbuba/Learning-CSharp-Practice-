using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevideTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"First Number:");
            string input1 = Console.ReadLine();
            double num1;
            if (!double.TryParse(input1, out num1))
            {
             Console.WriteLine("Invalid input! please input a valid number");
                return;
            }

            Console.WriteLine($"Secound Number:");
            string input2 = Console.ReadLine();
            double num2;

            if(!double.TryParse(input2,out num2))
            {
                Console.WriteLine("Invalid input!please input a valid number");
                return;
            }

            if(num2 == 0)
            {
                Console.WriteLine("cannot devide by zero");
                return;
            }
            double result = num1 / num2;
            Console.WriteLine($"Result : {num1}/{num2}={result}");

            
        }
    }
}
