using Coursemanagement.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coursemanagement.Service
{
    static class Menuservice
    {
        public static Courseservice courseservice = new Courseservice();

        public static void Creategroup()
        {
            Console.WriteLine("Please enter new group number");

            int groupno;

            string rowStr = Console.ReadLine();

            bool groupResult = int.TryParse(rowStr, out groupno);

            if (groupno <= 0)
            {
                Console.WriteLine("Please enter valid number");
                return;
            }

            Console.WriteLine("Please enter numbers of students");

            int stunumber;
            string colStr = Console.ReadLine();
            bool sturesult = int.TryParse(colStr, out stunumber);
            if (stunumber <= 0)
            {
                Console.WriteLine("Please enter valid number");
                return;
            }

            {
                Console.WriteLine("Please choose the category you want");

                foreach (var pro in Enum.GetValues(typeof(Professioncategory)))
                {
                    Console.WriteLine($"{(int)pro}. {pro}");
                }
                int category;
                string categoryStr = Console.ReadLine();
                bool categoryResult = int.TryParse(categoryStr, out category);

                if (categoryResult)
                {
                    switch (category)
                    {
                        case 1:
                            string No = courseservice.Creategroup(stunumber, groupno, Professioncategory.Programming);
                            Console.WriteLine($"{No} Group succesfully created");
                            break;
                        case 2:
                            No = courseservice.Creategroup(stunumber, groupno, Professioncategory.Design);
                            Console.WriteLine($"{No} Group succesfully created");
                            break;
                        case 3:
                            No = courseservice.Creategroup(stunumber, groupno, Professioncategory.Management);
                            Console.WriteLine($"{No} Group succesfully created");
                            break;
                        default:
                            break;


                    }
                }
            }
        }
        public static void Listofgroups()
        {
            Console.WriteLine("List of existed groups");
            courseservice.Listofgroups();
        }
           
        public static void Editgroupmenu()
            {
            Console.WriteLine("Please enter previous group number");
            string number = Console.ReadLine();

            Console.WriteLine("Please enter new group number ");
            string newnumber = Console.ReadLine();

            courseservice.Editgroups(number, newnumber);

            }
        public static void Groupstudents()
            {
            Console.WriteLine("please add the group students");
            String stu = Console.ReadLine();
            courseservice.Groupstudents(stu);


            }
        public static void Allstudents()
        {
            courseservice.Allstudents();
        }
        
        public static void Createstudent()
        {
                Console.WriteLine("please enter fullname of student");
                string name = Console.ReadLine();
                Console.WriteLine("please enter age of student");



                int stunumber1;
                string colStr = Console.ReadLine();
                bool sturesult = int.TryParse(colStr, out stunumber1);


                if (stunumber1 <= 0)
                {
                    Console.WriteLine("Please enter valid number");
                }
                else
                {
                    Console.WriteLine("Student was created succesfully");
                }
            }
        }
    } 


        



