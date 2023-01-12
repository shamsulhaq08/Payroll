using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Specialized;

namespace DAL
{
    public class Users
    {
        public string connectionstring;
        ListDictionary parameters = new ListDictionary();

        public Users()
        {
        }
        public void InsertRecord(Objects.Users obj)
        {
            try
            {
                string vProcName = "SP_Users_Insert";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", obj.UserID);
                cmd.Parameters.AddWithValue("@UserName", obj.UserName);
                cmd.Parameters.AddWithValue("@Password", obj.Password);
                cmd.Parameters.AddWithValue("@IsAdmin", obj.IsAdmin);


                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Users obj)
        {
            try
            {


                string vProcName = "SP_Users_Update";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@UserID", obj.UserID);
                cmd.Parameters.AddWithValue("@UserName", obj.UserName);
                cmd.Parameters.AddWithValue("@Password", obj.Password);
                cmd.Parameters.AddWithValue("@IsAdmin", obj.IsAdmin);



                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }

        public void DeleteRecord(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_Users_Delete";
            cmd.Parameters.AddWithValue("@UserID", id);

            new Database().ExecuteNonQueryOnly(cmd);
        }

        public DataTable getRecord(string vWhere)
        {
            string query = @"Select * from Users where 1=1 {0}";
            DataSet ds = new DataSet();

            try
            {

                ds = new Database().ExecuteForDataSet(string.Format(query, vWhere));
                return ds.Tables[0];

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }

        public DataTable getUserLogin(string vUserName, string vPassword)
        {
            string query = @"Select * from Users where  username='{0}' and password='{1}'";
            DataSet ds = new DataSet();

            try
            {

                ds = new Database().ExecuteForDataSet(string.Format(query, vUserName, vPassword));
                return ds.Tables[0];

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public string GetNextNumber()
        {
            return new Database().ExecuteForDataTable("SELECT ISNULL(max(UserID),0) + 1 from Users").Rows[0][0].ToString();
        }

    }
}
