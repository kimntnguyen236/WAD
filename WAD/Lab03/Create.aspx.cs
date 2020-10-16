using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab03
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        DAL.CountryDAO dao = new DAL.CountryDAO();
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Models.Country country = new Models.Country
                {
                    CountryName = txtName.Text,
                    Population = int.Parse(txtPop.Text),
                    Language = txtCode.Text,
                    Photo_ = "Images/" + FileUpload1.FileName
                };
                dao.AddCountry(country);
                lblMess.Text = "Successfully";
            }
            catch (Exception ex)
            {
                lblMess.Text = ex.Message;
            }
        }
    }
}