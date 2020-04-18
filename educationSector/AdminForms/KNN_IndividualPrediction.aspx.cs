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
    public partial class KNN_IndividualPrediction : System.Web.UI.Page
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

                    KNNAlgorithm();
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
               
        ArrayList output = new ArrayList();
        ArrayList mul = new ArrayList();
               
        private void KNNAlgorithm()
        {
            BLL obj = new BLL();
            BusinessLogic obj1 = new BusinessLogic();

            ArrayList _Distance = new ArrayList();
            ArrayList _RegNo = new ArrayList();


            string[] attributes = { "Hrs", "Regular", "Interaction", "TimeManagement", "GraspingAbility", "EXActivities", "PrevSemResults", "SSLC", "PUC", "IHS" };


            int[] classify = { DropDownListHrs.SelectedIndex, DropDownListRegular.SelectedIndex, DropDownListInteraction.SelectedIndex,
                             DropDownListTimeMgt.SelectedIndex,DropDownListGraspingAbility.SelectedIndex,DropDownListExActivities.SelectedIndex,
                             DropDownListPrevResults.SelectedIndex,DropDownListSSLC.SelectedIndex,DropDownListPUC.SelectedIndex,
                             DropDownListIHS.SelectedIndex};

            int m = 5;

            //finding the distance between the objects
            for (int i = 0; i < tabDataset.Rows.Count; i++)
            {
                double _val = 0.0;

                for (int j = 0; j < classify.Length; j++)
                {

                    //start identifying the dropdownlist index

                    if (j == 0)
                    {
                        //Hrs
                        string _HrsData = DropDownListHrs.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemHrs = new ListItem(_HrsData, tabDataset.Rows[i][j + 2].ToString());
                        int _indexHrs = DropDownListHrs.Items.IndexOf(_itemHrs);

                        _val += Math.Pow(double.Parse(_indexHrs.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    if (j == 1)
                    {
                        //regular
                        string _RegularData = DropDownListRegular.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemRegular = new ListItem(_RegularData, tabDataset.Rows[i][j + 2].ToString());
                        int _indexRegular = DropDownListRegular.Items.IndexOf(_itemRegular);

                        _val += Math.Pow(double.Parse(_indexRegular.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    if (j == 2)
                    {
                        //Interaction
                        string _InterationData = DropDownListInteraction.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemInteraction = new ListItem(_InterationData, tabDataset.Rows[i][j + 2].ToString());
                        int _indexInteraction = DropDownListInteraction.Items.IndexOf(_itemInteraction);

                        _val += Math.Pow(double.Parse(_indexInteraction.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    if (j == 3)
                    {
                        //time management
                        string _TimeData = DropDownListTimeMgt.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemTimeManagement = new ListItem(_TimeData, tabDataset.Rows[i][j + 2].ToString());
                        int _indexTimeManagement = DropDownListTimeMgt.Items.IndexOf(_itemTimeManagement);

                        _val += Math.Pow(double.Parse(_indexTimeManagement.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    if (j == 4)
                    {
                        //GraspingAbility
                        string _dataTextGraspingAbility = DropDownListGraspingAbility.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemGraspingAbility = new ListItem(_dataTextGraspingAbility, tabDataset.Rows[i][j + 2].ToString());
                        int _indexGraspingAbility = DropDownListGraspingAbility.Items.IndexOf(_itemGraspingAbility);

                        _val += Math.Pow(double.Parse(_indexGraspingAbility.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    if (j == 5)
                    {
                        //EXActivities
                        string _ExActivitiesData = DropDownListExActivities.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemEXActivities = new ListItem(_ExActivitiesData, tabDataset.Rows[i][j + 2].ToString());
                        int _indexEXActivities = DropDownListExActivities.Items.IndexOf(_itemEXActivities);

                        _val += Math.Pow(double.Parse(_indexEXActivities.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    if (j == 6)
                    {
                        //Prev Results
                        string _dataTextPrev = DropDownListPrevResults.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemPrevSemResults = new ListItem(_dataTextPrev, tabDataset.Rows[i][j + 2].ToString());
                        int _indexPrevSemResults = DropDownListPrevResults.Items.IndexOf(_itemPrevSemResults);

                        _val += Math.Pow(double.Parse(_indexPrevSemResults.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    if (j == 7)
                    {
                        //SSLC
                        string _dataTextSSLC = DropDownListSSLC.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemSSLC = new ListItem(_dataTextSSLC, tabDataset.Rows[i][j + 2].ToString());
                        int _indexSSLC = DropDownListSSLC.Items.IndexOf(_itemSSLC);

                        _val += Math.Pow(double.Parse(_indexSSLC.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    if (j == 8)
                    {
                        //PUC
                        string _dataTextPUC = DropDownListPUC.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemPUC = new ListItem(_dataTextPUC, tabDataset.Rows[i][j + 2].ToString());
                        int _indexPUC = DropDownListPUC.Items.IndexOf(_itemPUC);

                        _val += Math.Pow(double.Parse(_indexPUC.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    if (j == 9)
                    {
                        //IHS
                        string _dataIHS = DropDownListIHS.Items.FindByValue(tabDataset.Rows[i][j + 2].ToString()).ToString();

                        ListItem _itemIHS = new ListItem(_dataIHS, tabDataset.Rows[i][j + 2].ToString());
                        int _indexIHS = DropDownListIHS.Items.IndexOf(_itemIHS);

                        _val += Math.Pow(double.Parse(_indexIHS.ToString()) - double.Parse(classify[j].ToString()), 2);
                    }

                    //end                                       
                }

                _val = Math.Sqrt(_val);

                _Distance.Add(Math.Round(_val, 1));
                _RegNo.Add(tabDataset.Rows[i]["RegNo"].ToString());
            }

            ArrayList temp = new ArrayList();
            ArrayList arrayRegno = new ArrayList();

            ArrayList arrayExists = new ArrayList();
            int d = 0;

            for (int x = 0; x < _Distance.Count; x++)
            {
                temp.Add(_Distance[x]);
            }

            temp.Sort();

            for (int y = 0; y < m; y++)
            {
                d = 0;

                for (int z = 0; z < _Distance.Count; z++)
                {
                    if (_Distance[z].Equals(temp[y]))
                    {
                        if (d == 0 && !arrayExists.Contains(_RegNo[z]))
                        {
                            arrayRegno.Add(_RegNo[z]);

                            arrayExists.Add(_RegNo[z]);

                            ++d;

                        }
                    }
                }
            }

            if (arrayRegno.Count > 0)
            {
                int cnt;

                ArrayList arrayCnt = new ArrayList();
                ArrayList arrayOutcome = new ArrayList();

                DataTable tabOutcome = new DataTable();
                tabOutcome = obj1.GetDistinctResult(lblCourse.Text);

                for (int i = 0; i < tabOutcome.Rows.Count; i++)
                {
                    cnt = 0;

                    for (int j = 0; j < arrayRegno.Count; j++)
                    {
                        DataTable tabStudentResult = new DataTable();
                        tabStudentResult = obj1.Search_Student(arrayRegno[j].ToString());

                        if (tabStudentResult.Rows[0]["Result"].ToString().Equals(tabOutcome.Rows[i]["Result"].ToString()))
                        {
                            ++cnt;
                        }
                    }

                    arrayCnt.Add(cnt);
                    arrayOutcome.Add(tabOutcome.Rows[i]["Result"].ToString());
                }

                ArrayList temp1 = new ArrayList();

                for (int x = 0; x < arrayCnt.Count; x++)
                {
                    temp1.Add(arrayCnt[x]);
                }

                temp1.Sort();
                temp1.Reverse();

                for (int y = 0; y < arrayCnt.Count; y++)
                {
                    if (arrayCnt[y].Equals(temp1[0]))
                    {
                        Panel2.Visible = true;

                        lblOutput.Font.Bold = true;
                        lblOutput.ForeColor = System.Drawing.Color.Green;
                        lblOutput.Text = arrayOutcome[y].ToString();

                        lblName.Text = txtName.Text;
                        lblCName.Text = lblCourse.Text;

                        if (arrayOutcome[y].Equals("Bad"))
                        {
                            lblRecc.Text = "Poor result. Should give more time for studies. Should be regular to class. Should give more visits to library and go through technical books. Should improve interaction with faculties. Should improve grasping ability, decision making. Should be punctual to class. Faculties should give more guidance to improve the performance in coming semester.";
                        }
                        else if (arrayOutcome[y].Equals("Average"))
                        {
                            lblRecc.Text = "Average result. Should give more time for studies. Should be regular to class. Should give more visits to library and go through technical books. Should improve time management and grasping ability. Should be punctual to class. Faculties should give more guidance to improve the performance in coming semester.";
                        }
                        else if (arrayOutcome[y].Equals("Good"))
                        {
                            lblRecc.Text = "Good work. Should give more time for studies. Should give more visits to library and go through technical books. Should improve interaction, stress management and decision making skills. Should be punctual to improve the performance in coming semester.";
                        }
                        else
                        {
                            lblRecc.Text = "Outstanding work. Should keep up the good work.";
                        }

                        return;
                    }
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