using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductClassLibrary;
namespace MasterPageDemo
{
    public partial class Contact : System.Web.UI.Page
    {
        ProductClass pc=new ProductClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(txtId.Text);
            string pnm = txtPname.Text;
            int quant = Convert.ToInt32(txtPrice.Text);
            double cost = Convert.ToDouble(txtQuant.Text);

            int res = pc.Update_Prod(pid, pnm, quant, cost);
            Response.Redirect("Retrive.aspx");

        }
    }
}