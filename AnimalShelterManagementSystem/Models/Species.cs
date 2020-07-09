using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem.Models
{
    public class Species
    {
        public int SpeciesCode { get; set; }

        public string Name { get; set; }

        public Species(int speciesCode, string name)
        {
            SpeciesCode = speciesCode;
            Name = name;
        }

        public static List<Species> Load()
        {
            List<Species> list = new List<Species>();

            int[] values = (int[])Enum.GetValues(typeof(SpeciesType));
            foreach (var value in values)
            {
                string name = Enum.GetName(typeof(SpeciesType), value);

                list.Add(new Species(value, name));
            }

            return list;
        }
    }
}
