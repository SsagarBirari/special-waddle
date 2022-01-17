using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpRate
    {
        public void CheckEmpPerHrsRate()
        {
            //constants
            int FullTime = 1;
            int HrsRate = 20;

            //veriables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //computation
            int empcheck = random.Next(0, 2);
            if (empcheck == FullTime)
            {
                empHrs = 8;
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
