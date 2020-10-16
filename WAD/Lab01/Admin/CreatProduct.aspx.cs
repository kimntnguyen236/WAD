using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01.Admin
{
    public partial class CreatProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack && Session["name"]!= null)
            {
                lblWWel.Text = "Hi " + Session["name"] + "!!!";
                GridView1.DataSource =  dao.GetProducts();
                GridView1.DataBind();
            }
            else
            {
                
            }
        }
        DAL.ProductDAO dao = new DAL.ProductDAO();

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Product product = new Models.Product {
                    Name = txtName.Text,
                    Price = float.Parse(txtPrice.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                    Photo = "Image/" + FileUpload1.FileName
                };
                dao.addProduct(product);
                lblMessage.Text = "Create product completed successully! ";
                GridView1.DataSource = dao.GetProducts();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
    }
}