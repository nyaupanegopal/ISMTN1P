using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Class1
    {
        public static void Main121()
        {
            Console.WriteLine("Enter Any Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number%9==0)
            {
                Console.WriteLine("Divisible by 9");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }
            Console.ReadLine();
        }
    }
}
