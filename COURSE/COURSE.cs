using QLSV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLSV
{
    class COURSE
    {
        MY_DB mydb = new MY_DB();
        public bool checkCourseName(string courselabel, int courseId = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE label=@label And id <> @id", mydb.getConnection);
            command.Parameters.Add("@label", SqlDbType.VarChar).Value = courselabel;
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
                return false;
            else
                return true;
        }
        public bool insertCourse(string id, string label, int period, string semester, string description)
        {
            SqlCommand command = new SqlCommand("insert into course(id, label, period, semester, description)" +
                                                 "values (@id, @label, @period, @semester, @description)", mydb.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@label", System.Data.SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@period", System.Data.SqlDbType.Int).Value = period;
            command.Parameters.Add("@semester", System.Data.SqlDbType.VarChar).Value = semester;
            command.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = description;
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
        public bool updateCourse(string id, string label, int period, string semester, string description)
        {
            SqlCommand command = new SqlCommand("update course set id=@id, label=@label, period=@period, semester=@semester, description=@description where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
            command.Parameters.Add("@label", System.Data.SqlDbType.VarChar).Value = label;
            command.Parameters.Add("@period", System.Data.SqlDbType.Int).Value = period;
            command.Parameters.Add("@semester", System.Data.SqlDbType.VarChar).Value = semester;
            command.Parameters.Add("@description", System.Data.SqlDbType.VarChar).Value = description;
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
        public bool deleteCourse(string id)
        {
            SqlCommand command = new SqlCommand("delete from course where id=@id", mydb.getConnection);
            command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = id;
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
        public DataTable getAllCourses()
        {
            SqlCommand command= new SqlCommand("SELECT * FROM course", mydb.getConnection);
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public int totalCourse()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
        public DataTable getCoursesByID(string courseID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.VarChar).Value = courseID;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            // add a return statement here
            return table;
        }

        public DataTable getCoursebySemester(string semester)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM course WHERE semester=@semester", mydb.getConnection);
            command.Parameters.Add("@semester", SqlDbType.VarChar).Value = semester;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            // add a return statement here
            return table;
        }

        public DataTable getAllSemesters()
        {
            SqlCommand command = new SqlCommand("SELECT DISTINCT semester FROM course", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            // add a return statement here
            return table;
        }
        string execCount(string query)
        {
            mydb.openConnection();
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public string totalStudent()
        {
            return execCount("SELECT COUNT(*) FROM course");
        }
        
    }

}



