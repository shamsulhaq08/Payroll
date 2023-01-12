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
    public partial class SalaryViewer : Form
    {
        public SalaryViewer()
        {
            InitializeComponent();
        }

        public void SalaryviewerPrint(DataTable dt)
        {
            rptSalaryviewer rpt = new rptSalaryviewer();
            rpt.Database.Tables[0].SetDataSource(dt);
            crystalReportViewer2.ReportSource = rpt;
        }
    }
}
