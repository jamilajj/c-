using System;
using System.Xml.Schema;

namespace _06._02._23class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Notebook count:");
            int count = Convert.ToInt32(Console.ReadLine());
            Notebook[] notebooks = new Notebook[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Brand:");
                string brand = Console.ReadLine();
                Console.WriteLine("Model:");
                string model = Console.ReadLine();
                Console.WriteLine("Price:");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ram:");
                int ram = Convert.ToInt32(Console.ReadLine());
                Notebook nt = new Notebook(brand, model) { Price = price, Ram = ram };
                notebooks[i] = nt;
            }
            double sum = 0;
            for (int i = 0; i < notebooks.Length;i++)
            {
                sum += notebooks[i].Price;
            }
            var result = sum / notebooks.Length;
            Console.WriteLine(result);
        }
        

    }
}
