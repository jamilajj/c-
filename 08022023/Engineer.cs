using System;
using System.Collections.Generic;
using System.Text;

namespace _08022023
{
    internal class Engineer:Employee
    {
        public override int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value > 1000)
                    _salary = value;
                

                
            }
        }
    }
}
