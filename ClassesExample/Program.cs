using System;
using System.Collections.Generic;

namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //dot notation
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Focus";
            myCar.Year = 2013;

            //object intitialization
            var mazda = new Car()
            {
                Make = "Mazda",
                Model = "CX-5",
                Year = 2016
            };

            //passing in through the constructor
            Car chevy = new Car("Chevy", "Impala", 2001);


            var CarList = new List<Car>() { myCar, mazda, chevy};

            foreach (var vehicle in CarList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
