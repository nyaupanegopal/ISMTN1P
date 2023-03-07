using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class SwitchStatement
    {
        public static void Main1()
        {
            Console.WriteLine("Enter any number");
            int no=Convert.ToInt32(Console.ReadLine());
            switch (no)
            {
                case 1:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
            }
            //switch (sn)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("Ashma");
            //            break;
            //        }
            //        case 2:
            //        {
            //            Console.WriteLine("Amardip");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("Not Found");
            //            break;
            //        }
            //}

        }
    }
}
