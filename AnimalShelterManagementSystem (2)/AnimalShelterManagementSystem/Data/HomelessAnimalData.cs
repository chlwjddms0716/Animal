using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class HomelessAnimalData : EntityData<HomelessAnimal>
    {

        public HomelessAnimal Get(int homelessAnimalId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.HomelessAnimals.FirstOrDefault(a => a.HomelessAnimalId == homelessAnimalId);
        }

        public void Delete(int homelessAnimalId)
        {
            HomelessAnimal homelessAnimal = Get(homelessAnimalId);

            if (homelessAnimal == null)
                return;

            Delete(homelessAnimal);
        }

        public int GetMaxId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.HomelessAnimals
                        orderby x.HomelessAnimalId descending
                        select x.HomelessAnimalId;

            return query.FirstOrDefault();

        }

        public int GetFirstId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.HomelessAnimals
                        orderby x.HomelessAnimalId 
                        select x.HomelessAnimalId;

            return query.FirstOrDefault();
        }
    }
}
