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
        public List<Student> Students { get; set; }

        public Group(int groupnumber, Professioncategory category)
        {
            switch (category)
            {
                
                case Professioncategory.Programming:
                    NO = "P" +"-"+ count;
                    count++;
                    break;
                case Professioncategory.Design:
                    NO = "D" +"-"+ count;
                    count++;
                    break;
                case Professioncategory.SystemAdministration:
                    NO = "M" +"-"+ count;
                    count++;
                    break;
                default:
                    break;
                    
            }
        }
            public override string ToString()
        {
            return $"--{NO}--{Category}";
        }
    }
}

      


                

  
