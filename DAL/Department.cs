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
    public class Department
    {
        public string connectionstring;
        ListDictionary parameters = new ListDictionary();

        public Department()
        {
        }
        public void InsertRecord(Objects.Department obj)
        {
            try
            {
                string vProcName = "SP_Department_Insert";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@DepID", obj.DepID);
                cmd.Parameters.AddWithValue("@DepName", obj.DepName);
                cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
             

                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Department obj)
        {
            try
            {


                string vProcName = "SP_Department_Update";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DepID", obj.DepID);
                cmd.Parameters.AddWithValue("@DepName", obj.DepName);
                cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);


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
            cmd.CommandText = "SP_Department_Delete";
            cmd.Parameters.AddWithValue("@DepID", id);

            new Database().ExecuteNonQueryOnly(cmd);
        }

        public DataTable getRecord()
        {
            string query = @"Select * from Department ";
            DataSet ds = new DataSet();

            try
            {

                ds = new Database().ExecuteForDataSet(string.Format(query));
                return ds.Tables[0];

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public string GetNextNumber()
        {
            return new Database().ExecuteForDataTable("SELECT ISNULL(max(DepID),0) + 1 from Department").Rows[0][0].ToString();
        }

    }
}
