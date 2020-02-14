using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace educationSector
{
    public partial class frmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    //adding items into the dropdown list
                    ListItem itemAdmin = new ListItem("Admin", "admin");
                    ListItem itemStudent = new ListItem("Student", "Student");

                    DropDown_Type.Items.Add(itemAdmin);
                    DropDown_Type.Items.Add(itemStudent);

                    DropDown_Type.SelectedIndex = 0;
                    InitValidationControls();
                }
            }
            catch
            {

            }
        }

        //event to check the admin or student login
        protected void Button_Login_Click(object sender, System.EventArgs e)
        {
            try
            {
                BusinessLogic db = new BusinessLogic();
                DataTable tabUser = new DataTable();

                if (DropDown_Type.SelectedIndex != -1)
                {
                    if (DropDown_Type.SelectedIndex == 0)
                    {
                        tabUser = db.CheckLogin(Txt_User.Text.Trim(), Txt_Password.Text.Trim(), "admin");

                        if (tabUser.Rows.Count > 0)
                        {
                            MaintainState(Txt_User.Text.Trim());
                            Response.Redirect("~/AdminForms/frmAdminHome.aspx");
                        }
                        else
                        {
                            LabelError.Text = "*Invalid username/password";
                        }
                    }
                    else
                    {
                        tabUser = db.CheckLogin(Txt_User.Text.Trim(), Txt_Password.Text.Trim(), "student");

                        if (tabUser.Rows.Count > 0)
                        {
                            Session["RegNo"] = tabUser.Rows[0]["RegNo"].ToString();
                            MaintainState(Txt_User.Text.Trim());
                            Response.Redirect("~/StudentForms/frmStudentHome.aspx");
                        }
                        else
                        {
                            LabelError.Text = "*Invalid username/password";
                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void MaintainState(string username)
        {
            if (username != null)
            {
                Session["username"] = username;
            }
        }

        private void InitControls()
        {
            Txt_User.Text = string.Empty;
            Txt_Password.Text = string.Empty;
            LabelError.Text = string.Empty;
        }

        private void InitValidationControls()
        {
            RequiredFieldValidator1.Text = "*";
            RequiredFieldValidator1.ControlToValidate = "Txt_User";
            RequiredFieldValidator2.Text = "*";
            RequiredFieldValidator2.ControlToValidate = "Txt_Password";
        }

    }
}