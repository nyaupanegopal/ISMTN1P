using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class InheritanceExample
    {
        public static void Main()
        {
         
           
            
            Console.WriteLine("Enter Employee Type; 1 for Full Time Emp and 2 for PartTime EMp");
            int EmpType=Convert.ToInt32(Console.ReadLine());
            if(EmpType==1)
            {
                FullTimeEmp fte=new FullTimeEmp();
                Console.WriteLine("Enter Employee Name");
                fte.EmpName = Console.ReadLine();
                Console.WriteLine("Enter Monthly Salary");
                fte.MonthlySalary=Convert.ToInt32(Console.ReadLine());

                fte.TotalSAlary = 12 * fte.MonthlySalary;
                //NAme of Emp is dipesh and ....."
                Console.WriteLine("Name of Emp: " + fte.EmpName);//String Concat
                Console.WriteLine("Total Salary Of Emp: " + fte.TotalSAlary);
            }
            else
            {
                PartTimeEmp partTimeEmp=new PartTimeEmp();
                Console.WriteLine("Enter Employee Name");
                partTimeEmp.EmpName = Console.ReadLine();
                Console.WriteLine("Enter Working Hour");
                partTimeEmp.WorkingHour=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Hourly RAte");
                partTimeEmp.HourlyRate=Convert.ToInt32(Console.ReadLine());

                partTimeEmp.TotalSAlary=partTimeEmp.HourlyRate*partTimeEmp.WorkingHour;

                Console.WriteLine("Name of Emp: " + partTimeEmp.EmpName);
                Console.WriteLine("Total Salary Of Emp: " + partTimeEmp.TotalSAlary);
            }
           
            Console.ReadLine();
        }

    }
     class Employee
    {
        public string EmpName;
        public int EmployeeType;
        public int TotalSAlary;
    }
    class FullTimeEmp:Employee
    {
        public int MonthlySalary;
        
    }
    class PartTimeEmp:Employee
    {
        public int HourlyRate;
        public int WorkingHour;
    }
}
