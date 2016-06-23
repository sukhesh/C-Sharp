using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string myVal = superFormula();
            Console.WriteLine(myVal);
            Console.WriteLine();

            string myVal1 = superFormula("Sukhesh");
            Console.WriteLine(myVal1);
            Console.WriteLine();

            long myVal2 = superFormula(0);
            Console.WriteLine("My phone number is :"+myVal2);
            Console.WriteLine();

            Console.ReadLine();
        }

        private static string superFormula()
        {
            return "Hello...";
        }

        private static string superFormula(string name)
        {
            return String.Format("My name is {0}", name);
        }
        private static long superFormula(int no)
        {
            return 9620403028;
        }

    }
}