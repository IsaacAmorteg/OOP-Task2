using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchyLibrary
{
    public class Grass : Herbal
    {
        public override string GetSpeciesName()
        {
            return "Grass";
        }
    }
}
