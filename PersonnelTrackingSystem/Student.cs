using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelTrackingSystem
{
    class Student : Personnel, IPersonnelDirector
    {
        Student student;
        public int number;

        public void SetInfo()
        {
            Console.WriteLine(" ***** STUDENT *****");
            Console.Write(" STUDENT NAME    :");
            student.name = Console.ReadLine();
            Console.Write(" STUDENT SURNAME    :");
            student.surName = Console.ReadLine();
            Console.Write(" STUDENT AGE    :");
            student.age = Convert.ToInt32(Console.ReadLine());
            Console.Write(" STUDENT NUMBER    :");
            student.number = Convert.ToInt32(Console.ReadLine());
        }

        public void GetInfo()
        {
            Console.WriteLine("");
            Console.WriteLine(" ***** STUDENT *****");
            Console.WriteLine(" STUDENT NAME         :{0}", student.name);
            Console.WriteLine(" STUDENT SURNMAE      :{0}", student.surName);
            Console.WriteLine(" STUDENT AGE          :{0}", student.age);
            Console.WriteLine(" STUDENT NUMBER       :{0}", student.number);
            
        }

        public void Reset()
        {

            student = new Student();
        }

        
    }
}
