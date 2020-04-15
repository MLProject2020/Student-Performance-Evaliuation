using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace educationSector.AdminForms
{
    public partial class frmAdminReplyFeedbacks : System.Web.UI.Page
    {
        int QuestionID = 0;
        DataTable tab = new DataTable();
        BusinessLogic obj = new BusinessLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"] == null)
                {
                    Response.Redirect("~/Guest/frmLogin.aspx");
                }
                else
                {
                    QuestionID = int.Parse(Request.QueryString["value"].ToString());
                    GetDetails_ID();
                }
            }
            catch
            {

            }
        }

        public void GetDetails_ID()
        {
            tab.Rows.Clear();
            tab = obj.GetFeedbackById(QuestionID);

            if (tab.Rows.Count > 0)
            {
                txt_name.Text = tab.Rows[0]["RegNo"].ToString();
                TextBox1.Text = tab.Rows[0]["Feedback"].ToString();
            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                obj.SendReplyToFeedback(TextBox2.Text, DateTime.Now.ToShortDateString(), QuestionID);
                txt_name.Text = string.Empty;
                TextBox1.Text = string.Empty;
                TextBox2.Text = string.Empty;
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Replied Successfully')</script>");
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Server Error!')</script>");
            }
        }


    }
}