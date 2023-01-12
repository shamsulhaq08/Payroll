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
    public class Designation
    {
        public string connectionstring;
        ListDictionary parameters = new ListDictionary();

        public Designation()
        {
        }
        public void InsertRecord(Objects.Designation obj)
        {
            try
            {
                string vProcName = "SP_Designation_Insert";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DesigID", obj.DesigID);
                cmd.Parameters.AddWithValue("@DesigName", obj.DesigName);
                cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);


                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Designation obj)
        {
            try
            {


                string vProcName = "SP_Designation_Update";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@DesigID", obj.DesigID);
                cmd.Parameters.AddWithValue("@DesigName", obj.DesigName);
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
            cmd.CommandText = "SP_Designation_Delete";
            cmd.Parameters.AddWithValue("@DesigID", id);

            new Database().ExecuteNonQueryOnly(cmd);
        }

        public DataTable getRecord()
        {
            string query = @"Select * from Designation ";
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
            return new Database().ExecuteForDataTable("SELECT ISNULL(max(DesigID),0) + 1 from Designation").Rows[0][0].ToString();
        }

    }
}
