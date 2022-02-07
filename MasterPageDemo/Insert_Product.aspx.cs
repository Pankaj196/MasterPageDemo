using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductClassLibrary;
namespace MasterPageDemo
{
    public partial class More : System.Web.UI.Page
    {
        ProductClass pc=new ProductClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(TextBox1.Text);
            string pnm = TextBox2.Text;
            int quant= Convert.ToInt32(TextBox3.Text);
            double cost=Convert.ToDouble(TextBox4.Text);

            int res=pc.Insert_Prod(pid, pnm, quant, cost);
            Response.Redirect("Retrive.aspx");
            //Response.Write(res +" Record Inserted..");
        }
    }
}