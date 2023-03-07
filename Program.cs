using System;

static class Test
{
    // public static string CheckNumber(int num)
    //{
    //    if (num == 0) return "zeri";
    //    if (num % 2 == 0) return "positive";
    //    return "Negative";
    //}
   
    public static void Main1()//method
    {
        /*
        int SAlary = 1000000;
        if (SAlary > 1000000)
        {
            Console.WriteLine("Very Good");
        }
        
        else if (SAlary > 100000)
        {
            Console.WriteLine("Good");
        }

        else
        {
            Console.WriteLine("Not Good");
        }
        Console.ReadLine(); */

        //string result = Test.CheckNumber(-10);
        //Console.WriteLine(result);
        //Console.ReadLine();
        

        Console.WriteLine("Enter any Number");
        int no = Convert.ToInt32(Console.ReadLine());
        if(no>0)
        {
            Console.WriteLine("Positive");
        }
        else if(no<0)
        {
            Console.WriteLine("Negative No");
        }
        else
        {
            Console.WriteLine("Zero");
        }
        Console.ReadLine();

    }
}



