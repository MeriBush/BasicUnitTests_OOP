using _03_OOP_Defining_Classes_Exercise_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Defining_Classes_Exercise_1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the make of your car.");
            string CarMake = Console.ReadLine();

            Console.WriteLine("Enter the model of your car.");
            string CarModel = Console.ReadLine();

            Console.WriteLine("Enter the year your car was made.");
            string CarYearString = Console.ReadLine();
            int CarYearInt = Int32.Parse(CarYearString);

            Car car = new Car(CarMake, CarModel, CarYearInt);

            Console.WriteLine($"{car.CarMake} {car.CarModel} {car.CarModel}");
        }
    }
}
