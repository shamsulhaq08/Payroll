using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class FrmMain : Form
    {
        string vUserName;
        string vUserID;
        public FrmMain(string vUserName, string vUserID)
        {

            //Thread t = new Thread(new ThreadSart(Splash));
            //t.Start();
            //Thread.Sleep(5000);
            InitializeComponent();
            this.vUserName = vUserName;
            this.vUserID = vUserID;

            //t.Abort();
        }
       


    


        private void mniExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void mniCompanyInfo_Click(object sender, EventArgs e)
        {
            FrmCompanyInfo vForm = new FrmCompanyInfo();
            vForm.MdiParent = this;
            vForm.Show();


        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartment vForm = new FrmDepartment();
            vForm.MdiParent = this;
            vForm.Show();
        }

        private void designationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDesignation vForm = new FrmDesignation();
            vForm.MdiParent = this;
            vForm.Show();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployee vForm = new FrmEmployee();
            vForm.MdiParent = this;
            vForm.Show();
        }

        private void holidaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHolidays vForm = new FrmHolidays();
            vForm.MdiParent = this;
            vForm.Show();
        }

        private void dailyAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDailyAttendance vForm = new FrmDailyAttendance();
            vForm.MdiParent = this;
            vForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmUsers vForm = new FrmUsers();
            vForm.MdiParent = this;
            vForm.Show();

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + "--- User Name:" + vUserName;

        }

        private void employeeReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEmployeeList vForm = new FrmEmployeeList();
            vForm.MdiParent = this;
            vForm.Show();

        }

        private void employeeLeavesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmEmpLeaves vForm = new FrmEmpLeaves();
            vForm.MdiParent = this;
            vForm.Show();
        }

   

        private void salaryGenerationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSalaryGeneration vForm = new FrmSalaryGeneration();
            vForm.MdiParent = this;
            vForm.Show();

        }

        private void quickAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmEmployeeQuickAttendance vForm = new FrmEmployeeQuickAttendance();
            vForm.MdiParent = this;
            vForm.Show();
        }

        private void companyInfoReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompanyInfoReport vForm = new FrmCompanyInfoReport();
            vForm.MdiParent = this;
            vForm.Show();
        }
    }
    
}
