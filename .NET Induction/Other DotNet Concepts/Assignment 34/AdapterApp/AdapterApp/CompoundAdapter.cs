using System;

namespace AdapterApp
{
    class CompoundAdapter : Compound
    {
        private ChemicalDatabank bank;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">name of the compound.</param>
        public CompoundAdapter(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Overridden method display of parent class compound.
        /// </summary>
        public override void Display()
        {
            bank = new ChemicalDatabank();
            boilingpoint = bank.GetCriticalPoint(chemical, "B");
            meltingpoint = bank.GetCriticalPoint(chemical, "M");
            molecularweight = bank.GetMolecularWeight(chemical);
            molecularformula = bank.GetMolecularStructure(chemical);

            base.Display();
            Console.WriteLine(" Formula: {0}", molecularformula);
            Console.WriteLine(" Weight : {0}", molecularweight);
            Console.WriteLine(" Melting Pt: {0}", meltingpoint);
            Console.WriteLine(" Boiling Pt: {0}", boilingpoint);
        }
    }
}
