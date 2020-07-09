using AnimalShelterManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public void IsAdopted(int homelessAnimalId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            context.HomelessAnimals.FirstOrDefault(a => a.HomelessAnimalId == homelessAnimalId);
        }

        public List<HomelessAnimal> SearchWithAnimals(int speciesCode, int genderCode)
        {
            AnimalShelterManagementEntities context = CreateContext();


            var query = from x in context.HomelessAnimals
                        where x.Species == speciesCode && x.AdoptionStatus == 0
                        select x;

            if (genderCode == 1)
                query = query.Where(x => x.Gender == 1);

            else if (genderCode == 2)
                query = query.Where(x => x.Gender == 2);

            var list = query.ToList();

            foreach (var x in list)
            {
                x.SpeciesName = ((SpeciesType)x.Species).ToString();
                x.PhysicalConditionName = ((PhysicalConditionType)x.PhysicalCondition).ToString();
                x.GenderName = ((Genders)x.Gender).ToString();

            }

            return list;
        }

       
        public List<HomelessAnimal> SearchWithHomelessAnimal(int animalShelterId, int speciesCode, int gender, DateTime foundDateFrom, DateTime foundDateTo)
        {
            AnimalShelterManagementEntities context = CreateContext();


            var query = from x in context.HomelessAnimals
                        where x.AnimalShelterId == animalShelterId &&
                            x.Species == speciesCode &&
                        (x.LatestFindingReport >= foundDateFrom && x.LatestFindingReport <= foundDateTo)
                        select x;


            if (gender == 1)
                query = query.Where(x => x.Gender == 1);

            else if (gender == 2)
                query = query.Where(x => x.Gender == 2);

            //if(species = )




            var list = query.ToList();

            foreach (var x in list)
            {
                x.SpeciesName = ((SpeciesType)x.Species).ToString();
                x.GenderName = ((Genders)x.Gender).ToString();
                x.LatestFindingReportDate = x.LatestFindingReport;

            }

            return list;

        }

        public List<HomelessAnimal> GetByAnimalName(string animalName)
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.HomelessAnimals
                        where x.Name == animalName
                        orderby x.HomelessAnimalId
                        select x;

            return query.ToList();
        }
    }
}
