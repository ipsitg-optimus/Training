using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CSV
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            fileUpload.SaveAs(Server.MapPath("CSV") + "\\file.csv");
            bool status = UtilityFunctions.LoadFromCSV(Server.MapPath("CSV") + "\\file.csv");
            if (status)
                Response.Write("<script>alert('Data Added successfully.');</script>");
            else
                Response.Write("<script>alert('Some Error Occurred.');</script>");
        }
    }
}