using System;
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
        static Baddriver.APIv1.APIv1 _apiService = new Baddriver.APIv1.APIv1();

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

            List<badDriverModel.Driver> result = new List<badDriverModel.Driver>();


            return result;
        }

        public static bool UpdateDriver(model.Driver driverToBeUpdated)
        {
            return domain.Driver.UpdateDriver(driverToBeUpdated);
        }

        public static List<model.Driver> GetWorstDrivers()
        {
            // to do: adjust to read the implementation correct from API
            Baddriver.APIv1.APIv1 apiService = new Baddriver.APIv1.APIv1();


            var x = apiService.ListWorstDrivers();
            return new List<badDriverModel.Driver>();
        }

        public static bool InactiveDriverById(int id)
        {
            return domain.Driver.InactiveDriverById(id);
        }

        public static int ListDriversCount()
        {
            int result = 0;

            result = _apiService.ListDriversCount();

            return result;

        }

        public static int InsertIncident(model.Incident incident)
        {
            int result = 0;

            result = domain.Driver.InsertIncident(incident);

            return result;
        }

        public static List<model.Driver> ListWorstDrivers()
        {
            List<model.Driver> result = new List<model.Driver>();

            foreach (var i in _apiService.ListWorstDrivers())
            {
                model.Driver d = new model.Driver();
                d.Id = i.Id;
                d.Color = i.Color;
                d.Label = i.Label;
                d.Model = i.Model;
                d.Supplier = i.Supplier;
                d.IncidentQuantity = i.IncidentQuantity;

                result.Add(d);
            }

            return result;
        }
    }
}