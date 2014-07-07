using System;

namespace FactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BikeFactory bikefactory = new ConcreteBikeFactory();
            Bike bike = bikefactory.GetBike();
            Console.WriteLine(bike.Speed);
            Console.ReadKey();
        }
    }
}
