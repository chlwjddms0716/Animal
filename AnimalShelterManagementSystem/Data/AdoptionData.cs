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

        public List<HomelessAnimal> GetAnimalsByUserName(string userName)
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.Adoptions
                        where x.User.Name.Contains(userName)
                        select x.HomelessAnimal;

            return query.ToList();
        }

        //public List<HomelessAnimal> GetAnimalsByUserName2(string userName)
        //{
        //    AnimalShelterManagementEntities context = CreateContext();

        //    var query = from x in context.HomelessAnimals
        //                where x.Adoptions.Any(a => a.User.Name.Contains(userName))
        //                select x;

        //    return query.ToList();
        //}
    }
}
