using System;

namespace EntityFrameworkApp
{
    public partial class AddUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
                Response.Redirect("Login.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            using (userEntities2 context = new userEntities2())
            {
                user_details user = new user_details();
                user.user_id = Convert.ToInt32(txtUserID.Text);
                user.name = txtName.Text;
                user.age = Convert.ToInt32(txtAge.Text);
                user.user_type = Convert.ToInt32(ddlUserType.SelectedValue);
                context.user_details.Add(user);
                context.SaveChanges();
            }
        }
    }
}