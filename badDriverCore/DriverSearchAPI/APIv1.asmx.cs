using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DriverSearchAPI
{
    /// <summary>
    /// Summary description for APIv1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class APIv1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<badDriverModel.Driver> WorstDrivers()
        {
            List<badDriverModel.Driver> result = new List<badDriverModel.Driver>();



            return result;
        }
    }
}
