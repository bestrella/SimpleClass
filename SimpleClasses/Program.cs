using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car mynewCar = new Car();

            mynewCar.Make = "Old skul";
            mynewCar.Model = "Cutlas Supreme";
            mynewCar.Year = 1986;
            mynewCar.color = "silver";

            Console.WriteLine("{0} - {1} - {2}", mynewCar.Make, mynewCar.Model, mynewCar.color);

            // double marketvalueofCar = DecimalMarketValue(mynewCar);

            Console.WriteLine("Car's value: {0:C}", mynewCar.DetermineMarketValue());


            Console.ReadLine();
        }


        private static double determineMarketValue(Car _car)
        {
            double carValue = 100.00;

            return carValue;

        }
    }


    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string color { get; set; }


        public double DetermineMarketValue()
        {
            double carValue = 100.00;

            if (this.Year > 1990)
                carValue = 10000.0;
            else
                carValue = 20000.0;


            return carValue;
        }
       

    }
}
