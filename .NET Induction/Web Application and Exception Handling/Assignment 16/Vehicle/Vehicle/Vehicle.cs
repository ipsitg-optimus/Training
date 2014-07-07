using System;

namespace Vehicle
{
    class Vehicle
    {
        #region private members
        protected string make;
        protected int year_of_manufacture;
        protected string model;
        protected float speed;
        protected int wheels;
        protected int max_speed;

        #endregion

        #region Properties
        public string Make
        {
            get
            {
                return make;
            }
        }
        public int YearOfManufacture
        {
            get
            {
                return year_of_manufacture;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
        }
        public float Speed
        {
            get
            {
                return speed;
            }
        }
        public int Wheels
        {
            get
            {
                return wheels;
            }
        }
        #endregion

        /// <summary>
        /// Constructor for initializing a new vehicle's object.
        /// </summary>
        /// <param name="make">Maker of the vehicle.</param>
        /// <param name="year_of_manufacture">Manufacturing year</param>
        /// <param name="model">Model name</param>
        /// <param name="speed">Speed</param>
        /// <param name="wheels">Number of wheels</param>
        public Vehicle(string make, int year_of_manufacture, string model, float speed, int wheels, int max_speed)
        {
            this.make = make;
            this.year_of_manufacture = year_of_manufacture;
            this.model = model;
            this.speed = speed;
            this.wheels = wheels;
            this.max_speed = max_speed;
        }

        /// <summary>
        /// Accelerates the vehicle.
        /// </summary>
        public void Accelerate()
        {
            if (speed >= max_speed)
                throw new IsCarDeadException("Car has overheated!!");
            speed += 1.0f;
        }

        /// <summary>
        /// Decelerates the vehicle.
        /// </summary>
        public void Deaccelarate()
        {
            if (speed >= 1.0f)
                speed -= 1.0f;
            else
                throw new IsCarDeadException("Car has overheated!!");
        }

        /// <summary>
        /// Stops the vehicle.
        /// </summary>
        public void Stop()
        {
            speed = 0f;
        }

        /// <summary>
        /// Checks whether vehicle is moving.
        /// </summary>
        /// <returns>True if moving else False.</returns>
        public bool IsMoving()
        {
            if (speed > 0)
                return true;
            else
                return false;
        }
    }
}
