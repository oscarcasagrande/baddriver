using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using model = badDriverModel;
using utils = badDriverUtils;
using System.Configuration;

namespace badDriverDomain
{
    public static class User
    {
        static AppSettingsReader _reader = new AppSettingsReader();

        static string _folderEmailTemplate = _reader.GetValue("folderEmailTemplate", typeof(string)).ToString();

        public static model.User CreateUser(model.User user)
        {
            model.User result = new model.User();

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

            parameters.Add(new KeyValuePair<string, object>("@email", user.Email));
            parameters.Add(new KeyValuePair<string, object>("@nickname", user.Nickname));
            parameters.Add(new KeyValuePair<string, object>("@password", user.Password));


            try
            {

                user.Id = (Int32)utils.DatabaseHelper.ExecuteNonQuery(
                    parameters,
                    "procUser_Create",
                    new KeyValuePair<string, object>("@Id", user.Id));

                user.Active = true;

                result = user;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { }

            return result;
        }

        public static void SendWelcomeEmail(model.User user)
        {

            string templatePath = string.Format("{0}{1}", _folderEmailTemplate, "welcome.html");
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

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

            parameters.Add(new KeyValuePair<string, object>("@id", id));

            IDataReader reader = null;

            try
            {
                using (reader = utils.DatabaseHelper.ExecuteReader(parameters, "procUserId_read"))
                {
                    if (reader.Read())
                    {
                        result.Id = (int)reader["Id"];
                        result.Email = reader["email"].ToString();
                        result.Nickname = reader["nickname"].ToString();
                        result.Active = (bool)reader["active"];
                        result.Password = reader["password"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
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

        public static model.User GetUserByIOrEmailOrUsernameAndPassword(int id, string email, string username, string password)
        {
            model.User result = new model.User();

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

            parameters.Add(new KeyValuePair<string, object>("@id", id));
            parameters.Add(new KeyValuePair<string, object>("@email", email));
            parameters.Add(new KeyValuePair<string, object>("@nickname", username));
            parameters.Add(new KeyValuePair<string, object>("@password", password));
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
            catch (Exception ex)
            {
                throw ex;
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

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

            parameters.Add(new KeyValuePair<string, object>("@id", user.Id.ToString()));
            parameters.Add(new KeyValuePair<string, object>("@email", user.Email));
            parameters.Add(new KeyValuePair<string, object>("@Nickname", user.Nickname));
            parameters.Add(new KeyValuePair<string, object>("@password", user.Password));
            parameters.Add(new KeyValuePair<string, object>("@active", user.Active.ToString()));

            try
            {
                utils.DatabaseHelper.ExecuteNonQuery(parameters, "procUser_update", null);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }

            return result;
        }

        public static bool ResetUserPasswordByEmailOrUsername(string email, string username)
        {
            bool result = false;

            model.User userToUpdate = GetUserByEmailOrUsername(email, username);

            userToUpdate.Active = false;

            userToUpdate.Password = utils.Security.NewPassword();

            bool userUpdated = UpdateUser(userToUpdate);

            if (userUpdated)
            {
                result = true;
            }

            return result;
        }

        private static model.User GetUserByEmailOrUsername(string email, string username)
        {
            model.User result = new model.User();

            if (email.Length > 0)
            {
                result = GetUserByEmail(email);
            }
            else if (username.Length > 0)
            {
                result = GetUserByUsername(username);
            }

            return result;
        }

        private static model.User GetUserByUsername(string username)
        {
            model.User result = new model.User();

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

            parameters.Add(new KeyValuePair<string, object>("@nickname", username));

            IDataReader reader = null;

            try
            {
                using (reader = utils.DatabaseHelper.ExecuteReader(parameters, "procUserNickname_read"))
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
            catch (Exception ex)
            {
                throw ex;
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

        private static model.User GetUserByEmail(string email)
        {
            model.User result = new model.User();

            List<KeyValuePair<string, object>> parameters = new List<KeyValuePair<string, object>>();

            parameters.Add(new KeyValuePair<string, object>("@email", email));

            IDataReader reader = null;

            try
            {
                using (reader = utils.DatabaseHelper.ExecuteReader(parameters, "procUserEmail_read"))
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
            catch (Exception ex)
            {
                throw ex;
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
    }
}
