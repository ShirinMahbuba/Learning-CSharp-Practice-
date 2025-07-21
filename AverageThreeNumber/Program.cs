using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageThreeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;
            Console.WriteLine("First Number :");
            string input = Console.ReadLine();
            //num = double.Parse(input);
            if (!double.TryParse(input, out num))
            {
                Console.WriteLine("Invalid input first number");
                return;
            }

            double num2;
            Console.WriteLine("Seound Number :");
            string input2 = Console.ReadLine();
            //num2 = double.Parse(input2);
            if(!double.TryParse(input2, out num2))
            {
                Console.WriteLine("Invalid input secound Number");
                return;
            }

            double num3;
            Console.WriteLine("third Number:");
            string input3 = Console.ReadLine();
            //num3 = double.Parse(input3);
            if(!double.TryParse(input3, out num3))
            {
                Console.WriteLine("invalid third number");
                return;
            }

            double average = (num + num2 + num3) / 3;
            Console.WriteLine("average Number :" +average);
            Console.ReadKey();
           

        }
    }
}
