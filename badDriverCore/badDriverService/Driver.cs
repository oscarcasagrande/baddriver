﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = badDriverModel;
using domain = badDriverDomain;

namespace badDriverService
{
    public static class Driver
    {
        public static model.Driver GetDriverById(int id)
        {
            return domain.Driver.GetDriverById(id);
        }

        public static model.Driver CreateDriver(model.Driver driver)
        {
            return domain.Driver.CreateDriver(driver);
        }

        public static List<model.Driver> ListDrivers()
        {
            // to do: adjust to read the implementation correct from API
            Baddriver.APIv1.APIv1 apiService = new Baddriver.APIv1.APIv1();

            return new List<badDriverModel.Driver>();
        }

        public static bool UpdateDriver(model.Driver driverToBeUpdated)
        {
            return domain.Driver.UpdateDriver(driverToBeUpdated);
        }

        public static List<model.Driver> GetWorstDrivers()
        {
            // to do: adjust to read the implementation correct from API
            Baddriver.APIv1.APIv1 apiService = new Baddriver.APIv1.APIv1();

            return new List<badDriverModel.Driver>();
        }

        public static bool InactiveDriverById(int id)
        {
            return domain.Driver.InactiveDriverById(id);
        }
    }
}