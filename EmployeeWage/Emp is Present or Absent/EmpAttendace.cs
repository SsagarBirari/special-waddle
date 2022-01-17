using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpAttendace
    {
        public void checkempattendance()
        {
            int FullTime = 1;
            Random random = new Random();
            int empcheck=random.Next(0,2);
            if(empcheck==FullTime)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
