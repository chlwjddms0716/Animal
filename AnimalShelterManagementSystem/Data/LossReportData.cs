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

        public List<LossReport> GetEvery()
        {
            List<LossReport> lossReports = DataRepository.LossReport.GetAll();
            User user;
            foreach (LossReport lossReport in lossReports)
            {
                lossReport.SpeciesName = ((SpeciesType)lossReport.Species).ToString();
                user = DataRepository.User.Get(lossReport.UserId);
                lossReport.userLoginId = user.Id;
            }
            return lossReports;
        }

        //public List<LossReport> GetbyUserId(string userId)
        //{
        //    AnimalShelterManagementEntities context = CreateContext();
        //    List<LossReport> lossReports = DataRepository.LossReport.GetEvery();// new List<LossReport>();
        //    lossReports = lossReports.Where(x => x.UserLoginId == animalName).ToList();
        //    foreach (LossReport lossReport in context.LossReports)
        //    {
        //        if (lossReport.userLoginId.Contains(userId) == true)
        //            lossReports.Add(lossReport);
        //    }
        //    return lossReports;
        //}

        //public List<LossReport> GetbyAnimalName(string animalName)
        //{
        //    AnimalShelterManagementEntities context = CreateContext();
        //    List<LossReport> lossReports = DataRepository.LossReport.GetEvery();// new List<LossReport>();
        //    lossReports = lossReports.Where(x => x.AnimalName == animalName).ToList();
        //    foreach (LossReport lossReport in context.LossReports)
        //    {
        //        if (lossReport.AnimalName.Contains(animalName) == true)
        //            lossReports.Add(lossReport);
        //    }
        //    return lossReports;
        //}

    }
}

