using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class FrmDailyAttendance : Form
    {

        bool vIsOpen = false;
        DAL.DailyAttendance objDAL = new DAL.DailyAttendance();


        private enum AttendenceType
        {
            CheckIn = 0,
            CheckOut = 1
        }

        public FrmDailyAttendance()
        {
            InitializeComponent();
            btnClear_Click(null, null);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           

            Objects.DailyAttendance obj = new Objects.DailyAttendance();



            obj.ID = Convert.ToInt64(txtID.Text);
            obj.EmployeeID = int.Parse(cmbEmployee.SelectedValue.ToString());
            obj.Attendance = dtAttendance.Value;
            obj.Remarks = txtRemarks.Text;
            obj.AttendType = rdoCheckIn.Checked ? 
            (int)AttendenceType.CheckIn : (int)AttendenceType.CheckOut;


            if (vIsOpen)
            {
                objDAL.UpdateRecord(obj);
            }
            else
            {
                objDAL.InsertRecord(obj);
            }
            MessageBox.Show("Record Successfully Saved", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            vIsOpen = true;
            btnClear_Click(null, null);


        }


        private void FillDepartment()
        {

            try
            {
                DAL.Department department = new DAL.Department();


               

                DataTable dt = department.getRecord();
                if (dt.Rows.Count > 0)
                {
                    cmbDepartment.ValueMember = "DepID";
                    cmbDepartment.DisplayMember = "DepName";
                    cmbDepartment.DataSource = dt;
                }

               

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString(), "Error");
            }
        }


        private void FillDesignation()
        {
            try
            {
                DAL.Designation Designation = new DAL.Designation();

               
                DataTable dt = Designation.getRecord();
                if (dt.Rows.Count > 0)
                {
                    cmbDesignation.ValueMember = "DesigID";
                    cmbDesignation.DisplayMember = "DesigName";
                    cmbDesignation.DataSource = dt;
                }

               

            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString(), "Error");
            }
        }

        private void FillEmployee()
        {
            try
            {
                DAL.Employee Employee = new DAL.Employee();
                string query = $"AND Employee.DepID = {cmbDepartment.SelectedValue} AND Employee.DesigID = {cmbDesignation.SelectedValue}";
                DataTable dt = Employee.getRecord(query);
                if (dt.Rows.Count > 0)
                {
                    cmbEmployee.ValueMember = "EmpID";
                    cmbEmployee.DisplayMember = "EmpName";
                    cmbEmployee.DataSource = dt;


                }


            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString(), "Error");
            }
        }




        private void FrmDailyAttendance_Load(object sender, EventArgs e)
        {
            txtID.Text = objDAL.GetNextNumber();
            DataGrid();
            btnClear_Click(null, null);
        }
        private void DataGrid()
        {
            AttendanceData.DataSource = null;


            AttendanceData.AutoGenerateColumns = false;
            DataTable dt = objDAL.getRecord("");
            AttendanceData.DataSource = dt;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DataGrid();
            FillDepartment();
            FillDesignation();
            FillEmployee();
            cmbEmployee.DataSource = null;

            txtID.Text = objDAL.GetNextNumber();


            txtRemarks.Text = string.Empty;


            AttendanceData.Enabled = false;



        }




        private void AttendanceData_CellClick(object sender, DataGridViewCellEventArgs e)
        {



        


            if (AttendanceData.Rows.Count > 0 && AttendanceData.CurrentRow.Index != -1)
            {

                DataGridViewRow row = this.AttendanceData.Rows[AttendanceData.CurrentRow.Index];
                DataTable dt = objDAL.getRecord($"AND DailyAttendance.ID ={row.Cells["ID"].Value.ToString()}");
                if (dt.Rows.Count > 0)
                {
                    txtID.Text = dt.Rows[0]["ID"].ToString();

                    // Get Data From DAL and fill controls from that DT Row

                    dtAttendance.Text = dt.Rows[0]["Attendance"].ToString();

                    cmbDepartment.SelectedValue = dt.Rows[0]["DepID"].ToString();

                    cmbDesignation.SelectedValue = dt.Rows[0]["DesigID"].ToString();
                    FillEmployee();
                    cmbEmployee.SelectedValue = dt.Rows[0]["EmployeeID"].ToString();

                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();

                    rdoCheckOut.Checked = Convert.ToInt64(dt.Rows[0]["AttendType"].ToString()) == (int)AttendenceType.CheckOut ? true : false;
                    rdoCheckIn.Checked = !rdoCheckOut.Checked;

                    vIsOpen = true;
                }
            }


        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            AttendanceData.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this record!", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                objDAL.DeleteRecord(Convert.ToInt32(txtID.Text));

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Record Deleted Successfully ", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnClear_Click(null, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

     

   
        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillEmployee();
        }

        private void cmbDesignation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillEmployee();
        }
    }
}