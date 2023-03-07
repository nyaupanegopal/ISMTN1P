using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Task2
    {
        int Result;
        
        
        public Task2(int a,int b)
        {
            Result = a + b; ;
        }
        public static void Main4343()
        {
            Task2 task=new Task2(432,43);
            Console.WriteLine(task.Result);
            Console.ReadLine();
        }
    }
}
