using System;
using System.Collections.Generic;
using System.Text;
using Coursemanagement.Enums;
using Coursemanagement.Models;

namespace Coursemanagement.Interface
{
    interface Icourseservice
    {
        public List<Group> Groups { get;}

        string Creategroup(int numberofstudent, int groupnumber, Professioncategory category);

        void Listofgroups();

        void Editgroups(string number, string newnumber);

        void Groupstudents(string stu);

        void Allstudents();

        string Createstudent(string fullname,int age, string Istype,int groupno);
        
    }
}
