using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using badDriverCore.model;
using System.IO;

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

        public static void SendWelcomeEmail(model.User user)
        {
            string templatePath = @"C:\Users\oscar.l.casagrande\Source\Repos\baddriver\badDriverCore\badDriverWebMockup\emailTemplate\welcome.html";
            string templateString = string.Empty;

            List<KeyValuePair<string, string>> toFrom = new List<KeyValuePair<string, string>>();
            toFrom.Add(new KeyValuePair<string, string>("##TitleWelcome", "Bem-vinda ao BadDriver"));
            toFrom.Add(new KeyValuePair<string, string>("##nickname", user.Nickname));
            toFrom.Add(new KeyValuePair<string, string>("##link", "LINK_TBD"));

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(templatePath).ToList();

            foreach (var l in lines)
            {
                templateString += l;
            }

            utils.Email.sendEmail(user.Email, "Welcome", templateString, true, toFrom);

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
            IDataReader reader = null;
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

        public static bool UpdateUser(model.User user)
        {
            bool result = false;

            List<KeyValuePair<string, string>> parameters = new List<KeyValuePair<string, string>>();

            parameters.Add(new KeyValuePair<string, string>("@id", user.Id.ToString()));
            parameters.Add(new KeyValuePair<string, string>("@email", user.Email));
            parameters.Add(new KeyValuePair<string, string>("@username", user.Nickname));
            parameters.Add(new KeyValuePair<string, string>("@password", user.Password));
            parameters.Add(new KeyValuePair<string, string>("@active", user.Active.ToString()));

            try
            {
                result = utils.DatabaseHelper.ExecuteNonQuery(parameters, "procUser_update");
            }
            catch (Exception)
            {


                throw;
            }
            finally
            {

            }

            return result;
        }

        public static bool ResetUserPasswordByEmailOrUsername(string email, string ussername)
        {
            bool result = false;

            model.User userToUpdate = GetUserByEmailOrUsername(email, ussername);


            userToUpdate.Active = false;

            bool userUpdated = UpdateUser(userToUpdate);

            if (userUpdated)
            {
                result = true;
            }


            return result;
        }

        private static model.User GetUserByEmailOrUsername(string email, string ussername)
        {
            throw new NotImplementedException();
        }
    }
}
