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

    public enum ProductTypes
    {
        Egg,
        Meat,
        Milk
    }
    public static class AnimalFactory 
    {
        public static IAnimal CreateAnimal(AnimalTypes type)
        {
            return type switch
            {
                AnimalTypes.Cow => new Cow(),
                AnimalTypes.Chicken => new Chicken(),
                AnimalTypes.Sheep => new Sheep(),
                _ => throw new ArgumentException("Invalid Animal Type", nameof(type)),
            };
        }

    }

    public abstract class Animal : IAnimal
    {
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
        ProductTypes Type { get; }
        int Price { get; }
    }
    #endregion Interfaces

    #region Products

    public class Meat : IProduct
    {
        public ProductTypes Type { get; set; }
        public int Price { get;  set; }

        public Meat(int price)
        {
            Type = ProductTypes.Meat;
            Price = price;
        }

        public void CreateProduct()
        {
            Console.WriteLine(nameof(Type), "Produced");
        }
    }
    public class Milk : IProduct
    {
        public ProductTypes Type { get; set; }
        public int Price { get; set; } 
        public Milk(int price)
        {
            Type = ProductTypes.Milk;
            Price = price;
        }

        public void CreateProduct()
        {
            Console.WriteLine(nameof(Type), "Produced");
        }
    }
    public class Egg : IProduct
    {
        public ProductTypes Type {get; set;} 
        public int Price { get; private set; }


        public Egg(int price) 
        {
            
            Price = price;
            Type = ProductTypes.Egg;
        }

        public void CreateProduct()
        {
            Console.WriteLine(nameof(Type), "Produced");
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
        
        public IProduct ProduceMeat()
        {
            return new Meat(new Random().Next(15, 30)); 
        }
        public override void ProduceProduct()
        {
            Console.WriteLine("Sheep produces Meat.");
        }
    }

    #endregion Animals

}
