using System;

namespace PersonnelTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonnelBuilder personnelBuilder = new();
            MainMenu(personnelBuilder);
        }

        public static void MainMenu(PersonnelBuilder personnelBuilder)
        {
            Console.WriteLine("/// WELCOME PERSONNEL TRACKİNG SYSTEM /// \n ");
            Console.WriteLine(" PLEASE SELECT PROCESS YOU WANT WHİCH ONE \n 1 - ADD PERSONNEL \n 2 - LİST ALL PERSONNEL");
            int choose = Convert.ToInt32(Console.ReadLine());
            Process(choose, personnelBuilder);
        }

        public static void Process(int choose, PersonnelBuilder personnelBuilder)
        {
            switch (choose)
            {
                case 1:
                    Console.WriteLine(" PLEASE SELECT PERSONNEL TYPE \n 1 - STUDENT \n 2 - ACADEMİCİAN");
                    int select = Convert.ToInt32(Console.ReadLine());
                    InsertPersonnel(select, personnelBuilder);
                    break;
                case 2:
                    ListAllPersonnels(personnelBuilder);
                    break;
                default:
                    break;
            }
        }

        public static void InsertPersonnel(int select, PersonnelBuilder personnelBuilder)
        {
            Console.Clear();
            switch (select)
            {
                case 1:
                    Student student = new();
                    personnelBuilder.AddPersonnel(student);
                    Console.WriteLine(" succed student add");
                    Console.Clear();
                    MainMenu(personnelBuilder);
                    break;
                case 2:
                    Academician academician = new();
                    personnelBuilder.AddPersonnel(academician);
                    Console.WriteLine(" succed academician add");
                    Console.Clear();
                    MainMenu(personnelBuilder);
                    break;
                default:
                    break;
            }
        }

        public static void ListAllPersonnels(PersonnelBuilder personnelBuilder)
        {
            Console.Clear();
            Console.WriteLine(" *** ALL PERSONNELS *** ");
            foreach (var item in personnelBuilder.personnels)
            {
                item.GetInfo();
            }
            Console.WriteLine(" ");

        back:
            Console.WriteLine(" please select process \n 1 - Go to main menu");
            int mainmenu = Convert.ToInt32(Console.ReadLine());
            if (mainmenu == 1)
            {
                Console.Clear();
                MainMenu(personnelBuilder);
            }
            else
            {
                goto back;
            }
        }
    }
}
