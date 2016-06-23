using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("Values.txt");
            string line = "";
            string line1 = "";
           
            Console.WriteLine("Contents of file :\n");
           
            while(line != null)
            {
                line = reader.ReadLine();
                Console.WriteLine(line);
            }
            
            Console.WriteLine();

            Console.WriteLine("HashCode of the file is :");
                line1 = reader.GetHashCode().ToString();
                Console.WriteLine(line1);

               
            reader.Close();
            Console.ReadLine();
        }
    }
}
