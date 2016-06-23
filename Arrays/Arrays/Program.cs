using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[5];

            num[0] = 1;
            num[1] = 2;
            num[2] = 3;
            num[3] = 4;
            num[4] = 5;
            */

            /*
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine(num[3]);
            Console.ReadLine();
             */

            /*
            string[] names = new string[] { "aaa", "bbb", "ccc", "ddd", "eee", "fff", "ggg", };

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
             */

            string zig = "You can get what you want out of life" 
                        + "If you help enough other people to get what they want";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigReversed in charArray)
                Console.Write(zigReversed);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Total number of characters in zig including whitespaces are :"+charArray.Length);
            Console.ReadLine();
        }
    }
}
