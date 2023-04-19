using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchyLibrary
{
    public class Bear : Animal, IHerbivore, ICarnivore
    {
        private string _name;

        public Bear(string name)
        {
            _name = name;
        }
        public override string GetSpeciesName()
        {
            return "Bear";
        }
        public override string GetAnimalName()
        {
            return _name;
        }
        public void Eat(Animal food)
        {
            Console.WriteLine($"{GetSpeciesName()} is eating {food}.");
        }
        public void Eat(Herbal food)
        {
            Console.WriteLine($"{GetSpeciesName()} is eating {food}.");
        }
    }
    public interface IHerbivore
    {
        void Eat(Herbal food);
    }
    public interface ICarnivore
    {
        void Eat(Animal food);
    }
}
