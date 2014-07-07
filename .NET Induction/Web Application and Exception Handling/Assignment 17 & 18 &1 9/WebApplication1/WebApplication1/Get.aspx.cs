using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Get : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string roll_number = Request.Params["roll_number"].ToString();
            if (Session["roll_number"] == null)
                Session["roll_number"] = "";
            if (!Session["roll_number"].ToString().Contains(roll_number + ","))
                Session["roll_number"] = Session["roll_number"] + roll_number + ",";
        }
    }
}