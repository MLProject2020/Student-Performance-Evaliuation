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
using System.Data.Sql;
using System.Data.SqlClient;


namespace educationSector
{
    public partial class frmUpdateStudents : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlCommand cmd = null;

        BusinessLogic db = new BusinessLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"] != null)
                {
                    if (!IsPostBack)
                    {
                        Courses();
                        sems();
                        if (Request.QueryString["regno"] != null)
                        {
                            string regno = Request.QueryString["regno"].Trim();
                            TextBox_Search.Text = regno;
                            LoadStudent_Info(regno);
                        }

                        EnablePanel(true);

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

        private void Courses()
        {
            DataTable Tab_Courses = db.View_Courses();
            if (Tab_Courses.Rows.Count != 0)
            {
                DropDownList_Course.DataTextField = "cname";
                DropDownList_Course.DataSource = Tab_Courses;
                DropDownList_Course.DataBind();
                DropDownList_Course.Items.Insert(0, "-Select-");

            }
        }

        private void sems()
        {
            for (int i = 1; i <= 8; i++)
            {
                DropDownList_Sem.Items.Add(i.ToString());
            }
        }

        private void EnablePanel(bool flag)
        {
            PanelChange.Visible = flag;
            PanelUpdate.Visible = !flag;
        }

        protected void Button2_Click(object sender, System.EventArgs e)
        {
            EnablePanel(true);
        }

        protected void Button3_Click(object sender, System.EventArgs e)
        {
            EnablePanel(false);
        }

        private void LoadStudent_Info(string regno)
        {
            try
            {
                DataTable dt_Info = db.Search_Student(regno);
                if (dt_Info.Rows.Count != 0)
                {
                    DataRow r = dt_Info.Rows[0];
                    
                    TextBox_Name.Text = r["name"].ToString();
                    TextBox_Reg.Text = r["regno"].ToString();
                    TextBox_DOB.Text = r["dob"].ToString();
                    ListItem itemGender = new ListItem(r["gender"].ToString());
                    int IndexGender = DropDownList_Gender.Items.IndexOf(itemGender);

                    if (IndexGender != -1)
                    {
                        DropDownList_Gender.SelectedIndex = IndexGender;
                    }

                    ListItem itemCourse = new ListItem(r["Cname"].ToString());
                    int IndexCourse = DropDownList_Course.Items.IndexOf(itemCourse);
                    if (IndexCourse != -1)
                    {
                        DropDownList_Course.SelectedIndex = IndexCourse;
                    }

                    ListItem itemSem = new ListItem(r["sem"].ToString());
                    int IndexSem = DropDownList_Sem.Items.IndexOf(itemSem);

                    if (IndexSem != -1)
                    {
                        DropDownList_Sem.SelectedIndex = IndexSem;
                    }

                    ListItem itemstatus = new ListItem(r["status"].ToString());
                    int Indexstatus = DropDownListStatus.Items.IndexOf(itemstatus);

                    if (Indexstatus != -1)
                    {
                        DropDownListStatus.SelectedIndex = Indexstatus;
                    }

                    TextBox_Parent.Text = r["pname"].ToString();
                    TextBox_Email.Text = r["email_id"].ToString();
                    TextBox_Mobile.Text = r["mobile"].ToString();
                   // Txtusername.Text = r["uname"].ToString();
                    Txtpassword.Text = r["password"].ToString();
                    txtpStatus.Text = r["Result"].ToString();                    
                }
            }
            catch
            {

            }
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (Txtpassword.Text.Equals(TextBox_OldPwd.Text) == false)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Invalid current password!!!')</script>");

                }
                else if (TextBox_OldPwd.Text.Trim() != "" || TextBox_NewPwd.Text.Trim() != "" || TextBoxConfirm.Text.Trim() != "")
                {
                    int Result = db.ChangePassword1(TextBox_Reg.Text, TextBox_OldPwd.Text.Trim(), TextBox_NewPwd.Text);
                    if (Result > 0)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Password Changed Successfully!!!')</script>");

                        EnablePanel(true);
                    }
                }
            }
            catch
            {

            }
        }

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBox_Search.Text.Trim() != "")
                {
                    if (db.search_regno(TextBox_Search.Text) == 1)

                        LoadStudent_Info(TextBox_Search.Text.Trim());

                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Invalid regno!!!')</script>");
                    }

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Input regno!!!')</script>");
                }
            }
            catch
            {

            }
        }

        protected void btnAttributes_Click(object sender, EventArgs e)
        {
            try
            {
                if (db.search_regno(TextBox_Search.Text) == 1)
                {
                    DataTable tabstudent = new DataTable();
                    BusinessLogic obj = new BusinessLogic();
                    tabstudent = obj.Search_Student(TextBox_Search.Text);

                    Response.Redirect(string.Format("frmStudentAttributes.aspx?Cname={0}&regno={1}", tabstudent.Rows[0]["Cname"].ToString(), TextBox_Search.Text));
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Invalid regno!!!')</script>");
                }
            }
            catch
            {

            }

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int result = db.Update_Student(TextBox_Reg.Text, TextBox_Name.Text, TextBox_DOB.Text, DropDownList_Gender.SelectedItem.Text, DropDownList_Course.SelectedItem.Text, DropDownList_Sem.SelectedItem.Text, TextBox_Parent.Text, TextBox_Email.Text, TextBox_Mobile.Text, DropDownListStatus.SelectedValue, txtpStatus.Text);

                if (result > 0)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Updated successfull!!')</script>");
                    TextBox_Name.Text = "";
                    TextBox_DOB.Text = "";
                    TextBox_Email.Text = "";
                    TextBox_Mobile.Text = "";
                    TextBox_Parent.Text = "";
                    TextBox_Reg.Text = "";
                    TextBox_Search.Text = "";
                    Txtpassword.Text = "";
                    //Txtusername.Text = "";
                    DropDownList_Course.SelectedIndex = 0;
                    DropDownList_Sem.SelectedIndex = 0;

                    LoadStudent_Info(TextBox_Search.Text);                    
                }
                else
                {                   
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Updation Error')</script>");
                }

            }
            catch
            {

            }
        }
       
    }
}