using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
namespace XML_1
{
    public partial class Buttons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// this method adds a new child node assignment in root  node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("XML") + "\\Student.xml");
            XmlNode newElem = doc.CreateNode("element", "assignment", "");
            XmlNode childNode = doc.CreateNode("element", "number", "");
            childNode.InnerText = "1";
            Console.WriteLine("Add the new element to the document...");
            XmlElement root = doc.DocumentElement;
            root.AppendChild(newElem);
            newElem.AppendChild(childNode);
            doc.Save(Server.MapPath("XML") + "\\Student.xml");
            Response.Redirect("XML\\Student.xml");
        }

        /// <summary>
        /// displays details of the first child of the root node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnFirstChild_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("XML") + "\\Student.xml");
            XmlElement root = doc.DocumentElement;
            TextBox textbox1 = new TextBox();
            textbox1.ID = "txtFirstChild";
            textbox1.Text = root.FirstChild.Name;
            pnlPanel.Controls.Add(textbox1);
        }

        /// <summary>
        /// inserts a new node testing before first child of root node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnInsertBefore_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("XML") + "\\Student.xml");
            XmlElement root = doc.DocumentElement;
            XmlNode newnode = doc.CreateNode("element", "testing", "");
            XmlNode firstchild = root.FirstChild;
            root.InsertBefore(newnode, firstchild);
            doc.Save(Server.MapPath("XML") + "\\Student.xml");
            Response.Redirect("XML\\Student.xml");
        }

        /// <summary>
        /// removes node assignment from root node in the XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRemoveNode_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("XML") + "\\Student.xml");
            XmlNode todelete = doc.SelectSingleNode("assignment");
            if (todelete != null)
            {
                doc.RemoveAll();
                doc.Save(Server.MapPath("XML") + "\\Student.xml");
            }
            Response.Redirect("XML\\Student.xml");
        }

        /// <summary>
        /// displays names of all the child nodes of root node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnChildNode_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("XML") + "\\Student.xml");
            XmlElement root = doc.DocumentElement;
            TextBox txtBox;
            foreach (XmlNode node in root.ChildNodes)
            {
                txtBox = new TextBox();
                txtBox.Text = node.Name;
                pnlPanel.Controls.Add(txtBox);
                pnlPanel.Controls.Add(new LiteralControl("<br/>"));
            }
        }

        /// <summary>
        /// displays number of child nodes in the root node.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnTotalNode_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("XML") + "\\Student.xml");
            XmlElement root = doc.DocumentElement;
            Label label;
            label = new Label();
            label.Text = "Total number of child nodes of root= " + root.ChildNodes.Count;
            pnlPanel.Controls.Add(label);
        }

        /// <summary>
        /// replaces node testing with a new node TestingOver.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReplaceChild_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("XML") + "\\Student.xml");
            XmlElement root = doc.DocumentElement;
            XmlNode newchild = doc.CreateNode("element", "TestingOver", "");
            XmlNode oldchild = null;
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.Name.Equals("testing"))
                {
                    oldchild = node;
                    break;
                }
            }
            if (oldchild != null)
            {
                root.ReplaceChild(newchild, oldchild);
            }
            Response.Redirect("XML\\Student.xml");
        }
    }
}