using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace badDriverCore.utils
{

    public static class DatabaseHelper
    {
        static AppSettingsReader reader = new AppSettingsReader();


        static string connectionString = reader.GetValue("databaseConnectionString", typeof(string)).ToString();

        static DbConnection GetDatabaseConnection()
        {
            SqlConnection connection = new SqlConnection();
            try
            {
                connection.ConnectionString = connectionString;
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (connection.State == ConnectionState.Closed)
                {
                    throw new Exception("Database connection is closed.");
                }
            }

            return connection;
        }

        public static IDataReader ExecuteReader(List<KeyValuePair<string, object>> parameters, string procedure)
        {
            IDataReader reader = null;
            IDbCommand command = null;
            try
            {
                using (command = new SqlCommand(procedure, (SqlConnection)GetDatabaseConnection()))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    foreach (var p in parameters)
                    {
                        SqlParameter param = new SqlParameter();
                        param.ParameterName = p.Key;
                        param.Value = p.Value;
                        param.SqlDbType = TypeToSqlDbType(p.Value.GetType());
                        command.Parameters.Add(param);
                    }
                    reader = command.ExecuteReader();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Dispose();
            }

            return reader;
        }

        public static bool ExecuteNonQuery(List<KeyValuePair<string, string>> parameters, string procedure)
        {
            IDbCommand command = null;
            bool result = false;

            try
            {
                using (command = new SqlCommand(procedure, (SqlConnection)GetDatabaseConnection()))
                {
                    foreach (var p in parameters)
                    {
                        command.Parameters.Add(new SqlParameter(p.Key, p.Value));
                    }

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Dispose();
            }

            return result;
        }

        public static object ExecuteScalar(List<KeyValuePair<string, string>> parameters, string procedure)
        {
            IDbCommand command = null;
            object result = null;

            try
            {
                using (command = new SqlCommand(procedure, (SqlConnection)GetDatabaseConnection()))
                {
                    foreach (var p in parameters)
                    {
                        command.Parameters.Add(new SqlParameter(p.Key, p.Value));
                    }

                    result = command.ExecuteScalar();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Dispose();
            }

            return result;
        }

        private static SqlDbType TypeToSqlDbType(Type t)
        {
            String name = t.Name;
            SqlDbType result = SqlDbType.VarChar; // default value
            try
            {
                if (name.Contains("16") || name.Contains("32") || name.Contains("64"))
                {
                    name = name.Substring(0, name.Length - 2);
                }
                result = (SqlDbType)Enum.Parse(typeof(SqlDbType), name, true);
            }
            catch (Exception)
            {
                // add error handling to suit your taste
            }

            return result;
        }
    }
}
