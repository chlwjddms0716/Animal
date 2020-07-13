using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem.Data
{
    public class DataRepository
    {


        public static AnimalShelter AnimalShelter { get; } = new AnimalShelter();
        public static HomelessAnimalData HomelessAnimal { get; } = new HomelessAnimalData();

        public static UserData User { get; } = new UserData();
        public static AdoptionData Adoption { get; } = new AdoptionData();

        public static FindingReportData FindingReport { get; } = new FindingReportData();

        public static FindingReportRecordData FindingReportRecord { get; } = new FindingReportRecordData();

        public static FoundAnimalRecordData FoundAnimalRecord { get; } = new FoundAnimalRecordData();

        public static PhysicalConditionData PhysicalCondition { get; } = new PhysicalConditionData();

        public static Sex Sex { get; } = new Sex();

        public static LossReportData LossReport { get; } = new LossReportData();

        public static SpeciesData Species { get; } = new SpeciesData();
    }
}
