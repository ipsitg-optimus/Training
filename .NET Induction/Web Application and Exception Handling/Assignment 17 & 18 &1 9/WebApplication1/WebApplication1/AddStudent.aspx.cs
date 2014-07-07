using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
namespace WebApplication1
{
    public partial class AddStudent : System.Web.UI.Page
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
        /// adds student's entry into database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Student newstudent = new Student();
            newstudent.RollNumber = Convert.ToInt32(txtRollNumber.Text);
            newstudent.Name = txtName.Text;
            newstudent.FatherName = txtFatherName.Text;
            newstudent.Age = Convert.ToInt32(txtAge.Text);
            newstudent.Gender = txtGender.Text;
            newstudent.State = ddlState.SelectedValue;
            newstudent.Stream = ddlStream.SelectedValue;
            if (!newstudent.AddStudent())
                lblErrorMessage.Visible = true;
            else
                Response.Write("<script>alert('Record Added Successfully.');location='AddStudent.aspx';</script>");
        }
    }
}