using System;

namespace Vehicle
{
    class Bike : Vehicle
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
        /// Initiates a new Bike variable.
        /// </summary>
        /// <param name="make">Maker of the bike</param>
        /// <param name="year_of_manufacture">Manufacturing year</param>
        /// <param name="model">Model name</param>
        /// <param name="speed">Speed</param>
        /// <param name="gears">Number of gears</param>
        public Bike(string make, int year_of_manufacture, string model, float speed, int gears)
            : base(make, year_of_manufacture, model, speed, 2)
        {
            this.gears = gears;
        }

    }
}
