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
    public partial class MyVote : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-NBSMH4C\\SQLEXPRESS01;Initial Catalog=evoting2;Integrated Security=True";
            cn.Open();
            string voter = Session["voter"].ToString();
            cmd = new SqlCommand("select voter.nm, cand_name, party, logo from votes,voter,candidates where votes.voter_id=voter.voter_id and votes.cand_id = candidates.cand_id and votes.voter_id="+voter, cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                PlaceHolder1.Controls.Add(new LiteralControl("<div class='card d-flex flex-row align-items-center justify-content-between'><img style='width:250px; height:250px;' src='uploads/" + dr[3] + "'/><h1>" + dr[2] + "</h1><h1>" + dr[1] + "</h1></div>"));
            }
            else
            {
                MessageBox.Show("You have not Casted vote yet");
                Response.Redirect("GiveVote.aspx");
            }
            dr.Close();
        }
    }
}