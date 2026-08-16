using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Evoting2
{
    public partial class PublishResults : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source=DESKTOP-NBSMH4C\\SQLEXPRESS01;Initial Catalog=evoting2;Integrated Security=True");

            if (!IsPostBack)
            {
                try
                {
                    cn.Open();

                    cmd = new SqlCommand("SELECT COUNT(*) FROM results", cn);
                    int resultCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (resultCount > 0)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Results Already Published'); window.location='AdminDash.aspx';", true);
                        return;
                    }

                    // Fetch voting results
                    cmd = new SqlCommand("SELECT votes.cand_id, cand_name, party, logo, COUNT(*) AS total_votes FROM votes INNER JOIN candidates ON candidates.cand_id = votes.cand_id GROUP BY votes.cand_id, cand_name, party, logo", cn);
                    dr = cmd.ExecuteReader();

                    PlaceHolder1.Controls.Add(new LiteralControl("<table class='table'><tr><th colspan='2'>Party</th><th>Candidate</th><th>Total Votes</th></tr>"));

                    while (dr.Read())
                    {
                        string row = "<tr><td><img style='width:100px; height:100px;' src='uploads/" + dr["logo"].ToString() + "'/></td>";
                        row += "<td><h1>" + dr["party"].ToString() + "</h1></td>";
                        row += "<td><h1>" + dr["cand_name"].ToString() + "</h1></td>";
                        row += "<td><h1>" + dr["total_votes"].ToString() + "</h1></td></tr>";

                        PlaceHolder1.Controls.Add(new LiteralControl(row));
                    }

                    PlaceHolder1.Controls.Add(new LiteralControl("</table>"));
                    dr.Close();
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "error", "alert('Error: " + ex.Message.Replace("'", "\\'") + "');", true);
                }
                finally
                {
                    if (cn.State == System.Data.ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
            }
        }

        protected void btn_publish_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                List<KeyValuePair<int, int>> results = new List<KeyValuePair<int, int>>();

                // Fetch votes count per candidate
                cmd = new SqlCommand("SELECT votes.cand_id, COUNT(*) AS total_votes FROM votes GROUP BY votes.cand_id", cn);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    int candId = Convert.ToInt32(dr["cand_id"]);
                    int totalVotes = Convert.ToInt32(dr["total_votes"]);
                    results.Add(new KeyValuePair<int, int>(candId, totalVotes));
                }
                dr.Close();

                // Insert results into the results table
                foreach (var result in results)
                {
                    using (SqlCommand insertCmd = new SqlCommand("INSERT INTO results (cand_id, total_votes) VALUES (@cand_id, @total_votes)", cn))
                    {
                        insertCmd.Parameters.AddWithValue("@cand_id", result.Key);
                        insertCmd.Parameters.AddWithValue("@total_votes", result.Value);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                ClientScript.RegisterStartupScript(this.GetType(), "success", "alert('Results have been published successfully!'); window.location='AdminDash.aspx';", true);
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "error", "alert('Error: " + ex.Message.Replace("'", "\\'") + "');", true);
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
