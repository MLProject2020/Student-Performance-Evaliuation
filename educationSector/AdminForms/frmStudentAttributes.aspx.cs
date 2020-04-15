using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace educationSector.AdminForms
{
    public partial class frmStudentAttributes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["username"] != null)
                {
                    if (!this.IsPostBack)
                    {
                        TextBox_Reg.Text = Request.QueryString["regno"].ToString();
                        GetStudentDetails();
                        GetStudentAttributes();
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


        //function to get the student attributes
        private void GetStudentAttributes()
        {
            try
            {
                BusinessLogic obj = new BusinessLogic();
                DataTable tab = new DataTable();

                tab = obj.GetStudentAttributes(Request.QueryString["regno"].ToString());

                if (tab.Rows.Count > 0)
                {
                    btnAttributes.Text = "Update";

                    //Hrs
                    string HrsData = DropDownListHrs.Items.FindByValue(tab.Rows[0]["Hrs"].ToString()).ToString();

                    ListItem itemHrs = new ListItem(HrsData, tab.Rows[0]["Hrs"].ToString());
                    int indexHrs = DropDownListHrs.Items.IndexOf(itemHrs);

                    if (indexHrs != -1)
                    {
                        DropDownListHrs.SelectedIndex = indexHrs;
                    }

                    //regular
                    string RegularData = DropDownListRegular.Items.FindByValue(tab.Rows[0]["Regular"].ToString()).ToString();

                    ListItem itemRegular = new ListItem(RegularData, tab.Rows[0]["Regular"].ToString());
                    int indexRegular = DropDownListRegular.Items.IndexOf(itemRegular);

                    if (indexRegular != -1)
                    {
                        DropDownListRegular.SelectedIndex = indexRegular;
                    }



                    //Interaction
                    string InterationData = DropDownListInteraction.Items.FindByValue(tab.Rows[0]["Interaction"].ToString()).ToString();

                    ListItem itemInteraction = new ListItem(InterationData, tab.Rows[0]["Interaction"].ToString());
                    int indexInteraction = DropDownListInteraction.Items.IndexOf(itemInteraction);

                    if (indexInteraction != -1)
                    {
                        DropDownListInteraction.SelectedIndex = indexInteraction;
                    }

                    //time management

                    string TimeData = DropDownListTimeMgt.Items.FindByValue(tab.Rows[0]["TimeManagement"].ToString()).ToString();

                    ListItem itemTimeManagement = new ListItem(TimeData, tab.Rows[0]["TimeManagement"].ToString());
                    int indexTimeManagement = DropDownListTimeMgt.Items.IndexOf(itemTimeManagement);

                    if (indexTimeManagement != -1)
                    {
                        DropDownListTimeMgt.SelectedIndex = indexTimeManagement;
                    }

                    //GraspingAbility
                    string dataTextGraspingAbility = DropDownListGraspingAbility.Items.FindByValue(tab.Rows[0]["GraspingAbility"].ToString()).ToString();

                    ListItem itemGraspingAbility = new ListItem(dataTextGraspingAbility, tab.Rows[0]["GraspingAbility"].ToString());
                    int indexGraspingAbility = DropDownListGraspingAbility.Items.IndexOf(itemGraspingAbility);

                    if (indexGraspingAbility != -1)
                    {
                        DropDownListGraspingAbility.SelectedIndex = indexGraspingAbility;
                    }

                    //EXActivities
                    string ExActivitiesData = DropDownListExActivities.Items.FindByValue(tab.Rows[0]["EXActivities"].ToString()).ToString();

                    ListItem itemEXActivities = new ListItem(ExActivitiesData, tab.Rows[0]["EXActivities"].ToString());
                    int indexEXActivities = DropDownListExActivities.Items.IndexOf(itemEXActivities);

                    if (indexEXActivities != -1)
                    {
                        DropDownListExActivities.SelectedIndex = indexEXActivities;
                    }

                    //Prev Results
                    string dataTextPrev = DropDownListPrevResults.Items.FindByValue(tab.Rows[0]["PrevSemResults"].ToString()).ToString();

                    ListItem itemPrevSemResults = new ListItem(dataTextPrev, tab.Rows[0]["PrevSemResults"].ToString());
                    int indexPrevSemResults = DropDownListPrevResults.Items.IndexOf(itemPrevSemResults);

                    if (indexPrevSemResults != -1)
                    {
                        DropDownListPrevResults.SelectedIndex = indexPrevSemResults;
                    }

                    //SSLC
                    string dataTextSSLC = DropDownListSSLC.Items.FindByValue(tab.Rows[0]["SSLC"].ToString()).ToString();

                    ListItem itemSSLC = new ListItem(dataTextSSLC, tab.Rows[0]["SSLC"].ToString());
                    int indexSSLC = DropDownListSSLC.Items.IndexOf(itemSSLC);

                    if (indexSSLC != -1)
                    {
                        DropDownListSSLC.SelectedIndex = indexSSLC;
                    }

                    //PUC
                    string dataTextPUC = DropDownListPUC.Items.FindByValue(tab.Rows[0]["PUC"].ToString()).ToString();

                    ListItem itemPUC = new ListItem(dataTextPUC, tab.Rows[0]["PUC"].ToString());
                    int indexPUC = DropDownListPUC.Items.IndexOf(itemPUC);

                    if (indexPUC != -1)
                    {
                        DropDownListPUC.SelectedIndex = indexPUC;
                    }


                    //IHS
                    string dataIHS = DropDownListIHS.Items.FindByValue(tab.Rows[0]["IHS"].ToString()).ToString();

                    ListItem itemIHS = new ListItem(dataIHS, tab.Rows[0]["IHS"].ToString());
                    int indexIHS = DropDownListIHS.Items.IndexOf(itemIHS);

                    if (indexIHS != -1)
                    {
                        DropDownListIHS.SelectedIndex = indexIHS;
                    }
                }
                else
                {
                    btnAttributes.Text = "Upload Parameters";
                }
            }
            catch
            {

            }
        }
        
        //function to get student details
        private void GetStudentDetails()
        {
            try
            {
                BusinessLogic obj = new BusinessLogic();
                DataTable tab = new DataTable();


                tab = obj.Search_Student(Request.QueryString["regno"].ToString());

            }
            catch
            {

            }

        }

        protected void btnAttributes_Click(object sender, EventArgs e)
        {
            try
            {
                int result = 0;
                BusinessLogic obj = new BusinessLogic();

                if (btnAttributes.Text == "Upload Parameters")
                {
                    result = obj.InsertAttributes(TextBox_Reg.Text, DropDownListHrs.SelectedValue, DropDownListRegular.SelectedValue, DropDownListInteraction.SelectedValue, DropDownListTimeMgt.SelectedValue, DropDownListGraspingAbility.SelectedValue,
                     DropDownListExActivities.SelectedValue, DropDownListPrevResults.SelectedValue,
                     DropDownListSSLC.SelectedValue, DropDownListPUC.SelectedValue, DropDownListIHS.SelectedValue);

                    btnAttributes.Text = "Update";

                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Student Parameters Added Successfully!!!')</script>");
                }

                else if (btnAttributes.Text == "Update")
                {
                    result = obj.UpdateAttributes(DropDownListHrs.SelectedValue, DropDownListRegular.SelectedValue, DropDownListInteraction.SelectedValue, DropDownListTimeMgt.SelectedValue, DropDownListGraspingAbility.SelectedValue,
                        DropDownListExActivities.SelectedValue, DropDownListPrevResults.SelectedValue,
                        DropDownListSSLC.SelectedValue, DropDownListPUC.SelectedValue, DropDownListIHS.SelectedValue, TextBox_Reg.Text);

                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Student Parameters Updated Successfully!!!')</script>");
                    btnAttributes.Text = "Update";
                }

            }
            catch
            {

            }

        }       
       
    }
}