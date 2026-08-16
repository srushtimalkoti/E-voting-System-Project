using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Evoting2
{
    public partial class ShowResults : System.Web.UI.Page
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

            cmd = new SqlCommand("select * from results",cn);
            dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                flag = 2;
            }
            dr.Close();
            if (flag == 1)
            {
                cmd = new SqlCommand("SELECT cand_name, party, logo, total_votes from results, candidates where candidates.cand_id = results.cand_id order by total_votes desc", cn);
                dr = cmd.ExecuteReader();
                PlaceHolder1.Controls.Add(new LiteralControl("<table class='table res'><tr><th colspan='2'>Party</th><th>Candidate</th><th>Total Votes</th></tr>"));

                while (dr.Read())
                {
                    PlaceHolder1.Controls.Add(new LiteralControl("<tr><td><img style='width:100px; height:100px;' src='uploads/" + dr[2] + "'/></td><td><h1>" + dr[1] + "</h1></td><td><h1>" + dr[0] + "</h1></td><td><h1>" + dr[3] + "</h1></td></tr>"));
                }

                PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
            }
            if (flag == 2)
            {
                PlaceHolder1.Controls.Add(new LiteralControl("<h1>Results are not yet published</h1>"));
            }
        }
    }
}