using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = badDriverModel;
using service = badDriverService;

namespace backSimulatorForBadDriver
{
    class Program
    {
        static int id = 1;
        static string email = "teste3@teste.com.br";
        static string nickname = "bacana";
        static string password = "123456";
        static string newPassword = "123456new";
        static string newNickname = "osquinha";

        static void Main(string[] args)
        {

            testUserFeatures();

            testDriverFeatures();

        }

        private static void testDriverFeatures()
        {
            // Create Driver
            model.Driver driverToBeCreated = new model.Driver()
            {
                Color = "Black",
                Label = "FOH5698",
                Model = "Sentra",
                Supplier = "Nissan"
            };

            driverToBeCreated = service.Driver.CreateDriver(driverToBeCreated);

            // Get Driver
            model.Driver driverToBeGot = service.Driver.GetDriverById(1);

            // Update Driver
            model.Driver driverToBeUpdated = driverToBeGot;
            bool driverUpdated = false;
            Console.WriteLine("Driver Getted / To Be Updated Color [BEFORE CHANGE COLOR]: {0}", driverToBeUpdated.Color);
            driverToBeUpdated.Color = (driverToBeGot.Color == "Black") ? "White" : "Black";

            Console.WriteLine("Driver Getted / To Be Updated Color [AFTER CHANGE COLOR]: {0}", driverToBeUpdated.Color);
            driverUpdated = service.Driver.UpdateDriver(driverToBeUpdated);

            Console.WriteLine("Driver Updated: {0}", driverUpdated);

            driverToBeUpdated = service.Driver.GetDriverById(driverToBeUpdated.Id);
            Console.WriteLine("Driver new color: {0}", driverToBeUpdated.Color);


            // Insert incident for Driver
            model.Incident incident =
                new model.Incident()
                {
                    Latitude = "-23.6152779",
                    Longitude = "-46.7043542",
                    UserId = id,
                    DriverId = driverToBeUpdated.Id,
                    Photos = new List<model.Photo>()
                };

            incident.Photos.Add(
                new badDriverModel.Photo()
                {
                    Name = "badDriverSample01.jpg",
                    Url = @"\badDriverSample01.jpg",
                });

            incident.Photos.Add(
                new badDriverModel.Photo()
                {
                    Name = "badDriverSample02.jpg",
                    Url = @"\badDriverSample02.jpg",
                });



            int incidentInserted = service.Driver.InsertIncident(incident);
            Console.WriteLine("Incident inserted id: {0}", incidentInserted);



            // Insert more than 1 incident for Driver
            Console.WriteLine("######################################");
            Console.WriteLine("Insert more than 1 incident for Driver");
            Random random = new Random();
            int randomNext = random.Next(3, 10);

            model.Driver newDriver = randomicDriver();

            newDriver = service.Driver.CreateDriver(newDriver);

            for (int i = 1; i <= randomNext; i++)
            {
                model.Incident inc = new model.Incident()
                {
                    Latitude = "-23.6152779",
                    Longitude = "-46.7043542",
                    UserId = id,
                    Photos = new List<model.Photo>(),
                    DriverId = newDriver.Id
                };

                inc.Photos.Add(
                    new badDriverModel.Photo()
                    {
                        Name = "badDriverSample01.jpg",
                        Url = @"\badDriverSample01.jpg",
                    });

                inc.Photos.Add(
                    new badDriverModel.Photo()
                    {
                        Name = "badDriverSample02.jpg",
                        Url = @"\badDriverSample02.jpg",
                    });

                incidentInserted = service.Driver.InsertIncident(inc);
                incident.Id = incidentInserted;
                Console.WriteLine("{0} from {1} Incident(s) inserted(s) to driver id {2}, incident id: {3}", i, randomNext, newDriver.Id, incidentInserted);

                newDriver.Incidents.Add(incident);
            }


            // List Driver
            List<model.Driver> drivers = new List<model.Driver>();
            drivers = service.Driver.ListDrivers();

            // Path for photos
            List<model.Photo> photos = new List<model.Photo>();
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory.Replace(@"bin\Debug", string.Empty));

