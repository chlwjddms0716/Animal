using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem.Data
{
    public class DataRepository
    {



        public static HomelessAnimalData HomelessAnimal { get; } = new HomelessAnimalData();

        public static UserData User { get; } = new UserData();
        public static AdoptionData Adoption { get; } = new AdoptionData();

        public static FindingReportData FindingReport { get; } = new FindingReportData();

        public static FindingReportRecordData FindingReportRecord { get; } = new FindingReportRecordData();

        public static FoundAnimalRecordData FoundAnimalRecord { get; } = new FoundAnimalRecordData();



        public static LossReportData LossReport { get; } = new LossReportData();


        public static AnimalShelterData AnimalShelter { get; set; } = new AnimalShelterData();
    }
}
