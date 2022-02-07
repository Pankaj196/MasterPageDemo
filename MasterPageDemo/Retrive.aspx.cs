using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MasterPageDemo
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                SqlConnection con = new SqlConnection();
                con = new SqlConnection("data source =devops.aapnainfotech.com;database=Product_Master; uid=apnsa; pwd=aapnainfo@1234");
                SqlDataReader dr;
                con.Open();
                string query = "select * from Product";
                SqlCommand cmd = new SqlCommand(query, con);
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                GridView1.DataSource = dr;
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}