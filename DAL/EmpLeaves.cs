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
    public class EmpLeaves
    {
        public string connectionstring;
        ListDictionary parameters = new ListDictionary();

        public EmpLeaves()
        {
        }
        public void InsertRecord(Objects.EmpLeaves obj)
        {
            try
            {
                string vProcName = "SP_EmpLeaves_Insert";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpLeaveID", obj.EmpLeaveID);
                cmd.Parameters.AddWithValue("@EmployeeID", obj.EmployeeID);
                cmd.Parameters.AddWithValue("@LeaveFrom", obj.LeaveFrom);
                cmd.Parameters.AddWithValue("@LeaveTo", obj.LeaveTo);
                cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);


                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.EmpLeaves obj)
        {
            try
            {


                string vProcName = "SP_EmpLeaves_Update";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpLeaveID", obj.EmpLeaveID);
                cmd.Parameters.AddWithValue("@EmployeeID", obj.EmployeeID);
                cmd.Parameters.AddWithValue("@LeaveFrom", obj.LeaveFrom);
                cmd.Parameters.AddWithValue("@LeaveTo", obj.LeaveTo);
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
            cmd.CommandText = "SP_EmpLeaves_Delete";
            cmd.Parameters.AddWithValue("@EmpLeaveID", id);

            new Database().ExecuteNonQueryOnly(cmd);
        }


        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT EmpLeaves.EmpLeaveID, EmpLeaves.EmployeeID, EmpLeaves.LeaveFrom, EmpLeaves.LeaveTo, EmpLeaves.Remarks, Employee.EmpID, Designation.DesigID, Department.DepID, Employee.EmpName, Designation.DesigName, 
                  Department.DepName
FROM     EmpLeaves INNER JOIN
                  Employee ON EmpLeaves.EmployeeID = Employee.EmpID INNER JOIN
                  Department ON Employee.DepID = Department.DepID INNER JOIN
                  Designation ON Employee.DesigID = Designation.DesigID WHERE  (1 = 1) {0} ";
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
        public string GetNextNumber()
        {
            return new Database().ExecuteForDataTable("SELECT ISNULL(max(EmpLeaveID),0) + 1 from EmpLeaves").Rows[0][0].ToString();
        }

    }
}
