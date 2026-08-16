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
    public partial class Voter_Reg : System.Web.UI.Page
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

        public int GetNewID()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT MAX(voter_id) FROM voter";
            object x = cmd.ExecuteScalar();
            if (Convert.ToString(x) == "")
                return 1;
            else
                return Convert.ToInt32(x) + 1;
        }

        protected void btn_reg_Click(object sender, EventArgs e)
        {
            int voter_id = GetNewID();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "insert into voter values (@voter_id,@voter_no,@nm,@email,@pass)";
            cmd.Parameters.AddWithValue("@voter_id", voter_id);
            cmd.Parameters.AddWithValue("@voter_no", txt_voter_no.Text);
            cmd.Parameters.AddWithValue("@nm", txt_name.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@pass", txt_pass.Text);
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Registered Successfully");
                Response.Redirect("VoterLogin.aspx");
            }
        }
    }
}