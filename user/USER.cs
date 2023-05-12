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
    internal class USER
    {
        MY_DB mydb = new MY_DB();

        public DataTable getUserById(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE id=@uid", mydb.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertUser(int id, string username, string password, string gmail, string passgmail)
        {
            SqlCommand command = new SqlCommand("INSERT INTO login (id,username,password,gmail,passgmail)" +
                                                                           "VALUES (@id,@user,@pass,@gmail,@passgmail)", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@gmail", SqlDbType.VarChar).Value = gmail;
            command.Parameters.Add("@passgmail", SqlDbType.VarChar).Value = passgmail;
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

        public bool updateUser(int id, string username, string password, string gmail, string passgmail)
        {
            SqlCommand command = new SqlCommand("UPDATE login SET username=@user,password=@pass,gmail=@gmail,passgmail=@passgmail WHERE id=@id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@user", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
            command.Parameters.Add("@gmail", SqlDbType.VarChar).Value = gmail;
            command.Parameters.Add("@passgmail", SqlDbType.VarChar).Value = passgmail;
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

        //public bool deleteUser(int id)
        //{

        //}

        public bool exist_ID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM login WHERE id=@id", mydb.getConnection);
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
            command.Connection=mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
