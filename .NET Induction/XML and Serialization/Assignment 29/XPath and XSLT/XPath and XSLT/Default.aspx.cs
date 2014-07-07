using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
namespace XPath_and_XSLT
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(Server.MapPath("XML") + "\\Student.xml");
            XmlNode root = document.DocumentElement;
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.ChildNodes.Item(0).InnerText.Equals("PCM"))
                {
                    XmlElement newelement = document.CreateElement("College");
                    newelement.InnerText = "Engineering";
                    node.AppendChild(newelement);
                    pnl1.Controls.Add(new LiteralControl("New College node added for node name: " + node.Attributes.Item(0).Value + "<br/>"));
                }
            }
            document.Save(Server.MapPath("XML") + "\\Student.xml");
            pnl1.Controls.Add(new LiteralControl("Done adding file has been saved."));
        }
    }
}