// See https://aka.ms/new-console-template for more information
namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation Program on Master Branch");
            //EmpAttendace emp=new EmpAttendace();
            //emp.checkempattendance();
            //EmpRate rate = new EmpRate();
            //rate.CheckEmpPerHrsRate();
            //EmpTime time = new EmpTime();
            //time.CheckPartOrFullTime();
            //EmpWageSw empWageSw = new EmpWageSw();
            //empWageSw.Empwages();
            //EmpWagesForMonth empWagesM=new EmpWagesForMonth();
            //empWagesM.WagesForMonth();
            MaxWorkingHrsInMonth maxWorkingHrsInMonth = new MaxWorkingHrsInMonth();
            maxWorkingHrsInMonth.MaxWorkingHrs();

            Console.ReadLine();
        }

    }
    
}

