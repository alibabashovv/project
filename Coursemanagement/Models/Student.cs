using Coursemanagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coursemanagement.Models
{
    class Student
    {
        
        public string Fullname { get; set; }
        public int Groupno { get; set; }
        public Educationtype Edutype { get; set; }


        public Student(string fullname, int groupno, Educationtype edutype)
        {
            Fullname = fullname;
            Groupno = groupno;
            Edutype = edutype;
        }
        public override string ToString()
        {

            return $"{Fullname}   {Edutype}  {Groupno} ";

        }

    }
}

       
     
