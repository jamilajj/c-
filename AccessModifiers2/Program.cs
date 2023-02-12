using System;
using System.Text.RegularExpressions;


namespace AccessModifiers2
{
    internal class Program:Course
    {
        static void Main(string[] args)
        {
            Course course = new Course();
            Group gr1 = new Group();
            gr1.GroupNo = "Pqwe";
            Course.AddGroup();

            string GroupNo;
            string opt;
            string no;
            do
            {
                Console.WriteLine("1.qrup elave et");
                Console.WriteLine("2.Butun qruplara bax");
                Console.WriteLine("3.Verilmis point araliqindaki qruplara bax");
                Console.WriteLine("4.Verilmis nomreli qrupa bax");
                Console.WriteLine("5.Verilmis qruplar uzre axtaris et");
                Console.WriteLine("0.menudan cix");

                opt = Console.ReadLine();


                switch (opt)
                {
                    case "0":
                        Console.WriteLine("Proqram bitdi");
                        break;

                    case "1":
                        Console.WriteLine("\n====qrup elave et======");
                        Group groups = new Group();

                        Course.AddGroup( new Group { GroupNo = "P134" });
                        for (int i = 0; i < course.Groups.Length; i++)
                        {
                            Console.WriteLine(course.Groups[i].GroupNo);
                        }
                        break;



                    case "2":
                        Console.WriteLine("\n==============All Groups===============");
                        for (int i = 0; i < GroupNo.Length; i++)
                        {
                            Console.WriteLine(GroupNo[i]);
                        }
                        break;
                    case "3":
                        Console.WriteLine("\n===========point araliqi daxil edin==============");
                        do

                            Console.WriteLine("Baslangic deyer daxil edin");

                            int A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Bitish deyeri daxil edin");
                        int objB = Convert.ToInt32(Console.ReadLine());


                        break;
                    case "4":
                        Console.WriteLine("\n===========Group no daxil edin===========");
                        string GroupNo = Console.ReadLine();




                        break;
                    case "5":
                        Console.WriteLine("\n==============Group daxil edin========");
                        break;

                }
            } while (opt != "0");


        }
            }
}
