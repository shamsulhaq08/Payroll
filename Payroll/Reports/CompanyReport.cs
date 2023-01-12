using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll.Reports
{
    public partial class CompanyReport : Form
    {
        public CompanyReport()
        {
            InitializeComponent();
        }

        public void PrintCompanyReport(DataTable dt)
        {
            CompanyCrystalReport rpt = new CompanyCrystalReport();
            rpt.Database.Tables[0].SetDataSource(dt);
            crystalReportViewer5.ReportSource = rpt;
        }
    }
}
