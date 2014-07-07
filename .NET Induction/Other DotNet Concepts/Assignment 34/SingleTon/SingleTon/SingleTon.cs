
namespace SingleTon
{
    public class SingleTon
    {
        #region private members
        private static SingleTon instance;
        #endregion

        /// <summary>
        /// Private constructor.
        /// </summary>
        private SingleTon() { }

        /// <summary>
        /// static property for accessing instance.
        /// </summary>
        public static SingleTon Instance
        {
            get
            {
                if (instance == null)
                    instance = new SingleTon();
                return instance;
            }
        }
    }
}
