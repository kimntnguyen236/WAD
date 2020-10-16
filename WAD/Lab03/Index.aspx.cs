using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab03
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               // loadCountry();
                checkCache();
                lblVisitor.Text = "Visitor Number: " + Session["visit"].ToString();
            }
        }
        DAL.CountryDAO dao = new DAL.CountryDAO();
        private void checkCache()
        {
            List<Models.Country> countries = dao.GetCountries();
            if (Cache["list"]== null)
            {
                Cache.Insert("list", countries,null,DateTime.Now.AddSeconds(15),TimeSpan.Zero);
                GridView1.DataSource = countries;
                GridView1.DataBind();
                lblCache.Text = "Read data from DB...";
            }
            else
            {
                GridView1.DataSource = Cache["list"];
                GridView1.DataBind();
                lblCache.Text = "Read data from cache...";
            }
        }
        private void loadCountry()
        {
            GridView1.DataSource = dao.GetCountries();
            GridView1.DataBind();
        }
    }
}