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
  

    public partial class FrmCompanyInfoReport : Form
    {
        DAL.CompanyInfo objDAL = new DAL.CompanyInfo();
        public FrmCompanyInfoReport()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DataTable dt = objDAL.getRecord();

            Reports.CompanyReport rpt = new Reports.CompanyReport();
            rpt.PrintCompanyReport(dt);
            rpt.ShowDialog();


        }




        
    }
}
