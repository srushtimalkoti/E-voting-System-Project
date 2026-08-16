using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Evoting2
{
    public partial class GiveVote : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        int flag = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-NBSMH4C\\SQLEXPRESS01;Initial Catalog=evoting2;Integrated Security=True";
            cn.Open();
            string voter = Session["voter"].ToString();
            cmd = new SqlCommand("select * from votes where voter_id="+voter,cn);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                flag = 2;
            }
            dr.Close();
            if (flag == 1)
            {
                cmd = new SqlCommand("select * from Candidates",cn);
                dr = cmd.ExecuteReader();
                PlaceHolder1.Controls.Add(new LiteralControl("<div class='row'>"));
                while (dr.Read())
                {
                    PlaceHolder1.Controls.Add(new LiteralControl("<div class='col-md-12 d-flex align-items-center justify-content-between'><img style='width:300px; height:300px;' src='uploads/" + dr[3] + "'/><h1>" + dr[1] + "</h1><h2>" + dr[2] + "</h2><a class='btn btn-primary' href='castvote.aspx?cand="+dr[0]+"'>Vote Now</a></div>"));
                }
                PlaceHolder1.Controls.Add(new LiteralControl("</div>"));
            }
            if(flag == 2)
                PlaceHolder1.Controls.Add(new LiteralControl("<h1 class='text-success'>You have Already Casted your Vote...</h1>"));
        }
    }
}