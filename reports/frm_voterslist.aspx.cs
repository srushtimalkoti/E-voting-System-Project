using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Evoting2.reports
{
    public partial class frm_voterslist : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-NBSMH4C\\SQLEXPRESS01;Initial Catalog=evoting2;Integrated Security=True";
            cn.Open();
            cmd = new SqlCommand("select * from voter", cn);
            dr = cmd.ExecuteReader();
            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table'><tr><th>Voter Id</th><th>Name</th><th>Email</th><th>Password</th></tr>"));
            while (dr.Read())
            {
                PlaceHolder1.Controls.Add(new LiteralControl("<tr><td>" + dr[1] + "</td><td>" + dr[2] + "</td><td>" + dr[3] + "</td><td>" + dr[4] + "</td></tr>"));
            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
            dr.Close();
        }
    }
}