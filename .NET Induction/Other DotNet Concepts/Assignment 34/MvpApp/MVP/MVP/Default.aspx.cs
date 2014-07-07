using MVP.Presentor;
using MVP.View;
using System;

namespace MVP
{
    public partial class Default : System.Web.UI.Page, IView
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        #region View properties

        public string Label
        {
            get
            {
                return lbl1.Text;
            }
            set
            {
                lbl1.Text = value;
            }
        }

        public string TextBox
        {
            get
            {
                return txt1.Text;
            }
            set
            {
                txt1.Text = value;
            }
        }
        #endregion

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Presentor.Presentor presentor = new Presentor.Presentor(this, new MVP.Model.Model());
            presentor.BindModalView();
        }
    }
}