using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;
using System.Text;

namespace Lab03
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(Server.MapPath("~/HitVisitors.txt"));
            int cnt = 0;
            cnt = int.Parse(sr.ReadLine());
            Application.Lock();
            Session["visit"] = cnt;
            cnt++;
            sr.Close();
            Application.UnLock();
            StreamWriter sw = new StreamWriter(Server.MapPath("~/HitVisitors.txt"));
            sw.WriteLine(cnt);
            sw.Flush();
            sw.Close();
        }
    }
}