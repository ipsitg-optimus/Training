using System;

namespace EntityFrameworkApp
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
                Response.Redirect("Login.aspx");
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            user_details user;
            using (userEntities2 context = new userEntities2())
            {
                if ((user = context.user_details.Find(Convert.ToInt32(txtUserID.Text))) != null)
                {
                    context.user_details.Remove(user);
                    context.SaveChanges();
                    Response.Write("<script>alert('Record was deleted.!!');</script>");
                }
                else
                {
                    Response.Write("<script>alert('No record found.!!');</script>");
                }
            }
        }
    }
}