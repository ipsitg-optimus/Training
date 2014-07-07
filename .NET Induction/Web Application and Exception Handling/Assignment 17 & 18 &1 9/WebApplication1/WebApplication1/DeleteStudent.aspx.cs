using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class DeleteStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadStreams();
        }

        /// <summary>
        /// Loads drop down list with streams from database.
        /// </summary>
        private void LoadStreams()
        {
            Dictionary<int, string> dictionary;
            ListItem item;
            dictionary = UtilityFunctions.GetAllStreams();
            item = new ListItem();
            item.Value = "";
            item.Text = "--select--";
            ddlStream.Items.Add(item);
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                item = new ListItem();
                item.Value = pair.Key.ToString();
                item.Text = pair.Value.ToString();
                ddlStream.Items.Add(item);
            }
        }

        /// <summary>
        /// Called when dropdownlist of stream is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ddlStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Student> students = new Student().GetAllStudents(Convert.ToInt32(ddlStream.SelectedValue));
            ListItem item;
            lbLeft.Items.Clear();
            foreach (Student s in students)
            {
                item = new ListItem();
                item.Value = s.RollNumber.ToString();
                item.Text = s.Name;
                lbLeft.Items.Add(item);
            }
        }

        /// <summary>
        /// Called when delete button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string rollNumbers = Session["roll_number"].ToString();
            if (rollNumbers.Length > 1)
            {
                rollNumbers = rollNumbers.Substring(0, rollNumbers.Length - 1);
                new Student().DeleteStudents(rollNumbers);
                Response.Write("<script>alert('Students were deleted successfully.');location='DeleteStudent.aspx';</script>");
            }
        }

    }
}