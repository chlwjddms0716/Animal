using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class SpeciesData : EntityData<Species>
    {
        public Species Get(int speciesCode)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Specieses.FirstOrDefault(a => a.SpeciesCode == speciesCode);
        }

        public void Delete(int speciesCode)
        {
            Species species = Get(speciesCode);

            if (species == null)
                return;

            Delete(species);
        }

        public int GetMaxId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.Specieses
                        orderby x.SpeciesCode descending
                        select x.SpeciesCode;

            return query.FirstOrDefault();
        }
    }
}
