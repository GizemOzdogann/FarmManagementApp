using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagementApp.Data
{
    public abstract class Animal
    {   
        public int Age { get; set; }
        public string Type { get; set; }
        public int Lifetime { get; set; }
        public int DaysLived => Lifetime - Age;
        public Dictionary<string, decimal> ProductAmounts { get; protected set; }

        protected Animal(string type, string gender, int lifetime)
        {
            Type = type;
            Lifetime = lifetime;
            Age = 0;

            ProductAmounts = new Dictionary<string, decimal>
        {
            { "Meat", 0 },
            { "Milk", 0 },
            { "Egg", 0 }
        };

        }

    }
}