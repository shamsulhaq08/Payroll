using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public class DailyAttendance
    {

        public string connectionstring;

        ListDictionary parameters = new ListDictionary();

        

        public DailyAttendance()
        {
        }
        public void InsertRecord(Objects.DailyAttendance obj)
        {
            try
            {
                string vProcName = "SP_DailyAttendance_Insert";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.Parameters.AddWithValue("@EmployeeID", obj.EmployeeID);
                cmd.Parameters.AddWithValue("@Attendance", obj.Attendance);
                cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                cmd.Parameters.AddWithValue("@AttendType", obj.AttendType);


                new Database().ExecuteNonQueryOnly(cmd);

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public void UpdateRecord(Objects.DailyAttendance obj)
        {
            try
            {


                string vProcName = "SP_DailyAttendance_Update";
                SqlCommand cmd = new SqlCommand(vProcName);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", obj.ID);
                cmd.Parameters.AddWithValue("@EmployeeID", obj.EmployeeID);
                cmd.Parameters.AddWithValue("@Attendance", obj.Attendance);
                cmd.Parameters.AddWithValue("@Remarks", obj.Remarks);
                cmd.Parameters.AddWithValue("@AttendType", obj.AttendType);


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
            cmd.CommandText = "SP_DailyAttendance_Delete";
            cmd.Parameters.AddWithValue("@ID", id);

            new Database().ExecuteNonQueryOnly(cmd);
        }

        public DataTable getRecord(string vWhere)
        {
            string query = @"SELECT DailyAttendance.ID, DailyAttendance.EmployeeID, DailyAttendance.Attendance, DailyAttendance.Remarks, Employee.DesigID, Employee.DepID, Employee.EmpName, Employee.EmpID, DailyAttendance.AttendType
FROM     Employee INNER JOIN
                  DailyAttendance ON Employee.EmpID = DailyAttendance.EmployeeID
WHERE  (1 = 1) {0}";
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



        public DataTable GetDailyAttend(string Date)
        {


            string query = @"SELECT DailyAttendance.ID, DailyAttendance.EmployeeID, FORMAT(DailyAttendance.Attendance,'hh:mm tt')Attendance, DailyAttendance.Remarks, Employee.DesigID, Employee.DepID, Employee.EmpName, Employee.EmpID,CASE WHEN DailyAttendance.AttendType = 0
THEN 'CheckIn'
ELSE 'CheckOut'
END AS
AttendType FROM     Employee INNER JOIN
                  DailyAttendance ON Employee.EmpID = DailyAttendance.EmployeeID 
WHERE  (1 = 1) AND Convert(varchar,Attendance,103) = Convert(varchar,'{0}',103) 
order by DailyAttendance.ID ";
            DataSet ds = new DataSet();

            try
            {

                ds = new Database().ExecuteForDataSet(string.Format(query, Date));
                return ds.Tables[0];

            }
            catch (Exception exc)
            {

                throw exc;
            }

        }
        public DataTable getRecordEmployee(string vWhere)
        {
            string query = @"select TOP(1) * 
INTO #TodayAttendance
From [dbo].[DailyAttendance] 
where CONVERT(char(10), Attendance,126) = CONVERT(char(10), GetDate(),126) 
AND EmployeeID = {0}
ORDER BY ID DESC

SELECT Employee.EmpID, Employee.EmpName, Designation.DesigID, Designation.DesigName, Department.DepID, Department.DepName,
ISNULL(#TodayAttendance.AttendType,1) AttStatus
FROM     Designation INNER JOIN
                  Employee ON Designation.DesigID = Employee.DesigID INNER JOIN
                  Department ON Employee.DepID = Department.DepID LEFT OUTER JOIN
				  #TodayAttendance ON #TodayAttendance.EmployeeID = EmployeeID
Where 1=1 AND Employee.EmpID = {0}

DROP Table #TodayAttendance ";
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



        public DataTable getRecordEmployeethumb(string vWhere)
        {
            string query = @"select TOP(1) * 
INTO #TodayAttendance
From [dbo].[DailyAttendance] 
where CONVERT(char(10), Attendance,126) = CONVERT(char(10), GetDate(),126) 
AND EmployeeID = {0}
ORDER BY ID DESC

SELECT Employee.EmpID, Employee.EmpName, Designation.DesigID, Designation.DesigName, Department.DepID, Department.DepName,
ISNULL(#TodayAttendance.AttendType,1) AttStatus
FROM     Designation INNER JOIN
                  Employee ON Designation.DesigID = Employee.DesigID INNER JOIN
                  Department ON Employee.DepID = Department.DepID LEFT OUTER JOIN
				  #TodayAttendance ON #TodayAttendance.EmployeeID = EmployeeID
Where 1=1 AND Employee.EmpID = {0}

DROP Table #TodayAttendance ";
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
            return new Database().ExecuteForDataTable("SELECT ISNULL(max(ID),0) + 1 from DailyAttendance").Rows[0][0].ToString();
        }


    }
}
