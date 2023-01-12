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
    public partial class FrmUsers : Form
    {

        DAL.Users objDAL = new DAL.Users();

        bool vIsOpen = false;

        public FrmUsers()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Objects.Users obj = new Objects.Users();

            obj.UserID = Convert.ToInt32(txtUserID.Text);
            obj.UserName = txtUserName.Text;
            obj.Password = txtPassword.Text;
            obj.IsAdmin = Convert.ToBoolean(checkIsAdmin.Checked);


            if (txtUserID.Text.Length == 0)
            {

                MessageBox.Show("Designation Name is Required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
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


            GridView();
            btnClear_Click(null, null);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtUserID.Text = objDAL.GetNextNumber();
            txtUserName.Clear();
            txtPassword.Clear();
          

            checkIsAdmin.Checked = false;
            vIsOpen = false;
            GridView();
            UsersGridData.Enabled = false;
        
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
           
            GridView();
            btnClear_Click(null, null);

        }


        private void GridView()
        {

            UsersGridData.AutoGenerateColumns = false;
            UsersGridData.DataSource = objDAL.getRecord("");

           

        

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            UsersGridData.Enabled = true;

        }

     

        private void UsersGridData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsersGridData.Rows.Count > 0 && UsersGridData.CurrentRow.Index != -1)
            {
                DataGridViewRow row = this.UsersGridData.Rows[UsersGridData.CurrentRow.Index];
                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                DataTable dt = objDAL.getRecord("AND Users.UserID =" + txtUserID.Text);
                if (dt.Rows.Count > 0)
                {
                    txtUserName.Text = dt.Rows[0]["UserName"].ToString();
                    txtPassword.Text = dt.Rows[0]["Password"].ToString();

                    checkIsAdmin.Checked = Boolean.Parse(dt.Rows[0]["IsAdmin"].ToString());


                }

                vIsOpen = true;

            }



        }

        private void txtfilter_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtfilter.Text))
            {
                UsersGridData.DataSource = objDAL.getRecord("AND Users.UserName like '%" + txtfilter.Text + "%'");
            }
            else
            {
                UsersGridData.DataSource = objDAL.getRecord("");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this record!", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {

                objDAL.DeleteRecord(Convert.ToInt32(txtUserID.Text));

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
