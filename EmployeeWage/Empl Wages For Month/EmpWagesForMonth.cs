using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class EmpWagesForMonth
    {
        public const int Parttime = 1;
        public const int Fulltime = 2;
        public const int HrsRate = 20;
        public const int WorkingDays = 20;

        public void WagesForMonth()
        {
            //veriables
            int empHrs = 0;
            int empWages = 0;
            int totalEmpWages = 0;
            //computation
            for (int day = 0; day < WorkingDays; day++)
            {
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case Parttime:
                        empHrs = 4;
                        break;
                    case Fulltime:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWages = empHrs * HrsRate;
                totalEmpWages += empWages;
                Console.WriteLine("Emp Wage:" + empWages);
            }
            Console.WriteLine("Total Emp Wage:" + totalEmpWages);
        }
    }
}
