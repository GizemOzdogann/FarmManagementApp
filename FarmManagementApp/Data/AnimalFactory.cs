using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManagementApp.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm farmBarn = new FarmBarn();

            Cow cow = (Cow)farmBarn.OrderAnimal("cow");
            Chicken chicken = (Chicken)farmBarn.OrderAnimal("chicken");
            Sheep sheep = (Sheep)farmBarn.OrderAnimal("sheep");

            DisplayProduct(cow.ProduceMilk());
            DisplayProduct(cow.ProduceMeat());

            DisplayProduct(chicken.ProduceEggs());
            DisplayProduct(chicken.ProduceMeat());

            DisplayProduct(sheep.ProduceMeat());
        }
        static void DisplayProduct(IProduct product)
        {
            Console.WriteLine($"{product.Quantity} units of {product.ProductType} produced.");
        }
    }
    public abstract class Farm
    {
        protected abstract IAnimal CreateAnimal(string type);

        public IAnimal OrderAnimal(string type)
        {
            IAnimal animal = CreateAnimal(type);
            animal.ProduceProduct();
            return animal;
        }
    }

    public class FarmBarn : Farm
    {
        protected override IAnimal CreateAnimal(string type)
        {
            return type switch
            {
                "cow" => new Cow(),
                "chicken" => new Chicken(),
                "sheep" => new Sheep(),
                _ => throw new ArgumentException("Invalid Animal Type", nameof(type)),
            };
        }
    }

    public interface IAnimal
    {
        void ProduceProduct();
    }
    public interface IProduct
    {
        string ProductType { get; }
        int Quantity { get; }

        
    }

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


    public class Cow : IAnimal
    {
        public IProduct ProduceMilk()
        {
            return new Milk(new Random().Next(5, 15)); 
        }

        public IProduct ProduceMeat()
        {
            return new Meat(new Random().Next(20, 50)); 
        }
        public void ProduceProduct()
        {
            Console.WriteLine("Cow produces Milk and Meat.");
        }
    }
    public class Chicken : IAnimal
    {
        public IProduct ProduceEggs()
        {
            return new Egg(new Random().Next(1, 10)); 
        }
        public IProduct ProduceMeat()
        {
            return new Meat(new Random().Next(5, 15)); 
        }
        public void ProduceProduct()
        {
            Console.WriteLine("Chicken produces Eggs and Meat.");
        }
    }
    public class Sheep : IAnimal
    {
        public IProduct ProduceMeat()
        {
            return new Meat(new Random().Next(15, 30)); 
        }
        public void ProduceProduct()
        {
            Console.WriteLine("Sheep produces Meat and possibly Wool.");
        }
    }


        
}
