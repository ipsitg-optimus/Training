using System;

namespace XML_3
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            fupl1.SaveAs(Server.MapPath("XML") + "\\Students.xml");
            if (UtilityFunctions.LoadStudentsFromXMLFile(Server.MapPath("XML") + "\\Students.xml"))
            {
                Response.Write("<script>alert('Data added successfully.');</script>");
            }
            else
            {
                Response.Write("<script>alert('Some error occurred.');</script>");
            }
        }
    }
}