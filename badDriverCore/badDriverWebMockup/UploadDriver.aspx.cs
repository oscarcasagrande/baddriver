using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using model = badDriverCore.model;
using domain = badDriverCore.domain;

namespace badDriverWebMockup
{
    public partial class UploadDriver : System.Web.UI.Page
    {
        static AppSettingsReader reader = new AppSettingsReader();
        static string dir = reader.GetValue("photosDir", typeof(string)).ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.User.Identity.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }


            model.Driver driver = new model.Driver();

            if (driver.Id == 0)
            {
                driver.Color = ColorDropdownlist.Text;
                driver.Label = LabelTextbox.Text;
                driver.Model = Request["ModelSelect"];
                driver.Supplier = Request["SupplierSelect"];



                //driver = domain.Driver.CreateDriver(driver);
            }

            HtmlForm form = (HtmlForm)Master.FindControl("form1");
            form.Attributes.Add("class", "dropzone");

            if (IsPostBack)
            {
                foreach (var s in Request.Files.AllKeys)
                {
                    HttpPostedFile file = Request.Files[s];
                    int fileSizeInBytes = file.ContentLength;
                    string fileName = file.FileName;
                    string fileExtension = string.Empty;

                    if (string.IsNullOrEmpty(fileName) == false)
                    {
                        fileExtension = Path.GetExtension(fileName);
                    }

                    string savePath = Path.Combine(Request.PhysicalApplicationPath, dir);
                    string saveFile = Path.Combine(savePath, file.FileName);


                    file.SaveAs(saveFile);
                }
            }
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {



        }


    }
}