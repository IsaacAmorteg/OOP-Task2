using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchyLibrary
{
    public class Rabbit : Herbivore
    {
        private string _name;

        public Rabbit(string name) 
        {
            _name = name;
        }
    }
}
