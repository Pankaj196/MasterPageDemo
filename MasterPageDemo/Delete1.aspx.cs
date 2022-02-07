using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductClassLibrary;
namespace MasterPageDemo
{
    public partial class Delete1 : System.Web.UI.Page
    {
        ProductClass pc=new ProductClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int pid = Convert.ToInt32(TextBox1.Text);
            pc.Delete_Prod(pid);
            Response.Redirect("Retrive.aspx");

        }
    }
}