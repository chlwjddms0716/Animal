using AnimalShelterManagementSystem.Data;
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

   

        public List<LossReport> Search(string userId, string animalName)
        {
            var context = CreateContext();

            var query = from x in context.LossReports
                        select new
                        {
                            LossReport = x,
                            userLoginId = x.User.Id,
                        };


            if (string.IsNullOrEmpty(userId) == false)
                query = query.Where(x => x.userLoginId.Contains(userId) == true);

            if (string.IsNullOrEmpty(animalName) == false)
                query = query.Where(x => x.LossReport.AnimalName.Contains(animalName) == true);

            var list = query.ToList();

            foreach (var x in list)
            {
                x.LossReport.userLoginId = x.userLoginId; 
                x.LossReport.SpeciesName = ((SpeciesType)x.LossReport.Species).ToString();
            }

            return list.ConvertAll(x => x.LossReport);
        }
    }

}

