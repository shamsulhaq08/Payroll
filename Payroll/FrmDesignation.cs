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
    public partial class FrmDesignation : Form
    {

        DAL.Designation objDAL = new DAL.Designation();

        bool vIsOpen = false;

        public FrmDesignation()
        {
            InitializeComponent();
        }


        private void DataGrid()
        {
            DesignationData.DataSource = null;
            DataTable dt = objDAL.getRecord();
            DesignationData.DataSource = dt;

        }


        private void FrmDesignation_Load(object sender, EventArgs e)
        {
            DataGrid();

            btnClear_Click(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this record!", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes) 
            {

             objDAL.DeleteRecord(Convert.ToInt32(txtDesigID.Text));

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

            txtDesigID.Text = objDAL.GetNextNumber();
            txtDesigName.Clear();
            txtRemarks.Clear();
            vIsOpen = false;
            DataGrid();
            DesignationData.Enabled = false;

        
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DesignationData.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            Objects.Designation obj = new Objects.Designation();
                       
            obj.DesigID = Convert.ToInt32(txtDesigID.Text);
            obj.DesigName = txtDesigName.Text;
            obj.Remarks = txtRemarks.Text;


            if (txtDesigName.Text.Length == 0)
            {

                MessageBox.Show("Designation Name is Required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDesigName.Focus();
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
            MessageBox.Show("Record Successfully Saved", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DesignationData.Enabled = true;


            DataGrid();

            btnClear_Click(null, null);

        }

   

        private void DesignationData_Click(object sender, EventArgs e)
        {
            if (DesignationData.Rows.Count > 0 && DesignationData.CurrentRow.Index != -1)
            {
                DataGridViewRow row = this.DesignationData.Rows[DesignationData.CurrentRow.Index];
                txtDesigID.Text = row.Cells["DesigID"].Value.ToString();
                txtDesigName.Text = row.Cells["DesigName"].Value.ToString();
                txtRemarks.Text = row.Cells["Remarks"].Value.ToString();
                vIsOpen = true;
            }

           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Designation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
