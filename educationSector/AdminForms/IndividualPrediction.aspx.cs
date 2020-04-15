using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using System.IO;

namespace educationSector.AdminForms
{
    public partial class IndividualPrediction : System.Web.UI.Page
    {
        static DataTable tabDataset = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
              
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                Panel2.Visible = false;

                BLL obj = new BLL();

                tabDataset.Rows.Clear();
                tabDataset = obj.GetTrainingDatasetwithRegNo(lblCourse.Text, int.Parse(lblSem.Text));

                if (tabDataset.Rows.Count > 0)
                {
                    GetDataset();

                    NaiveBayesAlgorithm();
                }
                else
                {
                    lblDataset.ForeColor = System.Drawing.Color.Red;
                    lblDataset.Text = "Training Dataset Not Found!!!";
                }
            }
            catch
            {

            }

        }

        private void GetDataset()
        {
            BLL obj = new BLL();
            DataTable tabOldStudents = new DataTable();

            tabOldStudents = obj.GetTrainingDatasetwithRegNo(lblCourse.Text, int.Parse(lblSem.Text));

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
                    cellHrs.Width = 150;

                    //getting the student constraints (text information)

                    //Hrs
                    //string HrsData = DropDownListHrs.Items.FindByValue(tabOldStudents.Rows[cnt]["Hrs"].ToString()).ToString();
                    cellHrs.Text = tabOldStudents.Rows[cnt]["Hrs"].ToString();
                    row.Controls.Add(cellHrs);

                    TableCell celLRegular = new TableCell();
                    celLRegular.Width = 150;

                    //regular
                    //string RegularData = DropDownListRegular.Items.FindByValue(tabOldStudents.Rows[cnt]["Regular"].ToString()).ToString();
                    celLRegular.Text = tabOldStudents.Rows[cnt]["Regular"].ToString();
                    row.Controls.Add(celLRegular);

                    TableCell cellInteraction = new TableCell();
                    cellInteraction.Width = 150;

                    //Interaction
                    //string InterationData = DropDownListInteraction.Items.FindByValue(tabOldStudents.Rows[cnt]["Interaction"].ToString()).ToString();
                    cellInteraction.Text = tabOldStudents.Rows[cnt]["Interaction"].ToString();
                    row.Controls.Add(cellInteraction);

                    TableCell cellTimeData = new TableCell();
                    cellTimeData.Width = 150;

                    //time management
                    //string TimeData = DropDownListTimeMgt.Items.FindByValue(tabOldStudents.Rows[cnt]["TimeManagement"].ToString()).ToString();
                    cellTimeData.Text = tabOldStudents.Rows[cnt]["TimeManagement"].ToString();
                    row.Controls.Add(cellTimeData);

                    TableCell cellGC = new TableCell();
                    cellGC.Width = 150;

                    //GraspingAbility
                    //string dataTextGraspingAbility = DropDownListGraspingAbility.Items.FindByValue(tabOldStudents.Rows[cnt]["GraspingAbility"].ToString()).ToString();
                    cellGC.Text = tabOldStudents.Rows[cnt]["GraspingAbility"].ToString();
                    row.Controls.Add(cellGC);

                    TableCell cellExActivities = new TableCell();
                    cellExActivities.Width = 150;

                    //EXActivities
                    //string ExActivitiesData = DropDownListExActivities.Items.FindByValue(tabOldStudents.Rows[cnt]["EXActivities"].ToString()).ToString();
                    cellExActivities.Text = tabOldStudents.Rows[cnt]["EXActivities"].ToString();
                    row.Controls.Add(cellExActivities);

                    TableCell cellPRev = new TableCell();
                    cellPRev.Width = 150;

                    //Prev Results
                    //string dataTextPrev = DropDownListPrevResults.Items.FindByValue(tabOldStudents.Rows[cnt]["PrevSemResults"].ToString()).ToString();
                    cellPRev.Text = tabOldStudents.Rows[cnt]["PrevSemResults"].ToString();
                    row.Controls.Add(cellPRev);

                    TableCell cellSSLC = new TableCell();
                    cellSSLC.Width = 150;

                    //SSLC
                    //string dataTextSSLC = DropDownListSSLC.Items.FindByValue(tabOldStudents.Rows[cnt]["SSLC"].ToString()).ToString();
                    cellSSLC.Text = tabOldStudents.Rows[cnt]["SSLC"].ToString();
                    row.Controls.Add(cellSSLC);

                    TableCell cellPUC = new TableCell();
                    cellPUC.Width = 150;

                    //PUC
                    //string dataTextPUC = DropDownListPUC.Items.FindByValue(tabOldStudents.Rows[cnt]["PUC"].ToString()).ToString();
                    cellPUC.Text = tabOldStudents.Rows[cnt]["PUC"].ToString();
                    row.Controls.Add(cellPUC);

                    TableCell cellIHS = new TableCell();
                    cellIHS.Width = 150;

                    //IHS
                    //string dataIHS = DropDownListIHS.Items.FindByValue(tabOldStudents.Rows[cnt]["IHS"].ToString()).ToString();
                    cellIHS.Text = tabOldStudents.Rows[cnt]["IHS"].ToString();
                    row.Controls.Add(cellIHS);


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

        double pi;
        int nc, n;
        double result;
        ArrayList output = new ArrayList();
        ArrayList mul = new ArrayList();

        //function which contains the navie bayesian steps
        private void NaiveBayesAlgorithm()
        {
            try
            {
                ArrayList s = new ArrayList();

                s = GetSubject(lblCourse.Text);

                int m = 10;
                double p = 0.25;


                string[] attributes = { "Hrs", "Regular", "Interaction", "TimeManagement", "GraspingAbility", "EXActivities", "PrevSemResults", "SSLC", "PUC", "IHS" };

                string[] classify ={DropDownListHrs.SelectedValue, DropDownListRegular.SelectedValue, DropDownListInteraction.SelectedValue, DropDownListTimeMgt.SelectedValue, DropDownListGraspingAbility.SelectedValue, 
                        DropDownListExActivities.SelectedValue, DropDownListPrevResults.SelectedValue, 
                        DropDownListSSLC.SelectedValue, DropDownListPUC.SelectedValue, DropDownListIHS.SelectedValue};

                for (int i = 0; i < s.Count; i++)
                {
                    mul.Clear();

                    for (int j = 0; j < attributes.Length; j++)
                    {
                        n = 0;
                        nc = 0;

                        for (int d = 0; d < tabDataset.Rows.Count; d++)
                        {
                            string _para = tabDataset.Rows[d][j + 2].ToString();
                            string _res = tabDataset.Rows[d][m + 2].ToString();

                            if (tabDataset.Rows[d][j + 2].ToString().Equals(classify[j]))
                            {
                                ++n;

                                if (tabDataset.Rows[d][m + 2].ToString().Equals(s[i]))

                                    ++nc;
                            }
                        }

                        double x = m * p;
                        double y = n + m;
                        double z = nc + x;

                        pi = z / y;
                        mul.Add(Math.Abs(pi));
                    }

                    double mulres = 1.0;

                    for (int z = 0; z < mul.Count; z++)
                    {
                        mulres *= double.Parse(mul[z].ToString());

                    }

                    result = mulres * p;
                    output.Add(Math.Abs(result));

                }

                DisplayOutput(s);
            }
            catch
            {

            }

        }

        //function to display the output
        private void DisplayOutput(ArrayList s)
        {
            ArrayList list1 = new ArrayList();

            for (int x = 0; x < s.Count; x++)
            {
                list1.Add(output[x]);
            }

            list1.Sort();
            list1.Reverse();

            for (int y = 0; y < s.Count; y++)
            {
                if (output[y].Equals(list1[0]))
                {
                    Panel2.Visible = true;

                    lblOutput.Font.Bold = true;
                    lblOutput.ForeColor = System.Drawing.Color.Green;
                    lblOutput.Text = s[y].ToString();

                    lblName.Text = txtName.Text;
                    lblCName.Text = lblCourse.Text;

                    return;
                }
            }


        }

        //function to get the subjects(course names/subject names)
        public ArrayList GetSubject(string courseName)
        {
            ArrayList sub = new ArrayList();
            DataTable tab = new DataTable();
            BusinessLogic obj = new BusinessLogic();

            tab = obj.GetDistinctResult(courseName);

            if (tab.Rows.Count > 0)
            {
                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    string subeject = tab.Rows[i]["Result"].ToString();

                    if (subeject.Equals(""))
                    {

                    }
                    else
                    {
                        sub.Add(tab.Rows[i]["Result"].ToString());
                    }
                }
            }

            return sub;
        }
               
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            BusinessLogic obj = new BusinessLogic();
            DataTable tab = new DataTable();

            tab = obj.Search_Student(TextBox_Reg.Text);

            if (tab.Rows.Count != 0)
            {
                Panel2.Visible = false;
                btnCheck.Enabled = true;
                
                txtName.Text = tab.Rows[0]["Name"].ToString();
                lblCourse.Text = tab.Rows[0]["CName"].ToString();
                lblSem.Text = tab.Rows[0]["Sem"].ToString();

                GetStudentAttributes();
            }
            else
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                btnCheck.Enabled = false;

                txtName.Text = lblCourse.Text = lblSem.Text = string.Empty;
                DropDownListExActivities.SelectedIndex = DropDownListGraspingAbility.SelectedIndex = DropDownListHrs.SelectedIndex =
                    DropDownListIHS.SelectedIndex = DropDownListInteraction.SelectedIndex = DropDownListPrevResults.SelectedIndex = DropDownListPUC.SelectedIndex =
                    DropDownListRegular.SelectedIndex = DropDownListSSLC.SelectedIndex = DropDownListTimeMgt.SelectedIndex = 0;

                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Student Doesnt Exists!!!')</script>");
            }
        }

        //function to get the student attributes
        private void GetStudentAttributes()
        {
            try
            {
                BusinessLogic obj = new BusinessLogic();
                DataTable tab = new DataTable();

                tab = obj.GetStudentAttributes(TextBox_Reg.Text);

                if (tab.Rows.Count > 0)
                {                   
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
                    ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Student Parameters Not Updated!!!')</script>");
                }
            }
            catch
            {

            }
        }
        
    }
}