using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSV
{
    internal class GROUP
    {
        MY_DB mydb = new MY_DB();
        public bool insertGroup(int id, string gname, string username)
        {
            SqlCommand command = new SqlCommand("insert into mygroup(Id, name, username)" +
                                                "values (@id, @name, @urid)", mydb.getConnection);

            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = gname;
            command.Parameters.Add("@urid", System.Data.SqlDbType.VarChar).Value = Login_Form.User;

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
        public bool updateGroup(int id, string gname)
        {
            SqlCommand command = new SqlCommand("update mygroup set name = @New where Id = @id", mydb.getConnection);

            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@New", System.Data.SqlDbType.VarChar).Value = gname;

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
        public bool deleteGroup(int id)
        {
            SqlCommand command = new SqlCommand("delete from mygroup where Id = @id", mydb.getConnection);

            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;

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
        public DataTable getGroup(string username)
        {
            SqlCommand command = new SqlCommand("select * from mygroup where username = @id", mydb.getConnection);

            command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = Login_Form.User;
            command.Connection = mydb.getConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getAllGroup(string username)
        {
            SqlCommand command = new SqlCommand("select * from mygroup where username = @id", mydb.getConnection);

            command.Parameters.Add("@id", System.Data.SqlDbType.VarChar).Value = Login_Form.User;

            command.Connection = mydb.getConnection;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool groupExist(string name, string operation, string username, int groupid = 0)
        {
            string query = "";
            SqlCommand command = new SqlCommand();
            if (operation == "add")
            {
                query = "SELECT * FROM mygroup WHERE name = @name AND username = @uid AND Id = @gid";

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.VarChar).Value = Login_Form.User;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            else if (operation == "edit")
            {
                query = "SELECT * FROM mygroup WHERE name = @name AND username = @uid AND Id <> @gid";

                command.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                command.Parameters.Add("@uid", SqlDbType.VarChar).Value = Login_Form.User;
                command.Parameters.Add("@gid", SqlDbType.Int).Value = groupid;
            }
            command.Connection = mydb.getConnection;
            command.CommandText = query;

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
    }
}
