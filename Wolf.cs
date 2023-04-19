using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchyLibrary
{
    public class Wolf : Carnivore
    {
        private string _name;

        public Wolf(string name) 
        {
            _name = name;
        }
    }
}
