using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab01
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DAL.AdminLogin login = new DAL.AdminLogin();
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (login.checkLogin(txtName.Text,txtPassword.Text)==true)
                {
                    Session["name"] = txtName.Text;
                    Response.Redirect("~/Admin/CreatProduct.aspx");
                }
                else
                {
                    // Response.Write("<script>alert('Invalid.')</script>");
                    Error.Text = "Invalid.";
                }
            }
            catch (Exception ex)
            {
                // Response.Write("<script>alert('ex.Message')</script>");
                Error.Text = ex.Message;
            }
        }
    }
}