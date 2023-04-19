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

        public override string GetSpeciesName()
        {
            return "Rabbit";
        }

        public override string GetAnimalName()
        {
            return _name;
        }

        public override void Eat(Herbal food)
        {
            Console.WriteLine("Rabbit is eating " + food + ".");
        }
    }
}
