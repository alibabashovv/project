using Coursemanagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coursemanagement.Models
{
    class Group
    {
        public static int count = 1;
        public string NO { get; set; }
        public Professioncategory Category { get; set; }
        public bool IsOnline { get; set; }
        public int Limit { get; set; }
        public Student[] Students { get; set; }

        public Group(int groupnumber, int studentnumber, Professioncategory category)
        {
            switch (category)
            {
                case Professioncategory.Programming:
                    NO = "P" + count;
                    break;
                case Professioncategory.Design:
                    NO = "D" + count;
                    break;
                case Professioncategory.Management:
                    NO = "M" + count;
                    break;
                default:
                    break;
            }
            Category = category;
            Students = new Student[studentnumber];
        }
    }
}

      


                

  
