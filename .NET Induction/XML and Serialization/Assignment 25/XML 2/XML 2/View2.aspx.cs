using System;
using System.Web.UI;
using System.Xml;
namespace XML_2
{
    public partial class View2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(Server.MapPath("XML") + "\\Students.xml");
            XmlNode root = doc.DocumentElement;
            pnl1.Controls.Add(new LiteralControl("<table>"));
            pnl1.Controls.Add(new LiteralControl("<tr><th>Name</th><th>ID</th><th>Course</th></tr>"));
            foreach (XmlNode node in root.ChildNodes)
            {
                if (node.ChildNodes.Item(3).Attributes.Item(1).Value.Equals("D"))
                {
                    pnl1.Controls.Add(new LiteralControl("<tr>"));
                    pnl1.Controls.Add(new LiteralControl("<td>" + node.ChildNodes.Item(0).InnerText + "</td>"));
                    pnl1.Controls.Add(new LiteralControl("<td>" + node.Attributes.Item(0).Value + "</td>"));
                    pnl1.Controls.Add(new LiteralControl("<td>" + node.ChildNodes.Item(2).InnerText + "</td>"));
                    pnl1.Controls.Add(new LiteralControl("</tr>"));
                }
            }
            pnl1.Controls.Add(new LiteralControl("</table>"));
        }
    }
}