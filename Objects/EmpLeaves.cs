using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
   public class EmpLeaves
    {
        public int EmpLeaveID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime LeaveFrom { get; set; }
        public DateTime LeaveTo { get; set; }
        public string Remarks { get; set; }
    }
}
