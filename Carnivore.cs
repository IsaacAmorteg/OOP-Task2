using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchyLibrary
{
    public abstract class Carnivore : Animal
    {
        public abstract string Eat(Animal food);
    }
}
