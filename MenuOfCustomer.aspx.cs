using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ProjectCoffee
{
    public partial class MenuOfCustomer : System.Web.UI.Page
    {
        string ConnectionString = @"Data Source=LAPTOP-4JKOUPSU;Initial Catalog=UserDB;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            using(SqlConnection sqlcon = new SqlConnection(ConnectionString))
            {
                sqlcon.Open();
                SqlDataAdapter salDa = new SqlDataAdapter("SELECT * FROM Product", sqlcon);
                DataTable dtbl = new DataTable();
                salDa.Fill(dtbl);
                product.DataSource = dtbl;
                product.DataBind();

            }

        }

     
    }
}