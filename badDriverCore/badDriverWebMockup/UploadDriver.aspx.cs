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
using model = badDriverModel;
using service = badDriverService;

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


            HtmlForm form = (HtmlForm)Master.FindControl("form1");
            form.Attributes.Add("class", "dropzone");

            if (IsPostBack)
            {
                model.Driver driver = new model.Driver();

                if (driver.Id == 0)
                {
                    driver.Color = ColorDropdownlist.Text;
                    driver.Label = LabelTextbox.Text;
                    driver.Model = Request["ModelSelect"];
                    driver.Supplier = Request["SupplierSelect"];

                    driver.Incidents.Add(new model.Incident()
                    {
                        Latitude = Request.Form["latitudeTextBox"].ToString(),
                        Longitude = Request.Form["longitudeTextBox"].ToString(),
                        DriverId = driver.Id,
                        UserId = (int)Session["UserId"]
                    });
                }

                int i = 0;
                string savePath = string.Empty;
                string saveFile = string.Empty;
                model.Photo p = new model.Photo();

                foreach (var s in Request.Files.AllKeys)
                {
                    i++;
                    savePath = string.Empty;
                    saveFile = string.Empty;

                    HttpPostedFile file = Request.Files[s];
                    int fileSizeInBytes = file.ContentLength;
                    string fileName = file.FileName;
                    string fileExtension = string.Empty;

                    if (string.IsNullOrEmpty(fileName) == false)
                    {
                        fileExtension = Path.GetExtension(fileName);
                    }

                    savePath = Path.Combine(Request.PhysicalApplicationPath, dir, driver.Id.ToString());
                    saveFile = Path.Combine(savePath, i.ToString(), fileExtension);


                    file.SaveAs(saveFile);
                    p = new model.Photo()
                    {
                        IncidentId = driver.Incidents[0].Id,
                        Name = fileName,
                        Url = saveFile
                    };

                }

                driver.Incidents[0].Photos.Add(p);

                //driver = domain.Driver.CreateDriver(driver);
            }
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {



        }


    }
}