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
    public partial class XMLWrite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XmlTextWriter writer = new XmlTextWriter(Server.MapPath("XML") + "\\Student.xml", Encoding.Unicode);
            writer.WriteStartDocument();
            writer.WriteStartElement("iCalibrator");
            writer.WriteStartElement("Training");
            writer.WriteAttributeString("day", "1");
            writer.WriteStartElement("Chapter");
            writer.WriteString("XML 1");
            writer.WriteEndElement();
            writer.WriteStartElement("Chapter");
            writer.WriteString("XML 2");
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}