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
    public partial class ReportViewer : Form
    {
        public ReportViewer()
        {
            InitializeComponent();
        }
        public void PrintEmployeeList(DataTable dt)
        {
            rptEmployeeList rpt = new rptEmployeeList();
            rpt.Database.Tables[0].SetDataSource(dt);
            crystalReportViewer.ReportSource = rpt;
        }
    }
}
