using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class EditStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStreams();
                LoadStates();
            }
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
            item.Value = null;
            item.Text = "--select--";
            ddlStream.Items.Add(item);
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                item = new ListItem();
                item.Value = pair.Value.ToString();
                item.Text = pair.Value.ToString();
                ddlStream.Items.Add(item);
            }
        }

        /// <summary>
        /// Loads drop down list with states from database.
        /// </summary>
        private void LoadStates()
        {
            Dictionary<int, string> dictionary;
            ListItem item;
            dictionary = UtilityFunctions.GetAllStates();
            item = new ListItem();
            item.Value = null;
            item.Text = "--select--";
            ddlState.Items.Add(item);
            foreach (KeyValuePair<int, string> pair in dictionary)
            {
                item = new ListItem();
                item.Value = pair.Value.ToString();
                item.Text = pair.Value.ToString();
                ddlState.Items.Add(item);
            }
        }

        /// <summary>
        /// Searches for student for a particular roll number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Student student = new Student().GetStudent(Convert.ToInt32(txtRollSearch.Text));
            if (student != null)
            {
                txtName.Enabled = txtFatherName.Enabled = txtGender.Enabled = txtAge.Enabled = ddlState.Enabled = ddlStream.Enabled = btnUpdate.Enabled = true;
                txtRollSearch.Enabled = false;
                txtName.Text = student.Name;
                txtFatherName.Text = student.FatherName;
                txtGender.Text = student.Gender;
                txtAge.Text = student.Age.ToString();
            }
            else
            {
                txtName.Enabled = txtFatherName.Enabled = txtGender.Enabled = txtAge.Enabled = ddlState.Enabled = ddlStream.Enabled = btnUpdate.Enabled = false;
                txtRollSearch.Enabled = true;
                Response.Write("<script>alert('No Student was found!!');location='EditStudent.aspx';</script>");
            }
        }

        /// <summary>
        /// Updates details of student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.RollNumber = Convert.ToInt32(txtRollSearch.Text);
            student.Name = txtName.Text;
            student.FatherName = txtFatherName.Text;
            student.Gender = txtGender.Text;
            student.Age = Convert.ToInt32(txtAge.Text);
            student.State = ddlState.SelectedValue;
            student.Stream = ddlStream.SelectedValue;
            if (!student.UpdateStudent())
                lblErrorMessage.Visible = true;
            else
                Response.Write("<script>alert('Record Updated Successfully.');location='EditStudent.aspx';</script>");
        }
    }
}