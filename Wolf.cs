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
        public override string GetSpeciesName()
        {
            return "Wolf";
        }

        public override string GetAnimalName()
        {
            return _name;
        }

        public override void Eat(Animal food)
        {
            Console.WriteLine($"{GetSpeciesName()} is eating {food}.");
        }
    }

}
