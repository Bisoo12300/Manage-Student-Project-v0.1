using QLSV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLSV
{
    class SCORE
    {
        MY_DB mydb = new MY_DB();

        public bool insertScore(string studentId, string courseId, float scoreValue, string description)
        {
            SqlCommand command = new SqlCommand("insert into score(student_id, course_id, student_score, description)" +
                                                "values (@sid, @cid, @score, @desc)", mydb.getConnection);
            command.Parameters.Add("@sid", System.Data.SqlDbType.VarChar).Value = studentId;
            command.Parameters.Add("@cid", System.Data.SqlDbType.VarChar).Value = courseId;
            command.Parameters.Add("@score", System.Data.SqlDbType.Float).Value = scoreValue;
            command.Parameters.Add("@desc", System.Data.SqlDbType.VarChar).Value = description;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {

                return true;
            }
            else
            {

                return false;
            }
        }

        public bool studentScoreExist(string student_id, string course_id)
        {
            SqlCommand command = new SqlCommand("SELECT student_id,course_id FROM score WHERE student_id=@sid AND course_id=@cid",
                mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = student_id;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = course_id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
                return true;
            else
                return false;
        }

        public DataTable getAvgScoreByCourse()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText =
                "SELECT course.label, AVG(score.student_score) AS AverageGrade FROM course, score WHERE course.id = score.course_id GROUP BY course.label";

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        public bool deleteScore(string student_id, string course_id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM score WHERE student_id=@sid AND course_id=@cid",
                mydb.getConnection);
            command.Parameters.Add("@sid", SqlDbType.VarChar).Value = student_id;
            command.Parameters.Add("@cid", SqlDbType.VarChar).Value = course_id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public DataTable fillGrid(SqlCommand command)
        {
            command.Connection = mydb.getConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAllScore(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentsScore()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText =
                ("Select score.student_id,std.fname,std.mname,std.lname,score.course_id,course.label,score." +
                 "student_score from std inner join score on std.id=score.student_id inner join course on score.course_id=course.id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getCourseScore(string course_id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText =
                ("Select score.student_id,std.fname,std.mname,std.lname,score.course_id,course.label,score." +
                 "student_score from std inner join score on std.id=score.student_id inner join course on score.course_id=course.id where score.course_id=" +
                 course_id);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getStudentScoreByID(string student_id)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = mydb.getConnection;
            command.CommandText =
                ("Select score.student_id,std.fname,std.mname,std.lname,score.course_id,course.label,score." +
                 "student_score from std inner join score on std.id=score.student_id inner join course on score.course_id=course.id where score.student_id=" +
                 student_id);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool AddCourseForStudent(string student_id, string course_id)
        {
            SqlCommand command = new SqlCommand("insert into score(student_id, course_id)" +
                                                "values (@sid, @cid)", mydb.getConnection);
            command.Parameters.Add("@sid", System.Data.SqlDbType.VarChar).Value = student_id;
            command.Parameters.Add("@cid", System.Data.SqlDbType.VarChar).Value = course_id;
            mydb.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckTheScore_ISNULL(string id_std, string id_course)
        {
            SqlCommand command =
                new SqlCommand(
                    "SELECT * FROM SCORE WHERE student_id = @id_std and course_id = @id_course and student_score IS NULL",
                    mydb.getConnection);
            command.Parameters.Add("@id_std", SqlDbType.VarChar).Value = id_std;
            command.Parameters.Add("@id_course", SqlDbType.VarChar).Value = id_course;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateScore(string id_std, string id_course, double score,string des)
        {
            try
            {
                SqlCommand command =
                    new SqlCommand("UPDATE SCORE SET student_score = @score WHERE student_id = @id_std AND course_id = @id_course",
                        mydb.getConnection);
                command.Parameters.Add("@id_std", SqlDbType.VarChar).Value = id_std;
                command.Parameters.Add("@id_course", SqlDbType.VarChar).Value = id_course;
                command.Parameters.Add("@score", SqlDbType.Float).Value = score;
                command.Parameters.Add("@des", SqlDbType.VarChar).Value = des;
                mydb.openConnection();
                int rows = command.ExecuteNonQuery();
                mydb.closeConnection();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or display an error message)
                MessageBox.Show(ex.Message, "Text", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
        }

        public DataTable fillCommand(SqlCommand command)
        {
            
            command.Connection = mydb.getConnection;
            command.CommandText =
                ("Select score.student_id,std.fname,std.mname,std.lname,score.course_id,course.label,score." +
                                 "student_score from std inner join score on std.id=score.student_id inner join course on score.course_id=course.id");
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getStudentOfCourse(string CourID)
        {
            SqlCommand command = new SqlCommand();

            command.Connection = mydb.getConnection;
            command.CommandText = ("SELECT std.Id, std.fname,std.mname, std.Lname, std.Email FROM std INNER JOIN Score ON std.Id = Score.student_id INNER JOIN Course ON Score.course_id = Course.Id WHERE Course.Id = @CourID");
            command.Parameters.Add("@CourID", SqlDbType.VarChar).Value = CourID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}

