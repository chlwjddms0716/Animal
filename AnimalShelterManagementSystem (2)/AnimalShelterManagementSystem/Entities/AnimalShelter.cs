using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    partial class AnimalShelter : EntityData<AnimalShelter>
    {
        public object GetAll()
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.Set<AnimalShelter>().ToList();
        }
    }
}
