using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //testUserFeatures();

            testDriverFeatures();



        }

        private static void testDriverFeatures()
        {
            // Create Driver
            badDriverCore.model.Driver driverToBeCreated = new badDriverCore.model.Driver()
            {
                Color = "Black",
                Label = "FOH5698",
                Model = "Sentra",
                Supplier = "Nissan"
            };

            driverToBeCreated = badDriverCore.domain.Driver.CreateDriver(driverToBeCreated);

            // Get Driver
            badDriverCore.model.Driver driverToBeGot = badDriverCore.domain.Driver.GetDriverById(1);

            // Update Driver
            badDriverCore.model.Driver driverToBeUpdated = driverToBeGot;
            bool driverUpdated = false;
            Console.WriteLine("Driver Getted / To Be Updated Color [BEFORE CHANGE COLOR]: {0}", driverToBeUpdated.Color);
            driverToBeUpdated.Color = (driverToBeGot.Color == "Black") ? "White" : "Black";

            Console.WriteLine("Driver Getted / To Be Updated Color [AFTER CHANGE COLOR]: {0}", driverToBeUpdated.Color);
            driverUpdated = badDriverCore.domain.Driver.UpdateDriver(driverToBeUpdated);

            Console.WriteLine("Driver Updated: {0}", driverUpdated);

            driverToBeUpdated = badDriverCore.domain.Driver.GetDriverById(driverToBeUpdated.Id);
            Console.WriteLine("Driver new color: {0}", driverToBeUpdated.Color);

            // List Driver
            List<badDriverCore.model.Driver> drivers = new List<badDriverCore.model.Driver>();
            drivers = badDriverCore.domain.Driver.ListDrivers();

            // Active Driver

            // List Driver Photos

            // Add Driver Photos

            // Delete Driver Photos

            Console.ReadKey();
        }

        private static void testUserFeatures()
        {
            // Create user
            badDriverCore.model.User userToBeCreated = new badDriverCore.model.User()
            {
                Active = false,
                Email = email.Replace("teste", Guid.NewGuid().ToString()),
                Id = 0,
                Nickname = Guid.NewGuid().ToString(),
                Password = password
            };

            userToBeCreated = badDriverCore.domain.User.CreateUser(userToBeCreated);

            // E-mail send welcome
            badDriverCore.model.User userToReceiveEmail = new badDriverCore.model.User()
            {
                Active = true,
                Email = email,
                Id = 3,
                Nickname = nickname,
                Password = password
            };

            badDriverCore.domain.User.SendWelcomeEmail(userToReceiveEmail);

            // E-mail send password reset link
            Console.WriteLine(string.Format("User updated = {0}", badDriverCore.domain.User.ResetUserPasswordByEmailOrUsername(email, nickname)));


            // Create user
            badDriverCore.model.User newUser = new badDriverCore.model.User()
            {
                Active = true,
                Email = email,
                Id = 0,
                Nickname = nickname,
                Password = password
            };
            newUser = badDriverCore.domain.User.CreateUser(newUser);


            // Get User
            badDriverCore.model.User gettedUserById = badDriverCore.domain.User.GetUserById(id);
            badDriverCore.model.User gettedUserByEmail = badDriverCore.domain.User.GetUserByIOrEmailOrUsernameAndPassword(4, "teste3@teste.com.br", string.Empty, "123456");
            badDriverCore.model.User gettedUserByNickname = badDriverCore.domain.User.GetUserByIOrEmailOrUsernameAndPassword(0, string.Empty, nickname, password);


            // User reset password
            bool resetUserPasswordByEmail = badDriverCore.domain.User.ResetUserPasswordByEmailOrUsername(email, string.Empty);
            bool resetUserPasswordByNickname = badDriverCore.domain.User.ResetUserPasswordByEmailOrUsername(string.Empty, nickname);

            // Update User
            badDriverCore.model.User userToUpdate = badDriverCore.domain.User.GetUserById(1);
            userToUpdate.Nickname = newNickname;

            bool userUpdated = badDriverCore.domain.User.UpdateUser(userToUpdate);


            List<KeyValuePair<string, string>> values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("##user", "bacana"));

            //badDriverCore.utils.Email.sendEmail(@"C:\Users\oscar.l.casagrande\Source\Repos\baddriver\badDriverCore\badDriverWebMockup\emailTemplate\welcome.html",
            //    "oscar.casagrande@gmail.com",
            //    "oscar.casagrande@gmail.com",
            //    "teste",
            //    "teste",
            //    true,
            //    values);
        }
    }
}
