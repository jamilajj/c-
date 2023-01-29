using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Transactions;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {






            //int Max = (0);
            //int[] numbers = { 14, 17, 34, 0, 64,90 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > Max)
            //        Max = numbers[i];
            //}

            //Console.WriteLine(Max);


            //int num = 0;
            //Console.WriteLine("uc eded daxil edin");
            //num = Convert.ToInt32(Console.ReadLine());








            //int[] nums = { 1, 2, 3, 36, 45, 46, 57, };
            // bool hasWantedNumber = false;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] >0)
            //    {
            //        continue;
            //    }
            //    hasWantedNumber = true;
            //    break;

            //}
            //if (hasWantedNumber == true)
            //{
            //    Console.WriteLine("var");
            //}
            //else
            //{
            //    Console.WriteLine("yox");
            //}













            //Console.WriteLine("0-100 arasi eded daxil edin");
            //string nstr = Console.ReadLine();
            //int n = Convert.ToInt32(nstr);
            //while ( n < 0 || n > 100) 
            //{
            //    Console.WriteLine("bir daha daxil edin");
            //    nstr = Console.ReadLine();
            //     n = Convert.ToInt32(nstr);
            //    break;
            //}
            //if (n > 64)
            //{
            //    Console.WriteLine("mezun oldunuz");
            //}
            //else
            //{
            //    Console.WriteLine("bextinizi bir daha sinayin");
            //}








            //int num, sum = 0;
            //Console.WriteLine("eded daxil edin");
            //num = Convert.ToInt32(Console.ReadLine());
            //while (num > 0)
            //{
            //    sum += (num % 10);
            //     num = num / 10;

            //}
            //Console.WriteLine(sum);




            //
            ///

            //    sum += num % 10;
            //    num = (num - num % 10) / 10;



            double  count = 0;
            double sum = 0;
            double[] nums = { 21, 15, 27, 42 };

            for (int i = 0; i< nums.Length; i++) 
            {
                  if ( nums[i] % 21 == 0)
                  {
                    sum += nums[i];
                    count++;
                  }


                Console.WriteLine (sum/count) ;











        }   }
    }
}
