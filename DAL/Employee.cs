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
    public class Employee
    {
        public string connectionstring;
        ListDictionary parameters = new ListDictionary();

        public Employee()
        {
        }
        public void InsertRecord(Objects.Employee obj)
        {
            try
            {
                string vProcName = "SP_Employee_Insert";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpID", obj.EmpID);
                cmd.Parameters.AddWithValue("@EmpName", obj.EmpName);
                cmd.Parameters.AddWithValue("@FatherName", obj.FatherName);
                cmd.Parameters.AddWithValue("@DateofBirth", obj.DateofBirth);
                cmd.Parameters.AddWithValue("@DateofJoining", obj.DateofJoining);
                cmd.Parameters.AddWithValue("@ContactNo", obj.ContactNo);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@EmpPic", obj.EmpPic);
                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                cmd.Parameters.AddWithValue("@IsLeft", obj.IsLeft);
                cmd.Parameters.AddWithValue("@DesigID", obj.DesigID);
                cmd.Parameters.AddWithValue("@DepID", obj.DepID);
                cmd.Parameters.AddWithValue("@BasicSalary", obj.BasicSalary);
                //cmd.Parameters.AddWithValue("@MachineNo", obj.MachineNo);


                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }

        public void UpdateRecord(Objects.Employee obj)
        {
            try
            {


                string vProcName = "SP_Employee_Update";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpID", obj.EmpID);
                cmd.Parameters.AddWithValue("@EmpName", obj.EmpName);
                cmd.Parameters.AddWithValue("@FatherName", obj.FatherName);
                cmd.Parameters.AddWithValue("@DateofBirth", obj.DateofBirth);
                cmd.Parameters.AddWithValue("@DateofJoining", obj.DateofJoining);
                cmd.Parameters.AddWithValue("@ContactNo", obj.ContactNo);
                cmd.Parameters.AddWithValue("@Email", obj.Email);
                cmd.Parameters.AddWithValue("@EmpPic", obj.EmpPic);
                cmd.Parameters.AddWithValue("@Address", obj.Address);
                cmd.Parameters.AddWithValue("@Gender", obj.Gender);
                cmd.Parameters.AddWithValue("@IsLeft", obj.IsLeft);
                cmd.Parameters.AddWithValue("@DesigID", obj.DesigID);
                cmd.Parameters.AddWithValue("@DepID", obj.DepID);
                cmd.Parameters.AddWithValue("@BasicSalary", obj.BasicSalary);
                //cmd.Parameters.AddWithValue("@MachineNo", obj.MachineNo);

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
            cmd.CommandText = "SP_Employee_Delete";
            cmd.Parameters.AddWithValue("@EmpID", id);

            new Database().ExecuteNonQueryOnly(cmd);
        }

        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT Employee.EmpID, Employee.EmpName, Employee.FatherName, Employee.DateofBirth, Employee.DateofJoining, Employee.ContactNo, Employee.Email, Employee.EmpPic, Employee.Address, Employee.Gender, Employee.IsLeft, 
                  Employee.DesigID, Employee.DepID, Designation.DesigName, Department.DepName, Employee.BasicSalary
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



        public DataTable getRecordSalary(string vWhere,int month,int year)
        {
            string query = @"
select COUNT(*) AS Presents , EmployeeID
INTO #Presents
from DailyAttendance
where (Month(Attendance)={1} AND Year(Attendance)={2})
GROUP BY EmployeeID

SELECT EmployeeID,
SUM(CASE WHEN 
DATEDIFF(DAY,LeaveFrom,LeaveTo) = 0
THEN 1
ELSE DATEDIFF(DAY,LeaveFrom,LeaveTo)
END) AS Leaves 
INTO #Leaves
from EmpLeaves
WHERE (MONTH(LeaveFrom) = {1} AND YEAR(LeaveFrom) = {2}) AND 
	  (MONTH(LeaveTo) = {1} AND YEAR(LeaveTo) = {2})
GROUP BY EmployeeID

SELECT Employee.EmpID, Employee.EmpName, Employee.FatherName, Employee.DateofBirth, Employee.DateofJoining, Employee.ContactNo, Employee.Email, Employee.EmpPic, Employee.Address, Employee.Gender, Employee.IsLeft, 
                  Employee.DesigID, Employee.DepID, Employee.BasicSalary, Designation.DesigName, Department.DepName, 
				  Isnull(#Presents.Presents,0) as Presents,
				  --,isnull(#Leaves.Leaves,0) as Leaves,
				  (30 - Isnull(#Presents.Presents,0)) as Leaves,
				  (Employee.BasicSalary/30) * Isnull(#Presents.Presents,0) as NetSalary
FROM     Employee INNER JOIN
                  Designation ON Employee.DesigID = Designation.DesigID INNER JOIN
                  Department ON Department.DepID = Employee.DepID LEFT OUTER JOIN
				  #Presents ON #Presents.EmployeeID = Employee.EmpID LEFT OUTER JOIN
				  #Leaves ON #Leaves.EmployeeID = Employee.EmpID
WHERE 1=1 {0}

DROP TABLE #Presents
DROP TABLE #Leaves";
            DataSet ds = new DataSet();

            try
            {

                ds = new Database().ExecuteForDataSet(string.Format(query, vWhere, month, year));
                return ds.Tables[0];

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }



        public DataTable getRecordSalaryView(string vWhere)
        {
            string query = @"
select COUNT(*) AS Presents , EmployeeID
INTO #Presents
from DailyAttendance
where (Month(Attendance)={1} AND Year(Attendance)={2})
GROUP BY EmployeeID

SELECT EmployeeID,
SUM(CASE WHEN 
DATEDIFF(DAY,LeaveFrom,LeaveTo) = 0
THEN 1
ELSE DATEDIFF(DAY,LeaveFrom,LeaveTo)
END) AS Leaves 
INTO #Leaves
from EmpLeaves
WHERE (MONTH(LeaveFrom) = {1} AND YEAR(LeaveFrom) = {2}) AND 
	  (MONTH(LeaveTo) = {1} AND YEAR(LeaveTo) = {2})
GROUP BY EmployeeID

SELECT Employee.EmpID, Employee.EmpName, Employee.FatherName, Employee.DateofBirth, Employee.DateofJoining, Employee.ContactNo, Employee.Email, Employee.EmpPic, Employee.Address, Employee.Gender, Employee.IsLeft, 
                  Employee.DesigID, Employee.DepID, Employee.BasicSalary, Designation.DesigName, Department.DepName, 
				  Isnull(#Presents.Presents,0) as Presents,
				  --,isnull(#Leaves.Leaves,0) as Leaves,
				  (30 - Isnull(#Presents.Presents,0)) as Leaves,
				  (Employee.BasicSalary/30) * Isnull(#Presents.Presents,0) as NetSalary
FROM     Employee INNER JOIN
                  Designation ON Employee.DesigID = Designation.DesigID INNER JOIN
                  Department ON Department.DepID = Employee.DepID LEFT OUTER JOIN
				  #Presents ON #Presents.EmployeeID = Employee.EmpID LEFT OUTER JOIN
				  #Leaves ON #Leaves.EmployeeID = Employee.EmpID
WHERE 1=1 {0}

DROP TABLE #Presents
DROP TABLE #Leaves";
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
            string query = @"SELECT Employee.EmpID, Employee.EmpName, Employee.FatherName, Employee.DateofBirth,Employee.ContactNo
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
        public string GetNextNumber()
        {
            return new Database().ExecuteForDataTable("SELECT ISNULL(max(EmpID),0) + 1 from Employee").Rows[0][0].ToString();
        }

    }
}
