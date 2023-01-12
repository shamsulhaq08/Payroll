using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Specialized;


namespace DAL
{
    public class Salary
    {
        public string connectionstring;
        public void InsertRecord(Objects.Salary obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalaryInsert";

                /**/
             
                cmd.Parameters.AddWithValue("@SalaryID", obj.SalaryID);
                cmd.Parameters.AddWithValue("@SallaryMonth", obj.SallaryMonth);
                cmd.Parameters.AddWithValue("@Enterydate", obj.Enterydate);


                if (obj.DepID > 0)
                    cmd.Parameters.AddWithValue("@DepID", obj.DepID);
                else
                    cmd.Parameters.AddWithValue("@DepID", DBNull.Value);



                if (obj.DesignID > 0)

                    cmd.Parameters.AddWithValue("@DesignID", obj.DesignID);
                else
                    cmd.Parameters.AddWithValue("@DesignID", DBNull.Value);



                if (obj.EmpID > 0)

                    cmd.Parameters.AddWithValue("@EmpID", obj.EmpID);
                else
                    cmd.Parameters.AddWithValue("@EmpID", DBNull.Value);


            
                cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                cmd.Parameters.AddWithValue("@TotalSalary", obj.TotalSalary);


                new Database().ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.Salary obj)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalaryUpdate";

                cmd.Parameters.AddWithValue("@SalaryID", obj.SalaryID);
                cmd.Parameters.AddWithValue("@SallaryMonth", obj.SallaryMonth);
                cmd.Parameters.AddWithValue("@Enterydate", obj.Enterydate);
                cmd.Parameters.AddWithValue("@DepID", obj.DepID);
                cmd.Parameters.AddWithValue("@DesignID", obj.DesignID);
                cmd.Parameters.AddWithValue("@EmpID", obj.EmpID);
                cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                cmd.Parameters.AddWithValue("@TotalSalary", obj.TotalSalary);


                new Database().ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void DeleteRecord(Int64 vID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalaryDelete";

                cmd.Parameters.AddWithValue("@SalaryID", vID);
                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }







        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT Salary.SalaryID,
FORMAT(Salary.SallaryMonth, 'MMM')  + '/' +
Convert(varchar,Year(Salary.SallaryMonth)) 
as SallaryMonth,
Salary.DepID, Salary.DesignID, Salary.EmpID, Salary.TotalSalary, Department.DepID, Department.DepName
FROM     Salary INNER JOIN
                  Department ON Salary.DepID = Department.DepID Where 1=1 {0}";
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

        public DataTable getRecordGridtable(string vWhere)
        {
            string query = @"SELECT Salary.SalaryID, Salary.SallaryMonth, isnull(Salary.DepID,0) as DepID, Isnull(Department.DepName,'All') as DepName
FROM     Salary LEFT OUTER JOIN
                  Department ON Salary.DepID = Department.DepID

 Where 1=1 {0}";
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





        public DataTable getRecordGrid(string vWhere)
        {
            string query = @"SELECT Salary.SalaryID, Salary.SallaryMonth, ISNULL(Salary.DepID, 0) AS DepID, ISNULL(Department.DepName, 'All') AS DepName, Salary.Enterydate, Salary.Remarks, Salary.TotalSalary, SalaryBody.EmpID, SalaryBody.Presents, 
                  SalaryBody.Leaves, SalaryBody.NetSalary, ISNULL(Designation.DesigID,0) DesigID, ISNULL(Designation.DesigName,'All') DesigName,Employee.EmpName,Employee.BasicSalary
FROM     Salary INNER JOIN
                  SalaryBody ON Salary.SalaryID = SalaryBody.SalaryID LEFT OUTER JOIN
                  Designation ON Salary.DesignID = Designation.DesigID LEFT OUTER JOIN
                  Department ON Salary.DepID = Department.DepID INNER JOIN
				  Employee ON SalaryBody.EmpID = Employee.EmpID

 Where 1=1 {0}";
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
        public DataTable getPrintRecord(string vWhere)
        {
            string query = @"SELECT Salary.SalaryID, Salary.SallaryMonth, Department.DepID, Department.DepName , Salary.Enterydate, Salary.Remarks, Salary.TotalSalary, SalaryBody.EmpID, SalaryBody.Presents, 
                  SalaryBody.Leaves, SalaryBody.NetSalary, Designation.DesigID, Designation.DesigName,Employee.EmpName,Employee.BasicSalary
FROM     Salary INNER JOIN
                  SalaryBody ON Salary.SalaryID = SalaryBody.SalaryID INNER JOIN
				  Employee ON SalaryBody.EmpID = Employee.EmpID INNER JOIN
                  Designation ON Employee.DesigID = Designation.DesigID INNER JOIN
                  Department ON Employee.DepID = Department.DepID 
				  
 Where 1=1 {0}";
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
            return new Database().ExecuteForDataTable("SELECT ISNULL(max(SalaryID),0) + 1 from Salary").Rows[0][0].ToString();
        }



        public void InsertRecordBody(Objects.SalaryBody obj)
        {
            try
            {

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalaryBodyInsert";

                //cmd.Parameters.AddWithValue("@SerialNo", obj.SerialNo);
                cmd.Parameters.AddWithValue("@SalaryID", obj.SalaryID);
                cmd.Parameters.AddWithValue("@EmpID", obj.EmpID);
                cmd.Parameters.AddWithValue("@Presents", obj.Presents);
                cmd.Parameters.AddWithValue("@Leaves", obj.Leaves);
                cmd.Parameters.AddWithValue("@NetSalary", obj.NetSalary);


                new Database().ExecuteNonQueryOnly(cmd);
            }
            catch (Exception exc)
            {

                throw exc;
            }

        }


        public void DeleteRecordBody(Int64 vID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_SalaryBodyDelete";

                cmd.Parameters.AddWithValue("@SalaryID", vID);
                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }
        }

        public DataTable getRecordSalary(string vWhere)
        {
            string query = @"SELECT Employee.EmpID, Employee.EmpName, Employee.FatherName, Employee.DateofBirth, Employee.DateofJoining, Employee.ContactNo, Employee.Email, Employee.EmpPic, Employee.Address, Employee.Gender, Employee.IsLeft, 
                  Employee.DesigID, Employee.MachineNo, Employee.DepID, Designation.DesigName, Department.DepName, Employee.BasicSalary
FROM     Employee INNER JOIN
                  Designation ON Employee.DesigID = Designation.DesigID INNER JOIN
                  Department ON Department.DepID = Employee.DepID
WHERE 1=1 {0}";
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



    }
}