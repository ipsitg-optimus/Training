using System;
using System.Collections;
namespace Vehicle
{
    class TestCollection
    {
        static void Main(string[] args)
        {
            // Creates a new ArrayList
            ArrayList vehicleslist = new ArrayList();

            //declares array of vehicle type
            Vehicle[] vehicles = new Vehicle[5];
            vehicles[0] = new Vehicle("Maruti", 2010, "800", 20, 4);
            vehicles[1] = new Vehicle("Hyundai", 2013, "Verna", 25, 4);
            vehicles[2] = new Vehicle("Audi", 2008, "A8", 60, 4);
            vehicles[3] = new Vehicle("Maruti", 2009, "Alto", 20, 4);
            vehicles[4] = new Vehicle("Renault", 2014, "Duster", 40, 4);

            //declares a new car
            Car car = new Car("Honda", 2008, "City", 50, 5);

            //declares a new bike
            Bike bike = new Bike("TVS", 2001, "Star", 70, 5);

            //add all to arraylist.
            vehicleslist.Add(vehicles[0]);
            vehicleslist.Add(vehicles[1]);
            vehicleslist.Add(vehicles[2]);
            vehicleslist.Add(vehicles[3]);
            vehicleslist.Add(vehicles[4]);
            vehicleslist.Add(car);
            vehicleslist.Add(bike);


            //Iterating through each of them
            foreach (Vehicle v in vehicleslist)
                Console.WriteLine(v.ToString());
            Console.WriteLine("\n\n");
            for (int counter = 0; counter < vehicleslist.Count; counter++)
            {
                Console.WriteLine(vehicleslist[counter].ToString());
            }
            Console.ReadLine();
        }
    }
}
