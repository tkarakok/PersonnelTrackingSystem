using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelTrackingSystem
{
    class Academician :Personnel, IPersonnelDirector
    {
        Academician academician;
        public string depertmant;

        public void SetInfo()
        {
            Console.WriteLine(" ***** ACADEMİCİAN *****");
            Console.Write(" ACADEMİCİAN NAME             :");
            academician.name = Console.ReadLine();
            Console.Write(" ACADEMİCİAN SURNAME          :");
            academician.surName = Console.ReadLine();
            Console.Write(" ACADEMİCİAN AGE              :");
            academician.age = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ACADEMİCİAN DEPERTMANT       :");
            academician.depertmant = Console.ReadLine();
        }

        public void GetInfo()
        {
            Console.WriteLine("");
            Console.WriteLine(" ***** ACADEMİCİAN *****");
            Console.WriteLine(" ACADEMİCİAN NAME            :{0}", academician.name);
            Console.WriteLine(" ACADEMİCİAN SURNMAE         :{0}", academician.surName);
            Console.WriteLine(" ACADEMİCİAN AGE             :{0}", academician.age);
            Console.WriteLine(" ACADEMİCİAN DEPERTMANT      :{0}", academician.depertmant);
            
        }

        public void Reset()
        {

            academician = new Academician();
        }

        
    }
}
