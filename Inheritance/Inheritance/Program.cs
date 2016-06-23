using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "BMW";
            myCar.Model = "780i";
            myCar.Year = 2016;
            myCar.Colour = "Black";

            CarDetails(myCar);
            Console.ReadLine();

        }

        private static void CarDetails(Car car)
        {
            Console.WriteLine("Here are the Car Details :{0}", car.FormatMe());
        
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set;  }


        public string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make ,
                this.Model,
                this.Year,
                this.Colour);
        }
    }
}
