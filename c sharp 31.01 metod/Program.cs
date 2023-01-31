using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace c_sharp_firs_repo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş yazının əvvəlindəki boşluqları silib qayataran metod
            

             Console.WriteLine( numbers( "      salam  can"));

            int[] nums = { 1, 2, 3, 4, 5, -5, -6, };

            Console.WriteLine(positivenumber(nums));
        }


        static string numbers(string text)
        {
            
            string newstr = "";
            for (int i = 0; i < text.Length; i++)
            {
                { if (text[i] != (' '))
                        
                    newstr += text[i];
                    continue;
                }

                { 

                        newstr += (' ');

                }



            } 
                 return  newstr;
        }
        // -Verilmiş ədədlər siyahısından yalnız müsbət ədədlərindən ibarət yeni bir array düzəldib qaytaran metod
        
        
            
            



            static int[] positivenumber(int[] numbers)
            {
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0)
                        count++;

                }

                int a= 0;
                int[] positiveNumbers = new int[count];

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0)
                    {
                        positiveNumbers[a] = numbers[i];
                        a++;
                    }
                }

                return positiveNumbers;
            }

    }
}
