using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class MaxWorkingHrsInMonth
    {
        public const int Parttime = 1;
        public const int Fulltime = 2;
        public const int HrsRate = 20;
        public const int WorkingDays = 20;
        public const int MaxHrsmonth = 100;

        public void MaxWorkingHrs()
        {
            //veriables
            int empHrs = 0;
            int totalempHrs = 0;
            int totalWorkingDays = 0;
            //computation
            while (totalempHrs <= MaxHrsmonth && totalWorkingDays < WorkingDays)
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
                totalempHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays+ "Emp Hrs:" + empHrs);
            }
            int totalEmpWages = totalempHrs * HrsRate;
            Console.WriteLine("Total Emp Wage:" + totalEmpWages);
        }
    }
}
