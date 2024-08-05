using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagementApp.Data
{
    // crud 
    public class AnimalService
    {
        private List<IAnimal> animals = new List<IAnimal>();

        public void AddAnimal(AnimalTypes animalType)
        {
            IAnimal animal = AnimalFactory.CreateAnimal(animalType);
            animals.Add(animal);
        }

        public void ProduceAllProducts()
        {
            foreach (var animal in animals)
            {
                animal.ProduceProduct();
            }
        }

        public List<IAnimal> GetAnimals()
        {
            return animals;
        }
    }
   
}
