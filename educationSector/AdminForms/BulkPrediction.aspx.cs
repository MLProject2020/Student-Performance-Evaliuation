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
    public partial class BulkPrediction : System.Web.UI.Page
    {
        static ArrayList _arrayRegNo = new ArrayList();
        static string _currentStud = null;
        static DataTable tabDataset = new DataTable();
        static ArrayList _arrayName = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsPostBack)

                    LoadCourses();
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

                DropDownList_Course.Items.Insert(0, "- Select -");
            }

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

        //current students (testing dataset)
        protected void ButtonView_Click(object sender, EventArgs e)
        {
            try
            {
                BLL obj = new BLL();
                DataTable tabTrainingSet = new DataTable();

                tabTrainingSet = obj.GetTestingDataset(DropDownList_Course.SelectedItem.Text, int.Parse(DropDownList_Sem.SelectedValue));

                if (tabTrainingSet.Rows.Count > 0)
                {                    
                    lblMsg.Font.Bold = true;
                    lblMsg.Font.Size = 14;
                    lblMsg.ForeColor = System.Drawing.Color.Green;
                    lblMsg.Text = "Testing Dataset Found!!!";

                    panelImport.Visible = true;

                    // binding form data with dynamic table
                    string featuress = "Hrs,Regular,Interaction,TimeManagement,GraspingAbility,EXActivities,PrevSemResults,SSLC,PUC,IHS";

                    string[] s = featuress.Split(',');
                    int featureCnt = s.Length;

                    tableTraining.Rows.Clear();

                    tableTraining.BorderStyle = BorderStyle.Double;
                    tableTraining.GridLines = GridLines.Both;
                    tableTraining.BorderColor = System.Drawing.Color.SteelBlue;

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

                    TableCell cellC = new TableCell();
                    cellC.Text = "<b>Name</b>";
                    mainrow.Controls.Add(cellC);

                    for (int j = 0; j < s.Length; j++)
                    {
                        TableCell cell1 = new TableCell();
                        cell1.Text = "<b>" + s[j] + "</b>";
                        mainrow.Controls.Add(cell1);
                    }

                    TableCell cellR = new TableCell();
                    cellR.BackColor = System.Drawing.Color.Green;
                    cellR.Text = "<b>Res</b>";
                    mainrow.Controls.Add(cellR);

                    tableTraining.Controls.Add(mainrow);

                    for (int cnt = 0; cnt < tabTrainingSet.Rows.Count; cnt++)
                    {
                        TableRow row = new TableRow();

                        //TableCell cellCName = new TableCell();
                        //cellCName.Text = DropDownList_Course.SelectedItem.Text;
                        //row.Controls.Add(cellCName);

                        //TableCell cellSemester = new TableCell();
                        //cellSemester.Text = DropDownList_Sem.SelectedItem.Text;
                        //row.Controls.Add(cellSemester);

                        TableCell cellStudentRegNo = new TableCell();
                        cellStudentRegNo.Text = tabTrainingSet.Rows[cnt]["RegNo"].ToString();
                        row.Controls.Add(cellStudentRegNo);

                        TableCell cellName = new TableCell();
                        cellName.Text = tabTrainingSet.Rows[cnt]["Name"].ToString();
                        row.Controls.Add(cellName);


                        TableCell cellHrs = new TableCell();
                       
                        //getting the student constraints (text information)

                        //Hrs
                        //string HrsData = DropDownListHrs.Items.FindByValue(tabTrainingSet.Rows[cnt]["Hrs"].ToString()).ToString();
                        cellHrs.Text = tabTrainingSet.Rows[cnt]["Hrs"].ToString();
                        row.Controls.Add(cellHrs);

                        TableCell celLRegular = new TableCell();
                       
                        //regular
                        //string RegularData = DropDownListRegular.Items.FindByValue(tabTrainingSet.Rows[cnt]["Regular"].ToString()).ToString();
                        celLRegular.Text = tabTrainingSet.Rows[cnt]["Regular"].ToString();
                        row.Controls.Add(celLRegular);

                        TableCell cellInteraction = new TableCell();
                       
                        //Interaction
                        //string InterationData = DropDownListInteraction.Items.FindByValue(tabTrainingSet.Rows[cnt]["Interaction"].ToString()).ToString();
                        cellInteraction.Text = tabTrainingSet.Rows[cnt]["Interaction"].ToString();
                        row.Controls.Add(cellInteraction);

                        TableCell cellTimeData = new TableCell();
                       
                        //time management
                        //string TimeData = DropDownListTimeMgt.Items.FindByValue(tabTrainingSet.Rows[cnt]["TimeManagement"].ToString()).ToString();
                        cellTimeData.Text = tabTrainingSet.Rows[cnt]["TimeManagement"].ToString();
                        row.Controls.Add(cellTimeData);

                        TableCell cellGC = new TableCell();
                       
                        //GraspingAbility
                        //string dataTextGraspingAbility = DropDownListGraspingAbility.Items.FindByValue(tabTrainingSet.Rows[cnt]["GraspingAbility"].ToString()).ToString();
                        cellGC.Text = tabTrainingSet.Rows[cnt]["GraspingAbility"].ToString();
                        row.Controls.Add(cellGC);

                        TableCell cellExActivities = new TableCell();
                       
                        //EXActivities
                        //string ExActivitiesData = DropDownListExActivities.Items.FindByValue(tabTrainingSet.Rows[cnt]["EXActivities"].ToString()).ToString();
                        cellExActivities.Text = tabTrainingSet.Rows[cnt]["EXActivities"].ToString();
                        row.Controls.Add(cellExActivities);

                        TableCell cellPRev = new TableCell();
                        
                        //Prev Results
                        //string dataTextPrev = DropDownListPrevResults.Items.FindByValue(tabTrainingSet.Rows[cnt]["PrevSemResults"].ToString()).ToString();
                        cellPRev.Text = tabTrainingSet.Rows[cnt]["PrevSemResults"].ToString();
                        row.Controls.Add(cellPRev);

                        TableCell cellSSLC = new TableCell();
                        
                        //SSLC
                        //string dataTextSSLC = DropDownListSSLC.Items.FindByValue(tabTrainingSet.Rows[cnt]["SSLC"].ToString()).ToString();
                        cellSSLC.Text = tabTrainingSet.Rows[cnt]["SSLC"].ToString();
                        row.Controls.Add(cellSSLC);

                        TableCell cellPUC = new TableCell();
                       
                        //PUC
                        //string dataTextPUC = DropDownListPUC.Items.FindByValue(tabTrainingSet.Rows[cnt]["PUC"].ToString()).ToString();
                        cellPUC.Text = tabTrainingSet.Rows[cnt]["PUC"].ToString();
                        row.Controls.Add(cellPUC);

                        TableCell cellIHS = new TableCell();
                        
                        //IHS
                        //string dataIHS = DropDownListIHS.Items.FindByValue(tabTrainingSet.Rows[cnt]["IHS"].ToString()).ToString();
                        cellIHS.Text = tabTrainingSet.Rows[cnt]["IHS"].ToString();
                        row.Controls.Add(cellIHS);

                        TableCell cellResult = new TableCell();

                        cellResult.Text = "?";
                        row.Controls.Add(cellResult);

                       
                        tableTraining.Controls.Add(row);

                    }
                }
                else
                {
                    lblMsg.ForeColor = System.Drawing.Color.Red;
                    lblMsg.Text = "Testing Dataset Not Found!!!";

                    panelImport.Visible = false;
                }
            }
            catch
            {

            }
        }

        //training dataset
        protected void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                Panel1.Visible = true;

                ButtonView_Click(sender, e);

                GetDataset();
            }
            // need to catch possible exceptions
            catch (Exception ex)
            {
                //lblError.Text = ex.ToString();
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Input not in a Correct Format!!!')</script>");
            }

        }

        private void GetDataset()
        {
            BLL obj = new BLL();
            DataTable tabOldStudents = new DataTable();

            tabOldStudents = obj.GetTrainingDatasetwithRegNo(DropDownList_Course.SelectedItem.Text, int.Parse(DropDownList_Sem.SelectedValue));

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

        protected void DropDownList_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Panel1.Visible = false;
                Panel2.Visible = false;
                Panel5.Visible = false;
                panelImport.Visible = false;

                LoadCourseSemesters();
            }
            catch
            {

            }
        }

        string _timeNB = null;

        //predict placement status        
        protected void btnResult_Click(object sender, EventArgs e)
        {
            ButtonView_Click(sender, e);
            Panel1.Visible = false;

            //btnView_Click(sender, e);
                        
            BLL obj = new BLL();
            BusinessLogic db = new BusinessLogic();

            DataTable tabTesting = new DataTable();
            tabTesting = obj.GetTestingDataset(DropDownList_Course.SelectedItem.Text, int.Parse(DropDownList_Sem.SelectedItem.Text));

            if (tabTesting.Rows.Count > 0)
            {
                _arrayRegNo.Clear();
                _arrayResult.Clear();
                _arrayName.Clear();

                var watch = System.Diagnostics.Stopwatch.StartNew();

                for (int _cnt = 0; _cnt < tabTesting.Rows.Count; _cnt++)
                {
                    _currentStud = null;

                    tabDataset.Rows.Clear();
                    tabDataset = obj.GetTrainingDatasetwithRegNo(DropDownList_Course.SelectedItem.Text, int.Parse(DropDownList_Sem.SelectedValue));

                    _currentStud = tabTesting.Rows[_cnt]["Regno"].ToString();

                    if (tabDataset.Rows.Count > 0)
                    {
                        Panel5.Visible = true;

                        _arrayRegNo.Add(tabTesting.Rows[_cnt]["Regno"].ToString());
                        _arrayName.Add(tabTesting.Rows[_cnt]["Name"].ToString());

                        NB();

                    }
                    else
                    {
                        Panel5.Visible = false;
                        ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Training Dataset Not Found!!!')</script>");
                    }
                }

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                _timeNB = elapsedMs.ToString();


                Results();
                ResultAnaly();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "key", "<script>alert('Testing Dataset Not Found!!!')</script>");
            }
        }

        private void Results()
        {
            if (_arrayRegNo.Count > 0 && _arrayResult.Count > 0)
            {
                tablePrediction.Rows.Clear();

                tablePrediction.BorderStyle = BorderStyle.Double;
                tablePrediction.GridLines = GridLines.Both;
                tablePrediction.BorderColor = System.Drawing.Color.SteelBlue;

                TableRow mainrow = new TableRow();
                mainrow.Height = 30;
                mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;
                mainrow.BackColor = System.Drawing.Color.SteelBlue;

                TableCell cellC = new TableCell();
                cellC.Text = "<b>RegNo</b>";
                mainrow.Controls.Add(cellC);

                TableCell cellCname = new TableCell();
                cellCname.Text = "<b>Name</b>";
                mainrow.Controls.Add(cellCname);

                TableCell cellB = new TableCell();
                cellB.Text = "<b>Result</b>";
                mainrow.Controls.Add(cellB);

                tablePrediction.Controls.Add(mainrow);

                for (int cnt = 0; cnt < _arrayResult.Count; cnt++)
                {
                    TableRow row = new TableRow();

                    TableCell cellRegno = new TableCell();
                    cellRegno.Width = 250;
                    cellRegno.Text = _arrayRegNo[cnt].ToString();
                    row.Controls.Add(cellRegno);

                    TableCell cellName = new TableCell();
                    cellName.Width = 250;
                    cellName.Text = _arrayName[cnt].ToString();
                    row.Controls.Add(cellName);

                    TableCell cellStatus = new TableCell();
                    cellStatus.Width = 250;
                    cellStatus.Text = _arrayResult[cnt].ToString();
                    row.Controls.Add(cellStatus);

                    tablePrediction.Controls.Add(row);
                }
            }
        }

        double _outcomeCntNB = 0;

        private void ResultAnaly()
        {
            BLL obj = new BLL();
            DataTable tabActual = new DataTable();
            tabActual = obj.GetActualData(DropDownList_Course.SelectedItem.Text, int.Parse(DropDownList_Sem.SelectedItem.Text));

            if (tabActual.Rows.Count > 0)
            {
                for (int i = 0; i < tabActual.Rows.Count; i++)
                {
                    if (tabActual.Rows[i]["Result"].ToString().Equals(_arrayResult[i].ToString()))
                    {
                        ++_outcomeCntNB;
                    }
                }

                tableResults.Rows.Clear();

                tableResults.BorderStyle = BorderStyle.Double;
                tableResults.GridLines = GridLines.Both;
                tableResults.BorderColor = System.Drawing.Color.SteelBlue;

                TableRow mainrow = new TableRow();
                mainrow.Height = 30;
                mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;
                mainrow.BackColor = System.Drawing.Color.SteelBlue;

                TableCell cellC = new TableCell();
                cellC.Text = "<b>Naive Bayes</b>";
                mainrow.Controls.Add(cellC);

                TableCell cellB = new TableCell();
                cellB.Text = "<b>Constraint</b>";
                mainrow.Controls.Add(cellB);

                tableResults.Controls.Add(mainrow);

                //1st row
                TableRow row1 = new TableRow();

                TableCell cellAcc = new TableCell();
                cellAcc.Text = "<b>Accuracy</b>";
                row1.Controls.Add(cellAcc);

                TableCell cellAccNB = new TableCell();
                //cal
                double _percentageNB = (_outcomeCntNB / tabActual.Rows.Count) * 100;
                cellAccNB.Text = _percentageNB.ToString() + "%";
                row1.Controls.Add(cellAccNB);

                tableResults.Controls.Add(row1);

                //2nd row           
                TableRow row2 = new TableRow();

                TableCell cellTime = new TableCell();
                cellTime.Text = "<b>Time (milli secs)</b>";
                row2.Controls.Add(cellTime);

                TableCell cellTimeNB = new TableCell();
                cellTimeNB.Text = _timeNB;
                row2.Controls.Add(cellTimeNB);

                tableResults.Controls.Add(row2);

                //3rd row           
                TableRow row3 = new TableRow();

                TableCell cellCorrect = new TableCell();
                cellCorrect.Text = "<b>Correctly Classified</b>";
                row3.Controls.Add(cellCorrect);

                TableCell cellCorrectNB = new TableCell();
                cellCorrectNB.Text = _percentageNB.ToString() + "%";
                row3.Controls.Add(cellCorrectNB);

                tableResults.Controls.Add(row3);

                //4th row           
                TableRow row4 = new TableRow();

                TableCell cellInCorrect = new TableCell();
                cellInCorrect.Text = "<b>InCorrectly Classified</b>";
                row4.Controls.Add(cellInCorrect);

                TableCell cellInCorrectNB = new TableCell();
                cellInCorrectNB.Text = (100 - _percentageNB).ToString() + "%";
                row4.Controls.Add(cellInCorrectNB);

                tableResults.Controls.Add(row4);
            }
        }               

        #region -- Naive Bayes ----

        double pi;
        int nc, n;
        double result;
        ArrayList output = new ArrayList();
        ArrayList mul = new ArrayList();

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

        static ArrayList _arrayResult = new ArrayList();

        //function to get the student cluster and Algorithmsteps
        private void NB()
        {
            output.Clear();

            BLL obj = new BLL();
            BusinessLogic obj1 = new BusinessLogic();
            
            if (tabDataset.Rows.Count > 0)
            {
                try
                {
                    ArrayList s = new ArrayList();

                    s = GetSubject(DropDownList_Course.SelectedValue);

                    int m = 10;
                    double p = 0.25;

                    string[] attributes = { "Hrs", "Regular", "Interaction", "TimeManagement", "GraspingAbility", "EXActivities", "PrevSemResults", "SSLC", "PUC", "IHS" };

                    DataTable tabStud = new DataTable();
                    tabStud = obj1.GetStudentAttributes(_currentStud);

                    string[] classify ={tabStud.Rows[0]["Hrs"].ToString(),
            tabStud.Rows[0]["Regular"].ToString(),
            tabStud.Rows[0]["Interaction"].ToString(),
           tabStud.Rows[0]["TimeManagement"].ToString(),
           tabStud.Rows[0]["GraspingAbility"].ToString(),
          tabStud.Rows[0]["EXActivities"].ToString(),
           tabStud.Rows[0]["PrevSemResults"].ToString(),
           tabStud.Rows[0]["SSLC"].ToString(),
          tabStud.Rows[0]["PUC"].ToString(),
          tabStud.Rows[0]["IHS"].ToString()};

                    for (int i = 0; i < s.Count; i++)
                    {
                        mul.Clear();

                        for (int j = 0; j < attributes.Length; j++)
                        {
                            n = 0;
                            nc = 0;

                            for (int d = 0; d < tabDataset.Rows.Count; d++)
                            {
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

                            _arrayResult.Add(s[y].ToString());

                            return;
                        }
                    }
                }
                catch
                {

                }

            }
            else
            {

            }
        }

        #endregion



    }
}