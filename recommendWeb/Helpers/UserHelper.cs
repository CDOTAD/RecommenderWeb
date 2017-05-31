﻿using System;
using System.Collections;
using MySql.Data.MySqlClient;
using recommendWeb.Providers;
using recommendWeb.Models;

namespace recommendWeb.Helpers
{
    public class UserHelper
    {
        public static ArrayList GetAllUser()
        {
            ArrayList allUser = new ArrayList();

            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = DataBaseProvider.getInstance().mySqlConn;


            string sqlStr =
                @"select * from user";

            mySqlCommand.CommandText = sqlStr;

            mySqlCommand.Connection.Open();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        User user = new User();
                        user.UserId = reader.GetInt32(0);

                        allUser.Add(user);
                    }
                }
            }
            catch(Exception e)
            {
                throw (e);
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }

            return allUser;
           
        }

        public static User GetUserById(int id)
        {
            User user = new User();

            MySqlCommand mySqlCommand = new MySqlCommand();
            mySqlCommand.Connection = DataBaseProvider.getInstance().mySqlConn;

            string sqlStr =
                @"select * from user where userId = ?us_id";

            mySqlCommand.CommandText = sqlStr;
            mySqlCommand.Parameters.AddWithValue("?us_id", id);

            mySqlCommand.Connection.Open();

            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    if (reader.HasRows)
                    {
                        user.UserId = reader.GetInt32(0);
                    }
                }
            }
            catch(Exception e)
            {
                throw (e);
            }
            finally
            {
                mySqlCommand.Connection.Close();
            }

            return user;
        }
    }
}