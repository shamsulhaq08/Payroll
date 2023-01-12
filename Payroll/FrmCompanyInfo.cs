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
    public partial class FrmCompanyInfo : Form
    {
        DAL.CompanyInfo objDAL = new DAL.CompanyInfo();
        Byte[] openedBLOBData = new Byte[0];
        public FrmCompanyInfo()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //txtCompanyName.Focus();
            this.ActiveControl = txtCompanyName;

            DataTable du = objDAL.getRecord();

            if (du.Rows.Count > 0)
            {
                txtCompanyName.Text = du.Rows[0]["CompanyName"].ToString();
                txtWebsite.Text = du.Rows[0]["Website"].ToString();
                txtContactNumber.Text = du.Rows[0]["ContactNo"].ToString();
                txtAddress.Text = du.Rows[0]["Address"].ToString();
         
                if (du.Rows[0]["Logo"].ToString() != string.Empty)
                {
                    Byte[] byteBLOBData = new Byte[0];
                    openedBLOBData = byteBLOBData = (Byte[])(du.Rows[0]["Logo"]);

                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    stmBLOBData.Seek(0, SeekOrigin.Begin);
                    CompanyLogo.Image = Image.FromStream(stmBLOBData);
                }
            }
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {

            Objects.CompanyInfo obj = new Objects.CompanyInfo();

            obj.CompanyName = txtCompanyName.Text;
            obj.Website = txtWebsite.Text;
            obj.ContactNumber = txtContactNumber.Text;
            obj.Address = txtAddress.Text;

            if (CompanyLogo.ImageLocation != null)
            {
                FileInfo finfo = new FileInfo(CompanyLogo.ImageLocation);
                byte[] btImage = new byte[finfo.Length];
                FileStream fStream = finfo.OpenRead();
                fStream.Read(btImage, 0, btImage.Length);
                fStream.Close();
                obj.Logo = btImage;
            }
            else 
            if (openedBLOBData.Length > 0)
            {
                obj.Logo = openedBLOBData;
            }

             objDAL.DeleteRecord();
             objDAL.InsertRecord(obj);

             MessageBox.Show("Data Successfully Saved", "Message Box", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {


            openFileDialog1.ShowDialog();
            CompanyLogo.Load(openFileDialog1.FileName);
            CompanyLogo.Tag = openFileDialog1.FileName;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CompanyLogo.Image = null;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
