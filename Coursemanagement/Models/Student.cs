using System;
using System.Collections.Generic;
using System.Text;

namespace Coursemanagement.Models
{
    class Student
    {
        public static int acount = 0;
        public string Fullname { get; set; }
        public int Groupno { get; set; }
        public string IsType { get; set; }


        public Student(string fullname, int groupno, string itstype)
        {
            Fullname = fullname;
            Groupno = groupno;
            IsType = itstype;
        }

        
    }
}

       
     
