using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class FindingReportData : EntityData<FindingReport>
    {

        public FindingReport Get(int findingReportId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.FindingReports.FirstOrDefault(a => a.FindingReportId == findingReportId);
        }

        public void Delete(int findingReportId)
        {
            FindingReport findingReport = Get(findingReportId);

            if (findingReport == null)
                return;

            Delete(findingReport);
        }

        public int GetMaxId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.FindingReports
                        orderby x.FindingReportId descending
                        select x.FindingReportId;

            return query.FirstOrDefault();
        }
    }

}
