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
    public partial class FrmEmployeeList : Form
    {
        DAL.Employee objDAL = new DAL.Employee();
       // bool vIsOpen = false;

        public FrmEmployeeList()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            string query = " ";
            if (int.Parse(cmbDepartment.SelectedValue.ToString())> 0)
            {
                query = query + $"AND Employee.DepID = {cmbDepartment.SelectedValue}";
            }


            if (int.Parse(cmbDesignation.SelectedValue.ToString()) > 0)
            {
                query = query + $" AND Employee.DesigID = {cmbDesignation.SelectedValue}";
            }

            DataTable dt = objDAL.getPrintRecord(query);


            if (dt.Rows.Count > 0)
            {
                Reports.ReportViewer rpt = new Reports.ReportViewer();
                rpt.PrintEmployeeList(dt);
                rpt.ShowDialog();
            }
            else
            {
                MessageBox.Show("Record Not Found", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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



        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmEmployeeList_Load(object sender, EventArgs e)
        {
            FillDesignation();
            FillDepartment();
        }
    }
}
