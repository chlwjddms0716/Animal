using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public partial class HomelessAnimal
    {
        public override string ToString()
        {
            return $"HomelessAnimalId={HomelessAnimalId}, Name={Name},Age={Age} ,Sex={Sex},Feature={Feature},LatestFindingReport{LatestFindingReport},PictureLink={PictureLink},PhysicalCondition={PhysicalCondition},SpeciesCode={SpeciesCode}";
        }



    }
}

