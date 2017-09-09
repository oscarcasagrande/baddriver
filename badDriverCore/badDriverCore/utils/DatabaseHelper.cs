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
                    foreach (var p in parameters)
                    {
                        command.Parameters.Add(new SqlParameter(p.Key, p.Value));
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
                reader.Dispose();
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
    }
}
