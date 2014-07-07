using System;

namespace Vehicle
{

    /// <summary>
    /// Class for a Vehicle.
    /// </summary>
    class Bicycle : Vehicle
    {
        /// <summary>
        /// Initiates a new Bicycle type object.
        /// </summary>
        /// <param name="make">Maker of the bicycle</param>
        /// <param name="year_of_manufacture">Manufacturing year</param>
        /// <param name="model">Model name</param>
        /// <param name="speed">Speed</param>
        public Bicycle(string make, int year_of_manufacture, string model, float speed)
            : base(make, year_of_manufacture, model, speed, 2)
        {
            Console.WriteLine("This is Bicycle.");
        }
    }
}
