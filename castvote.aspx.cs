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
    public partial class castvote : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-NBSMH4C\\SQLEXPRESS01;Initial Catalog=evoting2;Integrated Security=True";
            cn.Open();
            int vote_id = GetNewID();
            string voter = Session["voter"].ToString();
            string cand = Request.QueryString["cand"];
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "insert into votes values(@vote_id, @voter, @cand)";
            cmd.Parameters.AddWithValue("@vote_id", vote_id);
            cmd.Parameters.AddWithValue("@voter", voter);
            cmd.Parameters.AddWithValue("@cand", cand);
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Your Vote is Submitted");
                Response.Redirect("MyVote.aspx");
            }
            else
            {
                MessageBox.Show("Vote not casted! Something went wrong");
                Response.Redirect("GiveVote.aspx");
            }
        }

        public int GetNewID()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT MAX(vote_id) FROM votes";
            object x = cmd.ExecuteScalar();
            if (Convert.ToString(x) == "")
                return 1;
            else
                return Convert.ToInt32(x) + 1;
        }
    }
}