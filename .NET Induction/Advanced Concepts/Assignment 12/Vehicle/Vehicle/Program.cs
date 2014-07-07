using System;
using System.Collections.Generic;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new vehicle
            Vehicle[] vehicles = new Vehicle[5];
            vehicles[0] = new Vehicle("Maruti", 2010, "800", 20, 4);
            vehicles[1] = new Vehicle("Hyundai", 2013, "Verna", 25, 4);
            vehicles[2] = new Vehicle("Audi", 2008, "A8", 60, 4);
            vehicles[3] = new Vehicle("Maruti", 2009, "Alto", 20, 4);
            vehicles[4] = new Vehicle("Renault", 2014, "Duster", 40, 4);

            //Creates a new list and adds all vehicles in the list.
            List<Vehicle> list = new List<Vehicle>();
            list.Add(vehicles[0]);
            list.Add(vehicles[1]);
            list.Add(vehicles[2]);
            list.Add(vehicles[3]);
            list.Add(vehicles[4]);
            list.Sort();

            foreach (Vehicle v in list)
            {
                Console.WriteLine("Maker: {0}  Model: {1}  Year of manufacture: {2}", v.Make, v.Model, v.YearOfManufacture);
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("Vehicle 1 is equal to Vehicle 2 : {0}", vehicles[0].Equals(vehicles[1]));
            VehicleCollections vecoll = new VehicleCollections(vehicles);
            Console.WriteLine("\n\n");
            foreach (Vehicle v in vecoll)
            {
                Console.WriteLine("Maker: {0}  Model: {1}  Year of manufacture: {2}", v.Make, v.Model, v.YearOfManufacture);
            }
            Console.ReadLine();
        }
    }
}
