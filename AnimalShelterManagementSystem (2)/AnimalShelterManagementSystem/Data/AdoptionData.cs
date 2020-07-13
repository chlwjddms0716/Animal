using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class AdoptionData : EntityData<Adoption>
    {

   /*     public Adopter Get(int adoptionId)
        {
            AnimalShelterEntities context = CreateContext();

            return context.Adopters.FirstOrDefault(a => a.AdopterId == adoptionId);
        }

        public void Delete(int adopterId)
        {
            Adopter Adopter = Get(adopterId);

            if (Adopter == null)
                return;

            Delete(Adopter);
        }

        public int GetMaxId()
        {
            AnimalShelterEntities context = CreateContext();

            var query = from x in context.HomelessAnimals
                        orderby x.HomelessAnimalId descending
                        select x.HomelessAnimalId;

            return query.FirstOrDefault();
        }*/
    }
}
