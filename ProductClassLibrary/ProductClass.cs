using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace ProductClassLibrary
{
    public class ProductClass
    {
        
        public SqlConnection GetConnection()
        {
            SqlConnection con = null;
            con = new SqlConnection("data source =devops.aapnainfotech.com;database=Product_Master; uid=apnsa; pwd=aapnainfo@1234");
            return con;
        }
        public bool Cust_Login(string unm,string pswd)
        {
            SqlConnection con = GetConnection();
            string query = "select * from Cust_Login";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            SqlDataReader rd= cmd.ExecuteReader();
            bool isUserExist = false;
            while(rd.Read())
            {
                if(unm==rd["uname"].ToString() && pswd==rd["password"].ToString())
                {
                    isUserExist = true;
                    break;
                }
            }
            if(isUserExist)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Insert_Prod(int pid,string pnm,int quant,double cost)
        {
            SqlConnection con = GetConnection();
            string query = "insert into Product values(@pid,@pname,@quant,@price)";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pnm);
            cmd.Parameters.AddWithValue("@quant", quant);
            cmd.Parameters.AddWithValue("@price", cost);

            
            int recordsInserted= cmd.ExecuteNonQuery();
            return recordsInserted;

        }

        public int Update_Prod(int pid, string pnm, int quant, double cost)
        {
            SqlConnection con = GetConnection();
            string query = "update Product set pname='"+pnm+"',quant="+quant+",price="+cost+" where pid="+pid;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int recordsInserted = cmd.ExecuteNonQuery();
            return recordsInserted;

        }

        public int Delete_Prod(int pid)
        {
            SqlConnection con = GetConnection();
            string query = "delete Product where pid="+pid;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int recordsInserted = cmd.ExecuteNonQuery();
            return recordsInserted;

        }

    }
}
