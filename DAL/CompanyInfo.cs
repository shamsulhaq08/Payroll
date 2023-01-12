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
    public class CompanyInfo
    {
        public string connectionstring;
        ListDictionary parameters = new ListDictionary();
        public CompanyInfo()
        {
        }
        public void InsertRecord(Objects.CompanyInfo obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_CompanyInfo_Insert";
                cmd.Parameters.AddWithValue("@CompanyName", obj.CompanyName);
                cmd.Parameters.AddWithValue("@Website", obj.Website);
                cmd.Parameters.AddWithValue("@ContactNumber", obj.ContactNumber);
                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@Logo", obj.Logo);

                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }

        public void DeleteRecord()
        {
            string vSql = "Delete From CompanyInfo ";

            new Database().ExecuteNonQueryOnly(string.Format(vSql));
        }

        public DataTable getRecord()
        {
            string query = @"Select * from CompanyInfo ";
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
    }
}
