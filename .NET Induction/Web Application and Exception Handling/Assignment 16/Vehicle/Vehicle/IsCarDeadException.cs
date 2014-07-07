using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    /// <summary>
    /// Class of a custom Exception IsCarDeadException.
    /// </summary>
    class IsCarDeadException : Exception
    {
        /// <summary>
        /// Non parameterized constructor for creating a instance of IsCarDeadException.
        /// </summary>
        public IsCarDeadException()
            : base("Car is dead exception is being thrown!!.")
        {
            Console.Error.WriteLine("Car Exploded at " + System.DateTime.Now);
        }

        /// <summary>
        /// Parameterized constructor for creating a instance of IsCarDeadException.
        /// </summary>
        /// <param name="message">Message to be passed on constructor.</param>
        public IsCarDeadException(string message)
            : base(message)
        {
            Console.Error.WriteLine("Car Exploded at " + System.DateTime.Now);
        }
    }
}
