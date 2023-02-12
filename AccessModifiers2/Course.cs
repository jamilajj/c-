using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers2
{
    internal class Course
    {
        public Group[] Groups;
        public void AddGroup(Group group)
        {
            Array.Resize(ref Groups, Groups.Length + 1);
            Groups[Groups.Length - 1] = group;
        }
        public Group[] GetGroupByNo = null;
        public void GetGroupByNo(Group group)
        {
            for (int i = 0; i < Groups.Length; i++)
            {
                Groups[i] =(Group[i]Groups);
            }
        }

        //public Group GetGroupByPointRange;
        //public string Search;
    }
}
