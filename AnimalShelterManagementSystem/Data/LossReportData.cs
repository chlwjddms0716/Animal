using AnimalShelterManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    public class LossReportData : EntityData<LossReport>
    {
        public LossReport Get(int lossReportId)
        {
            AnimalShelterManagementEntities context = CreateContext();

            return context.LossReports.FirstOrDefault(a => a.LossReportId == lossReportId);
        }

        public void Delete(int lossReportId)
        {
            LossReport lossReport = Get(lossReportId);

            if (lossReport == null)
                return;

            Delete(lossReport);
        }

        public int GetMaxId()
        {
            AnimalShelterManagementEntities context = CreateContext();

            var query = from x in context.LossReports
                        orderby x.LossReportId descending
                        select x.LossReportId;

            return query.FirstOrDefault();
        }

        public IEnumerable<LossReport> GetbyAnimalName(string AnimalName)
        {
                AnimalShelterManagementEntities context = CreateContext();


                var query = from x in context.LossReports
                            where x.
                            select x;

                
                var list = query.ToList();

                foreach (var x in list)
                {
                    x.SpeciesName = ((SpeciesType)x.Species).ToString();
                }

                return list;
            }
        }
    }
}
