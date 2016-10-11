using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using LiveOdiaGit.Models;

namespace LiveOdiaGit
{
    public class dbutility
    {
        public static DataTable getAllTopStory()
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT * FROM topnews";
                MySqlCommand cmd = new MySqlCommand(query, conn);


                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public static DataTable getNewstoryById(int id)
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT * FROM newstory where nsid=" + id;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public static DataTable getAllNewStory()
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT * FROM newstory";
                MySqlCommand cmd = new MySqlCommand(query, conn);


                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public static DataTable getHotNewsDetail(int id)
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT * FROM hotnews WHERE ndid=" + id;
                MySqlCommand cmd = new MySqlCommand(query, conn);
                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public static DataTable GetHotNewsTitle()
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT * FROM newsdivision";
                MySqlCommand cmd = new MySqlCommand(query, conn);


                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public static DataTable getTopNewsById(int id)
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT * FROM topnews where tnid=" + id;
                MySqlCommand cmd = new MySqlCommand(query, conn);


                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public static bool addNewCategory(AdminModel value)
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            bool res = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText = "INSERT INTO newsdivision (newsdiv) VALUES (@newsdiv)";
                cmd.Parameters.AddWithValue("newsdiv", value.CNAME);
                cmd.Connection = conn;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;

        }

        public static void SaveData(Dictionary<string, object> myData)
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            bool res = false;
            try
            {

                foreach (var key in myData)
                {

                }

                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText = "INSERT INTO newsdivision (newsdiv) VALUES (@newsdiv)";
                cmd.Parameters.AddWithValue("newsdiv", myData.Keys);
                cmd.Connection = conn;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
        }
    }
}