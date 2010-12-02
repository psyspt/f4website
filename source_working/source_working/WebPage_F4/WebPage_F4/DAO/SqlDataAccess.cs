using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Xml;

namespace DAO
{
    public class SqlDataAccess
    {
#region ConnectionString
        protected static String connectionString;
        public static String ConnectionString
        {
            get
            {
                return ReadConnectionString("E:\\WebSource\\source_working\\source_working\\WebPage_F4\\ConnectionString.xml");
            }
        }
        public static String ReadConnectionString(String file)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);
                XmlElement root = doc.DocumentElement;
                String connectionString = root.InnerText;
                return connectionString;
            }
            catch (System.Exception e)
            {
                throw e;
            }
        }
#endregion
#region ExecuteNoneQuery
        public static int ExecuteNoneQuery(String spName, List<SqlParameter> sqlParams)
        {
            int n;
            try
            {
                SqlConnection connect = new SqlConnection(ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand command = connect.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = spName;
                    if (sqlParams != null)
                    {
                        foreach (SqlParameter param in sqlParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }
                    n = command.ExecuteNonQuery();
                }

                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return n;
        }
        public static int ExecuteNoneQuery(String spName)
        {
            return ExecuteNoneQuery(spName, null);
        }
#endregion
#region ExecuteQuery
        public static DataTable ExecuteQuery(String sqName, List<SqlParameter> sqlParams)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection connect = new SqlConnection(ConnectionString);
                connect.Open();
                try
                {
                    SqlCommand command = connect.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = sqName;
                    if (sqlParams != null)
                    {
                        foreach (SqlParameter param in sqlParams)
                        {
                            command.Parameters.Add(param);
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = command;
                    adapter.Fill(dt);
                }
                catch (System.Exception e)
                {
                    throw e;
                }
                finally
                {
                    connect.Close();
                }
            }
            catch (System.Exception e)
            {
                throw e;
            }
            return dt;
        }
        public static DataTable ExecuteQuery(String spName)
        {
            return ExecuteQuery(spName, null);
        }
#endregion
    }
}
