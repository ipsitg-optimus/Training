using System;

namespace Vehicle
{
    /// <summary>
    /// Class for storing Car's information.
    /// </summary>
    class Car : Vehicle
    {
        #region private members
        private int gears;

        #endregion

        #region properties
        public int Gears
        {
            get
            {
                return gears;
            }
        }
        #endregion

        /// <summary>
        /// Initiates a new Car type variable.
        /// </summary>
        /// <param name="make">Maker of the car</param>
        /// <param name="year_of_manufacture">Manufacturing year</param>
        /// <param name="model">Model Name</param>
        /// <param name="speed">Speed</param>
        /// <param name="gears">Number of gears</param>
        public Car(string make, int year_of_manufacture, string model, float speed, int gears)
            : base(make, year_of_manufacture, model, speed, 4)
        {
            this.gears = gears;
        }
    }
}
