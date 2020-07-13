using AnimalShelterManagementSystem.Models;
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

        public List<Adoption> GetAnimalsById(string userId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.Adoptions
                        where x.User.Name.Contains(userId)
                        select new
                        {
                            Adopt = x,
                            AnimalName = x.HomelessAnimal.Name,
                            userLoginId = x.User.Id,
                            AdoptionStatus = x.HomelessAnimal.AdoptionStatus
                        } ;

            var list = query.ToList();

            foreach (var x in list)
            {
                x.Adopt.AnimalName = x.AnimalName;
                x.Adopt.userLoginId = x.userLoginId;
                x.Adopt.AdoptionStatus = (AdoptionStatusType)x.AdoptionStatus;
            }

            return list.ConvertAll(x => x.Adopt);

        }

        public List<Adoption> Search(string userId, int statusCode)
        {
            var context = CreateContext();

            var query = from x in context.Adoptions
                        select new
                        {
                            Adopt = x,
                            AnimalName = x.HomelessAnimal.Name,
                            userLoginId = x.User.Id,
                            AdoptionStatus = x.HomelessAnimal.AdoptionStatus
                        };

            if (string.IsNullOrEmpty(userId) == false)
                query = query.Where(x => x.userLoginId.Contains(userId));

            if (statusCode != 3)
                query = query.Where(x => x.AdoptionStatus == statusCode);

            var list = query.ToList();

            foreach (var x in list)
            {
                x.Adopt.AnimalName = x.AnimalName;
                x.Adopt.userLoginId = x.userLoginId;
                x.Adopt.AdoptionStatus = (AdoptionStatusType)x.AdoptionStatus;
            }

            return list.ConvertAll(x => x.Adopt);
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
