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
    internal class STUDENT
    {
        MY_DB mydb = new MY_DB();

        public bool insertStudent(string Id, string fname, string mname, string lname, DateTime bdate, string gender, string phone, string email, string address, string year, string falcuty, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO std(Id,fname,mname,lname,bdate,gender,phone,email,address,year,falcuty, picture)" +
                "VALUES (@Id,@fn,@mn,@ln,@bdt,@gdr,@phn,@eml,@adrs,@yr,@fcty,@pic)", mydb.getConnection);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@mn", SqlDbType.VarChar).Value = mname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@yr", SqlDbType.VarChar).Value = year;
            cmd.Parameters.Add("@fcty", SqlDbType.VarChar).Value = falcuty;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if ((cmd.ExecuteNonQuery() == 1))
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


        public DataTable getStudents(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteStudent(int Id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM std WHERE Id= @Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
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
        

        public bool updateStudent(string Id, string fname, string mname, string lname, DateTime bdate, string gender, string phone, string email, string address, string year, string falcuty, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("UPDATE std SET fname=@fn, mname=@mn, lname=@ln, bdate=@bdt, gender=@gdr, phone=@phn, email=@eml, address=@adrs, year=@yr, falcuty=@fcty, picture=@pic WHERE Id=@Id", mydb.getConnection);
            cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@mn", SqlDbType.VarChar).Value = mname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            cmd.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@yr", SqlDbType.VarChar).Value = year;
            cmd.Parameters.Add("@fcty", SqlDbType.VarChar).Value = falcuty;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if ((cmd.ExecuteNonQuery() == 1))
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
            return execCount("SELECT COUNT(*) FROM std");
        }
        public string totalMaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Male'");
        }
        public string totalFemaleStudent()
        {
            return execCount("SELECT COUNT(*) FROM std WHERE gender='Female'");
        }

        internal bool deleteStudent(string studentID)
        {
            throw new NotImplementedException();
        }

        public bool checkId(string Id)
        {
            SqlCommand command = new SqlCommand("SELECT id FROM std WHERE id=@Id", mydb.getConnection);
            command.Parameters.Add("@Id", SqlDbType.VarChar).Value = Id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getStudentID()
        {
            
            SqlCommand command = new SqlCommand("SELECT id FROM std ", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        
    }
}


