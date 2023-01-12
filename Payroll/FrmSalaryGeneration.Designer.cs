
namespace Payroll
{
    partial class FrmSalaryGeneration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterDate = new System.Windows.Forms.DateTimePicker();
            this.DepartmentData = new System.Windows.Forms.DataGridView();
            this.SalaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SallaryMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGenerationDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalaryMonth = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDepartment2 = new System.Windows.Forms.ComboBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.GridSalary = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BasicSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leaves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnPrint = new System.Windows.Forms.Button();
            this.txtSalaryID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 105);
            this.panel1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salary Generation";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(438, 269);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(224, 30);
            this.cmbDepartment.TabIndex = 41;
            this.cmbDepartment.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartment_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(207, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 40;
            this.label6.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 40;
            this.label2.Text = "Filter";
            // 
            // FilterDate
            // 
            this.FilterDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterDate.CustomFormat = "MMM/yyyy";
            this.FilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FilterDate.Location = new System.Drawing.Point(21, 170);
            this.FilterDate.Name = "FilterDate";
            this.FilterDate.Size = new System.Drawing.Size(172, 22);
            this.FilterDate.TabIndex = 42;
            this.FilterDate.ValueChanged += new System.EventHandler(this.FilterDate_ValueChanged);
            // 
            // DepartmentData
            // 
            this.DepartmentData.AllowUserToAddRows = false;
            this.DepartmentData.AllowUserToDeleteRows = false;
            this.DepartmentData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DepartmentData.ColumnHeadersHeight = 29;
            this.DepartmentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DepartmentData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalaryID,
            this.SallaryMonth,
            this.DepName});
            this.DepartmentData.Cursor = System.Windows.Forms.Cursors.Default;
            this.DepartmentData.Location = new System.Drawing.Point(16, 232);
            this.DepartmentData.Name = "DepartmentData";
            this.DepartmentData.ReadOnly = true;
            this.DepartmentData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DepartmentData.RowTemplate.Height = 24;
            this.DepartmentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepartmentData.Size = new System.Drawing.Size(398, 482);
            this.DepartmentData.TabIndex = 43;
            this.DepartmentData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentData_CellClick);
            // 
            // SalaryID
            // 
            this.SalaryID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SalaryID.DataPropertyName = "SalaryID";
            this.SalaryID.Frozen = true;
            this.SalaryID.HeaderText = "ID";
            this.SalaryID.MinimumWidth = 6;
            this.SalaryID.Name = "SalaryID";
            this.SalaryID.ReadOnly = true;
            this.SalaryID.Width = 50;
            // 
            // SallaryMonth
            // 
            this.SallaryMonth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SallaryMonth.DataPropertyName = "SallaryMonth";
            this.SallaryMonth.Frozen = true;
            this.SallaryMonth.HeaderText = "Month";
            this.SallaryMonth.MinimumWidth = 6;
            this.SallaryMonth.Name = "SallaryMonth";
            this.SallaryMonth.ReadOnly = true;
            this.SallaryMonth.Width = 125;
            // 
            // DepName
            // 
            this.DepName.DataPropertyName = "DepName";
            this.DepName.HeaderText = "Department";
            this.DepName.MinimumWidth = 6;
            this.DepName.Name = "DepName";
            this.DepName.ReadOnly = true;
            this.DepName.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 29);
            this.label3.TabIndex = 40;
            this.label3.Text = "Sheet #";
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTotalSalary.Enabled = false;
            this.txtTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSalary.Location = new System.Drawing.Point(954, 362);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(212, 30);
            this.txtTotalSalary.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(585, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 40;
            this.label4.Text = "Generation Date";
            // 
            // txtGenerationDate
            // 
            this.txtGenerationDate.CustomFormat = "dd/MM/yyyy";
            this.txtGenerationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtGenerationDate.Location = new System.Drawing.Point(590, 172);
            this.txtGenerationDate.Name = "txtGenerationDate";
            this.txtGenerationDate.Size = new System.Drawing.Size(172, 22);
            this.txtGenerationDate.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(814, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 29);
            this.label5.TabIndex = 40;
            this.label5.Text = "Salary Month";
            // 
            // txtSalaryMonth
            // 
            this.txtSalaryMonth.CustomFormat = "MMM/yyyy";
            this.txtSalaryMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtSalaryMonth.Location = new System.Drawing.Point(819, 173);
            this.txtSalaryMonth.Name = "txtSalaryMonth";
            this.txtSalaryMonth.Size = new System.Drawing.Size(172, 22);
            this.txtSalaryMonth.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Department";
            // 
            // cmbDepartment2
            // 
            this.cmbDepartment2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment2.FormattingEnabled = true;
            this.cmbDepartment2.Location = new System.Drawing.Point(212, 167);
            this.cmbDepartment2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDepartment2.Name = "cmbDepartment2";
            this.cmbDepartment2.Size = new System.Drawing.Size(207, 30);
            this.cmbDepartment2.TabIndex = 41;
            this.cmbDepartment2.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment2_SelectedIndexChanged);
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(689, 269);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(225, 30);
            this.cmbDesignation.TabIndex = 46;
            this.cmbDesignation.SelectionChangeCommitted += new System.EventHandler(this.cmbDesignation_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(691, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 29);
            this.label8.TabIndex = 45;
            this.label8.Text = "Designation";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(928, 269);
            this.cmbEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(238, 30);
            this.cmbEmployee.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(923, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 29);
            this.label10.TabIndex = 47;
            this.label10.Text = "Employee";
            // 
            // GridSalary
            // 
            this.GridSalary.AllowUserToAddRows = false;
            this.GridSalary.AllowUserToDeleteRows = false;
            this.GridSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GridSalary.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.GridSalary.ColumnHeadersHeight = 29;
            this.GridSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.dataGridViewTextBoxColumn2,
            this.BasicSalary,
            this.Presents,
            this.Leaves,
            this.NetSalary});
            this.GridSalary.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridSalary.Location = new System.Drawing.Point(438, 431);
            this.GridSalary.Name = "GridSalary";
            this.GridSalary.ReadOnly = true;
            this.GridSalary.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.GridSalary.RowTemplate.Height = 24;
            this.GridSalary.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridSalary.Size = new System.Drawing.Size(732, 283);
            this.GridSalary.TabIndex = 49;
            // 
            // EmpID
            // 
            this.EmpID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.EmpID.Frozen = true;
            this.EmpID.HeaderText = "Id";
            this.EmpID.MinimumWidth = 6;
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            this.EmpID.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // BasicSalary
            // 
            this.BasicSalary.HeaderText = "Basic Salary";
            this.BasicSalary.MinimumWidth = 6;
            this.BasicSalary.Name = "BasicSalary";
            this.BasicSalary.ReadOnly = true;
            this.BasicSalary.Width = 115;
            // 
            // Presents
            // 
            this.Presents.HeaderText = "Presents";
            this.Presents.MinimumWidth = 6;
            this.Presents.Name = "Presents";
            this.Presents.ReadOnly = true;
            this.Presents.Width = 93;
            // 
            // Leaves
            // 
            this.Leaves.HeaderText = "Leaves";
            this.Leaves.MinimumWidth = 6;
            this.Leaves.Name = "Leaves";
            this.Leaves.ReadOnly = true;
            this.Leaves.Width = 83;
            // 
            // NetSalary
            // 
            this.NetSalary.DataPropertyName = "NetSalary";
            this.NetSalary.HeaderText = "Net Salary";
            this.NetSalary.MinimumWidth = 6;
            this.NetSalary.Name = "NetSalary";
            this.NetSalary.ReadOnly = true;
            this.NetSalary.Width = 103;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(433, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 29);
            this.label11.TabIndex = 40;
            this.label11.Text = "Remarks";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarks.Location = new System.Drawing.Point(438, 362);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(344, 30);
            this.txtRemarks.TabIndex = 44;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerate.Location = new System.Drawing.Point(807, 357);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(125, 40);
            this.btnGenerate.TabIndex = 50;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(949, 320);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 29);
            this.label12.TabIndex = 40;
            this.label12.Text = "Total Salary";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(403, 741);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 41);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Tan;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(989, 741);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 41);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect.Location = new System.Drawing.Point(601, 741);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(181, 41);
            this.btnSelect.TabIndex = 54;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(212, 741);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(173, 41);
            this.btnClear.TabIndex = 52;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(16, 741);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 41);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.BackColor = System.Drawing.Color.LightCoral;
            this.BtnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnPrint.Location = new System.Drawing.Point(796, 741);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(173, 41);
            this.BtnPrint.TabIndex = 52;
            this.BtnPrint.Text = "Print";
            this.BtnPrint.UseVisualStyleBackColor = false;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // txtSalaryID
            // 
            this.txtSalaryID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtSalaryID.Enabled = false;
            this.txtSalaryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryID.Location = new System.Drawing.Point(446, 167);
            this.txtSalaryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalaryID.Name = "txtSalaryID";
            this.txtSalaryID.Size = new System.Drawing.Size(102, 34);
            this.txtSalaryID.TabIndex = 57;
            // 
            // FrmSalaryGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 803);
            this.Controls.Add(this.txtSalaryID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.GridSalary);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.txtTotalSalary);
            this.Controls.Add(this.DepartmentData);
            this.Controls.Add(this.txtSalaryMonth);
            this.Controls.Add(this.txtGenerationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FilterDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDepartment2);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSalaryGeneration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Generation";
            this.Load += new System.EventHandler(this.FrmSalaryGeneration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FilterDate;
        private System.Windows.Forms.DataGridView DepartmentData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtGenerationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtSalaryMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDepartment2;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView GridSalary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnPrint;
        private System.Windows.Forms.TextBox txtSalaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn BasicSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Leaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SallaryMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepName;
    }
}