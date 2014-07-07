using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
namespace EntityFrameworkApp
{
    public partial class UpdateUser : System.Web.UI.Page
    {
        static user_details user;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
                Response.Redirect("Login.aspx");
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            using (userEntities2 context = new userEntities2())
            {
                if ((user = context.user_details.Find(Convert.ToInt32(txtUserID.Text))) != null)
                {
                    txtUserID.Enabled = btnFind.Enabled = false;
                    txtName.Enabled = txtAge.Enabled = ddlUserType.Enabled = btnUpdate.Enabled = true;
                    txtName.Text = user.name;
                    txtAge.Text = user.age.ToString();
                    ddlUserType.SelectedIndex = (int)user.user_type;
                }
                else
                {
                    Response.Write("<script>alert('No record found.!!');</script>");
                }
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            user.name = txtName.Text;
            user.age = Convert.ToInt32(txtAge.Text);
            user.user_type = Convert.ToInt32(ddlUserType.SelectedValue);
            using (userEntities2 context = new userEntities2())
            {
                context.Entry(user).State = System.Data.EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}