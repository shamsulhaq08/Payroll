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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text.Length == 0)
            {
                MessageBox.Show("Username is Required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Password is Required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            DAL.Users objDal = new DAL.Users();
            DataTable dt = objDal.getUserLogin(txtUserName.Text, txtPassword.Text);

            if (dt.Rows.Count > 0)
            {
                // User Exist
                FrmMain vForm = new FrmMain(dt.Rows[0]["username"].ToString(),dt.Rows[0]["userid"].ToString());
                vForm.Show();
                this.Hide();
            }
            else
            {
                // User Not Exist
                MessageBox.Show("Invalid User Name or Password.", "Invalid Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


        }

        private void MoveToNextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
