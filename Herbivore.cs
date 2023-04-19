using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchyLibrary
{
    public abstract class Herbivore : Animal
    {
        public abstract void Eat(Herbal food);
    }
}
