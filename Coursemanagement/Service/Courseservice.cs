
using Coursemanagement.Enums;
using Coursemanagement.Interface;
using Coursemanagement.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coursemanagement.Service
{
    class Courseservice : Icourseservice
    {
        private List<Student> _students = new List<Student>();
        public List<Student> Students => _students;
        private List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;


        public void Allstudents()
        {
            foreach (Student student in _students)
            {
                Console.WriteLine(student.Fullname, student.Groupno);
            }
        }


        public string Creategroup(int groupnumber, Professioncategory category)
        {
            Group group = new Group(groupnumber, category);

            _groups.Add(group);

            return group.NO.ToString();
        }

        public string Createstudent(string fullname, int groupno, Educationtype edutype)
        {

            Student student = new Student(fullname, groupno, edutype);
            _students.Add(student);

            return student.ToString();
        }


        public void Editgroups(string number, string newnumber)
        {
            Group existedgroup = FindGroup(number);
            if (existedgroup == null)
            {
                Console.WriteLine($"{number}There is no group");
                return;
            }
            foreach (Group group in _groups)
            {
                if (group.NO.ToString().Trim() == newnumber.ToLower().Trim())
                {
                    Console.WriteLine($"{newnumber} Number succesfully was changed");
                    return;
                }
            }
            existedgroup.NO = newnumber.ToUpper();
            Console.WriteLine($"{number} Changed to {newnumber}");
        }
        public Group FindGroup(string no)
        {
            foreach (Group group in _groups)
            {
                if (group.NO.ToLower().Trim() == no.ToLower().Trim())
                {
                    return group;
                }
            }
            return null;
        }

        public void Groupstudents(string stu)
        {
            foreach (var group in _groups)
            {

                Console.WriteLine(group.Students);
            }
        }

        public void Listofgroups()
        {
            if (Group.count == 0)
            {
                Console.WriteLine("There is no any group");
            }
            foreach (Group group in _groups)
            {

                Console.WriteLine(group);
            }
        }

        internal void Editgroups()
        {
            throw new NotImplementedException();
        }
    }
}
                
