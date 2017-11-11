using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace badDriverWebMockup
{
    public partial class ConsultOfWorstDrivers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<badDriverModel.Driver> drivers = new List<badDriverModel.Driver>();
            drivers = badDriverService.Driver.ListWorstDrivers();
            Top10Repeater.DataSource = drivers;
            Top10Repeater.DataBind();
        }
    }
}