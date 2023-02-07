using System;

namespace _07022023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tarix daxil edin");
            DateTime date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(date);
            Console.WriteLine("ili daxil edin");
            DateTime dateyear = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(dateyear.Year);

        }
    }
}