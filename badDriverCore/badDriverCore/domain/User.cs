using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace badDriverCore.domain
{
    public static class User
    {
        public static model.User CreateUser(model.User user)
        {
            model.User result = new model.User();

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

        public static model.User GetUserById(int id)
        {
            model.User result = new model.User();

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

        public static model.User GetUserByIOrEmailOrUsernameAndPassword(int id, string email, string username, string password)
        {
            model.User result = new model.User();

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

        public static bool ResetUserPasswordByEmailOrUsername(string email, string ussername)
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
