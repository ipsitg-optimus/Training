using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            user_details user;
            using (userEntities2 context = new userEntities2())
            {
                if ((user = context.user_details.Find(Convert.ToInt32(txtUserID.Text))) != null)
                {
                    Session["UserID"] = txtUserID.Text;
                    Session["UserType"] = user.user_type;
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Response.Write("<script>alert('No record found.!!');</script>");
                }
            }
        }
    }
}