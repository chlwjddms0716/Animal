using AnimalShelterManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem
{
    partial class Adoption
    {
        public string userLoginId { get; set; }
        public string AnimalName { get; set; }
        public AdoptionStatusType AdoptionStatus { get; set; }

    }
}
