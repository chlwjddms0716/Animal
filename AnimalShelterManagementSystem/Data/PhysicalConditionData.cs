using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class PhysicalConditionData : EntityData<PhysicalCondition>
    {
        public PhysicalCondition Get(int physicalConditionCode)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.PhysicalConditions.FirstOrDefault(a => a.PhysicalConditionCode == physicalConditionCode);
        }

        public void Delete(int physicalConditionCode)
        {
            PhysicalCondition physicalCondition = Get(physicalConditionCode);

            if (physicalCondition == null)
                return;

            Delete(physicalCondition);
        }

        public int GetMaxCode()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.PhysicalConditions
                        orderby x.PhysicalConditionCode descending
                        select x.PhysicalConditionCode;

            return query.FirstOrDefault();
        }
    }
}
