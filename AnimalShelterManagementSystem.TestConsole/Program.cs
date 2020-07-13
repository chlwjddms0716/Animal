using AnimalShelterManagementSystem.Data;
using AnimalShelterManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterManagementSystem.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = DataRepository.Adoption.Search("이권능", 1);
        }
    }
}
