using System;
using System.Collections.Generic;
using System.Text;

namespace labosi63
{
   public class Car : IEquatable<Car>
    {
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Km { get; private set; }
        public int Year { get; private set; }

        public Car(string brand, string type, int km, int year)
        {
            Make = brand;
            Model = type;
            Km = km;
            Year = year;
        }

        public override string ToString() => $"{Make} - {Model} - {Km} - {Year}";

        public override int GetHashCode() => HashCode.Combine(Make, Model, Km, Year);

        public override bool Equals(object obj)
        {
            if (obj is Car == false) return false;
            return this.Equals((Car) obj);
        }

        public bool Equals(Car other) => this.Make == other.Make &&
        this.Model == other.Model &&
        this.Year == other.Year &&
        this.Km == other.Km;

 }
}
