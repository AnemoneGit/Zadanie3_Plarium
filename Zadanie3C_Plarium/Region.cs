using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3C_Plarium
{
    class Region
    {
        public string Nazva;
        public int Plochad;
        public People people;

        public Region(string Name, int plochad, People person)
        {
            Nazva = Name;
            Plochad = plochad;
            people = person;
          
        }

    }
}
