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

        public List<AnimalShelter> Search(string address, int shelterId)
        {
            var context = CreateContext();

            var query = from x in context.AnimalShelters
                        select x;

            if (string.IsNullOrEmpty(address) == false)
                query = query.Where(x => x.Address.Contains(address) == true);

            if (shelterId != 0)
                query = query.Where(x => x.AnimalShelterId == shelterId);

            var list = query.ToList();

            return list;
        }
    }
}