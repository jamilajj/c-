using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AccessModifiers2
{
    internal class Group
    {
      public string _no;
      
        public void showinfo()
        {
            Console.WriteLine($"no:{_no}");
        }
        public virtual string GroupNo
        {
            get => _no;
            set
            {
                if (CheckNo(value))
                    _no = value;
            }
        }
        public bool CheckNo(string GroupNo)
        {
            if (!string.IsNullOrWhiteSpace(GroupNo) && GroupNo.Length == 4 && char.IsUpper(GroupNo[0]) && char.IsNumber(GroupNo[1]) && char.IsNumber(GroupNo[2]) && char.IsNumber(GroupNo[3])) 
                return true;
         
                return false;

        }
        public double AvgPoint; 
          
           
           
           

           
            
               

            

            
          
           






    }
}
