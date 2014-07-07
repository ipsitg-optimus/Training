using System;

namespace SingleTon
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTon instance1 = SingleTon.Instance;
            SingleTon instance2 = SingleTon.Instance;
            if (instance1 == instance2)
                Console.WriteLine("Both the instances are equal.");
            Console.ReadKey();
        }
    }
}
