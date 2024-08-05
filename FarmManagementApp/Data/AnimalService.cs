using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagementApp.Data
{
    internal class AnimalService
    {
        // 
        public AnimalService() 
        {
            AnimalFactory.CreateAnimal(AnimalTypes.Cow);
        }
    }
}
