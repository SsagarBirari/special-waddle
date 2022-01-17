using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpTime
    {
        public void CheckPartOrFullTime()
        {
            //constants
            int Parttime = 1;
            int Fulltime = 2;
            int HrsRate = 20;

            //veriables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //computation
            int empcheck = random.Next(0, 3);
            if(empcheck==Parttime)
            {
                empHrs = 8;
            }
            else if(empcheck==Fulltime)
            {
                empHrs = 16;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * HrsRate;
            Console.WriteLine("Emp Wages:" + empWage);
        }
    }
}
