using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace badDriverWebMockup
{
    public partial class UploadDriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            string filepath = "C:\\Program Files\\Git\\Github\\Baddriver\\badDriverCore\\badDriverWebMockup\\DriversPhotos";
            HttpFileCollection uploadedFiles = Request.Files;

            for (int i = 0; i < uploadedFiles.Count; i++)
            {
                HttpPostedFile userPostedFile = uploadedFiles[i];

                try
                {
                    if (userPostedFile.ContentLength > 0)
                    {
                        Label1.Text += "<u>File #" + (i + 1) +
                           "</u><br>";
                        Label1.Text += "File Content Type: " +
                           userPostedFile.ContentType + "<br>";
                        Label1.Text += "File Size: " +
                           userPostedFile.ContentLength + "kb<br>";
                        Label1.Text += "File Name: " +
                           userPostedFile.FileName + "<br>";

                        userPostedFile.SaveAs(filepath + "\\" +
                           System.IO.Path.GetFileName(userPostedFile.FileName));

                        Label1.Text += "Location where saved: " +
                           filepath + "\\" +
                           System.IO.Path.GetFileName(userPostedFile.FileName) +
                           "<p>";
                    }
                }
                catch (Exception Ex)
                {
                    Label1.Text += "Error: <br>" + Ex.Message;
                }
            }
        }
    }
}