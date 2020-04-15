using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace educationSector
{
    public partial class frmAdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                LabelUser.ForeColor = System.Drawing.Color.Red;

                if (DateTime.Now.Hour < 12)
                {
                    LabelUser.Text = "Welcome : " + "Admin" + ", Good Morning";
                }
                else if (DateTime.Now.Hour < 16)
                {
                    LabelUser.Text = "Welcome : " + "Admin" + ", Good Afternoon";
                }
                else
                {
                    LabelUser.Text = "Welcome : " + "Admin" + ", Good Evening";
                }     
            }
            else
            {
                Response.Redirect("../GuestForms/Index.aspx");
            }
        }

        

               
    }
}