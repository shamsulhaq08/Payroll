using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class FrmEmployee : Form
    {
        DAL.Employee objDAL = new DAL.Employee();
        Byte[] openedBLOBData = new Byte[0];
        bool vIsOpen = false;
        public FrmEmployee()
        {

            InitializeComponent();
            FillDepartment();
            FillDesignation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
         
                Objects.Employee obj = new Objects.Employee();

           

                  obj.EmpID = Convert.ToInt32(txtEmpID.Text);
                obj.EmpName = txtEmpName.Text;
                obj.FatherName = txtFatherName.Text;
                obj.BasicSalary = Convert.ToDecimal(txtBasicSalary.Text);
                obj.DateofBirth = Convert.ToDateTime(DateofBirth.Text);
                obj.DateofJoining = Convert.ToDateTime(DateofJoining.Text);
                obj.ContactNo = txtContactNo.Text;
                obj.Email = txtEmail.Text;
                obj.Address = txtAddress.Text;
                obj.Gender = Convert.ToInt16(CmbGender.SelectedIndex);
                obj.IsLeft = Convert.ToBoolean(checkIsLeft.Checked);
                obj.DesigID = Convert.ToInt32(cmbDesignation.SelectedValue);
                obj.DepID = Convert.ToInt32(cmbDepartment.SelectedValue);
                //obj.MachineNo = Convert.ToInt32(txtMachineNo.Text);


            if (EmpPic.ImageLocation != null)
            {
                FileInfo finfo = new FileInfo(EmpPic.ImageLocation);
                byte[] btImage = new byte[finfo.Length];
                FileStream fStream = finfo.OpenRead();
                fStream.Read(btImage, 0, btImage.Length);
                fStream.Close();
                obj.EmpPic = btImage;
            }
            else
            if (openedBLOBData.Length > 0)
            {
                obj.EmpPic = openedBLOBData;
            }

          

            if (txtEmpName.Text.Length == 0)
            {

                MessageBox.Show("Employee Name is Required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmpName.Focus();
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

            btnClear_Click(null, null);


        }

        private void FillDepartment()
        {
            try
            {
                DAL.Department department = new DAL.Department();
                DataTable dt =  department.getRecord();
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


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            EmpPic.Load(openFileDialog1.FileName);
            EmpPic.Tag = openFileDialog1.FileName;
        }

        private void btnClear_Click()
        {
            txtEmpID.Text = objDAL.GetNextNumber();

            vIsOpen = false;
           
            EmpGridData.Enabled = false;

        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = objDAL.GetNextNumber(); 
            EmpGridData.AutoGenerateColumns = false;
            EmpGridData.DataSource = objDAL.getRecord("");
           
          

            btnClear_Click(null, null);
        }

        private void EmpGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnClear_Click(null, null);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            EmpGridData.Enabled = true;
        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtfilter.Text))
            {
                EmpGridData.AutoGenerateColumns = false;
                EmpGridData.DataSource = objDAL.getRecord("AND Employee.EmpName like '%" + txtfilter.Text + "%'");
            }
            else
            {
                EmpGridData.AutoGenerateColumns = false;
                EmpGridData.DataSource = objDAL.getRecord("");
            }
         
        }


        private void EmpGridData_grid()
        {
          
            if (EmpGridData.Rows.Count > 0 && EmpGridData.CurrentRow.Index != -1)
            {
                DataGridViewRow row = this.EmpGridData.Rows[EmpGridData.CurrentRow.Index];
                txtEmpID.Text = row.Cells["EmpID"].Value.ToString();
                DataTable dt = objDAL.getRecord("AND Employee.EmpID =" + txtEmpID.Text);
                if (dt.Rows.Count > 0)
                {
                    txtEmpName.Text = dt.Rows[0]["EmpName"].ToString();

                    txtBasicSalary.Text = dt.Rows[0]["BasicSalary"].ToString();

                    txtFatherName.Text = dt.Rows[0]["FatherName"].ToString();
                    DateofBirth.Text = dt.Rows[0]["DateofBirth"].ToString();
                    DateofJoining.Text = dt.Rows[0]["DateofJoining"].ToString();
                    txtContactNo.Text = dt.Rows[0]["ContactNo"].ToString();
                    CmbGender.SelectedIndex = int.Parse(dt.Rows[0]["Gender"].ToString());
                    CmbGender.Text = dt.Rows[0]["Gender"].ToString();
                    txtAddress.Text = dt.Rows[0]["Address"].ToString();
                    txtEmail.Text = dt.Rows[0]["Email"].ToString();
                    //txtMachineNo.Text = dt.Rows[0]["MachineNo"].ToString();

                    checkIsLeft.Checked = Boolean.Parse(dt.Rows[0]["IsLeft"].ToString());
                    cmbDepartment.SelectedValue = dt.Rows[0]["DepID"].ToString();
                    cmbDesignation.SelectedValue = dt.Rows[0]["DesigID"].ToString();

                }

                if (dt.Rows[0]["EmpPic"].ToString() != string.Empty)
                {
                    Byte[] byteBLOBData = new Byte[0];
                    openedBLOBData = byteBLOBData = (Byte[])(dt.Rows[0]["EmpPic"]);

                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    stmBLOBData.Seek(0, SeekOrigin.Begin);
                    EmpPic.Image = Image.FromStream(stmBLOBData);
                }

                vIsOpen = true;
              
            }
          


        }

        private void EmpGridData_Click(object sender, EventArgs e)
        {

            EmpGridData_grid();
        }

        private void imgClear_Click(object sender, EventArgs e)
        {
            EmpPic.Image = null;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtEmpID.Text = objDAL.GetNextNumber();

            txtEmpName.Text = string.Empty;
            txtBasicSalary.Text = string.Empty;
            txtBasicSalary.Text = string.Empty;
            txtContactNo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtMachineNo.Text = string.Empty;
            
            DateofBirth.Text = string.Empty;
            DateofJoining.Text = string.Empty;

            checkIsLeft.Checked = false;
            vIsOpen = false;
            //DataGrid();
            EmpGridData.Enabled = false;

            //EmpGridData_grid();
            EmpGridData.AutoGenerateColumns = false;
            EmpGridData.DataSource = objDAL.getRecord("");

            EmpPic.Image = null;
            CmbGender.SelectedIndex = 0;

            FillDesignation();
            FillDepartment();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this record!", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                objDAL.DeleteRecord(Convert.ToInt32(txtEmpID.Text));

            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }

            MessageBox.Show("Record Deleted Successfully ", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnClear_Click(null, null);


        }

        private void txtMachineNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBiometric frm = new FrmBiometric(Convert.ToInt32(txtEmpID.Text));
            frm.ShowDialog();
        }
    }
}
