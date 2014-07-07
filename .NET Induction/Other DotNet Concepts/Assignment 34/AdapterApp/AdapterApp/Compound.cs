using System;

namespace AdapterApp
{
    class Compound
    {
        #region protected members
        protected string chemical;
        protected float boilingpoint;
        protected float meltingpoint;
        protected double molecularweight;
        protected string molecularformula;
        #endregion

        /// <summary>
        /// Constructor for initializing a new instance of Compound class.
        /// </summary>
        /// <param name="chemical"></param>
        public Compound(string chemical)
        {
            this.chemical = chemical;
        }

        /// <summary>
        /// method which prints details of the compound to the console.
        /// </summary>
        public virtual void Display()
        {
            Console.WriteLine("\nCompound: {0} ------ ", chemical);
        }
    }
}
