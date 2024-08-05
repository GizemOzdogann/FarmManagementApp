using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FarmManagementApp.Data
{

    public enum AnimalTypes
    {
        Cow, 
        Chicken,
        Sheep
    }
    public static class AnimalFactory 
    {
        public static IAnimal CreateAnimal(AnimalTypes type)
        {
            return type switch
            {
                AnimalTypes.Cow => new Cow(),
                AnimalTypes.Chicken => new Chicken(),
                AnimalTypes.Sheep => new Sheep("sheep"),
                _ => throw new ArgumentException("Invalid Animal Type", nameof(type)),
            };
        }

    }

    
    // lifespan, 
    public abstract class Animal : IAnimal
    {
        // virtual ???
        public virtual int LifeSpan => 1;
        public virtual void ProduceProduct()
        {
            throw new NotImplementedException();
        }
    }

    #region Interfaces
    public interface IAnimal
    {
        void ProduceProduct();
    }
    public interface IProduct
    {
        string ProductType { get; }
        int Quantity { get; }
        /// replace with price
    }
    #endregion Interfaces

    #region Products

    public class Meat : IProduct
    {
        public string ProductType { get; private set; }
        public int Quantity { get; private set; }

        public Meat(int quantity)
        {
            ProductType = "Meat";
            Quantity = quantity;
        }

        public void CreateProduct()
        {
            Console.WriteLine(nameof(ProductType), "Produced");
        }
    }
    public class Milk : IProduct
    {
        public string ProductType { get; set; }
        public int Quantity { get; set; } 
        public Milk(int quantity)
        {
            ProductType = "Milk";
            Quantity = quantity;
        }

        public void CreateProduct()
        {
            Console.WriteLine(nameof(ProductType), "Produced");
        }
    }
    public class Egg : IProduct
    {
        public string ProductType { get; private set; }
        public int Quantity { get; private set; }
        public Egg(int quantity)
        {
            ProductType = "Egg";
            Quantity = quantity;
        }

        public void CreateProduct()
        {
            Console.WriteLine(nameof(ProductType), "Produced");
        }
    }

    #endregion Products

    #region Animals

    public class Cow : Animal
    {
        public override int LifeSpan => base.LifeSpan;

        public IProduct ProduceMilk()
        {
            return new Milk(new Random().Next(5, 15)); 
        }

        public IProduct ProduceMeat()
        {
            return new Meat(new Random().Next(20, 50)); 
        }
        public override void ProduceProduct()
        {
            Console.WriteLine("Cow produces Milk and Meat.");
        }
    }
    public class Chicken : Animal
    {
        
        public IProduct ProduceEggs()
        {
            return new Egg(new Random().Next(1, 10)); 
        }
        public IProduct ProduceMeat()
        {
            return new Meat(new Random().Next(5, 15)); 
        }
        public override void ProduceProduct()
        {
            Console.WriteLine("Chicken produces Eggs and Meat.");
        }
    }
    public class Sheep : Animal
    {
        public string Name { get; set; }
        public Sheep(string name)
        {
            Name = name;
        }
        public IProduct ProduceMeat()
        {
            return new Meat(new Random().Next(15, 30)); 
        }
        public override void ProduceProduct()
        {
            Console.WriteLine("Sheep produces Meat and possibly Wool.");
        }
    }

    #endregion Animals

}