            // List Driver Photos
            List<model.Photo> driverPhotos = new List<model.Photo>();

            foreach (var i in newDriver.Incidents)
            {
                Console.WriteLine("For Driver ID {0} we have {1} Incidents", driverToBeGot.Id, driverToBeGot.Incidents.Count());

                foreach (var p in i.Photos)
                {
                    Console.WriteLine("----- Photo ID {0}, URL {1} and Name {2}", p.Id, p.Url, p.Name);
                }
            }

            // List total Drivers
            Console.WriteLine("List total Drivers : {0}", service.Driver.ListDriversCount());

            // Listing worst drivers
            foreach (var d in service.Driver.ListWorstDrivers())
            {
                Console.WriteLine("Listing worst Drivers {0} - {1} {2}", d.Id, d.Label, d.Model);
            }

            Console.ReadKey();
        }

        private static model.Driver randomicDriver()
        {
            model.Driver d = new model.Driver();

            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 3; i++)
            {
                d.Label += new string(Enumerable.Repeat(chars, 1).Select(s => s[new Random().Next(26)]).ToArray());
            }

            Random label = new Random();
            d.Label += label.Next(1000, 9999).ToString();

            Random randomColor = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomColor.Next(names.Length)];

            d.Color = Color.FromKnownColor(randomColorName).Name;

            d.Supplier = "Ford";
            d.Model = "Fiesta";

            return d;
        }

        private static void testUserFeatures()
        {
            // Create user
            model.User userToBeCreated = new model.User()
            {
                Active = false,
                Email = email.Replace("teste", Guid.NewGuid().ToString()),
                Id = 0,
                Nickname = Guid.NewGuid().ToString(),
                Password = password
            };

            userToBeCreated = service.User.CreateUser(userToBeCreated);
            Console.WriteLine("User {0} created with id {1}", userToBeCreated.Nickname, userToBeCreated.Id);

            // E-mail send welcome
            model.User userToReceiveEmail = new model.User()
            {
                Active = true,
                Email = email,
                Id = 1,
                Nickname = nickname,
                Password = password
            };

            service.User.SendWelcomeEmail(userToReceiveEmail);


            // E-mail send password reset link
            Console.WriteLine(string.Format("User updated = {0}", service.User.ResetUserPasswordByEmailOrUsername(email, nickname)));


            // Create user
            model.User newUser = new model.User()
            {
                Active = true,
                Email = email,
                Id = 0,
                Nickname = nickname,
                Password = password
            };
            newUser = service.User.CreateUser(newUser);


            // Get User
            model.User gettedUserById = service.User.GetUserById(id);
            model.User gettedUserByEmail = service.User.GetUserByIOrEmailOrUsernameAndPassword(4, "teste3@teste.com.br", string.Empty, "123456");
            model.User gettedUserByNickname = service.User.GetUserByIOrEmailOrUsernameAndPassword(0, string.Empty, nickname, password);


            // User reset password
            bool resetUserPasswordByEmail = service.User.ResetUserPasswordByEmailOrUsername(email, string.Empty);
            bool resetUserPasswordByNickname = service.User.ResetUserPasswordByEmailOrUsername(string.Empty, nickname);

            // Update User
            model.User userToUpdate = service.User.GetUserById(1);
            userToUpdate.Nickname = newNickname;

            bool userUpdated = service.User.UpdateUser(userToUpdate);


            List<KeyValuePair<string, string>> values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("##user", "bacana"));

            //utils.Email.sendEmail(@"C:\Users\oscar.l.casagrande\Source\Repos\baddriver\badDriverCore\badDriverWebMockup\emailTemplate\welcome.html",
            //    "oscar.casagrande@gmail.com",
            //    "oscar.casagrande@gmail.com",
            //    "teste",
            //    "teste",
            //    true,
            //    values);
        }
    }
}
