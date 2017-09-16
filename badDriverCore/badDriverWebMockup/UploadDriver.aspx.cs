using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Security;

namespace badDriverWebMockup
{
    public partial class UploadDriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            {

                HttpFileCollection fileCollection = Request.Files;
                for (int i = 0; i < fileCollection.Count; i++)
                {
                    HttpPostedFile uploadfile = fileCollection[i];
                    string fileName = Path.GetFileName(uploadfile.FileName);
                    if (uploadfile.ContentLength > 0)
                    {
                        uploadfile.SaveAs(Server.MapPath("DriverPhotos") + fileName);
                        lblUploadStatus.Text += fileName + "Saved Successfully<br>";
                    }
                }
            }
        }
    }
}