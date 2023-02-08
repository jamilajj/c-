﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08022023
{
    internal class Employee
    {
        public string FullName;
        protected int _salary;


        public virtual int Salary 
        {
            get
            {
                return _salary;
            } 
            set 
            { 
                if (value < 300)
                    _salary = value;
            } 
        }

        public void ShowInfo()
        {
            Console.WriteLine($"FullName:{FullName},Salary:{_salary}");
        }
        
        

        
        

        
    }
}
