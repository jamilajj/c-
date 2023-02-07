using System;
using System.Collections.Generic;
using System.Text;

namespace _07022023
{
    internal class Vehicle
    {
        public string Brand;
        public string Model;
        public int Millage;
        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand},Model:{Model},Millage:{Millage}");
        }

    }
}
