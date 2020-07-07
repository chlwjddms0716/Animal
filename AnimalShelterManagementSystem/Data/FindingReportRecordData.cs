using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class FindingReportRecordData : EntityData<FindingReportRecord>
    {
        public FindingReportRecord Get(int findingReportId, int homelessAnimalId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.FindingReportRecords.FirstOrDefault(a => a.FindingReportId == findingReportId && a.HomelessAnimalId == homelessAnimalId);
        }

        public void Delete(int findingReportId, int homelessAnimalId)
        {
            FindingReportRecord fingdingReportRecord = Get(findingReportId, homelessAnimalId);

            if (fingdingReportRecord == null)
                return;

            Delete(fingdingReportRecord);
        }
    }

}
