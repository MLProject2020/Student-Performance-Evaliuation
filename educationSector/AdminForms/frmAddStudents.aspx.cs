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
using System.Data.SqlClient;
using System.Data.Sql;

namespace educationSector
{
    public partial class frmAddStudents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"] != null)
                {                   
                    if (!this.IsPostBack)
                    {
                        DropDownList_Gender.SelectedIndex = 0;
                        Courses();
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

        private void Courses()
        {
            try
            {
                DataTable Tab_Courses = db.View_Courses();
                if (Tab_Courses.Rows.Count != 0)
                {
                    ddlCourses.DataTextField = "cname";
                    ddlCourses.DataSource = Tab_Courses;
                    ddlCourses.DataBind();
                    ddlCourses.Items.Insert(0, "-Select-");
                }
            }
            catch
            {

            }
        }
             
       
        protected void btnReggggg_Click(object sender, EventArgs e)
        {
            try
            {
                string RegNo = TextBox_Reg.Text.Trim();
                string name = TextBox_Name.Text.Trim();
                string dob = dropdownlistDay.SelectedValue + "/" + dropdownlistMonth.SelectedValue + "/" + dropdownlistYear.SelectedValue;
                string gender = DropDownList_Gender.SelectedItem.Text;
                string course = ddlCourses.SelectedItem.Text;
                string sem = DropDownList_Sem.SelectedItem.Text;
                string pname = TextBox_Parent.Text.Trim();
                
                string email_id = TextBox_Email.Text.Trim();
                string pwd = TextBox_Password.Text.Trim();
                string mobile = TextBox_Mobile.Text.Trim();
                                
                if (db.CheckRegNo(TextBox_Reg.Text))
                {
                    if (ddlStatus.SelectedIndex > 0)
                    {
                        //old student
                        int Result = db.Register_Student(RegNo, name, dob, gender, course, sem, pname, pwd, mobile, email_id, ddlStatus.SelectedValue, ddlPStatus.SelectedItem.Text);
                       
                        if (Result > 0)
                        {                            
                            Response.Redirect(string.Format("frmStudentAttributes.aspx?regno={0}&Cname={1}", RegNo, course));
                        }
                        else
                        {
                            lblMsg.Text = "Falied to Register!!";
                            ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Falied to Register!!!')</script>");
                        }
                    }
                    else
                    {
                        //new student
                        int Result = db.Register_Student(RegNo, name, dob, gender, course, sem, pname, pwd, mobile, email_id, ddlStatus.SelectedValue, null);

                        if (Result > 0)
                        {
                            
                            Response.Redirect(string.Format("frmStudentAttributes.aspx?regno={0}&Cname={1}", RegNo, course));
                        }
                        else
                        {
                            lblMsg.Text = "Falied to Register!!";
                            ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Falied to Register!!!')</script>");
                        }
                    }

                    
                }
                else
                {
                    lblMsg.Text = "RegNo already Exists Falied to Register!!!";
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('RegNo already Exists Falied to Register!!!')</script>");
                }

            }
            catch
            {

            }
        }

        protected void ddlCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_sem = db.Get_sem(ddlCourses.SelectedItem.Text);
                int semcount = int.Parse(dt_sem.Rows[0][0].ToString());

                if (dt_sem != null)
                {
                    DropDownList_Sem.Items.Clear();
                    for (int i = 1; i <= semcount; i++)
                    {
                        DropDownList_Sem.Items.Add(i.ToString());
                    }

                }
            }
            catch
            {

            }
        }

       
              

    }
}