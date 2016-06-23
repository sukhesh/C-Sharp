using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "Hello World..!";
            //string str = "Hello \"Sukhesh\"";
           // string str = String.Format("{0}!", "India");
            //string str = String.Format("Get {0} Model {1} Because {2}", "BMW","780i,", "That car is awesome");
            //string str = String.Format("{0:C}", 123.00);
            //string str = String.Format("{0:N}", 123456789);
            //string str = String.Format("{0:P}", .123);
            //string str = String.Format("Phone Number : (+91){0:###-###-####}",9620403028);

           /*
            string str = "";
            for (int i = 0; i <= 99; i++)
            {
                //str = str + "--" + i;
                str += "--" + i;
            }
            Console.Write(str);
            */

            /*
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                str.Append("--");
                str.Append(i);
            }
            Console.WriteLine(str);

            Console.ReadLine();
             * */

            string str = " Spanish eyes looking into spanish eyes ";
            //str = str.Substring(3, 10);
            //str = str.ToUpper();
           // str = str.Replace(" ", "--");
            str = String.Format(" Length before Trim : {0} \n Length After Trim  : {1}", str.Length, str.Trim().Length);
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
