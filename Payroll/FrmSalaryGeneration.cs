using Payroll.Reports;
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
    public partial class FrmSalaryGeneration : Form
    {
        DAL.Salary objDAL = new DAL.Salary();
        bool vIsOpen = false;

        public FrmSalaryGeneration()
        {
            InitializeComponent();
            FillDesignation();
            FillDepartment();
            FillDepartment2();
            FillEmployee();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Objects.Salary obj = new Objects.Salary();

            obj.SalaryID = Convert.ToInt32(txtSalaryID.Text);

            decimal vTotalSalary;
            decimal.TryParse(txtTotalSalary.Text, out vTotalSalary);


            obj.SallaryMonth = txtSalaryMonth.Value;
            obj.Enterydate = txtGenerationDate.Value;
            obj.DepID = Convert.ToInt32(cmbDepartment.SelectedValue);
            obj.DesignID = Convert.ToInt32(cmbDesignation.SelectedValue);
            obj.EmpID = Convert.ToInt32(cmbEmployee.SelectedValue);
            obj.Remarks = txtRemarks.Text;
            obj.TotalSalary = vTotalSalary;

            if (vIsOpen)
            {
              
                objDAL.UpdateRecord(obj);

            }
            else
            {

                objDAL.InsertRecord(obj);
            }


            // Delete Old Record of Salary ID From Body
            objDAL.DeleteRecordBody(obj.SalaryID);

            foreach (DataGridViewRow dr in GridSalary.Rows)
            {
                Objects.SalaryBody salaryBody = new Objects.SalaryBody();

                salaryBody.SalaryID = obj.SalaryID;
                salaryBody.Presents = Convert.ToDecimal(dr.Cells["Presents"].Value);
                salaryBody.Leaves = Convert.ToDecimal(dr.Cells["Leaves"].Value);
                salaryBody.NetSalary = Convert.ToDecimal(dr.Cells["NetSalary"].Value);
                salaryBody.EmpID = Convert.ToInt32(dr.Cells["EmpID"].Value);
                objDAL.InsertRecordBody(salaryBody);
            }
            // Insert Record in Salary Body Table
            // Run a Foreach loop on Grid
            // Pick row by row and insert into body table

            MessageBox.Show("Record Successfully Saved", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnClear_Click(null, null);
        }






        private void FillDesignation()
        {
            try
            {
                DAL.Designation Designation = new DAL.Designation();
                DataTable dt = Designation.getRecord();

                DataRow dr = dt.NewRow();
                dr["DesigID"] = 0;
                dr["DesigName"] = "All";
                dt.Rows.Add(dr);

                if (dt.Rows.Count > 0)
                {
                    cmbDesignation.ValueMember = "DesigID";
                    cmbDesignation.DisplayMember = "DesigName";
                    cmbDesignation.DataSource = dt;

                    cmbDesignation.SelectedValue = 0;
                    cmbDesignation.SelectedText = "All";
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString(), "Error");
            }
        }


        private void FillDepartment()
        {
            try
            {
                DAL.Department department = new DAL.Department();
                DataTable dt = department.getRecord();

                DataRow dr = dt.NewRow();
                dr["DepID"] = 0;
                dr["DepName"] = "All";
                dt.Rows.Add(dr);

                if (dt.Rows.Count > 0)
                {
                    cmbDepartment.ValueMember = "DepID";
                    cmbDepartment.DisplayMember = "DepName";
                    cmbDepartment.DataSource = dt;

                    cmbDepartment.SelectedValue = 0;
                    cmbDepartment.SelectedText = "All";
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString(), "Error");
            }
        }


        private void FillDepartment2()
        {
            try
            {
                DAL.Department department = new DAL.Department();
                DataTable dt = department.getRecord();

                DataRow dr = dt.NewRow();
                dr["DepID"] = 0;
                dr["DepName"] = "All";
                dt.Rows.Add(dr);

                if (dt.Rows.Count > 0)
                {
                    cmbDepartment2.ValueMember = "DepID";
                    cmbDepartment2.DisplayMember = "DepName";
                    cmbDepartment2.DataSource = dt;

                    cmbDepartment2.SelectedValue = 0;
                    cmbDepartment2.SelectedText = "All";
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

                DataRow dr = dt.NewRow();
                dr["EmpID"] = 0;
                dr["EmpName"] = "All";
                dt.Rows.InsertAt(dr, 0);

                cmbEmployee.ValueMember = "EmpID";
                cmbEmployee.DisplayMember = "EmpName";
                cmbEmployee.DataSource = dt;
                cmbEmployee.SelectedValue = 0;



            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString(), "Error");
            }
        }

        private void cmbDepartment_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillEmployee();
        }

        private void cmbDesignation_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillEmployee();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            vIsOpen = false;
          
            DepartmentData.Enabled = false;

            txtRemarks.Text = string.Empty;
            txtGenerationDate.Text = string.Empty;
            txtSalaryMonth.Text = string.Empty;
            txtTotalSalary.Text = string.Empty;

            FillDesignation();
            FillDepartment();
            FillEmployee();

           

            //DataGrid();
            GridSalary.Rows.Clear();
         

            DAL.Salary objDAL = new DAL.Salary();
            txtSalaryID.Text = objDAL.GetNextNumber();
        }

        private void FrmSalaryGeneration_Load(object sender, EventArgs e)
        {
            btnClear_Click(null, null);

           
            DepartmentData.Enabled = false;
            DataGrid();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GridSalary.AllowUserToAddRows = false;
            decimal sum = 0;
            int month = txtSalaryMonth.Value.Month;
            int year = txtSalaryMonth.Value.Year;

            GridSalary.Rows.Clear();

            DAL.Employee Employee = new DAL.Employee();

            string vWhere = string.Empty;
            if ((int)cmbDepartment.SelectedValue > 0)
                vWhere = $"AND Employee.DepID = {cmbDepartment.SelectedValue}";
            if ((int)cmbDesignation.SelectedValue > 0)
                vWhere += $" AND Employee.DesigID = {cmbDesignation.SelectedValue}";
            if ((int)cmbEmployee.SelectedValue > 0)
                vWhere += $" AND Employee.EmpID = {cmbEmployee.SelectedValue}";

            DataTable dt = Employee.getRecordSalary(vWhere, month, year);
            foreach (DataRow dr in dt.Rows)
            {
                sum += decimal.Parse(dr["NetSalary"].ToString());
                GridSalary.Rows.Add(dr["EmpID"], dr["EmpName"], decimal.Parse(dr["BasicSalary"].ToString()).ToString("G29"),
                    dr["Presents"], dr["Leaves"],
                    Math.Round(decimal.Parse(dr["NetSalary"].ToString())).ToString("G29"));
            }
            txtTotalSalary.Text = Math.Round(sum).ToString("G29");


          
        }

        private void DataGrid()
        {

            DepartmentData.DataSource = null;
            DepartmentData.AutoGenerateColumns = false;
            DataTable dt = objDAL.getRecordGridtable("");
            DepartmentData.DataSource = dt;

         
        }

        private void FilterDate_ValueChanged(object sender, EventArgs e)
        {
            FilterData();
        }

        private void FilterData()
        {
            string vWhere = " AND Month(SallaryMonth) = " + FilterDate.Value.Month;
            if (cmbDepartment2.Text != "All")
                vWhere += " AND Department.DepName like '%" + cmbDepartment2.Text + "%'";
            DepartmentData.AutoGenerateColumns = false;
            DepartmentData.DataSource = objDAL.getRecord(vWhere);
        }


        private void cmbDepartment2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment2.SelectedIndex != -1)
                FilterData();

            if ((int)cmbDepartment2.SelectedValue == 0)
            {
                DepartmentData.AutoGenerateColumns = false;
                DepartmentData.DataSource = objDAL.getRecord("");

            }

            btnClear_Click(null, null);
        }


        private void DepartmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnClear_Click(null, null);
            vIsOpen = true;
            if (DepartmentData.Rows.Count > 0 && DepartmentData.CurrentRow.Index != -1)
            {
                txtSalaryID.Text = DepartmentData.Rows[DepartmentData.CurrentRow.Index].Cells["SalaryID"].Value.ToString();
                DataTable dt = objDAL.getRecordGrid(" AND Salary.SalaryID=" + txtSalaryID.Text);
                if (dt.Rows.Count > 0)
                {
                    txtSalaryMonth.Value = DateTime.Parse(dt.Rows[0]["SallaryMonth"].ToString());
                    txtGenerationDate.Value = DateTime.Parse(dt.Rows[0]["Enterydate"].ToString());
                    cmbDepartment.SelectedValue = dt.Rows[0]["DepID"].ToString();
                    cmbDesignation.SelectedValue = dt.Rows[0]["DesigID"].ToString();
                    FillEmployee();
                    cmbEmployee.SelectedValue = int.Parse(dt.Rows[0]["EmpID"].ToString());
                    txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();
                    txtTotalSalary.Text = decimal.Parse(dt.Rows[0]["TotalSalary"].ToString()).ToString("G29");
                }

                foreach (DataRow dr in dt.Rows)
                {                    
                    GridSalary.Rows.Add(dr["EmpID"], dr["EmpName"], decimal.Parse(dr["BasicSalary"].ToString()).ToString("G29"),
                    dr["Presents"], dr["Leaves"],
                    Math.Round(decimal.Parse(dr["NetSalary"].ToString())).ToString("G29"));
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {



            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this record!", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                objDAL.DeleteRecordBody(Convert.ToInt32(txtSalaryID.Text));
                objDAL.DeleteRecord(Convert.ToInt32(txtSalaryID.Text));

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Record Deleted Successfully ", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnClear_Click(null, null);

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            vIsOpen = true;
            DepartmentData.Enabled = true;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

            DAL.Salary objDAL = new DAL.Salary();

            DataTable dt = objDAL.getRecordGrid(" AND Salary.SalaryID = " + txtSalaryID.Text);

            SalaryViewer rpt = new SalaryViewer();
            rpt.SalaryviewerPrint(dt);
            rpt.ShowDialog();
        }
    }

}
