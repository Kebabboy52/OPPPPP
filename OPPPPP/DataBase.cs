﻿//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OPPPPP
//{
//    public class Database
//    {
//        private readonly string dataSource;
//        public Database(string dataSource)
//        {
//            this.dataSource = dataSource;
//        }
//        public bool InitializeDatabase()
//        {
//            SQLiteConnection conn = new SQLiteConnection(dataSource);
//            try
//            {
//                conn.Open();
//                if (conn.State == ConnectionState.Open)
//                {
//                    SQLiteCommand cmd = conn.CreateCommand();
//                    string sql_command = "DROP TABLE IF EXISTS users;"
//                    + "CREATE TABLE users("
//                   + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
//                   + "login TEXT, "
//                   + "password TEXT, "
//                   + "role TEXT; ";
//                    cmd.CommandText = sql_command;
//                    cmd.ExecuteNonQuery();
//                }
//            }
//            catch
//            {
//                return false;
//            }
//            finally
//            {
//                conn.Dispose();
//            }
//            return true;
//        }
//    }
//}
