using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using utils = badDriverUtils;
using model = badDriverModel;
using System.Data;

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
        public List<model.Driver>   ListWorstDrivers()
        {
            List<model.Driver> result = new List<model.Driver>();

            try
            {
                IDataReader reader = utils.DatabaseHelper.ExecuteReader(new List<KeyValuePair<string, object>>(), "procDriverWorst_Read");
                while (reader.Read())
                {
                    result.Add(new badDriverModel.Driver()
                    {
                        Color = reader["Color"].ToString(),
                        Id = (int)reader["Id"],
                        Incidents = new List<model.Incident>(),
                        Label = reader["Label"].ToString(),
                        Model = reader["Model"].ToString(),
                        Supplier = reader["Supplier"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        [WebMethod]
        public int ListDriversCount()
        {
            int result = 0;
            try
            {
                IDataReader reader = utils.DatabaseHelper.ExecuteReader(new List<KeyValuePair<string, object>>(), "procDriverCount_Read");
                if(reader.Read())
                {
                    result = (int)reader["count"];
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        [WebMethod]
        public List<model.Driver> ListAllDrivers()
        {
            List<model.Driver> result = new List<model.Driver>();

            try
            {
                IDataReader reader = utils.DatabaseHelper.ExecuteReader(new List<KeyValuePair<string, object>>(), "procDriverFull_Read");
                while (reader.Read())
                {
                    result.Add(new badDriverModel.Driver()
                    {
                        Color = reader["Color"].ToString(),
                        Id = (int)reader["Id"],
                        Incidents = new List<model.Incident>(),
                        Label = reader["Label"].ToString(),
                        Model = reader["Model"].ToString(),
                        Supplier = reader["Supplier"].ToString()
                    });
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
