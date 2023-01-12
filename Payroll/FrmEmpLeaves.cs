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
    public partial class FrmEmpLeaves : Form
    {

        DAL.EmpLeaves objDAL = new DAL.EmpLeaves();

        bool vIsOpen = false;
        public FrmEmpLeaves()
        {
            InitializeComponent();
            FillDesignation();
            FillDepartment();
            FillEmployee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Objects.EmpLeaves obj = new Objects.EmpLeaves();

            obj.EmpLeaveID = Convert.ToInt32(txtEmpLeaveID.Text);
            obj.EmployeeID = int.Parse(cmbEmployee.SelectedValue.ToString());

            obj.LeaveFrom = Convert.ToDateTime(txtLeaveFrom.Text);
            obj.LeaveTo = Convert.ToDateTime(txtLeaveTo.Text);
            obj.Remarks = txtRemarks.Text;

          



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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmpLeaveID.Text = objDAL.GetNextNumber();

            FillDepartment();
            FillDesignation();
            FillEmployee();
            DataGrid();
           
            txtLeaveFrom.Text = string.Empty;
            txtLeaveTo.Text = string.Empty;
            txtRemarks.Text = string.Empty;
            LeavesDataView.Enabled = false;

        }


        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillEmployee();
        }

        private void cmbDesignation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillEmployee();
        }



        private void LeavesDataView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (LeavesDataView.Rows.Count > 0 && LeavesDataView.CurrentRow.Index != -1)
            {
                DataGridViewRow row = this.LeavesDataView.Rows[LeavesDataView.CurrentRow.Index];
                txtEmpLeaveID.Text = row.Cells["EmpLeaveID"].Value.ToString();
                DataTable dt = objDAL.getRecord("AND EmpLeaveID =" + txtEmpLeaveID.Text);
                if (dt.Rows.Count > 0)
                {
                    txtEmpLeaveID.Text = row.Cells["EmpLeaveID"].Value.ToString();
                  
                    cmbDepartment.SelectedValue = dt.Rows[0]["DepID"].ToString();

                    cmbDesignation.SelectedValue = dt.Rows[0]["DesigID"].ToString();
                    FillEmployee();
                    cmbEmployee.SelectedValue = dt.Rows[0]["EmployeeID"].ToString();

                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();
                }

                vIsOpen = true;
            }
        }

        private void DataGrid()
        {
            LeavesDataView.DataSource = null;
            LeavesDataView.AutoGenerateColumns = false;
            DataTable dt = objDAL.getRecord("");
            LeavesDataView.DataSource = dt;

        }


        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtfilter.Text))
            {
                LeavesDataView.AutoGenerateColumns = false;
                LeavesDataView.DataSource = objDAL.getRecord("AND Employee.EmpName like '%" + txtfilter.Text + "%'");
            }
            else
            {
                LeavesDataView.AutoGenerateColumns = false;
                LeavesDataView.DataSource = objDAL.getRecord("");
            }
        }

        private void FrmEmpLeaves_Load(object sender, EventArgs e)
        {
            DataGrid();

            btnClear_Click(null, null);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            LeavesDataView.Enabled = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this record!", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                objDAL.DeleteRecord(Convert.ToInt32(txtEmpLeaveID.Text));

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
    }
}