using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = badDriverModel;
using domain = badDriverDomain;

namespace badDriverService
{
    public static class User
    {
        public static model.User CreateUser(model.User user)
        {
            return domain.User.CreateUser(user);
        }

        public static void SendWelcomeEmail(model.User user)
        {
            domain.User.SendWelcomeEmail(user);
        }

        public static model.User GetUserById(int id)
        {
            return domain.User.GetUserById(id);
        }

        public static model.User GetUserByIOrEmailOrUsernameAndPassword(int id, string email, string username, string password)
        {
            return domain.User.GetUserByIOrEmailOrUsernameAndPassword(id, email, username, password);
        }

        public static bool UpdateUser(model.User user)
        {
            return domain.User.UpdateUser(user);
        }

        public static bool ResetUserPasswordByEmailOrUsername(string email, string username)
        {
            return domain.User.ResetUserPasswordByEmailOrUsername(email, username);
        }
    }
}
