
namespace Payroll
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCompanyInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistration = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holidaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeLeavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryGenerationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.companyInfoReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSystem,
            this.mnuRegistration,
            this.payrollToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.mnuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "System";
            // 
            // mnuSystem
            // 
            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCompanyInfo,
            this.usersToolStripMenuItem,
            this.mniLogout,
            this.mniExit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Size = new System.Drawing.Size(88, 32);
            this.mnuSystem.Text = "System";
            // 
            // mniCompanyInfo
            // 
            this.mniCompanyInfo.Name = "mniCompanyInfo";
            this.mniCompanyInfo.Size = new System.Drawing.Size(290, 32);
            this.mniCompanyInfo.Text = "Company Information";
            this.mniCompanyInfo.Click += new System.EventHandler(this.mniCompanyInfo_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(290, 32);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // mniLogout
            // 
            this.mniLogout.Name = "mniLogout";
            this.mniLogout.Size = new System.Drawing.Size(290, 32);
            this.mniLogout.Text = "Logout";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(290, 32);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mnuRegistration
            // 
            this.mnuRegistration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.designationToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.mnuRegistration.Name = "mnuRegistration";
            this.mnuRegistration.Size = new System.Drawing.Size(131, 32);
            this.mnuRegistration.Text = "Registration";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // designationToolStripMenuItem
            // 
            this.designationToolStripMenuItem.Name = "designationToolStripMenuItem";
            this.designationToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.designationToolStripMenuItem.Text = "Designation";
            this.designationToolStripMenuItem.Click += new System.EventHandler(this.designationToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // payrollToolStripMenuItem
            // 
            this.payrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.holidaysToolStripMenuItem,
            this.quickAttendanceToolStripMenuItem,
            this.dailyAttendanceToolStripMenuItem,
            this.employeeLeavesToolStripMenuItem,
            this.salaryGenerationToolStripMenuItem1});
            this.payrollToolStripMenuItem.Name = "payrollToolStripMenuItem";
            this.payrollToolStripMenuItem.Size = new System.Drawing.Size(85, 32);
            this.payrollToolStripMenuItem.Text = "Payroll";
            // 
            // holidaysToolStripMenuItem
            // 
            this.holidaysToolStripMenuItem.Name = "holidaysToolStripMenuItem";
            this.holidaysToolStripMenuItem.Size = new System.Drawing.Size(253, 32);
            this.holidaysToolStripMenuItem.Text = "Holidays";
            this.holidaysToolStripMenuItem.Click += new System.EventHandler(this.holidaysToolStripMenuItem_Click);
            // 
            // quickAttendanceToolStripMenuItem
            // 
            this.quickAttendanceToolStripMenuItem.Name = "quickAttendanceToolStripMenuItem";
            this.quickAttendanceToolStripMenuItem.Size = new System.Drawing.Size(253, 32);
            this.quickAttendanceToolStripMenuItem.Text = "Quick Attendance";
            this.quickAttendanceToolStripMenuItem.Click += new System.EventHandler(this.quickAttendanceToolStripMenuItem_Click);
            // 
            // dailyAttendanceToolStripMenuItem
            // 
            this.dailyAttendanceToolStripMenuItem.Name = "dailyAttendanceToolStripMenuItem";
            this.dailyAttendanceToolStripMenuItem.Size = new System.Drawing.Size(253, 32);
            this.dailyAttendanceToolStripMenuItem.Text = "Daily Attendance";
            this.dailyAttendanceToolStripMenuItem.Click += new System.EventHandler(this.dailyAttendanceToolStripMenuItem_Click);
            // 
            // employeeLeavesToolStripMenuItem
            // 
            this.employeeLeavesToolStripMenuItem.Name = "employeeLeavesToolStripMenuItem";
            this.employeeLeavesToolStripMenuItem.Size = new System.Drawing.Size(253, 32);
            this.employeeLeavesToolStripMenuItem.Text = "Employee Leaves";
            this.employeeLeavesToolStripMenuItem.Click += new System.EventHandler(this.employeeLeavesToolStripMenuItem_Click);
            // 
            // salaryGenerationToolStripMenuItem1
            // 
            this.salaryGenerationToolStripMenuItem1.Name = "salaryGenerationToolStripMenuItem1";
            this.salaryGenerationToolStripMenuItem1.Size = new System.Drawing.Size(253, 32);
            this.salaryGenerationToolStripMenuItem1.Text = "Salary Generation";
            this.salaryGenerationToolStripMenuItem1.Click += new System.EventHandler(this.salaryGenerationToolStripMenuItem1_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeReportToolStripMenuItem1,
            this.companyInfoReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(85, 32);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // employeeReportToolStripMenuItem1
            // 
            this.employeeReportToolStripMenuItem1.Name = "employeeReportToolStripMenuItem1";
            this.employeeReportToolStripMenuItem1.Size = new System.Drawing.Size(285, 32);
            this.employeeReportToolStripMenuItem1.Text = "Employee Report";
            this.employeeReportToolStripMenuItem1.Click += new System.EventHandler(this.employeeReportToolStripMenuItem1_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(81, 32);
            this.mnuAbout.Text = "About";
            // 
            // companyInfoReportToolStripMenuItem
            // 
            this.companyInfoReportToolStripMenuItem.Name = "companyInfoReportToolStripMenuItem";
            this.companyInfoReportToolStripMenuItem.Size = new System.Drawing.Size(285, 32);
            this.companyInfoReportToolStripMenuItem.Text = "Company Info Report";
            this.companyInfoReportToolStripMenuItem.Click += new System.EventHandler(this.companyInfoReportToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mniCompanyInfo;
        private System.Windows.Forms.ToolStripMenuItem mniLogout;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistration;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holidaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeReportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeLeavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaryGenerationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quickAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyInfoReportToolStripMenuItem;
    }
}