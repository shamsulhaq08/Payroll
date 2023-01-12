using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Salary
    {

        public Int64 SalaryID { get; set; }
        public DateTime SallaryMonth { get; set; }
        public DateTime Enterydate { get; set; }
        public Int32 DepID { get; set; }
        public Int32 DesignID { get; set; }
        public Int32 EmpID { get; set; }
        public string Remarks { get; set; }
        public decimal TotalSalary { get; set; }


    }
}