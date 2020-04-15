using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace educationSector
{
    public class BusinessLogic
    {
        //class which contains class member and member functions

        string ConnectionString = ConfigurationManager.ConnectionStrings["educationalDatabaseConnectionString"].ConnectionString;

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader buffer;
        SqlDataAdapter adap;
        DataTable dt;
        DataSet ds;

        #region ---- Accounts ----

        //Check adminlogin and student login
        public DataTable CheckLogin(string username, string password, string LoginType)
        {
            string SQL_Check = null;
                       
            if (LoginType.ToLower() == "admin")
            {
                SQL_Check = string.Format("select AdminId from  tblAdmin where AdminId='{0}' and Password='{1}'", username, password);
            }
            else
            {
                SQL_Check = string.Format("select RegNo from  tblStudents where Regno='{0}' and Password='{1}'", username, password);
            }

            DataTable tabUser = RetriveDetails(SQL_Check);
            return tabUser;
        }

        //check  studentId availability
        public bool Check(string username)
        {
            bool Flag_Check = false;
            string SQL_Check = "select uname from tblStudents where Regno='" + username + "'";
            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand(SQL_Check, con);
            try
            {
                con.Open();
                buffer = cmd.ExecuteReader();
                if (buffer.Read())
                {
                    Flag_Check = true;
                }

            }
            catch (Exception errorConnecting)
            {
                WriteLog(errorConnecting.ToString());
            }
            finally
            {
                if (con.State.ToString().ToLower() == "open")
                {
                    con.Close();
                }

            }
            return Flag_Check;

        }

        //check  regno availability
        public bool CheckRegNo(string regNo)
        {
            bool Flag_Check = true;
            string SQL_Check = "select RegNo from tblStudents where RegNo='" + regNo + "'";
            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand(SQL_Check, con);
            try
            {
                con.Open();
                buffer = cmd.ExecuteReader();
                if (buffer.Read())
                {
                    Flag_Check = false;
                }

            }
            catch (Exception errorConnecting)
            {
                WriteLog(errorConnecting.ToString());
            }
            finally
            {
                if (con.State.ToString().ToLower() == "open")
                {
                    con.Close();
                }

            }
            return Flag_Check;

        }

        //Student-change password 
        public int ChangePassword1(string regNo,string oldpwd, string new_pwd)
        {
            string SQL_Change = string.Format("update tblStudents set Password='{0}' where Regno='{1}' and Password='{2}'", new_pwd, regNo, oldpwd);
            int Result_Change = SQLStatement_Execute(SQL_Change);
            return Result_Change;
        }

        //Student-change password 
        public int ChangePassword(string uname, string new_pwd)
        {
            string SQL_Change = string.Format("update tblStudents set Password='{0}' where Regno='{1}'", new_pwd, uname);
            int Result_Change = SQLStatement_Execute(SQL_Change);
            return Result_Change;
        }

        //Change password for admin
        public int ChangePassword_Admin(string uname, string npwd)
        {
            string SQL_Change = string.Format("update tblAdmin set Password='{0}' where AdminId='{1}'", npwd, uname);
            int Result_Change = SQLStatement_Execute(SQL_Change);
            return Result_Change;
        }

        #endregion

        #region ---- Course Management ----

        //Add New Course
        public int Add_Course(string cname, string sems, string desc)
        {
            string SQL_Insert = string.Format("insert into tblCourses values('{0}','{1}',{2})", cname, desc, sems);
            int Result_Insert = SQLStatement_Execute(SQL_Insert);
            return Result_Insert;
        }

        //Delete Existing Course
        public int Delete_Course(string cname)
        {
            string SQL_Delete = string.Format("delete from tblCourses where cname='{0}'", cname);
            int Resut_Delete = SQLStatement_Execute(SQL_Delete);
            return Resut_Delete;
        }

        //Update Existing Course
        public int UpdateCourse(string ncname, string sems, string desc, string ocname)
        {
            string SQL_Update = string.Format("update tblCourses set cname='{0}',description='{1}',semisters={2} where cname='{3}'", ncname, desc, sems, ocname);
            int Resut_Update = SQLStatement_Execute(SQL_Update);
            return Resut_Update;
        }

        //Get cname and sem details
        public DataTable View_Courses()
        {
            string SQL_View_Course = string.Format("select cname,semisters from tblCourses");
            DataTable Tab_Course = RetriveDetails(SQL_View_Course);
            return Tab_Course;
        }

        //Get the Semister based on coursename
        public DataTable Get_sem(string cname)
        {
            string SQL_Get_sem = string.Format("select semisters from tblCourses where cname='{0}'", cname);
            DataTable Tab_sem = RetriveDetails(SQL_Get_sem);
            return Tab_sem;
        }

        //Get the Course Details based on coursename
        public DataTable Get_Course(string cname)
        {
            string SQL_Get_Course = string.Format("select * from tblCourses where cname='{0}'", cname);
            DataTable Tab_Course = RetriveDetails(SQL_Get_Course);
            return Tab_Course;
        }

        #endregion


        #region ---- Student Registration ----

        //Register New Student 
        //Register New Student 
        public int Register_Student(string RegNo, string name, string dob, string gender, string course, string sem, string pname, string pwd, string mobile, string email_id, string status, string result)
        {
            string SQL_Register = string.Format("insert into tblStudents values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", RegNo, pwd, name, dob, gender, course, sem, pname, mobile, email_id, result, status);
            int Result_Register = SQLStatement_Execute(SQL_Register);
            return Result_Register;
        }

        //Update Student based on register number
        public int Update_Student(string RegNo, string name, string dob, string gender, string course, string sem, string pname, string mailid, string mobile, string status, string result)
        {
            string SQL_Update = string.Format("Update tblStudents set name='{0}',dob='{1}',gender='{2}',cname='{3}',sem='{4}',pname='{5}',email_id='{6}',mobile='{7}',status='{8}', Result='{9}' where regno='{10}'", name, dob, gender, course, sem, pname, mailid, mobile, status, result, RegNo);
            int Result_Register = SQLStatement_Execute(SQL_Update);
            return Result_Register;
        }

        //Get Students based on Coursename and Sem
        public DataTable Get_Students(string cname, string sem)
        {
            string SQL_Get_Students = string.Format("select regno,name from tblStudents where cname='{0}' and sem='{1}' and Status='Current'", cname, sem);
            DataTable Tab_Students = RetriveDetails(SQL_Get_Students);
            return Tab_Students;
        }

        //Get Students details based on the register number
        public DataTable GetStudentByUName(string uName)
        {
            string SQL_Search = string.Format("Select *from tblStudents where regno='{0}'", uName);
            DataTable Tab_Student_Info = RetriveDetails(SQL_Search);
            return Tab_Student_Info;
        }

        //Get Students details based on the register number
        public DataTable Search_Student(string regno)
        {
            string SQL_Search = string.Format("Select *from tblStudents where regno='{0}'", regno);
            DataTable Tab_Student_Info = RetriveDetails(SQL_Search);
            return Tab_Student_Info;
        }

        //Get Students details based on the register number
        public DataTable Search_Admin(string AdminId)
        {
            string SQL_Search = string.Format("Select *from tblAdmin where AdminId='{0}'", AdminId);
            DataTable Tab_Student_Info = RetriveDetails(SQL_Search);
            return Tab_Student_Info;
        }

        //Search the  student register number
        public int search_regno(string regno)
        {
            string _sql = string.Format("select count(*) from tblStudents where regno='{0}'", regno);
            int result = int.Parse(SQLStatement_ExecuteAggregate(_sql).ToString());
            return result;
        }


        //function to insert student attributes
        public int InsertAttributes(string regNo, string Hrs, string Regular, string interaction, string timemanagement, string graspingAbility, string exActivities, string prevsemResults, string SSLC, string PUC, string IHS)
        {
            string SQL_Insert = string.Format("insert into tblAttributes(regno,Hrs,Regular,Interaction,TimeManagement,GraspingAbility,EXActivities,PrevSemResults,SSLC,PUC,IHS) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                regNo, Hrs, Regular, interaction, timemanagement, graspingAbility, exActivities, prevsemResults, SSLC, PUC, IHS);
            return SQLStatement_Execute(SQL_Insert);
        }

        //function to Update student attributes
        public int UpdateAttributes(string Hrs, string Regular, string interaction, string timemanagement, string graspingAbility, string exActivities, string prevsemResults, string SSLC, string PUC, string IHS, string regNo)
        {
            string SQL_Update = string.Format("Update tblAttributes set Hrs='{0}',Regular='{1}',Interaction='{2}',TimeManagement='{3}',GraspingAbility='{4}',EXActivities='{5}',PrevSemResults='{6}',SSLC='{7}',PUC='{8}',IHS='{9}' where Regno='{10}'",
                Hrs, Regular, interaction, timemanagement, graspingAbility, exActivities, prevsemResults, SSLC, PUC, IHS, regNo);
            return SQLStatement_Execute(SQL_Update);
        }

        //Get Students attributes based regno 
        public DataTable GetStudentAttributes(string regNo)
        {
            string sql = string.Format("Select *from tblAttributes where RegNo='{0}'", regNo);
            DataTable Tab_Students = RetriveDetails(sql);
            return Tab_Students;
        }


        public DataTable GetDistinctResult(string cName)
        {
            string SQL_Get_Students = string.Format("select DISTINCT(Result) from tblStudents where cname='{0}'", cName);
            DataTable Tab_Students = RetriveDetails(SQL_Get_Students);
            return Tab_Students;
        }

        public DataTable GetResult_Student(string regNo)
        {
            string SQL_Get_Students = string.Format("select Result from tblStudents where RegNo='{0}'", regNo);
            DataTable Tab_Students = RetriveDetails(SQL_Get_Students);
            return Tab_Students;
        }

        //Get the student details like name,regno,coursename and sem based on the parent-id
        public DataTable Get_UserInfo(string regNo)
        {
            string SQL_Get = string.Format("select regno,name,cname,sem,status from tblStudents where Regno='{0}'", regNo);
            return RetriveDetails(SQL_Get);
        }

        public DataTable GetDistinctClasses(string cName, int sem)
        {
            string SQL_Get_Students = string.Format("select DISTINCT(Result) from tblStudents where cname='{0}' and sem='{1}' and Status='Old'", cName, sem);
            DataTable Tab_Students = RetriveDetails(SQL_Get_Students);
            return Tab_Students;
        }

        //Get Students attributes based regno 
        public DataTable GetStudent_Attributes(string regNo)
        {
            string sql = string.Format("Select Hrs,Regular,Interaction,TimeManagement,GraspingAbility,EXActivities,PrevSemResults,SSLC,PUC,IHS from tblAttributes where RegNo='{0}'", regNo);
            DataTable Tab_Students = RetriveDetails(sql);
            return Tab_Students;
        }

        #endregion
               

        #region ------- Student Feedbacks Management-------

        //function to insert the new feedback
        public int InsertFeedback(string regNo,string feedback,string date)
        {
            string sql = string.Format("Insert into tblFeedbacks(RegNo,Feedback,PostedDate) values('{0}','{1}','{2}')", regNo, feedback, date);

            int Result_Insert = SQLStatement_Execute(sql);
            return Result_Insert;
        }

        //function to retrive all feedbacks
        public DataTable GetAllFeedbacks()
        {
            string sql = "Select *from tblFeedbacks";
            return RetriveDetails(sql);         
        }

        //function to get the pending feedbacks
        public DataTable GetPendingFeedbacks()
        {
            string sql = "Select *from tblFeedbacks where Response IS NULL";
            return RetriveDetails(sql);  
        }

        //function to get the answered feedbacks
        public DataTable GetRepliedFeedbacks()
        {
            string sql = "Select *from tblFeedbacks where Response IS NOT NULL";
            return RetriveDetails(sql);
        }

        //function to delete the feedback
        public int DeleteFeedback(int feedbackId)
        {
            string sql = string.Format("Delete from tblFeedbacks where FeedbackId='{0}'", feedbackId);

            int result = SQLStatement_Execute(sql);
            return result;
        }

        //function to retrive the feedback based on feedback id
        public DataTable GetFeedbackById(int feedbackId)
        {
            string sql = string.Format("Select *from tblFeedbacks where feedbackId='{0}'", feedbackId);
            return RetriveDetails(sql);
        }

        //function to send reply for the feedback
        public int SendReplyToFeedback(string response, string date, int feedbackId)
        {
            string sql = string.Format("Update tblFeedbacks set Response='{0}',ResponseDate='{1}' where feedbackId='{2}'", response, date, feedbackId);
            int result = SQLStatement_Execute(sql);
            return result;
        }

        //function to get feedbacks based on student id
        public DataTable GetFeedbacksByStudent(string regNo)
        {
            string sql = string.Format("Select *from tblFeedbacks where Regno='{0}'", regNo);
            return RetriveDetails(sql);
        }

        //function to get feedbacks based on student id
        public DataTable GetPendingFeedbacksByStudent(string regNo)
        {
            string sql = string.Format("Select *from tblFeedbacks where Regno='{0}' and Response IS NULL", regNo);
            return RetriveDetails(sql);
        }

        //function to get feedbacks based on student id
        public DataTable GetRepliedFeedbacksByStudent(string regNo)
        {
            string sql = string.Format("Select *from tblFeedbacks where Regno='{0}'and Response IS NOT NULL", regNo);
            return RetriveDetails(sql);
        }

        #endregion

              
        #region ---------------- DB Operations ------------------

        //Write Error message to Text File
        void WriteLog(string message)
        {
            string ErrorLogPath = System.Configuration.ConfigurationSettings.AppSettings["ErrorLogPath"].ToString() + "Error.txt";

            try
            {
                FileStream fs = new FileStream(ErrorLogPath, FileMode.Append);
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine(message);
                writer.Close();
            }
            catch (Exception error)
            {
            }
        }

        //This function is common for insert,delete and update Queries 
        private int SQLStatement_Execute(string SQL)
        {
            int Result = 0;
            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand(SQL, con);
            //try
            //{
                con.Open();
                Result = cmd.ExecuteNonQuery();
            //}
            //catch (Exception error)
            //{
            //    WriteLog(error.ToString());
            //}
            //finally
            //{
            //    if (con.State.ToString().ToLower() == "open")
            //    {
            //        con.Close();
            //    }
            //}
            return Result;
        }

        //function to execute  SQL queries involving aggregate functions
        private object SQLStatement_ExecuteAggregate(string SQL)
        {
            object Result = 0;
            con = new SqlConnection(ConnectionString);
            cmd = new SqlCommand(SQL, con);
            try
            {
                con.Open();
                Result = cmd.ExecuteScalar();
            }
            catch (Exception error)
            {
                WriteLog(error.ToString());
            }
            finally
            {
                if (con.State.ToString().ToLower() == "open")
                {
                    con.Close();
                }
            }
            return Result;
        }

        //Retrive the detail[s] of the specified table[s]
        public DataTable RetriveDetails(string SQL)
        {
            DataTable Table_Retrive = new DataTable("Details");
            SqlDataAdapter adap = new SqlDataAdapter(SQL, ConnectionString);
            //try
            //{
            adap.Fill(Table_Retrive);
            //}
            //catch (Exception error)
            //{
            //    WriteLog(error.ToString());
            //}

            return Table_Retrive;
        }

        
        #endregion

    }
}