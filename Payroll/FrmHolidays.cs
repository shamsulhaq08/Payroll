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
    public partial class FrmHolidays : Form
    {
        DAL.Holidays objDAL = new DAL.Holidays();

        bool vIsOpen = false;

        public FrmHolidays()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Objects.Holidays obj = new Objects.Holidays();

           
            obj.ID = Convert.ToInt32(txtID.Text);        
            obj.HolidayTitle = txtHolidayTitle.Text;
            obj.HolidayFrom = Convert.ToDateTime(txtHolidayFrom.Text);
            obj.HolidayTo = Convert.ToDateTime(txtHolidayTo.Text);
            obj.Remarks = txtRemarks.Text;



            if (txtHolidayTitle.Text.Length == 0)
            {

                MessageBox.Show("Holiday Title is Required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHolidayTitle.Focus();
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

            btnClear_Click(null, null);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = objDAL.GetNextNumber();

            txtHolidayTitle.Clear();
            txtRemarks.Clear();
            //txtHolidayTo.Clear();
            vIsOpen = false;
            DataGrid();
            HolidaysData.Enabled = false;

        }



        private void DataGrid()
        {
            HolidaysData.AutoGenerateColumns = false;
            DataTable dt = objDAL.getRecord();
            HolidaysData.DataSource = dt;

        }

        private void FrmHolidays_Load(object sender, EventArgs e)
        {
            txtID.Text = objDAL.GetNextNumber();
            DataGrid();
            HolidaysData.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            HolidaysData.Enabled = true;
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

        private void HolidaysData_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (HolidaysData.Rows.Count > 0 && HolidaysData.CurrentRow.Index != -1)
            {
                DataGridViewRow row = this.HolidaysData.Rows[HolidaysData.CurrentRow.Index];
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtHolidayTitle.Text = row.Cells["HolidayTitle"].Value.ToString();
                txtHolidayFrom.Text = row.Cells["HolidayFrom"].Value.ToString();
                txtHolidayTo.Text = row.Cells["HolidayTo"].Value.ToString();

                txtRemarks.Text = row.Cells["Remarks"].Value.ToString();
                vIsOpen = true;
            }

        }
    }
}
