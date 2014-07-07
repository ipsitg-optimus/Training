using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;
namespace Mail
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DirectoryInfo directory = new DirectoryInfo(txtPath.Text);
            if (directory.Exists)
            {
                Process(directory);
            }
            else
            {
                lblMessage.Visible = true;
            }
        }

        /// <summary>
        /// Checks for files and folders in current directory,
        /// deletes files of size above 100 bytes and appends 'Size less than 100 bytes' on other files.
        /// </summary>
        /// <param name="path">path of current directory.</param>
        private void Process(DirectoryInfo parent)
        {
            string message = "";
            foreach (FileInfo file in parent.GetFiles())
            {
                if (file.Length > 100)
                {
                    message += file.Name + "\n";
                    file.Delete();
                }
                else
                {
                    FileStream stream = new FileStream(file.FullName, FileMode.Append);
                    StreamWriter writer = new StreamWriter(stream);
                    writer.Write("Size less than 100 bytes");
                    writer.Close();
                }
            }
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("ipsit.gaur@optimusinfo.com");
            mail.To.Add("naman.agrawal@optimusinfo.com");
            mail.Subject = "Deleted files";
            mail.Body = message;
            SmtpServer.Port = 25;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ipsit.gaur@optimusinfo.com", "");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}