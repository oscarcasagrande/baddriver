using System;
using System.Collections.Generic;
using System.Data;
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

            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();

            parameters.Add(new KeyValuePair<string, string>("@email", email));
            parameters.Add(new KeyValuePair<string, string>("@username", username));
            parameters.Add(new KeyValuePair<string, string>("@password", password));
            IDataReader reader;
            try
            {
                using (reader = utils.DatabaseHelper.ExecuteReader(parameters, "procUser_read"))
                {
                    if (reader.Read())
                    {
                        result.Id = (int)reader["Id"];
                        result.Email = reader["email"].ToString();
                        result.Nickname = reader["nickname"].ToString();
                        result.Active = (bool)reader["active"];
                    }
                }
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
