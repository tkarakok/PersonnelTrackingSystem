using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelTrackingSystem
{
    class PersonnelBuilder
    {
        public List<IPersonnelDirector> personnels = new List<IPersonnelDirector>();

        public void AddPersonnel(IPersonnelDirector personnelDirector)
        {
            personnelDirector.Reset();
            personnelDirector.SetInfo();
            personnels.Add(personnelDirector);
        }
    }
}
