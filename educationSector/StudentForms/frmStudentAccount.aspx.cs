using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace educationSector
{
    public partial class frmStudentAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {

            }
            else
            {
                Response.Redirect("~/GuestForms/Index.aspx");

            }
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                DataTable tab = new DataTable();
                BusinessLogic obj = new BusinessLogic();
                tab.Rows.Clear();

                tab = obj.GetStudentByUName(Session["username"].ToString());
                string oldPassword = tab.Rows[0]["Password"].ToString();

                if (TextBox1.Text.Equals(oldPassword))
                {

                    obj.ChangePassword(Session["username"].ToString(), TextBox2.Text);

                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Student Password changed successfully')</script>");

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Student Old password incorrect')</script>");
                }
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Server Error!!!Please Check Database Connectivity')</script>");
            }

        }
    }
}