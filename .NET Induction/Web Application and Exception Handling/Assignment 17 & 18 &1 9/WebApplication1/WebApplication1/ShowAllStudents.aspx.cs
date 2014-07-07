using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class ShowAllStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStreams();
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
                item.Value = pair.Key.ToString();
                item.Text = pair.Value.ToString();
                ddlStream.Items.Add(item);
            }
        }

        protected void ddlStream_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdShowStudents.DataSource = null;
            grdShowStudents.DataBind();
            grdShowStudents.DataSource = new Student().GetAllStudents(Convert.ToInt32(ddlStream.SelectedValue));
            grdShowStudents.DataBind();
        }
    }
}