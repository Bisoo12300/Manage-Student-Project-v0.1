using System.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    
    internal class CONTACT
    {
        MY_DB mydb = new MY_DB();
        public bool insertContact(int id, string fname,string mname, string lname, string phone, string address, string email, int userid, string groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("insert into contact(id,fname,mname,lname,group_id, phone, email, address, pic, userid)" +
                                                "values (@id,@fn,@mn, @ln, @grp, @phn,@mail,@adrs,@pic,@uid)", mydb.getConnection);

            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@mn", System.Data.SqlDbType.VarChar).Value = mname;
            command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", System.Data.SqlDbType.VarChar).Value = groupid;
            command.Parameters.Add("@phn", System.Data.SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", System.Data.SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", System.Data.SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@uid", System.Data.SqlDbType.Int).Value = userid;
            command.Parameters.Add("@pic", System.Data.SqlDbType.Image).Value = picture.ToArray();

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
        public bool updateContact(int contactid, string fname,string mname, string lname, string phone, string address, string email, int groupid, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("update contact set fname=@fn,mname=@mn, lname=@ln, group_id=@grp, phone=@phn, email=@mail, address=@adrs, pic=@pic where id = @contactid", mydb.getConnection);

            command.Parameters.Add("@fn", System.Data.SqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@mn", System.Data.SqlDbType.VarChar).Value = mname;
            command.Parameters.Add("@ln", System.Data.SqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@grp", System.Data.SqlDbType.VarChar).Value = groupid;
            command.Parameters.Add("@phn", System.Data.SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@mail", System.Data.SqlDbType.VarChar).Value = email;
            command.Parameters.Add("@adrs", System.Data.SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@contactid", System.Data.SqlDbType.Int).Value = contactid;
            command.Parameters.Add("@pic", System.Data.SqlDbType.Image).Value = picture.ToArray();

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
        public bool deleteContact(int contactid)
        {
            SqlCommand command = new SqlCommand("delete from contact where id = @id", mydb.getConnection);

            command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = contactid;
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
        public DataTable SelectContactList(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public DataTable getContactById(int contactId)
        {
            SqlCommand command = new SqlCommand("select id, fname,mname, lname, group_id, phone, email, address, pic, userid From contact Where id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = contactId;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool checkID(int id)
        {

            SqlCommand command = new SqlCommand("SELECT * FROM contact WHERE id = @id", mydb.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            if ((table.Rows.Count == 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
