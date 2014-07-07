using System;

namespace Vehicle
{
    /// <summary>
    /// Class for storing Truck's information.
    /// </summary>
    class Truck : Vehicle
    {
        #region Private members
        private int gears;

        #endregion

        #region Properties
        public int Gears
        {
            get
            {
                return gears;
            }
        }
        #endregion

        /// <summary>
        /// Initiates a new Truck variable.
        /// </summary>
        /// <param name="make">Maker of the Truck</param>
        /// <param name="year_of_manufacture">Manufacturing year</param>
        /// <param name="model">Model's Name</param>
        /// <param name="speed">Speed</param>
        /// <param name="gears">Number of gears</param>
        public Truck(string make, int year_of_manufacture, string model, float speed, int gears)
            : base(make, year_of_manufacture, model, speed, 6,100)
        {
            this.gears = gears;
            Console.WriteLine("This is Truck.");
        }
    }
}
