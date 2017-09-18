﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using badDriverCore.model;

namespace badDriverCore.domain
{
    public static class Driver
    {
        public static model.Driver GetDriverById(int id)
        {
            model.Driver result = new model.Driver();

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

        public static model.Driver CreateDriver(model.Driver driver)
        {
            model.Driver result = new model.Driver();

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

                result = driver;
            }
            catch (Exception ex)
            {
                throw ex;
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