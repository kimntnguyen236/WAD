using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                con.setConnect();
                loadData();
            }   
        }
        DAL.ConnectDB con = new DAL.ConnectDB();
        DAL.ProductDAO db = new DAL.ProductDAO();

        private void loadData()
        {
            try
            {
                DataList1.DataSource = db.GetProducts();
                DataList1.DataBind();
            }
            catch (Exception exx)
            {

                throw;
            }
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Equals("banana"))
            {
                Response.Redirect("~/Details.aspx?Id="+e.CommandArgument);
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            db.findAll(TextBox1, DataList1);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                db.findAll(TextBox1, DataList1);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}