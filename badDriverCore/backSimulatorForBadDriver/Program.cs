using System;
using System.Collections.Generic;
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

            // List Driver
            List<model.Driver> drivers = new List<model.Driver>();
            drivers = service.Driver.ListDrivers();

            // List Driver Photos

            // Add Driver Photos

            // Delete Driver Photos

            Console.ReadKey();
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

            // E-mail send welcome
            model.User userToReceiveEmail = new model.User()
            {
                Active = true,
                Email = email,
                Id = 3,
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
