using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class AdoptionData : EntityData<Adoption>
    {

        public Adoption Get(int userId, int homelessAnimalId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Adoptions.FirstOrDefault(a => a.UserId == userId && a.HomelessAnimalId == homelessAnimalId);
        }

        public void Delete(int userId, int homelessAnimalId)
        {
            Adoption adoption = Get(userId, homelessAnimalId);

            if (adoption == null)
                return;

            Delete(adoption);
        }


    }
}
