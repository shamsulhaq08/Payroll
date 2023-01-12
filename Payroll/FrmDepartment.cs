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
    public partial class FrmDepartment : Form
    {

        DAL.Department objDAL = new DAL.Department();

        bool vIsOpen = false;

        public FrmDepartment()
        {
            InitializeComponent();
        }


        private void DataGrid()
        {
            DepartmentData.DataSource = null;
            DataTable dt = objDAL.getRecord();
            DepartmentData.DataSource = dt;

        }


        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            DataGrid();

            btnClear_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this record!", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) 
            {

             objDAL.DeleteRecord(Convert.ToInt32(txtDepID.Text));

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Record Deleted Successfully ", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnClear_Click(null, null);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtDepID.Text = objDAL.GetNextNumber();
            txtDepName.Clear();
            txtRemarks.Clear();
            vIsOpen = false;
            DataGrid();
            DepartmentData.Enabled = false;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DepartmentData.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            Objects.Department obj = new Objects.Department();

            obj.DepID = Convert.ToInt32(txtDepID.Text);
            obj.DepName = txtDepName.Text;
            obj.Remarks = txtRemarks.Text;


            if (txtDepName.Text.Length == 0)
            {

                MessageBox.Show("Department Name is Required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDepName.Focus();
                return;
            }

            if (vIsOpen)
            { 
                objDAL.UpdateRecord(obj);
            }
            else
            {
                objDAL.InsertRecord(obj);
            }
            MessageBox.Show("Data Successfully Saved", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DepartmentData.Enabled = true;


            DataGrid();
            btnClear_Click(null, null);

        }


        private void DepartmentData_Click(object sender, EventArgs e)
        {
            if (DepartmentData.Rows.Count > 0 && DepartmentData.CurrentRow.Index != -1)
            {
                DataGridViewRow row = this.DepartmentData.Rows[DepartmentData.CurrentRow.Index];
                txtDepID.Text = row.Cells["DepID"].Value.ToString();
                txtDepName.Text = row.Cells["DepName"].Value.ToString();
                txtRemarks.Text = row.Cells["Remarks"].Value.ToString();
                vIsOpen = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
