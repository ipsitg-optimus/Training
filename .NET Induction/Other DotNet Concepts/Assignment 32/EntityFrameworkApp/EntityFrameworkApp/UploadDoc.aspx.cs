using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace EntityFrameworkApp
{
    public partial class UploadDoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserID"] == null)
                Response.Redirect("Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(Server.MapPath("Documents") + "\\" + Session["UserID"]);
            if (!directory.Exists)
                directory.Create();
            int file_number = new DirectoryInfo(Server.MapPath("Documents") + "\\" + Session["UserID"]).GetFiles().Length + 1;
            fuplFile1.SaveAs(Server.MapPath("Documents") + "\\" + Session["UserID"] + "\\" + file_number);
            Response.Write("<script>alert('File uploaded successfully');</script>");
        }
    }
}