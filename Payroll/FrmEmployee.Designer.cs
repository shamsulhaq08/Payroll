
namespace Payroll
{
    partial class FrmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMachineNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBasicSalary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.EmpPic = new System.Windows.Forms.PictureBox();
            this.CmbGender = new System.Windows.Forms.ComboBox();
            this.DateofBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.imgClear = new System.Windows.Forms.Button();
            this.EmpGridData = new System.Windows.Forms.DataGridView();
            this.EmpID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.checkIsLeft = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtfilter = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DateofJoining = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label14 = new System.Windows.Forms.Label();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMachineNo);
            this.panel1.Location = new System.Drawing.Point(2, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 105);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(921, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee";
            // 
            // txtMachineNo
            // 
            this.txtMachineNo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMachineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachineNo.Location = new System.Drawing.Point(685, 69);
            this.txtMachineNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMachineNo.Name = "txtMachineNo";
            this.txtMachineNo.Size = new System.Drawing.Size(106, 34);
            this.txtMachineNo.TabIndex = 6;
            this.txtMachineNo.Visible = false;
            this.txtMachineNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMachineNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employee Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(305, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Father Name";
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicSalary.Location = new System.Drawing.Point(152, 462);
            this.txtBasicSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(120, 34);
            this.txtBasicSalary.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(418, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Date of Joining";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(305, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(24, 536);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(257, 65);
            this.txtAddress.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 434);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Gender";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(498, 825);
            this.textBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(422, 34);
            this.textBox7.TabIndex = 3;
            // 
            // EmpPic
            // 
            this.EmpPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmpPic.Location = new System.Drawing.Point(310, 442);
            this.EmpPic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmpPic.Name = "EmpPic";
            this.EmpPic.Size = new System.Drawing.Size(264, 114);
            this.EmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmpPic.TabIndex = 7;
            this.EmpPic.TabStop = false;
            // 
            // CmbGender
            // 
            this.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbGender.FormattingEnabled = true;
            this.CmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.CmbGender.Location = new System.Drawing.Point(24, 462);
            this.CmbGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmbGender.Name = "CmbGender";
            this.CmbGender.Size = new System.Drawing.Size(104, 30);
            this.CmbGender.TabIndex = 10;
            // 
            // DateofBirth
            // 
            this.DateofBirth.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateofBirth.CustomFormat = "dd/mm/yyyy";
            this.DateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateofBirth.Location = new System.Drawing.Point(269, 151);
            this.DateofBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateofBirth.Name = "DateofBirth";
            this.DateofBirth.Size = new System.Drawing.Size(151, 28);
            this.DateofBirth.TabIndex = 11;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpName.Location = new System.Drawing.Point(24, 227);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(257, 34);
            this.txtEmpName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(310, 304);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(265, 34);
            this.txtEmail.TabIndex = 3;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(24, 308);
            this.txtContactNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(257, 34);
            this.txtContactNo.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(309, 565);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 36);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // imgClear
            // 
            this.imgClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgClear.Location = new System.Drawing.Point(493, 565);
            this.imgClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.imgClear.Name = "imgClear";
            this.imgClear.Size = new System.Drawing.Size(81, 36);
            this.imgClear.TabIndex = 14;
            this.imgClear.Text = "Clear";
            this.imgClear.UseVisualStyleBackColor = true;
            this.imgClear.Click += new System.EventHandler(this.imgClear_Click);
            // 
            // EmpGridData
            // 
            this.EmpGridData.AllowUserToAddRows = false;
            this.EmpGridData.AllowUserToDeleteRows = false;
            this.EmpGridData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpGridData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpGridData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmpID,
            this.EmpName});
            this.EmpGridData.Location = new System.Drawing.Point(599, 189);
            this.EmpGridData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EmpGridData.Name = "EmpGridData";
            this.EmpGridData.ReadOnly = true;
            this.EmpGridData.RowHeadersWidth = 51;
            this.EmpGridData.RowTemplate.Height = 24;
            this.EmpGridData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpGridData.Size = new System.Drawing.Size(408, 411);
            this.EmpGridData.TabIndex = 15;
            this.EmpGridData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpGridData_CellContentClick);
            this.EmpGridData.Click += new System.EventHandler(this.EmpGridData_Click);
            // 
            // EmpID
            // 
            this.EmpID.DataPropertyName = "EmpID";
            this.EmpID.HeaderText = "Employee ID";
            this.EmpID.MinimumWidth = 6;
            this.EmpID.Name = "EmpID";
            this.EmpID.ReadOnly = true;
            // 
            // EmpName
            // 
            this.EmpName.DataPropertyName = "EmpName";
            this.EmpName.HeaderText = "Employee name";
            this.EmpName.MinimumWidth = 6;
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 25);
            this.label11.TabIndex = 4;
            this.label11.Text = "Department";
            // 
            // checkIsLeft
            // 
            this.checkIsLeft.AutoSize = true;
            this.checkIsLeft.Location = new System.Drawing.Point(156, 147);
            this.checkIsLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkIsLeft.Name = "checkIsLeft";
            this.checkIsLeft.Size = new System.Drawing.Size(79, 28);
            this.checkIsLeft.TabIndex = 16;
            this.checkIsLeft.Text = "Is Left";
            this.checkIsLeft.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(319, 632);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 36);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Tan;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(629, 632);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(151, 36);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelect.Location = new System.Drawing.Point(474, 632);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(151, 36);
            this.btnSelect.TabIndex = 20;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(171, 632);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 36);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(23, 632);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(144, 36);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(24, 391);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(257, 30);
            this.cmbDepartment.TabIndex = 10;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(310, 387);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(265, 30);
            this.cmbDesignation.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(305, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 25);
            this.label12.TabIndex = 4;
            this.label12.Text = "Designation";
            // 
            // txtfilter
            // 
            this.txtfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfilter.Location = new System.Drawing.Point(599, 148);
            this.txtfilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtfilter.Name = "txtfilter";
            this.txtfilter.Size = new System.Drawing.Size(408, 34);
            this.txtfilter.TabIndex = 3;
            this.txtfilter.TextChanged += new System.EventHandler(this.txtfilter_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(594, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Filter";
            // 
            // DateofJoining
            // 
            this.DateofJoining.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateofJoining.CustomFormat = "dd/mm/yyyy";
            this.DateofJoining.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateofJoining.Location = new System.Drawing.Point(423, 151);
            this.DateofJoining.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DateofJoining.Name = "DateofJoining";
            this.DateofJoining.Size = new System.Drawing.Size(151, 28);
            this.DateofJoining.TabIndex = 11;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(147, 433);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Basic Salary";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.Location = new System.Drawing.Point(310, 227);
            this.txtFatherName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(257, 34);
            this.txtFatherName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(784, 632);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Thumb Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(26, 147);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(102, 34);
            this.txtEmpID.TabIndex = 6;
            // 
            // FrmEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1030, 691);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkIsLeft);
            this.Controls.Add(this.EmpGridData);
            this.Controls.Add(this.imgClear);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.DateofJoining);
            this.Controls.Add(this.DateofBirth);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.CmbGender);
            this.Controls.Add(this.EmpPic);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtfilter);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmployee";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpGridData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBasicSalary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.PictureBox EmpPic;
        private System.Windows.Forms.ComboBox CmbGender;
        private System.Windows.Forms.DateTimePicker DateofBirth;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button imgClear;
        private System.Windows.Forms.DataGridView EmpGridData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkIsLeft;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtfilter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker DateofJoining;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMachineNo;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEmpID;
    }
}