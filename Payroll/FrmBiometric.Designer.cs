
namespace Payroll
{
    partial class FrmBiometric
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblPlaceFinger = new System.Windows.Forms.Label();
            this.pbFingerprint = new System.Windows.Forms.PictureBox();
            this.cboReaders = new System.Windows.Forms.ComboBox();
            this.lblSelectReader = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(241, 479);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            // 
            // lblPlaceFinger
            // 
            this.lblPlaceFinger.Location = new System.Drawing.Point(46, 484);
            this.lblPlaceFinger.Name = "lblPlaceFinger";
            this.lblPlaceFinger.Size = new System.Drawing.Size(187, 19);
            this.lblPlaceFinger.TabIndex = 8;
            this.lblPlaceFinger.Text = "Place a finger on the reader";
            // 
            // pbFingerprint
            // 
            this.pbFingerprint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbFingerprint.Location = new System.Drawing.Point(47, 105);
            this.pbFingerprint.Name = "pbFingerprint";
            this.pbFingerprint.Size = new System.Drawing.Size(256, 360);
            this.pbFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFingerprint.TabIndex = 9;
            this.pbFingerprint.TabStop = false;
            // 
            // cboReaders
            // 
            this.cboReaders.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboReaders.Location = new System.Drawing.Point(44, 539);
            this.cboReaders.Name = "cboReaders";
            this.cboReaders.Size = new System.Drawing.Size(262, 24);
            this.cboReaders.TabIndex = 16;
            // 
            // lblSelectReader
            // 
            this.lblSelectReader.Location = new System.Drawing.Point(41, 510);
            this.lblSelectReader.Name = "lblSelectReader";
            this.lblSelectReader.Size = new System.Drawing.Size(262, 26);
            this.lblSelectReader.TabIndex = 15;
            this.lblSelectReader.Text = "Select Reader:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(44, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(262, 41);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmpID
            // 
            this.txtEmpID.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtEmpID.Enabled = false;
            this.txtEmpID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpID.Location = new System.Drawing.Point(44, 53);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(262, 34);
            this.txtEmpID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "Employee ID";
            // 
            // FrmBiometric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 641);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboReaders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectReader);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPlaceFinger);
            this.Controls.Add(this.pbFingerprint);
            this.Name = "FrmBiometric";
            this.Text = "FrmBiometric";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBiometric_FormClosing);
            this.Load += new System.EventHandler(this.FrmBiometric_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFingerprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnBack;
        internal System.Windows.Forms.Label lblPlaceFinger;
        internal System.Windows.Forms.PictureBox pbFingerprint;
        internal System.Windows.Forms.ComboBox cboReaders;
        internal System.Windows.Forms.Label lblSelectReader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmpID;
        internal System.Windows.Forms.Label label1;
    }
}