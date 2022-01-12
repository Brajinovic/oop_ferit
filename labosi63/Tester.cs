using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labosi63
{
    static class Tester
    {
        public static void GetAvailableManufacturers()
        {
            var cars = Networking.GetUsedCars().OrderBy(single => single.Make).Select(single => single.Make).Distinct();
            foreach(var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }

        public static void GetHighestMileageManufacturer()
        {
            var cars = Networking.GetUsedCars().Where(single => single.Km == Networking.GetUsedCars().Max(single => single.Km)).Select(single => single.Make);
            foreach(var car in cars) { 
                Console.WriteLine(car.ToString());
            }
        }

        public static void CalculateAverageAgeDacia()
        {
            var age = Networking.GetUsedCars().Where(single => single.Make == "Dacia").Average(single => single.Year);
            Console.WriteLine(2022 - age);
        }

        public static void GetTimeFrameOfManufacturing()
        {
            var jungest = Networking.GetUsedCars().Max(single => single.Year);
            var oldest = Networking.GetUsedCars().Min(single => single.Year);
            Console.WriteLine($"From {oldest} to {jungest}");
        }
    }
}
