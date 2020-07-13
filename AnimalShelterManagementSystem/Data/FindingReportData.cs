using AnimalShelterManagementSystem.Models;
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

        public List<FindingReport> Search(int speciesCode, DateTime dateTimeFrom, DateTime dateTimeTo, string place)
        {
            var context = CreateContext();
            var query = from x in context.FindingReports
                        select x;

            if (speciesCode != 0)
                query = query.Where(x => x.Species == speciesCode);

            if (dateTimeFrom < dateTimeTo)
                query = query.Where(x => x.Date >= dateTimeFrom && x.Date <= dateTimeTo);

            if (string.IsNullOrEmpty(place) != true )
                query = query.Where(x => x.Place.Contains(place) == true);
            
            var list = query.ToList();
            
            foreach (var x in list)
            {
                x.SpeciesName = ((SpeciesType)x.Species).ToString();
            }
            // query.OrderBy()
            return list;
        }
    }

}
