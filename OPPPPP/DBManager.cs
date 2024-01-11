using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.SQLite;
using System.Windows.Forms;

namespace OPPPPP
{
    public class DBManager
    {
        public bool AddNewUser(string db,string username, string password)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + db);
            conn.Open();
            if (conn.State== System.Data.ConnectionState.Open)
            {
                try 
                { 
                    SQLiteCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO users VALUES('" + username + "', '" + password + "')";
                        command.ExecuteNonQuery();
                        conn.Dispose();
                        return true;
                } 
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                    conn.Dispose ();
                }
            }
            return false;
        }
        public bool AuthUser (string bd, string username, string password) 
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + db);
            conn.Open();
            if (conn.State == System.Data.ConnectionState.Open) { }
                return false;
        }










    }
}
