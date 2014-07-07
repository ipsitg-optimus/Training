using System;

namespace AdapterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Non-adapted chemical compound
            Compound unknown = new Compound("Unknown");
            unknown.Display();

            // Adapted chemical compounds
            Compound water = new CompoundAdapter("Water");
            water.Display();

            Compound benzene = new CompoundAdapter("Benzene");
            benzene.Display();

            Compound ethanol = new CompoundAdapter("Ethanol");
            ethanol.Display();
            Console.ReadKey();
        }
    }
}
