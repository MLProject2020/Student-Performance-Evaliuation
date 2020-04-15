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
    public partial class frmAdminAccount : System.Web.UI.Page
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

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                DataTable tab = new DataTable();
                BusinessLogic obj = new BusinessLogic();
                tab.Rows.Clear();

                tab = obj.Search_Admin(Session["username"].ToString());
                string oldPassword = tab.Rows[0]["Password"].ToString();

                if (TextBox1.Text.Equals(oldPassword))
                {
                    try
                    {
                        obj.ChangePassword_Admin(Session["username"].ToString(), TextBox2.Text);
                                               
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Admin Password changed successfully')</script>");
                    }
                    catch
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Server Error!')</script>");
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Admin Old password incorrect')</script>");
                }
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Server Error!!!Please Check Database Connectivity')</script>");
            }
        }

    }
}