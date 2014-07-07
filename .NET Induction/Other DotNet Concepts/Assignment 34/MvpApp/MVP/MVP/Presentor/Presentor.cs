using MVP.Model;
using MVP.View;
using System;
using System.Collections.Generic;
namespace MVP.Presentor
{
    public class Presentor
    {
        #region class members
        IView pview;
        IModel pmodel;
        #endregion

        /// <summary>
        /// Constructor for initializing a new instance of Presenter Class.
        /// </summary>
        /// <param name="PView">instance of class implementing interface IView.</param>
        /// <param name="PModel">instance of class implementing interface IModel.</param>
        public Presentor(IView PView, IModel PModel)
        {
            pview = PView;
            pmodel = PModel;
        }

        /// <summary>
        /// method which binds model to the view.
        /// </summary>
        public void BindModalView()
        {
            List<String> list = pmodel.setinfo();
            pview.TextBox = list[0];
            pview.Label = list[1];
        }
    }
}