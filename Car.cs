using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Car
    {
        public string Brand;
        public string Model;
        public string Price;
    }
    class Suzuki : Car
    {
        public static void Main1()
        {
            Suzuki suzuki = new Suzuki();
            suzuki.Brand = "Suzuki";
            suzuki.Model = "----";
            suzuki.Price = "10000$";

            Console.WriteLine("Brand: "+suzuki.Brand+
                "Model"+ suzuki.Model+
                "Price"+suzuki.Price
                );
        }
    }
    class Honda:Car
    {
        public double discountPrice;

        public static void Main()
        {
            Honda honda = new Honda();
            honda.Model = "Civic";
            honda.Brand = "Honda";
            honda.Price = "100000";
            //honda.discountPrice = Convert.ToInt32(honda.Price) * 0.01;
            honda.discountPrice = honda.CalculateDiscountPrice("10000");

        }
        public double CalculateDiscountPrice(string price)
        {
            double discountPrice = Convert.ToInt32(price) * 0.01;
            return discountPrice;
        }
    }
}
