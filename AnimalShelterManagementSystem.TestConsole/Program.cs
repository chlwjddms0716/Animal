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
            var list = DataRepository.HomelessAnimal.SearchWithAnimals((int)SpeciesType.개, false, false);
            foreach (var x in list)
            {
                Console.WriteLine($"{x.HomelessAnimalId} / {x.Gender}");
            }
            Console.ReadLine();
        }
    }
}
