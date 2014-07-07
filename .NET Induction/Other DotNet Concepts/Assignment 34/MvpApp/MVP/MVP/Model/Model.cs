using System;
using System.Collections.Generic;

namespace MVP.Model
{
    /// <summary>
    /// Class Model implements interface IModel.
    /// </summary>
    public class Model : IModel
    {
        /// <summary>
        /// Implemented method setinfo of interface IModel.
        /// </summary>
        /// <returns></returns>
        public List<string> setinfo()
        {
            List<String> list = new List<string>();
            list.Add("Enter name");
            list.Add("Capital letters only");
            return list;
        }
    }
}