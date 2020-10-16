using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab01.DAL
{
    public class AdminLogin
    {
        ConnectDB connect = new ConnectDB();
        public AdminLogin()
        {
          // connect.setConnect();
        }
        public bool checkLogin(string name, string pass)
        {
            string query = "select * from Login WHERE Username = @name AND Password = @pass";
            var command = new SqlCommand(query, connect.setConnect());
            command.Parameters.AddWithValue("@name",name);
            command.Parameters.AddWithValue("@pass", pass);
            var sqlda = new SqlDataAdapter(command);
            var ds = new DataSet();
            sqlda.Fill(ds, "Login");
            if (ds.Tables["Login"].Rows.Count >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}