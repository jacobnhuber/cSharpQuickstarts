using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeIfAndElseWorkTogether
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //int b = 3;
            //if (a + b > 10)
            //    Console.WriteLine("The answer is greater than 10");
            //else
            //    Console.WriteLine("The answer is not greater than 10");

            //int a = 5;
            //int b = 3;
            //int c = 4;
            //if ((a + b + c > 10) && ( a > b))
            //{
            //    Console.WriteLine("The answer is greater than 10");
            //    Console.WriteLine("And the first nummber is greater than the second");
            //}
            //else
            //{
            //    Console.WriteLine("Tje amswer is not greater than 10");
            //    Console.WriteLine("Or the first number is not greater than the second");
            //}

            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }
    }
}
