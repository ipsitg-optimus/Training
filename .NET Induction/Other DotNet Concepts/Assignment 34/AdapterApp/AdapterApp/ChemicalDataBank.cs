
namespace AdapterApp
{
    class ChemicalDatabank
    {
        /// <summary>
        /// Method for getting critical point of a compound
        /// </summary>
        /// <param name="compound">name of compound to be searched</param>
        /// <param name="point">type of critical point.</param>
        /// <returns>critical point of the compound.</returns>
        public float GetCriticalPoint(string compound, string point)
        {
            // Melting Point
            if (point == "M")
            {
                switch (compound.ToLower())
                {
                    case "water": return 0.0f;
                    case "benzene": return 5.5f;
                    case "ethanol": return -114.1f;
                    default: return 0f;
                }
            }
            // Boiling Point
            else
            {
                switch (compound.ToLower())
                {
                    case "water": return 100.0f;
                    case "benzene": return 80.1f;
                    case "ethanol": return 78.3f;
                    default: return 0f;
                }
            }
        }

        /// <summary>
        /// gets molecular structure of the compound.
        /// </summary>
        /// <param name="compound">name of compound.</param>
        /// <returns>molecular structure of compound.</returns>
        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }

        /// <summary>
        /// gets the molecular weight of the compound.
        /// </summary>
        /// <param name="compound">name of the compound.</param>
        /// <returns>molecular weight of the compound.</returns>
        public double GetMolecularWeight(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return 18.015;
                case "benzene": return 78.1134;
                case "ethanol": return 46.0688;
                default: return 0d;
            }
        }
    }
}
