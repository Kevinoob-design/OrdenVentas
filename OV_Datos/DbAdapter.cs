using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OV_Datos
{
    public static class DbAdapter
    {
        private static SqlConnection con;

        public static void InitializeConnection()
        {
            string Source = ConfigurationManager.AppSettings.Get("Source");
            string InitialCat = ConfigurationManager.AppSettings.Get("InitialCat");
            string IntSecuirity = ConfigurationManager.AppSettings.Get("IntSecuirity");
            string UserID = ConfigurationManager.AppSettings.Get("UserID");
            string Password = ConfigurationManager.AppSettings.Get("Password");

            con = new SqlConnection($"{Source} {InitialCat} {IntSecuirity} {UserID} {Password}");
            con.Open();
        }

        public static List<T> LoadTable<T>(string tableName, string fields = "*", string where = "") where T : new()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"SELECT {fields} FROM {tableName} {where}";

            SqlDataReader dr = cmd.ExecuteReader();

            List<T> listOfItems = new List<T>();

            while (dr.Read())
            {
                T item = new T();
                Type type = item.GetType();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    object boxed = item;

                    type.GetProperty(dr.GetName(i))?.SetValue(boxed, dr.GetValue(i));

                    item = (T)boxed;
                }

                listOfItems.Add(item);
            }
            dr.Close();

            return listOfItems;
        }

        public static List<T> LoadDataFromSp<T>(string spName, Dictionary<string, string> spParams = null) where T : new()
        {
            SqlCommand cmd = PrepareSp(spName, spParams);

            SqlDataReader dr = cmd.ExecuteReader();

            List<T> listOfItems = new List<T>();

            while (dr.Read())
            {
                T item = new T();
                Type type = item.GetType();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    object boxed = item;

                    type.GetProperty(dr.GetName(i))?.SetValue(boxed, dr.GetValue(i));

                    item = (T)boxed;
                }

                listOfItems.Add(item);
            }
            dr.Close();

            return listOfItems;
        }

        public static SqlCommand PrepareSp(string spName, Dictionary<string, string> spParams = null)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;

            foreach (var item in spParams)
            {
                cmd.Parameters.AddWithValue($"@{item.Key}", item.Value);
            }

            return cmd;
        }

        public static DataSet LoadDataBackToDataSetWithSp(string srcTable, string spName, Dictionary<string, string> spParams = null)
        {
            SqlCommand cmd = PrepareSp(spName, spParams);

            SqlDataAdapter da = new SqlDataAdapter($"{cmd.CommandText} {cmd.Parameters}", con);

            DataSet ds = new DataSet();

            da.Fill(ds, srcTable);

            return ds;
        }
    }
}
