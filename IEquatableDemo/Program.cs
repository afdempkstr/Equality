using System;
using System.Collections.Generic;

namespace IEquatableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle();
            Vehicle v2 = new Vehicle("My bicycle", 60);
            Vehicle v3 = new Vehicle("Bugatti Chiron", 467);
            Vehicle v4 = new Vehicle("Airbus A380", 1020);
            Vehicle v5 = null;

            //initialize a list of vehicles and add all these vehicles
            var vehicles = new List<Vehicle>() { v1, v2, v3, v4, v5 };

            //compare each vehicle in the list to the rest using the default equality
            foreach (var v in vehicles)
            {
                Console.WriteLine($"{v} equals {v1} = {object.Equals(v, v1)}");
                Console.WriteLine($"{v} equals {v2} = {object.Equals(v, v2)}");
                Console.WriteLine($"{v} equals {v3} = {object.Equals(v, v3)}");
                Console.WriteLine($"{v} equals {v4} = {object.Equals(v, v4)}");
                Console.WriteLine($"{v} equals {v5} = {object.Equals(v, v5)}");
            }

        }
    }
}
