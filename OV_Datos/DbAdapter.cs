﻿using Libs;
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

            return Read<T>(dr);
        }

        public static List<T> LoadDataFromSp<T>(string spName, Dictionary<string, string> spParams = null) where T : new()
        {
            SqlCommand cmd = PrepareSp(spName, spParams);

            SqlDataReader dr = cmd.ExecuteReader();

            return Read<T>(dr);
        }

        public static void ExecSp(string spName, Dictionary<string, string> spParams = null)
        {
            SqlCommand cmd = PrepareSp(spName, spParams);

            cmd.ExecuteNonQuery();
        }

        private static SqlCommand PrepareSp(string spName, Dictionary<string, string> spParams = null)
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

        private static List<T> Read<T>(SqlDataReader dr) where T : new()
        {
            List<T> listOfItems = new List<T>();

            while (dr.Read())
            {
                T item = new T();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    item = Utils.MapBoxedFromKeyValue(item, dr.GetName(i), dr.GetValue(i));
                }

                listOfItems.Add(item);
            }
            dr.Close();

            return listOfItems;
        }

        public static DataSet LoadBackToDataSetWithSp(string srcTable, string spName, Dictionary<string, string> spParams = null)
        {
            SqlCommand cmd = PrepareSp(spName, spParams);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds, srcTable);

            return ds;
        }
    }
}
