using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Evoting2.reports
{
    public partial class frm_candidateslist : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-NBSMH4C\\SQLEXPRESS01;Initial Catalog=evoting2;Integrated Security=True";
            cn.Open();
            cmd = new SqlCommand("select * from candidates",cn);
            dr = cmd.ExecuteReader();
            PlaceHolder1.Controls.Add(new LiteralControl("<table class='table'><tr><th>Candidate Id</th><th>Candidate</th><th>Party</th><th>Logo</th></tr>"));
            while (dr.Read())
            {
                PlaceHolder1.Controls.Add(new LiteralControl("<tr><td>" + dr[0] + "</td><td>" + dr[1] + "</td><td>" + dr[2] + "</td><td><img style='width:150px; height:150px;' src='../uploads/" + dr[3] + "'</td></tr>"));
            }
            PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
            dr.Close();
        }
    }
}