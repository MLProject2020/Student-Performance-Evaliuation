using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.UI.DataVisualization.Charting;

namespace educationSector.AdminForms
{
    public partial class _CompareAlgorithms : System.Web.UI.Page
    {
        Dictionary<string, double> testData = new Dictionary<string, double>();

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                _ComparativeAnalysis();

                base.OnLoad(e);

                if (!IsPostBack)
                {
                    // bind chart type names to ddl
                    ddlChartType.DataSource = Enum.GetNames(typeof(SeriesChartType));
                    ddlChartType.DataBind();

                    cbUse3D.Checked = true;
                }

                DataBind();

            }
            catch
            {

            }
        }

        protected override void OnDataBinding(EventArgs e)
        {
            base.OnDataBinding(e);
            testData.Clear();

            testData.Add("NB", _percentageNB);
            testData.Add("DT", _percentageDT);  
            testData.Add("KNN", _percentageKNN);          

            cTestChart.Series["Testing"].Points.DataBind(testData, "Key", "Value", string.Empty);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // update chart rendering           
            cTestChart.Series["Testing"].ChartTypeName = "Column";

            cTestChart.ChartAreas[0].Area3DStyle.Enable3D = cbUse3D.Checked;
            cTestChart.ChartAreas[0].Area3DStyle.Inclination = Convert.ToInt32(rblInclinationAngle.SelectedValue);

            cTestChart.Visible = true;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            cTestChart.Visible = true;

            OnDataBinding(e);
            OnPreRender(e);
        }

        static double _percentageKNN, _percentageNB, _percentageDT;

        private void _ComparativeAnalysis()
        {
            BLL obj = new BLL();

            DataTable tab = new DataTable();
            tab = obj.GetActualData(Request.QueryString["courseName"].ToString(), int.Parse(Request.QueryString["sem"].ToString()));

            int _ActualCnt = tab.Rows.Count;

            Table1.Rows.Clear();

            Table1.BorderStyle = BorderStyle.Double;
            Table1.GridLines = GridLines.Both;
            Table1.BorderColor = System.Drawing.Color.DarkGray;

            //mainrow
            TableRow mainrow = new TableRow();
            mainrow.Height = 30;
            mainrow.ForeColor = System.Drawing.Color.WhiteSmoke;

            mainrow.BackColor = System.Drawing.Color.SteelBlue;

            TableCell cell1 = new TableCell();
            cell1.Width = 350;
            cell1.Text = "<b>Constraint</b>";
            mainrow.Controls.Add(cell1);

           
            TableCell cell4 = new TableCell();
            cell4.Width = 200;
            cell4.Text = "<b>Naive Bayes</b>";
            mainrow.Controls.Add(cell4);

            TableCell cell3 = new TableCell();
            cell3.Width = 200;
            cell3.Text = "<b>DT</b>";
            mainrow.Controls.Add(cell3);




            TableCell cell2 = new TableCell();
            cell2.Width = 200;
            cell2.Text = "<b>KNN</b>";
            mainrow.Controls.Add(cell2);


            Table1.Controls.Add(mainrow);

            //1st row
            TableRow row1 = new TableRow();

            TableCell cellAcc = new TableCell();
            cellAcc.Text = "<b>Accuracy</b>";
            row1.Controls.Add(cellAcc);

            double _outcomeNB = double.Parse(Session["NB_Result"].ToString());

            TableCell cellAccNB = new TableCell();
            _percentageNB = (_outcomeNB / _ActualCnt) * 100;
            cellAccNB.Text = _percentageNB.ToString() + "%";
            row1.Controls.Add(cellAccNB);


            double _outcomeDT = double.Parse(Session["DT_Result"].ToString());

            TableCell cellAccDT = new TableCell();
            //cal
            _percentageDT = (_outcomeDT / _ActualCnt) * 100;
            cellAccDT.Text = _percentageDT.ToString() + "%";
            row1.Controls.Add(cellAccDT);

            double _outcomeKNN = double.Parse(Session["KNN_Result"].ToString());

            TableCell cellAccKNN = new TableCell();
            _percentageKNN = (_outcomeKNN / _ActualCnt) * 100;
            cellAccKNN.Text = _percentageKNN.ToString() + "%";
            row1.Controls.Add(cellAccKNN);

            Table1.Controls.Add(row1);

            //2nd row           
            TableRow row2 = new TableRow();

            TableCell cellTime = new TableCell();
            cellTime.Text = "<b>Time (milli secs)</b>";
            row2.Controls.Add(cellTime);


            TableCell cellTimeNB = new TableCell();
            cellTimeNB.Text = Session["NB_Time"].ToString(); ;
            row2.Controls.Add(cellTimeNB);


            TableCell cellTimeDT = new TableCell();
            cellTimeDT.Text = Session["DT_Time"].ToString(); ;
            row2.Controls.Add(cellTimeDT);


            TableCell cellTimeKNN = new TableCell();
            cellTimeKNN.Text = Session["KNN_Time"].ToString();
            row2.Controls.Add(cellTimeKNN);



           

            Table1.Controls.Add(row2);

            //3rd row           
            TableRow row3 = new TableRow();

            TableCell cellCorrect = new TableCell();
            cellCorrect.Text = "<b>Correctly Classified</b>";
            row3.Controls.Add(cellCorrect);

            TableCell cellCorrectNB = new TableCell();
            cellCorrectNB.Text = _percentageNB.ToString() + "%";
            row3.Controls.Add(cellCorrectNB);


            TableCell cellCorrectDT = new TableCell();
            cellCorrectDT.Text = _percentageDT.ToString() + "%";
            row3.Controls.Add(cellCorrectDT);



            TableCell cellCorrectKNN = new TableCell();
            cellCorrectKNN.Text = _percentageKNN.ToString() + "%";
            row3.Controls.Add(cellCorrectKNN);




        

            Table1.Controls.Add(row3);

            //4th row           
            TableRow row4 = new TableRow();

            TableCell cellInCorrect = new TableCell();
            cellInCorrect.Text = "<b>InCorrectly Classified</b>";
            row4.Controls.Add(cellInCorrect);

            TableCell cellInCorrectNB = new TableCell();
            cellInCorrectNB.Text = (100 - _percentageNB).ToString() + "%";
            row4.Controls.Add(cellInCorrectNB);


            TableCell cellInCorrectDT = new TableCell();
            cellInCorrectDT.Text = (100 - _percentageDT).ToString() + "%";
            row4.Controls.Add(cellInCorrectDT);


            TableCell cellInCorrectKNN = new TableCell();
            cellInCorrectKNN.Text = (100 - _percentageKNN).ToString() + "%";
            row4.Controls.Add(cellInCorrectKNN);


           


            Table1.Controls.Add(row4);
        }

    }
}