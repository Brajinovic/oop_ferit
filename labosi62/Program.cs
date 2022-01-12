using System;
using System.Collections.Generic;

namespace labosi62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number: ");
            Random generator = new Random();
            int number = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for(int i = 0; i < number; i++)
            {
                list.Add(generator.Next(-10, 10));
            }

            Func<int, bool> divisibleByThree = x => x % 3 == 0;
            Func<int, bool> inGivenRange = x => x >= -5 && x <= 5;

            Utilities.Filter(list, divisibleByThree);
            Utilities.Filter(list, inGivenRange);
        }
    }
}
