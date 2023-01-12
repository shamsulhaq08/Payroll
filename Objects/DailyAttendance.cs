using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class DailyAttendance
    {
        public Int64 ID { get; set; }
        public int EmployeeID { get; set; }
        public DateTime Attendance { get; set; }
        public string Remarks { get; set; }
        public Int32 AttendType { get; set; }
    }
}
