using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace educationSector.AdminForms
{
    public partial class frmDataset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsPostBack)

                    LoadCourses();

                Dataset();
            }
            catch
            {

            }
        }

        //function to load courses
        private void LoadCourses()
        {
            BusinessLogic obj = new BusinessLogic();
            DataTable tab = new DataTable();

            tab = obj.View_Courses();

            if (tab.Rows.Count > 0)
            {
                DropDownList_Course.Items.Clear();
                DropDownList_Course.DataSource = tab;
                DropDownList_Course.DataTextField = "Cname";
                DropDownList_Course.DataValueField = "Cname";

                DropDownList_Course.DataBind();

                DropDownList_Course.Items.Insert(0, "- All -");
            }

        }             
        
        protected void btnDataset_Click(object sender, EventArgs e)
        {
            Dataset();
        }

        private void Dataset()
        {
            try
            {

                BLL obj = new BLL();
                DataTable tabOldStudents = new DataTable();

                if (DropDownList_Course.SelectedIndex > 0)
                {
                    tabOldStudents = obj.GetTrainingDatasetwithRegNo(DropDownList_Course.SelectedItem.Text, int.Parse(DropDownList_Sem.SelectedValue));
                }
                else
                {
                    tabOldStudents = obj.GetAllTrainingDataset();
                }

                if (tabOldStudents.Rows.Count > 2)
                {
                    lblDataset.Font.Bold = true;
                    lblDataset.Font.Size = 14;
                    lblDataset.ForeColor = System.Drawing.Color.Green;
                    lblDataset.Text = "Training Data Set Found!!!";

                    // binding form data with dynamic table
                    string featuress = "Hrs,Regular,Interaction,TimeManagement,GraspingAbility,EXActivities,PrevSemResults,SSLC,PUC,IHS";

                    string[] s = featuress.Split(',');
                    int featureCnt = s.Length;

                    tableDataset.Rows.Clear();

                    tableDataset.BorderStyle = BorderStyle.Double;
                    tableDataset.GridLines = GridLines.Both;
                    tableDataset.BorderColor = System.Drawing.Color.SteelBlue;

                    TableRow mainrow = new TableRow();
                    mainrow.Height = 30;
                    mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;
                    mainrow.BackColor = System.Drawing.Color.SteelBlue;

                    //TableCell cellC = new TableCell();
                    //cellC.Text = "<b>CourseName</b>";
                    //mainrow.Controls.Add(cellC);

                    //TableCell cellSem = new TableCell();
                    //cellSem.Text = "<b>Sem</b>";
                    //mainrow.Controls.Add(cellSem);

                    TableCell cellRegNo = new TableCell();
                    cellRegNo.BackColor = System.Drawing.Color.Red;
                    cellRegNo.Text = "<b>RegNo</b>";
                    mainrow.Controls.Add(cellRegNo);

                    for (int j = 0; j < s.Length; j++)
                    {
                        TableCell cell1 = new TableCell();
                        cell1.Text = "<b>" + s[j] + "</b>";
                        mainrow.Controls.Add(cell1);
                    }

                    TableCell cellR = new TableCell();
                    cellR.BackColor = System.Drawing.Color.Green;
                    cellR.Text = "<b>Result</b>";
                    mainrow.Controls.Add(cellR);

                    tableDataset.Controls.Add(mainrow);

                    for (int cnt = 0; cnt < tabOldStudents.Rows.Count; cnt++)
                    {
                        TableRow row = new TableRow();

                        //TableCell cellCName = new TableCell();
                        //cellCName.Text = DropDownList_Course.SelectedItem.Text;
                        //row.Controls.Add(cellCName);

                        //TableCell cellSemester = new TableCell();
                        //cellSemester.Text = DropDownList_Sem.SelectedItem.Text;
                        //row.Controls.Add(cellSemester);

                        TableCell cellStudentRegNo = new TableCell();
                        cellStudentRegNo.Text = tabOldStudents.Rows[cnt]["RegNo"].ToString();
                        row.Controls.Add(cellStudentRegNo);

                        TableCell cellHrs = new TableCell();
                       
                        //getting the student constraints (text information)

                        //Hrs
                        //string HrsData = DropDownListHrs.Items.FindByValue(tabOldStudents.Rows[cnt]["Hrs"].ToString()).ToString();
                        cellHrs.Text = tabOldStudents.Rows[cnt]["Hrs"].ToString();
                        row.Controls.Add(cellHrs);

                        TableCell celLRegular = new TableCell();
                       
                        //regular
                        //string RegularData = DropDownListRegular.Items.FindByValue(tabOldStudents.Rows[cnt]["Regular"].ToString()).ToString();
                        celLRegular.Text = tabOldStudents.Rows[cnt]["Regular"].ToString();
                        row.Controls.Add(celLRegular);

                        TableCell cellInteraction = new TableCell();
                      
                        //Interaction
                        //string InterationData = DropDownListInteraction.Items.FindByValue(tabOldStudents.Rows[cnt]["Interaction"].ToString()).ToString();
                        cellInteraction.Text = tabOldStudents.Rows[cnt]["Interaction"].ToString();
                        row.Controls.Add(cellInteraction);

                        TableCell cellTimeData = new TableCell();
                       
                        //time management
                        //string TimeData = DropDownListTimeMgt.Items.FindByValue(tabOldStudents.Rows[cnt]["TimeManagement"].ToString()).ToString();
                        cellTimeData.Text = tabOldStudents.Rows[cnt]["TimeManagement"].ToString();
                        row.Controls.Add(cellTimeData);

                        TableCell cellGC = new TableCell();
                        
                        //GraspingAbility
                        //string dataTextGraspingAbility = DropDownListGraspingAbility.Items.FindByValue(tabOldStudents.Rows[cnt]["GraspingAbility"].ToString()).ToString();
                        cellGC.Text = tabOldStudents.Rows[cnt]["GraspingAbility"].ToString();
                        row.Controls.Add(cellGC);

                        TableCell cellExActivities = new TableCell();
                       

                        //EXActivities
                        //string ExActivitiesData = DropDownListExActivities.Items.FindByValue(tabOldStudents.Rows[cnt]["EXActivities"].ToString()).ToString();
                        cellExActivities.Text = tabOldStudents.Rows[cnt]["EXActivities"].ToString();
                        row.Controls.Add(cellExActivities);

                        TableCell cellPRev = new TableCell();
                       
                        //Prev Results
                        //string dataTextPrev = DropDownListPrevResults.Items.FindByValue(tabOldStudents.Rows[cnt]["PrevSemResults"].ToString()).ToString();
                        cellPRev.Text = tabOldStudents.Rows[cnt]["PrevSemResults"].ToString();
                        row.Controls.Add(cellPRev);

                        TableCell cellSSLC = new TableCell();
                       
                        //SSLC
                        //string dataTextSSLC = DropDownListSSLC.Items.FindByValue(tabOldStudents.Rows[cnt]["SSLC"].ToString()).ToString();
                        cellSSLC.Text = tabOldStudents.Rows[cnt]["SSLC"].ToString();
                        row.Controls.Add(cellSSLC);

                        TableCell cellPUC = new TableCell();
                       

                        //PUC
                        //string dataTextPUC = DropDownListPUC.Items.FindByValue(tabOldStudents.Rows[cnt]["PUC"].ToString()).ToString();
                        cellPUC.Text = tabOldStudents.Rows[cnt]["PUC"].ToString();
                        row.Controls.Add(cellPUC);

                        TableCell cellIHS = new TableCell();
                       
                        //IHS
                        //string dataIHS = DropDownListIHS.Items.FindByValue(tabOldStudents.Rows[cnt]["IHS"].ToString()).ToString();
                        cellIHS.Text = tabOldStudents.Rows[cnt]["IHS"].ToString();
                        row.Controls.Add(cellIHS);

                        TableCell cellResult = new TableCell();
                       
                        cellResult.Text = tabOldStudents.Rows[cnt]["Result"].ToString();
                        row.Controls.Add(cellResult);


                        tableDataset.Controls.Add(row);
                    }
                }
                else
                {
                    lblDataset.Font.Bold = true;
                    lblDataset.Font.Size = 24;
                    lblDataset.ForeColor = System.Drawing.Color.Red;
                    lblDataset.Text = "Training Dataset Not Found!!!";
                }

            }
            catch
            {

            }
        }

        protected void DropDownList_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCourseSemesters();
        }


        //function to load semesters based on course
        private void LoadCourseSemesters()
        {
            BusinessLogic obj = new BusinessLogic();
            DataTable tab = new DataTable();

            if (DropDownList_Course.SelectedIndex > 0)
            {
                tab = obj.Get_sem(DropDownList_Course.SelectedItem.Text);
                int semcount = int.Parse(tab.Rows[0][0].ToString());

                if (tab != null)
                {
                    DropDownList_Sem.Items.Clear();
                    for (int i = 1; i <= semcount; i++)
                    {
                        DropDownList_Sem.Items.Add(i.ToString());
                    }

                }
            }
            else
            {
                DropDownList_Sem.Items.Clear();
                DropDownList_Sem.DataSource = null;
                DropDownList_Sem.DataBind();
            }
        }     
      
    }
}