using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace educationSector.StudentForms
{
    public partial class frmStudentFeedbacks : System.Web.UI.Page
    {
        BusinessLogic obj = new BusinessLogic();
        DataTable tab = new DataTable();
        string value = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                GetFeedbacksByStudent();
            }
            catch
            {

            }
        }

        public void GetFeedbacksByStudent()
        {
            tab.Rows.Clear();
            tab = obj.GetFeedbacksByStudent(Session["RegNo"].ToString());

            if (tab.Rows.Count > 0)
            {
                Table1.Rows.Clear();
                Table1.GridLines = GridLines.Both;

                TableHeaderRow mainrow = new TableHeaderRow();
                mainrow.BackColor = System.Drawing.Color.AliceBlue;

                TableHeaderCell cell1 = new TableHeaderCell();
                cell1.Text = "Feedback";
                mainrow.Controls.Add(cell1);

                TableHeaderCell cell2 = new TableHeaderCell();
                cell2.Text = "Posted Date";
                mainrow.Controls.Add(cell2);

                TableHeaderCell cell3 = new TableHeaderCell();
                cell3.Text = "Response";
                mainrow.Controls.Add(cell3);

                TableHeaderCell cell4 = new TableHeaderCell();
                cell4.Text = "Response Date";
                mainrow.Controls.Add(cell4);

                Table1.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

                    TableCell cell_question = new TableCell();
                    cell_question.Width = 250;
                    cell_question.Text = tab.Rows[i]["Feedback"].ToString();
                    row.Controls.Add(cell_question);

                    TableCell cell_posteddate = new TableCell();
                    cell_posteddate.Width = 100;
                    cell_posteddate.Text = tab.Rows[i]["PostedDate"].ToString();
                    row.Controls.Add(cell_posteddate);

                    TableCell cell_response = new TableCell();
                    cell_response.Width = 250;
                    cell_response.Text = tab.Rows[i]["Response"].ToString();
                    row.Controls.Add(cell_response);

                    TableCell cell_resposedate = new TableCell();
                    cell_resposedate.Width = 100;
                    cell_resposedate.Text = tab.Rows[i]["ResponseDate"].ToString();
                    row.Controls.Add(cell_resposedate);

                    Table1.Controls.Add(row);
                }


            }
            else
            {
                Table1.Rows.Clear();

                Table1.GridLines = GridLines.None;
                TableHeaderRow row = new TableHeaderRow();
                TableHeaderCell cell = new TableHeaderCell();
                cell.ForeColor = System.Drawing.Color.Red;
                cell.Text = "No Feedbacks Found";
                row.Controls.Add(cell);

                Table1.Controls.Add(row);


            }
        }

        public void GetPendingQuestions()
        {
            tab.Rows.Clear();
            tab = obj.GetPendingFeedbacksByStudent(Session["RegNo"].ToString());

            if (tab.Rows.Count > 0)
            {
                Table1.Rows.Clear();
                Table1.GridLines = GridLines.Both;

                TableHeaderRow mainrow = new TableHeaderRow();
                mainrow.BackColor = System.Drawing.Color.AliceBlue;

                TableHeaderCell cell1 = new TableHeaderCell();
                cell1.Text = "Feedback";
                mainrow.Controls.Add(cell1);

                TableHeaderCell cell2 = new TableHeaderCell();
                cell2.Text = "Posted Date";
                mainrow.Controls.Add(cell2);

                TableHeaderCell cell3 = new TableHeaderCell();
                cell3.Text = "Response";
                mainrow.Controls.Add(cell3);

                TableHeaderCell cell4 = new TableHeaderCell();
                cell4.Text = "Response Date";
                mainrow.Controls.Add(cell4);

                Table1.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

                    TableCell cell_question = new TableCell();
                    cell_question.Width = 250;
                    cell_question.Text = tab.Rows[i]["Feedback"].ToString();
                    row.Controls.Add(cell_question);

                    TableCell cell_posteddate = new TableCell();
                    cell_posteddate.Width = 100;
                    cell_posteddate.Text = tab.Rows[i]["PostedDate"].ToString();
                    row.Controls.Add(cell_posteddate);

                    TableCell cell_response = new TableCell();
                    cell_response.Width = 250;
                    cell_response.Text = tab.Rows[i]["Response"].ToString();
                    row.Controls.Add(cell_response);

                    TableCell cell_resposedate = new TableCell();
                    cell_resposedate.Width = 100;
                    cell_resposedate.Text = tab.Rows[i]["ResponseDate"].ToString();
                    row.Controls.Add(cell_resposedate);

                    Table1.Controls.Add(row);
                }


            }
            else
            {
                Table1.Rows.Clear();

                Table1.GridLines = GridLines.None;
                TableHeaderRow row = new TableHeaderRow();
                TableHeaderCell cell = new TableHeaderCell();
                cell.ForeColor = System.Drawing.Color.Red;
                cell.Text = "No Pending Feedbacks Found";
                row.Controls.Add(cell);

                Table1.Controls.Add(row);


            }
        }

        public void GetAnsweresQuestions()
        {
            tab.Rows.Clear();
            tab = obj.GetRepliedFeedbacksByStudent(Session["RegNo"].ToString());

            if (tab.Rows.Count > 0)
            {
                Table1.Rows.Clear();
                Table1.GridLines = GridLines.Both;

                TableHeaderRow mainrow = new TableHeaderRow();
                mainrow.BackColor = System.Drawing.Color.AliceBlue;

                TableHeaderCell cell1 = new TableHeaderCell();
                cell1.Text = "Feedback";
                mainrow.Controls.Add(cell1);

                TableHeaderCell cell2 = new TableHeaderCell();
                cell2.Text = "Posted Date";
                mainrow.Controls.Add(cell2);

                TableHeaderCell cell3 = new TableHeaderCell();
                cell3.Text = "Response";
                mainrow.Controls.Add(cell3);

                TableHeaderCell cell4 = new TableHeaderCell();
                cell4.Text = "Response Date";
                mainrow.Controls.Add(cell4);

                Table1.Controls.Add(mainrow);

                for (int i = 0; i < tab.Rows.Count; i++)
                {
                    TableRow row = new TableRow();

                    TableCell cell_question = new TableCell();
                    cell_question.Width = 250;
                    cell_question.Text = tab.Rows[i]["Feedback"].ToString();
                    row.Controls.Add(cell_question);

                    TableCell cell_posteddate = new TableCell();
                    cell_posteddate.Width = 100;
                    cell_posteddate.Text = tab.Rows[i]["PostedDate"].ToString();
                    row.Controls.Add(cell_posteddate);

                    TableCell cell_response = new TableCell();
                    cell_response.Width = 250;
                    cell_response.Text = tab.Rows[i]["Response"].ToString();
                    row.Controls.Add(cell_response);

                    TableCell cell_resposedate = new TableCell();
                    cell_resposedate.Width = 100;
                    cell_resposedate.Text = tab.Rows[i]["ResponseDate"].ToString();
                    row.Controls.Add(cell_resposedate);

                    Table1.Controls.Add(row);
                }


            }
            else
            {
                Table1.Rows.Clear();

                Table1.GridLines = GridLines.None;
                TableHeaderRow row = new TableHeaderRow();
                TableHeaderCell cell = new TableHeaderCell();
                cell.ForeColor = System.Drawing.Color.Red;
                cell.Text = "No Answered Feedbacks Found";
                row.Controls.Add(cell);

                Table1.Controls.Add(row);


            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Panel9.Visible = false;
            Panel8.Visible = true;
            GetPendingQuestions();
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Panel9.Visible = false;
            Panel8.Visible = true;
            GetAnsweresQuestions();
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Panel9.Visible = true;
            Panel8.Visible = false;
        }

        protected void btn_postquestion_Click(object sender, EventArgs e)
        {
            try
            {
                obj.InsertFeedback(Session["RegNo"].ToString(), txt_postQuestion.Text, DateTime.Now.ToShortDateString());
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('New Feedback Posted Successfully')</script>");
                txt_postQuestion.Text = string.Empty;
                GetFeedbacksByStudent();
                Panel9.Visible = false;
                Panel8.Visible = true;
            }
            catch
            {
                ClientScript.RegisterStartupScript(this.GetType(), "Key", "<script>alert('Server Error!')</script>");
            }
        }

    }
}