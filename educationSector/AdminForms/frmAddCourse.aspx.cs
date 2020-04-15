using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Drawing;

namespace educationSector
{
    public partial class frmAddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"] != null)
                {
                    if (!IsPostBack)
                    {
                        InitControls();
                        Sems();
                        if (Request.QueryString["cname"] != null)
                        {

                            DataTable Course = db.Get_Course(Request.QueryString["cname"]);
                            if (Course == null || Course.Rows.Count > 0)
                            {
                                DataRow r = Course.Rows[0];
                                TextBox_Course.Text = r[0].ToString();
                                ViewState["ocname"] = r[0].ToString();
                                ListItem item = new ListItem(r[2].ToString());
                                int index = DropDownList1.Items.IndexOf(item);
                                DropDownList1.SelectedIndex = index;
                                TextBox_Desc.Text = r[1].ToString();
                                Button_Delete.Enabled = true;
                                Button_Update.Enabled = true;
                                Button_Add.Enabled = false;
                            }
                        }
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

        protected void ButtonView_Click(object sender, System.EventArgs e)
        {
            Response.Redirect("frmViewCourses.aspx");
        }

        #region User Written Code

        private void Sems()
        {
            for (int i = 1; i <= 8; i++)
            {
                DropDownList1.Items.Add(i.ToString());
            }
        }

        private void InitControls()
        {
            LabelMessage.ForeColor = Color.DarkGreen;
            TextBox_Course.Text = string.Empty;
            TextBox_Desc.Text = string.Empty;
            DropDownList1.SelectedIndex = 0;
            Button_Add.Enabled = true;
            Button_Delete.Enabled = false;
            Button_Update.Enabled = false;
        }

        #endregion

        BusinessLogic db = new BusinessLogic();

        protected void Button_Add_Click(object sender, System.EventArgs e)
        {
            try
            {
                int Result_Insert = db.Add_Course(TextBox_Course.Text.Trim(), DropDownList1.SelectedItem.Text.Trim(), TextBox_Desc.Text.Trim());
                Message(Result_Insert);
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Course Name Exists!!')</script>");
            }
        }

        protected void Button_Delete_Click(object sender, System.EventArgs e)
        {
            try
            {
                int result = db.Delete_Course(TextBox_Course.Text);
                Message(result);
            }
            catch
            {

            }
        }

        private void Message(int result)
        {
            if (result > 0)
            {
                LabelMessage.ForeColor = Color.DarkGreen;
                LabelMessage.Text = "Successfull";
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Successfull')</script>");
                InitControls();
            }
            else
            {
                LabelMessage.ForeColor = Color.Red;
                LabelMessage.Text = "Failed";
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Failed')</script>");
                InitControls();
            }
        }

        protected void Button_Update_Click(object sender, System.EventArgs e)
        {
            try
            {
                int result = db.UpdateCourse(TextBox_Course.Text, DropDownList1.SelectedItem.Text, TextBox_Desc.Text, ViewState["ocname"].ToString());
                Message(result);
            }
            catch
            {

            }
        }

    }
}