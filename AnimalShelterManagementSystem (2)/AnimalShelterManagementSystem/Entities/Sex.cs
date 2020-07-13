using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalShelterManagementSystem
{


    public partial class Sex : EntityData<Sex>
    {
        public object GetAll()
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Set<Sex>().ToList();
        }

        public int GetBy(string sex)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Sexes.FirstOrDefault(a => a.Sex1 == sex).SexId;
        }
    }
}