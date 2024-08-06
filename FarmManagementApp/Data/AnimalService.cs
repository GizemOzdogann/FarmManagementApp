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
        private List<IAnimal> animals;

        public AnimalService()
        {
            animals = new List<IAnimal>();
        }

        // Create
        public void AddAnimal(AnimalTypes animalType)
        {
            IAnimal animal = AnimalFactory.CreateAnimal(animalType);
            animals.Add(animal);
        }

        // Read
        public List<IAnimal> GetAnimals()
        {
            return animals;
        }

        // Update
        public bool UpdateAnimal(int index, AnimalTypes type)
        {
            if (index < 0 || index >= animals.Count)
                return false;

            var animal = AnimalFactory.CreateAnimal(type);
            animals[index] = animal;
            return true;
        }
        
        private void RemoveAnimalsAtEndOfLife()
        {
            animals.RemoveAll(a => a.Age >= a.LifeSpan);
        }

        public void AgeAllAnimalsOneYear()
        {
            foreach (var animal in animals)
            {
                animal.Age++;
            }
            RemoveAnimalsAtEndOfLife();
        }

    }
   
}
