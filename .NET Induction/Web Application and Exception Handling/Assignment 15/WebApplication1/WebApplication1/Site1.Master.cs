using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] == null)
                lnkLogOut.Visible = false;
        }

        protected void lnkLogOut_Click(object sender, EventArgs e)
        {
            Session["UserName"] = null;
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}