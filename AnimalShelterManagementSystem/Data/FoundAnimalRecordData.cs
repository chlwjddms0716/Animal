using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class FoundAnimalRecordData : EntityData<FoundAnimalRecord>
    {
        public FoundAnimalRecord Get(int lossReportId, int homelessAnimalId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.FoundAnimalRecords.FirstOrDefault(a => a.LossReportId == lossReportId && a.HomelessAnimalId == homelessAnimalId);
        }

        public void Delete(int lossReportId, int homelessAnimalId)
        {
            FoundAnimalRecord foundAnimalRecord = Get(lossReportId, homelessAnimalId);

            if (foundAnimalRecord == null)
                return;

            Delete(foundAnimalRecord);
        }
    }
}
