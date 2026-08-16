using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Evoting2
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "Admin" && txt_pass.Text == "123")
            {
                MessageBox.Show("Login Successfull");
                Response.Redirect("AdminDash.aspx");
            }
            else
                MessageBox.Show("Login Failed");
        }
    }
}