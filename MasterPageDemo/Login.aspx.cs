using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProductClassLibrary;
namespace MasterPageDemo
{
    public partial class Login : System.Web.UI.Page
    {
        ProductClass ps=new ProductClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string uname=txtUser.Text;
            string pass=txtPwd.Text;            
           bool res= ps.Cust_Login(uname, pass);
            if (res)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Label3.Visible = true;
                Label3.Text = "Invalid Credentials";
                //Response.Redirect("Login.aspx");
            }
        }
    }
}