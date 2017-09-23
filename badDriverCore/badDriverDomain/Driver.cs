using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = badDriverModel;
using utils = badDriverUtils;

namespace badDriverDomain
{
    public static class Driver
    {
        public static model.Driver GetDriverById(int id)
        {
            model.Driver result = new model.Driver();

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

            parameters.Add(new KeyValuePair<string, object>("@id", id));

            IDataReader reader = null;

            try
            {
                using (reader = utils.DatabaseHelper.ExecuteReader(parameters, "procDriverId_read"))
                {
                    if (reader.Read())
                    {
                        result.Id = (int)reader["Id"];
                        result.Color = reader["color"].ToString();
                        result.Label = reader["label"].ToString();
                        result.Model = reader["model"].ToString();
                        result.Supplier = reader["supplier"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (reader.IsClosed == false)
                {
                    reader.Close();
                    reader.Dispose();
                }
            }

            return result;
        }

        public static model.Driver CreateDriver(model.Driver driver)
        {
            model.Driver result = new model.Driver();
            result = GetDriver(driver);

            if (result.Id == 0)
            {
                List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

                parameters.Add(new KeyValuePair<string, object>("@Color", driver.Color));
                parameters.Add(new KeyValuePair<string, object>("@Label", driver.Label));
                parameters.Add(new KeyValuePair<string, object>("@Model", driver.Model));
                parameters.Add(new KeyValuePair<string, object>("@Supplier", driver.Supplier));

                try
                {
                    result.Id = (Int32)utils.DatabaseHelper.ExecuteNonQuery(
                        parameters,
                        "procDriver_Create",
                        new KeyValuePair<string, object>("@Id", driver.Id));

                    driver.Id = result.Id;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return result;
        }

        public static bool InsertIncident(model.Incident incident, int driverId)
        {
            // to do: need to be implemented
            return false;
        }

        public static List<model.Driver> ListDrivers()
        {
            List<model.Driver> result = new List<model.Driver>();

            return result;
        }

        public static bool UpdateDriver(model.Driver driverToBeUpdated)
        {
            bool result = false;

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

            parameters.Add(new KeyValuePair<string, object>("@Id", driverToBeUpdated.Id));
            parameters.Add(new KeyValuePair<string, object>("@Color", driverToBeUpdated.Color));
            parameters.Add(new KeyValuePair<string, object>("@Label", driverToBeUpdated.Label));
            parameters.Add(new KeyValuePair<string, object>("@Model", driverToBeUpdated.Model));
            parameters.Add(new KeyValuePair<string, object>("@Supplier", driverToBeUpdated.Supplier));

            try
            {
                utils.DatabaseHelper.ExecuteNonQuery(parameters, "procDriver_Update", null);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }

            return result;
        }

        private static model.Driver GetDriver(model.Driver driver)
        {
            model.Driver result = new model.Driver();

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

            parameters.Add(new KeyValuePair<string, object>("@Color", driver.Color));
            parameters.Add(new KeyValuePair<string, object>("@Label", driver.Label));
            parameters.Add(new KeyValuePair<string, object>("@Model", driver.Model));
            parameters.Add(new KeyValuePair<string, object>("@Supplier", driver.Supplier));

            IDataReader reader = null;

            try
            {
                using (reader = utils.DatabaseHelper.ExecuteReader(parameters, "procDriver_Read"))
                {
                    if (reader.Read())
                    {
                        result.Id = (int)reader["Id"];
                        result.Color = reader["Color"].ToString();
                        result.Label = reader["Label"].ToString();
                        result.Model = reader["Model"].ToString();
                        result.Supplier = reader["Supplier"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (reader.IsClosed == false)
                {
                    reader.Close();
                    reader.Dispose();
                }
            }

            return result;
        }

        public static List<model.Driver> GetWorstDrivers()
        {
            List<model.Driver> result = new List<model.Driver>();

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            finally { }

            return result;
        }

        public static bool InactiveDriverById(int id)
        {
            bool result = false;

            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            finally { }

            return result;
        }
    }
}
