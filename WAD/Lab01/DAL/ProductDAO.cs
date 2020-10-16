using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace Lab01.DAL
{
    public class ProductDAO
    {

        ConnectDB connect = new ConnectDB();
        public ProductDAO(){
            connect.setConnect();
        }
        public DataSet GetProducts()
        {
            string query = "select * from Product";
            var sqlda = new SqlDataAdapter(query, connect.setConnect());
            var ds = new DataSet();
            sqlda.Fill(ds, "Product");
            return ds;
        }
        public void findOne(int id,DetailsView detailsView)
        {
            string query = "select * from Product where Id=@id";
            var command = new SqlCommand(query, connect.setConnect());
            command.Parameters.AddWithValue("@id", id);
            var sqlda = new SqlDataAdapter(command);
            var ds = new DataSet();
            sqlda.Fill(ds, "Product");
            detailsView.DataSource = ds.Tables["Product"];
            detailsView.DataBind();
        }

        public void findAll(TextBox textBox, DataList dataList)
        {
            string query = "select * from Product where Name LIKE '%"+textBox.Text+"%'";
            var sqlda = new SqlDataAdapter(query, connect.setConnect());
            var ds = new DataSet();
            sqlda.Fill(ds, "Product");
            dataList.DataSource = ds.Tables["Product"];
            dataList.DataBind();
        }

        public void addProduct(Lab01.Models.Product product)
        {
            string query = "INSERT Product VALUES(@name,@price,@quantity,@photo)";
            var command = new SqlCommand(query, connect.setConnect());
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@quantity", product.Quantity);
            command.Parameters.AddWithValue("@photo", product.Photo);
            var sqlda = new SqlDataAdapter(command);
            var ds = new DataSet();
            sqlda.Fill(ds, "Product");
        }
    }
}