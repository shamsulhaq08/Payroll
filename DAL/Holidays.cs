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
    public class Holidays
    {
        public string connectionstring;
        ListDictionary parameters = new ListDictionary();

        public Holidays()
        {
        }
        public void InsertRecord(Objects.Holidays obj)
        {
            try
            {
                string vProcName = "SP_Holidays_Insert";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.Parameters.AddWithValue("@HolidayTitle", obj.HolidayTitle);
                cmd.Parameters.AddWithValue("@HolidayFrom", obj.HolidayFrom);
                cmd.Parameters.AddWithValue("@HolidayTo", obj.HolidayTo);
                cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);


                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Holidays obj)
        {
            try
            {


                string vProcName = "SP_Holidays_Update";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.Parameters.AddWithValue("@HolidayTitle", obj.HolidayTitle);
                cmd.Parameters.AddWithValue("@HolidayFrom", obj.HolidayFrom);
                cmd.Parameters.AddWithValue("@HolidayTo", obj.HolidayTo);
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
            cmd.CommandText = "SP_Holidays_Delete";
            cmd.Parameters.AddWithValue("@ID", id);

            new Database().ExecuteNonQueryOnly(cmd);
        }

        public DataTable getRecord()
        {
            string query = @"Select * from Holidays ";
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
            return new Database().ExecuteForDataTable("SELECT ISNULL(max(ID),0) + 1 from Holidays").Rows[0][0].ToString();
        }

    }
}
