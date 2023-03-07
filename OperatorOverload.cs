using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Employees
    {
        public int salary;
        public int TotalSales ;
        public Employees(int _salary,int _totalsales)
        {
            salary = _salary;
            TotalSales = _totalsales;
        }
        public static void Main()
        {
            Employees ram=new Employees(5000,50000);
            Employees sam=new Employees(1000,10000);
            Employees hari = new Employees(4000,40000);
            Employees gita = new Employees(3000,30000);
        
            var result=ram-sam;
        
        }
        public static double operator +(Employees obj, Employees obj1)
        {
            int salary=obj.salary+obj1.salary;
            int totalsales = obj.TotalSales + obj1.TotalSales;
            double salarywithBonus = salary + totalsales * 0.2;
            return salarywithBonus;
        }
       

       



    }
    public class test1
    {
        int x;
        int y;
        public static void Main()
        {
            test1 obj = new test1();
            test1 obj1 = new test1();
            var sumresult = obj + obj1;
            var intresult = obj.x + obj.y;
        }
        public static int operator +(test1 a, test1 b)
        {
            
            var result=a.x + b.x+a.y+b.y;
            return result;
        }
    }

}
