using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public string FatherName { get; set; }
        public DateTime DateofBirth { get; set; }
        public DateTime DateofJoining { get; set; }
        public string ContactNo { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Int16 Gender { get; set; }
        public bool IsLeft { get; set; }
        public int DesigID { get; set; }
        public int DepID { get; set; }
    
        public int MachineNo { get; set; }
        public decimal BasicSalary { get; set; }

        public byte[] EmpPic { get; set; }


    }
}
