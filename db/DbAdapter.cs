using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace OrdenVentas.db
{
    internal static class DbAdapter
    {
        private static SqlConnection sqlConnection;
        private static SqlCommand sqlCommand;
        private static SqlDataReader dr;

        public static void InitializeConnection()
        {
            string Source = "";
            string InitialCat = "";
            // string IntSecuirity = "";
            string UserID = "";
            string Password = "";

            sqlConnection = new SqlConnection($"{Source} {InitialCat} {UserID} {Password}");
            sqlConnection.Open();
        }

        public static List<T> LoadTable<T>(string tableName, string fields = "*", string where = "") where T : new()
        {
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = $"SELECT {fields} FROM {tableName} {where}";

            dr = sqlCommand.ExecuteReader();

            List<T> listOfItems = new List<T>();

            while (dr.Read())
            {
                T item = new T();
                Type type = item.GetType();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    object boxed = item;

                    type.GetProperty(dr.GetName(i)).SetValue(boxed, dr.GetValue(i));

                    item = (T)boxed;
                }

                listOfItems.Add(item);
            }
            dr.Close();

            return listOfItems;
        }

        public static List<T> LoadWithSp<T>(Dictionary<string, string> items, string spName) where T : new()
        {
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = spName;

            if (items != null)
            {
                foreach (var item in items)
                {
                    sqlCommand.Parameters.AddWithValue($"@{item.Key}", item.Value);
                }
            }

            dr = sqlCommand.ExecuteReader();

            List<T> listOfItems = new List<T>();

            while (dr.Read())
            {
                T item = new T();
                Type type = item.GetType();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    object boxed = item;

                    type.GetProperty(dr.GetName(i)).SetValue(boxed, dr.GetValue(i));

                    item = (T)boxed;
                }

                listOfItems.Add(item);
            }
            dr.Close();

            return listOfItems;
        }

        public static void RunSp(Dictionary<string, string> items, string spName)
        {
            sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = spName;

            foreach (var item in items)
            {
                sqlCommand.Parameters.AddWithValue($"@{item.Key}", item.Value);
            }

            sqlCommand.ExecuteNonQuery();
        }
    }
}
