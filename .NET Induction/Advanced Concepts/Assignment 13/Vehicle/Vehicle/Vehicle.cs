﻿using System;
using System.Collections.Generic;

namespace Vehicle
{
    class Vehicle : IComparable
    {
        #region private members
        protected string make;
        protected int year_of_manufacture;
        protected string model;
        protected float speed;
        protected int wheels;

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
        public Vehicle(string make, int year_of_manufacture, string model, float speed, int wheels)
        {
            this.make = make;
            this.year_of_manufacture = year_of_manufacture;
            this.model = model;
            this.speed = speed;
            this.wheels = wheels;
        }

        /// <summary>
        /// Compares with other Vehicle object.
        /// </summary>
        /// <param name="other">other object of the vehicle with which to compare.</param>
        /// <returns>
        /// </returns>
        public int CompareTo(object other)
        {
            Vehicle v = other as Vehicle;
            if (this.make.Equals(v.make))
                return this.year_of_manufacture.CompareTo(v.year_of_manufacture);
            return this.make.CompareTo(v.make);
        }

        /// <summary>
        /// Checks for equality of two vehicles.
        /// </summary>
        /// <param name="obj">other object to compare</param>
        /// <returns>True if both are equal
        /// else
        /// False
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Vehicle v = obj as Vehicle;
            if ((System.Object)v == null)
            {
                return false;
            }
            return (make.Equals(v.make) && model.Equals(v.model));
        }

        /// <summary>
        /// Accelerates the vehicle.
        /// </summary>
        public void Accelerate()
        {
            speed += 1.0f;
        }

        /// <summary>
        /// Accelerates the vehicle.
        /// </summary>
        public void Deaccelarate()
        {
            if (speed >= 1.0f)
                speed -= 1.0f;
            else
                speed = 0f;
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
