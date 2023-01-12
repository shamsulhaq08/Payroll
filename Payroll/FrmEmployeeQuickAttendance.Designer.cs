
namespace Payroll
{
    partial class FrmEmployeeQuickAttendance
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDepartName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDesignName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblAttendStatus = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAttendTime = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMark = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AttendanceData = new System.Windows.Forms.DataGridView();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Attendance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDate = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblheadingtxt = new System.Windows.Forms.Label();
            this.cboReaders = new System.Windows.Forms.ComboBox();
            this.lblSelectReader = new System.Windows.Forms.Label();
            this.lblPlaceFinger = new System.Windows.Forms.Label();
            this.pbFingerprint = new System.Windows.Forms.PictureBox();
            this.btnFinger = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceData)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1622, 115);
            this.panel1.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(653, 125);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(741, 74);
            this.panel7.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Quick Attendance";
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchUser.Location = new System.Drawing.Point(117, 145);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(192, 34);
            this.txtSearchUser.TabIndex = 4;
            this.txtSearchUser.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchUser_KeyUp);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGo.Location = new System.Drawing.Point(332, 145);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(119, 41);
            this.btnGo.TabIndex = 32;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            this.btnGo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchUser_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "User ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Employee Name: ";
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpName.Location = new System.Drawing.Point(20, 6);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(0, 25);
            this.lblEmpName.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(350, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Deparment: ";
            // 
            // lblDepartName
            // 
            this.lblDepartName.AutoSize = true;
            this.lblDepartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartName.Location = new System.Drawing.Point(13, 6);
            this.lblDepartName.Name = "lblDepartName";
            this.lblDepartName.Size = new System.Drawing.Size(0, 25);
            this.lblDepartName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Designation:";
            // 
            // lblDesignName
            // 
            this.lblDesignName.AutoSize = true;
            this.lblDesignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignName.Location = new System.Drawing.Point(14, 8);
            this.lblDesignName.Name = "lblDesignName";
            this.lblDesignName.Size = new System.Drawing.Size(0, 25);
            this.lblDesignName.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(341, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 25);
            this.label9.TabIndex = 31;
            this.label9.Text = "Attendance Status: ";
            // 
            // lblAttendStatus
            // 
            this.lblAttendStatus.AutoSize = true;
            this.lblAttendStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendStatus.Location = new System.Drawing.Point(13, 8);
            this.lblAttendStatus.Name = "lblAttendStatus";
            this.lblAttendStatus.Size = new System.Drawing.Size(0, 25);
            this.lblAttendStatus.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 445);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Attendance Time: ";
            // 
            // lblAttendTime
            // 
            this.lblAttendTime.AutoSize = true;
            this.lblAttendTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendTime.Location = new System.Drawing.Point(14, 8);
            this.lblAttendTime.Name = "lblAttendTime";
            this.lblAttendTime.Size = new System.Drawing.Size(0, 25);
            this.lblAttendTime.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Tan;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(214, 542);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 41);
            this.btnClose.TabIndex = 36;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMark
            // 
            this.btnMark.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMark.Location = new System.Drawing.Point(432, 542);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(173, 41);
            this.btnMark.TabIndex = 35;
            this.btnMark.Text = "Mark";
            this.btnMark.UseVisualStyleBackColor = false;
            this.btnMark.Visible = false;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblEmpName);
            this.panel2.Location = new System.Drawing.Point(32, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 39);
            this.panel2.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblDepartName);
            this.panel3.Location = new System.Drawing.Point(346, 248);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 39);
            this.panel3.TabIndex = 37;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblDesignName);
            this.panel4.Location = new System.Drawing.Point(23, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(291, 39);
            this.panel4.TabIndex = 37;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.lblAttendStatus);
            this.panel5.Location = new System.Drawing.Point(346, 351);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 39);
            this.panel5.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 31;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.lblAttendTime);
            this.panel6.Location = new System.Drawing.Point(214, 441);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(338, 39);
            this.panel6.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 25);
            this.label8.TabIndex = 31;
            // 
            // AttendanceData
            // 
            this.AttendanceData.AllowUserToAddRows = false;
            this.AttendanceData.AllowUserToDeleteRows = false;
            this.AttendanceData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.AttendanceData.ColumnHeadersHeight = 29;
            this.AttendanceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AttendanceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpName,
            this.AttendType,
            this.Attendance});
            this.AttendanceData.Cursor = System.Windows.Forms.Cursors.Default;
            this.AttendanceData.Location = new System.Drawing.Point(923, 245);
            this.AttendanceData.Name = "AttendanceData";
            this.AttendanceData.ReadOnly = true;
            this.AttendanceData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.AttendanceData.RowTemplate.Height = 24;
            this.AttendanceData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendanceData.Size = new System.Drawing.Size(551, 334);
            this.AttendanceData.TabIndex = 40;
            // 
            // EmpName
            // 
            this.EmpName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.Frozen = true;
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            this.EmpName.Width = 170;
            // 
            // AttendType
            // 
            this.AttendType.DataPropertyName = "AttendType";
            this.AttendType.Frozen = true;
            this.AttendType.HeaderText = "Attend Type";
            this.AttendType.MinimumWidth = 6;
            this.AttendType.Name = "AttendType";
            this.AttendType.ReadOnly = true;
            this.AttendType.Width = 125;
            // 
            // Attendance
            // 
            this.Attendance.DataPropertyName = "Attendance";
            this.Attendance.Frozen = true;
            this.Attendance.HeaderText = "Time";
            this.Attendance.MinimumWidth = 6;
            this.Attendance.Name = "Attendance";
            this.Attendance.ReadOnly = true;
            this.Attendance.Width = 200;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(664, 137);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(233, 22);
            this.txtDate.TabIndex = 41;
            this.txtDate.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(23, 542);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 41);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.lblheadingtxt);
            this.panel8.Location = new System.Drawing.Point(664, 165);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(810, 71);
            this.panel8.TabIndex = 43;
            // 
            // lblheadingtxt
            // 
            this.lblheadingtxt.AutoSize = true;
            this.lblheadingtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheadingtxt.Location = new System.Drawing.Point(35, 21);
            this.lblheadingtxt.Name = "lblheadingtxt";
            this.lblheadingtxt.Size = new System.Drawing.Size(0, 38);
            this.lblheadingtxt.TabIndex = 31;
            // 
            // cboReaders
            // 
            this.cboReaders.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboReaders.Location = new System.Drawing.Point(923, 135);
            this.cboReaders.Margin = new System.Windows.Forms.Padding(4);
            this.cboReaders.Name = "cboReaders";
            this.cboReaders.Size = new System.Drawing.Size(211, 24);
            this.cboReaders.TabIndex = 47;
            this.cboReaders.Visible = false;
            // 
            // lblSelectReader
            // 
            this.lblSelectReader.Location = new System.Drawing.Point(919, 116);
            this.lblSelectReader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectReader.Name = "lblSelectReader";
            this.lblSelectReader.Size = new System.Drawing.Size(161, 16);
            this.lblSelectReader.TabIndex = 46;
            this.lblSelectReader.Text = "Select Reader:";
            this.lblSelectReader.Visible = false;
            // 
            // lblPlaceFinger
            // 
            this.lblPlaceFinger.Location = new System.Drawing.Point(661, 568);
            this.lblPlaceFinger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlaceFinger.Name = "lblPlaceFinger";
            this.lblPlaceFinger.Size = new System.Drawing.Size(195, 23);
            this.lblPlaceFinger.TabIndex = 44;
            this.lblPlaceFinger.Text = "Place a finger on the reader";
            // 
            // pbFingerprint
            // 
            this.pbFingerprint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFingerprint.Location = new System.Drawing.Point(664, 248);
            this.pbFingerprint.Margin = new System.Windows.Forms.Padding(4);
            this.pbFingerprint.Name = "pbFingerprint";
            this.pbFingerprint.Size = new System.Drawing.Size(234, 316);
            this.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFingerprint.TabIndex = 45;
            this.pbFingerprint.TabStop = false;
            // 
            // btnFinger
            // 
            this.btnFinger.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinger.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinger.Location = new System.Drawing.Point(706, 587);
            this.btnFinger.Name = "btnFinger";
            this.btnFinger.Size = new System.Drawing.Size(119, 41);
            this.btnFinger.TabIndex = 48;
            this.btnFinger.Text = "Go";
            this.btnFinger.UseVisualStyleBackColor = false;
            this.btnFinger.Click += new System.EventHandler(this.btnFinger_Click);
            // 
            // FrmEmployeeQuickAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 640);
            this.Controls.Add(this.btnFinger);
            this.Controls.Add(this.cboReaders);
            this.Controls.Add(this.lblSelectReader);
            this.Controls.Add(this.lblPlaceFinger);
            this.Controls.Add(this.pbFingerprint);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.AttendanceData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSearchUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Name = "FrmEmployeeQuickAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Quick Attendance";
            this.Load += new System.EventHandler(this.FrmEmployeeQuickAttendance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceData)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDepartName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDesignName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAttendStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblAttendTime;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView AttendanceData;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DateTimePicker txtDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblheadingtxt;
        internal System.Windows.Forms.ComboBox cboReaders;
        internal System.Windows.Forms.Label lblSelectReader;
        internal System.Windows.Forms.Label lblPlaceFinger;
        internal System.Windows.Forms.PictureBox pbFingerprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Attendance;
        private System.Windows.Forms.Button btnFinger;
    }
}