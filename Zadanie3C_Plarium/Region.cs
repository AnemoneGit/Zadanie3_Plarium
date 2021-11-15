using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3C_Plarium
{
    class Region // класс регион
    {
        public string Nazva; //название региона
        public int Plochad; // площадь региона
        public People people; // люди которые живут в регионе

        public Region(string Name, int plochad, People person)
        {
            Nazva = Name;
            Plochad = plochad;
            people = person;
          
        }

    }
}
