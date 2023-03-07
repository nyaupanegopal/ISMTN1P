using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Calculate
    {
        int a = 10;
        int b = 20;
        int c = 30;

        //Access_Modifier return_type idetifier (input Param)
        //{}
        public int Sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        //Method Def
        public int Mult(int a, int b, int c)
        {
            return a * b * c;
        }
        public Calculate()//USer Defined Constructor
        {
            a = 30;
            b = 40;
            c = 50;
            Console.WriteLine("User Defined Constructer Called");
        }
        public Calculate(int firstValue,int secondValue, int thirdValue)
        {
            a = firstValue;
            b= secondValue;
            c = thirdValue;
        }
        public Calculate(int firstValue, int secondValue, string thirdValue)
        {
            a = firstValue;
            b = secondValue;
        }
        public Calculate(int firstValue)
        {
            a = firstValue;
           
        }
        public Calculate(int firstValue, int secondValue)
        {
            a = firstValue;
            b = secondValue;
        }
        public static void Main4324()
        {

            int c = 30;
            int d = 40;
            Calculate cal = new Calculate();//user defined Constructor
            Calculate cal1 = new Calculate(1);
            Calculate cal2 = new Calculate(1,2);

            int sum = cal.Sum(cal.a, cal.b);
            int Sub= cal.Sub(cal.a,cal.b);
            Console.WriteLine(sum);
            int sum1 = cal.Sum(c, d);
            Console.WriteLine(sum1);
            int mult = cal.Mult(cal.a, cal.b, cal.c);
            Console.WriteLine(mult);
            Console.ReadLine();
        }


    }
}
