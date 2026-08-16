using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Evoting2
{
    public partial class VoterLogin : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-NBSMH4C\\SQLEXPRESS01;Initial Catalog=evoting2;Integrated Security=True";
            cn.Open();
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from voter where voter_no='"+txt_voter_id.Text+"' and pass ='"+txt_pass.Text+"'", cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Login Successfull");
                Session["voter"] = dr[0];
                Response.Redirect("VoterDash.aspx");
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }
    }
}