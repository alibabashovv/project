using Coursemanagement.Service;
using System;

namespace Coursemanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to course application");

            int selection;
            do
            {
                Console.WriteLine("1.Creategroup");
                Console.WriteLine("2.ListofGroups");
                Console.WriteLine("3.Editgroups");
                Console.WriteLine("4.Groupstudents");
                Console.WriteLine("5.Allstudents");
                Console.WriteLine("6.Createstudent");
                Console.WriteLine("  ");
                Console.WriteLine("Please select one of these");

                string n = Console.ReadLine();
                bool result = int.TryParse(n, out selection);

                if (result)
                {
                    switch (selection)
                    {
                        case 1:
                            Menuservice.Creategroup();
                            break;
                        case 2:
                            Menuservice.Listofgroups();
                            break;
                        case 3:
                            Menuservice.Editgroupmenu();
                            break;
                        case 4:
                            Menuservice.Groupstudents();
                            break;
                        case 5:
                            Menuservice.Allstudents();
                            break;
                        case 6:
                            Menuservice.Createstudent();
                            break;
                            
                           
                            

                        default:
                            break;
                    }
                }
            } while(selection !=0);
        }
    }
}