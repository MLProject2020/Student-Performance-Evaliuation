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
    public partial class frmViewCourses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"] != null)
                {
                    if (!IsPostBack)
                    {
                        LoadGrid();
                    }
                }
                else
                {
                    Response.Redirect("~/GuestForms/Index.aspx");
                }
            }
            catch
            {

            }
            
        }

        BusinessLogic db = new BusinessLogic();

        private void LoadGrid()
        {
            try
            {
                DataGridView.DataSource = db.View_Courses();
                DataGridView.DataBind();
            }
            catch
            {
            }
        }

        protected void Button_Add_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("frmAddCourse.aspx");
        }

    }
}