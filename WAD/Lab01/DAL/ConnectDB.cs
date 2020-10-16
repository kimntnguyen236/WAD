using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Lab01.DAL
{
    public class ConnectDB
    {

        private SqlConnection sqlConnection;
        public SqlConnection setConnect()
        {
            string str = "server=.;database=Sem3DB;uid=sa;pwd=123";
            sqlConnection = new SqlConnection(str);
            return sqlConnection;
        }
    }
}