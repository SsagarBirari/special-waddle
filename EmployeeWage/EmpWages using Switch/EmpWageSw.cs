using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmpWageSw
    {
        public const int Parttime= 1;
        public const int Fulltime= 2;
        public const int HrsRate= 20;

        public void Empwages()
        {
            //veriables
            int empHrs = 0;
            int empWages = 0;
            Random random = new Random();

            //computation
            int empcheck = random.Next(0, 3);
            switch(empcheck)
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
            Console.WriteLine("Emp Wage:" + empWages);
        }
    }
}
