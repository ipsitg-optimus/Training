
using System.Collections;
namespace Vehicle
{
    class VehicleCollections : IEnumerable
    {
        #region private members

        private Vehicle[] vehicle;
        #endregion

        /// <summary>
        /// Initiates a new List of Vehicles
        /// </summary>
        /// <param name="varray">Array of Vehicle objects</param>
        public VehicleCollections(Vehicle[] varray)
        {
            vehicle = new Vehicle[varray.Length];
            for (int i = 0; i < varray.Length; i++)
                vehicle[i] = varray[i];
        }

        /// <summary>
        /// Iterates through each element.
        /// </summary>
        /// <returns>instance current list item while traversing.</returns>
        public IEnumerator GetEnumerator()
        {
            foreach (Vehicle v in vehicle)
            {
                if (v == null)
                    break;
                else
                    yield return v;
            }
        }
    }
}
