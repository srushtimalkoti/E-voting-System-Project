using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Evoting2
{
    public partial class Candidate : System.Web.UI.Page
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        static int flag = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DESKTOP-NBSMH4C\\SQLEXPRESS01;Initial Catalog=evoting2;Integrated Security=True";
            cn.Open();
            SetGrid();
        }
        public void EnableText()
        {
            txt_name.Enabled = true;
            txt_party.Enabled = true;
            FileUpload1.Enabled = true;
            btn_upload.Enabled = true;
        }
        public void DisableText()
        {
            txt_name.Enabled = false;
            txt_party.Enabled = false;
            FileUpload1.Enabled = false;
            btn_upload.Enabled = false;
        }
        public void ClearText()
        {
            txt_name.Text = "";
            txt_party.Text = "";
        }

        protected void btn_new_Click(object sender, EventArgs e)
        {
            flag = 1;
            EnableText();
            btn_save.Enabled = true;
            btn_new.Enabled = false;
        }

        public int GetNewID()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "SELECT MAX(cand_id) FROM candidates";
            object x = cmd.ExecuteScalar();
            if (Convert.ToString(x) == "")
                return 1;
            else
                return Convert.ToInt32(x) + 1;
        }
        public void SetGrid()
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Select * From Candidates order by cand_id";
            dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
        }
        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                txt_cand_id.Text = GetNewID().ToString();
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into Candidates values(@id,@nm,@party,@logo)";
                cmd.Parameters.AddWithValue("@id", txt_cand_id.Text);
                cmd.Parameters.AddWithValue("@nm", txt_name.Text);
                cmd.Parameters.AddWithValue("@party", txt_party.Text);
                cmd.Parameters.AddWithValue("@logo", filename);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                    MessageBox.Show("Record saved");
                else
                    MessageBox.Show("Record Not saved");
            }
            if (flag == 2)
            {
                cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "update Candidates set cand_name=@nm, party=@party, logo = @logo where cand_id = @id";
                cmd.Parameters.AddWithValue("@id", txt_cand_id.Text);
                cmd.Parameters.AddWithValue("@nm", txt_name.Text);
                cmd.Parameters.AddWithValue("@party", txt_party.Text);
                cmd.Parameters.AddWithValue("@logo", filename);
                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                    MessageBox.Show("Record Updated");
                else
                    MessageBox.Show("Record Not updated");
            }
            SetGrid();
            ClearText();
            DisableText();
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        static string filename;

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_cand_id.Text = GridView1.SelectedRow.Cells[1].Text;
            txt_name.Text = GridView1.SelectedRow.Cells[2].Text;
            txt_party.Text = GridView1.SelectedRow.Cells[3].Text;

            btn_new.Enabled = false;
            btn_save.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;

        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            flag = 2;
            EnableText();
            btn_new.Enabled = false;
            btn_save.Enabled = true;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = "Delete from Candidates where cand_id=@id";
            cmd.Parameters.AddWithValue("@id", txt_cand_id.Text);

            int x = cmd.ExecuteNonQuery();
            if (x > 0)
                MessageBox.Show("Record Deleted");
            else
                MessageBox.Show("Record  Not Deleted");

            SetGrid();
            ClearText();
            DisableText();
            btn_new.Enabled = true;
            btn_save.Enabled = false;
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
        }

        protected void btn_upload_Click1(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                filename = txt_party.Text + Path.GetExtension(FileUpload1.FileName);
                string filepath = Server.MapPath("~/uploads/") + filename;
                FileUpload1.SaveAs(filepath);
                MessageBox.Show("Logo Uploaded Successfully");
            }
        }

    }
}