using System;

namespace METODS
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            int[] numbers = { 12, 34 };
            var sumOfArr = Sum(numbers);
            Console.WriteLine(sumOfArr);

            ShowSum(10, 64);



            var reverse = Reverse("Saqol");

            Console.WriteLine(reverse);


            var digitsSum = SumOfDigits(23);

            Console.WriteLine(digitsSum);


            //Verilmiş ədədlər siyahısındaki ədədlərini cəmini qaytaran metod



        }
        static int Sum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;

        }




        //Verilmiş iki ədədi toplayıb qaytaran metod
        static void ShowSum(int num1, int num2)
            {
                var result = num1 + num2;
                Console.WriteLine(result);
            }






            // Verilmiş ədədlər siyahısındaki ən böyük ədədi qaytaran metod
            static int ShowMax(int[] numbers)
            {
                int MaxValue = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > MaxValue)
                    MaxValue = numbers[i];
                return MaxValue;
            }



                //Verilmiş 3 ədəddən ən böyüyünü tapan proqram






                static int max(int number1, int number2, int number3)
                {
                    int Maxvalue = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] > Maxvalue)
                            Maxvalue = numbers[i];
                        return Maxvalue;
                    }
                }




                //erilmiş yazını əks şəkildə qaytaran metod
                static string Reverse(string str)
            {
                string newStr = "";

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    newStr += str[i];
                }

                return newStr;
            }


            //Verilmiş ədədin rəqəmləri cəmini qaytaran metod

            static int SumOfDigits(int n)
            {
                int sum = 0;
                while (n > 0)
                {
                    sum += n % 10;
                    n /= 10;
                }

                return sum;
            }







































        }

    }
}
