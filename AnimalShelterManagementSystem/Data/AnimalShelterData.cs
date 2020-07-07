using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class AnimalShelterData : EntityData<AnimalShelter>
    {

        public AnimalShelter Get(int animalShelterId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.AnimalShelters.FirstOrDefault(a => a.AnimalShelterId == animalShelterId);
        }

        public void Delete(int animalShelterId)
        {
            AnimalShelter animalShelter = Get(animalShelterId);

            if (animalShelter == null)
                return;

            Delete(animalShelter);
        }

        public int GetMaxId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.AnimalShelters
                        orderby x.AnimalShelterId descending
                        select x.AnimalShelterId;

            return query.FirstOrDefault();
        }

        public int GetFirstId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.AnimalShelters
                        orderby x.AnimalShelterId
                        select x.AnimalShelterId;

            return query.FirstOrDefault();
        }
    }
}