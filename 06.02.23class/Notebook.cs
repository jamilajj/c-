using System;
using System.Collections.Generic;
using System.Text;

namespace _06._02._23class
{
    internal class Notebook
    {
        public string Brand;
        public string Model;
        public double Price;
        public int Ram = 4;

        public void ShowInfo()
        {
            Console.WriteLine($"Brand:{Brand}-Model:{Model}-Price:{Price}");

        }
        public Notebook(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Notebook(string brand,string model,double price) : this(brand, model)
        {
            Price = price;
        }
        public Notebook(string brand,string model,double price,int ram) : this(brand, model, price)
        {
            Ram = ram;
        }


    }
}
