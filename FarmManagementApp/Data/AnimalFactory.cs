using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
//using static FarmManagementApp.Data.ProductFactory;

namespace FarmManagementApp.Data
{
    public enum AnimalTypes
    {
        Cow, 
        Chicken,
        Sheep
    }

    public interface IAnimal
    {
        bool Gender { get; set; }
        int Age { get; set; }
        int LifeSpan { get;}
        public void ProduceProduct();
         
    }

    public static class AnimalFactory 
    {
        public static IAnimal CreateAnimal(AnimalTypes type) => type switch
        {
            AnimalTypes.Cow => new Cow(),
            AnimalTypes.Chicken => new Chicken(),
            AnimalTypes.Sheep => new Sheep(),
            _ => throw new ArgumentException($"Invalid Animal Type, {type}"),
        };
    }

    public abstract class Animal : IAnimal
    {

        public int Age { get; set; }
        public virtual int LifeSpan => 0;

        public bool Gender { get ; set ; }

        public virtual void ProduceProduct()
        {
        }
        
    }

    #region Animals

    public class Cow : Animal
    {

        public override int LifeSpan => 20;

        public IProduct ProduceMilk()
        {
            return new Milk(); 
        }

        public IProduct ProduceMeat()
        {
            return new Meat(); 
        }
        public override void ProduceProduct()
        {
            Console.WriteLine("Cow produces Milk and Meat.");
        }
    }

    public class Chicken : Animal
    {
        public override int LifeSpan => 10;

        public IProduct ProduceMeat()
        {
            return new Meat(); 
        }
        public override void ProduceProduct()
        {
            Console.WriteLine("Chicken produces Eggs and Meat.");
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }

    public class Sheep : Animal
    {
        public override int LifeSpan => 15;
        public IProduct ProduceMeat()
        {
            return new Meat(); 
        }
        public override void ProduceProduct()
        {
            Console.WriteLine("Sheep produces Meat.");
        }
    }

    #endregion Animals
}
