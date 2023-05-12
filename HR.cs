using QLSV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLSV
{
    internal class HR
    {
        MY_DB mydb = new MY_DB();
        

        
        public DataTable getUserById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HRLogin WHERE id=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getHR(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    
        string execCount(SqlCommand command)
        {
            /*SqlCommand command = new SqlCommand(query, mydb.getConnection);*/
            mydb.openConnection();
            string count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }
        public bool checkUser(string userNAME, int ID)
        {
            //SqlCommand command = new SqlCommand("select count(*) from login where username=userNAME or id=ID", mydb.getConnection);
            SqlCommand command = new SqlCommand("select count(*) from HRLogin where username=@user or id=@iD", mydb.getConnection);
            command.Parameters.AddWithValue("@id", ID);
            command.Parameters.AddWithValue("@user", userNAME);
            if (int.Parse(execCount(command)) > 0)
                return true;
            else
                return false;

        }

       
        public bool insertUser( string fname,string mname, string lname, string username, string password,string gmail, MemoryStream picture,int state)
        {
            SqlCommand command = new SqlCommand("INSERT INTO HRLogin ( firstname,midname, lastname, username, password,gmail, picture,state)" + "VALUES (@fn,@mn,@ln,@un,@pw,@gm,@fi,0)", mydb.getConnection);
            
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@mn",SqlDbType.VarChar).Value= mname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@gm",SqlDbType.VarChar).Value = gmail;
            command.Parameters.Add("@fi", SqlDbType.Image).Value = picture.ToArray();

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
        public bool usernameExist(string username, string operation, int userid = 0)
        {
            string query = "";
            if (operation == "register")
            {
                query = "SELECT * FROM HRLogin where username=@un ";
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM HR where username=@un  AND id <> @uid";
            }
            SqlCommand command = new SqlCommand(query, mydb.getConnection);
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userid;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
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

        public bool updatetUser(string fname,string mname, string lname, string password,string gmail,
            MemoryStream picture)
        {
            SqlCommand command =
                new SqlCommand(
                    "UPDATE HRLogin SET firstname = @fn,midname=@mn, lastname = @ln, username = @un, password = @pw,gmail=@gm, picture = @fi WHERE username=@un",
                    mydb.getConnection);
         
            command.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@mn", SqlDbType.VarChar).Value = mname;
            command.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@un", SqlDbType.VarChar).Value = Login_Form.User;
            command.Parameters.Add("@pw", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@gm", SqlDbType.VarChar).Value = gmail;
            command.Parameters.Add("@fi", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() > 0))
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

        public DataTable getAllHR()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HRLogin", mydb.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteHR(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM HRLogin WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() > 0))
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

        public bool exist_ID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM HRLogin WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if ((table.Rows.Count > 0))
                return true;
            else
                return false;
        }

        public DataTable getUser(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}

