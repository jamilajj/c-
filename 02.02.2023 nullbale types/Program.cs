using System;
using System.Linq;
using System.Linq.Expressions;

namespace _02._02._2023_nullbale_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { " name surname","eli veliyev" };
            string opt;
            do
            {
                Console.WriteLine("\n1.Butun telebelere bax");
                Console.WriteLine("2. Yeni telebe elave et");
                Console.WriteLine("3.Telebeler uzre axtaris et");
                Console.WriteLine("4. Telebelerin adlarına bax");
                Console.WriteLine("5. Siyahıda adın olub olmadığına bax");
                Console.WriteLine("0  Menudan çıx");
                Console.WriteLine("\nsecim edin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine(students[i]);
                        }
                        break;
                    case "2":
                   

                    Console.WriteLine("fullname daxil edin");
                    string std = Console.ReadLine();
                    
                    while ( std.Length <= 3) 
                    {
                      Console.WriteLine("bir daha daxil edin");
                      std = Console.ReadLine();
                        
                      
                    }
                    if (std.Length > 3)
                    {
                            Array.Resize(ref students, students.Length + 1);
                       students[students.Length - 1] = std;
                      
                    }


                        //var newstd = std.ToLower();
                        //var newstd2 = char.ToUpper(newstd[0]);
                        //std = newstd + newstd2;
                        //Console.WriteLine(std);

                        break;

                    case "3":
                        Console.WriteLine("search");
                      string  stdname = Console.ReadLine();
                        Console.WriteLine(students.Contains(stdname));
                        break;
                    case "4":
                            opt = opt.Trim();
                            int space = opt.IndexOf(' ');

                            Console.WriteLine(opt.Substring(0,space));
                        break;
                    case "5":
                        Console.WriteLine("fullname");
                            string student = Console.ReadLine();
                            Console.WriteLine(students.Contains(student));
                        break;
                    case "0":

                        break;
                }  

            } while (opt != "0");
       
        }
    }   
}