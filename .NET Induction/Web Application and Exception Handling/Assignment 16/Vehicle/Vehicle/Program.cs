using System;

namespace Vehicle
{
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args">command line arguments</param>
        static void Main(string[] args)
        {
            //Creating a new vehicle
            Vehicle new_vehicle = new Vehicle("Tata", 2005, "i-10", 20, 4, 30);
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Current speed is: {0}", new_vehicle.Speed);
                new_vehicle.Accelerate();
                System.Threading.Thread.Sleep(200);
            }
            Console.WriteLine("New speed is: {0}", new_vehicle.Speed);
            Console.WriteLine("Vehicle is moving :{0}", new_vehicle.IsMoving());
            new_vehicle.Stop();
            Console.WriteLine("New speed is: {0}", new_vehicle.Speed);
            Console.ReadLine();

            //Creating a new Bike

            Bike bike1 = new Bike("Apache", 2012, "RTR", 40, 5);
            Console.WriteLine("Current speed is: {0}", bike1.Speed);
            bike1.Accelerate();
            Console.WriteLine("New speed is: {0}", bike1.Speed);
            Console.WriteLine("Vehicle is moving :{0}", bike1.IsMoving());
            bike1.Stop();
            Console.WriteLine("New speed is: {0}", bike1.Speed);
            Console.ReadLine();
        }
    }
}
