using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static FarmManagementApp.Data.ProductFactory;

namespace FarmManagementApp.Data
{
    public enum ProductTypes
    {
        Egg,
        Meat,
        Milk
    }

    public interface IProduct
    {
        ProductTypes Type { get; }
        int Price { get; }
    }

    public static class ProductFactory
    {
        public static IProduct CreateProduct(ProductTypes type)
        {
            switch (type)
            {
                case ProductTypes.Meat:
                    return new Meat();

                case ProductTypes.Milk:
                    return new Milk();

                case ProductTypes.Egg:
                    return new Egg();

                default:
                    throw new ArgumentException("Invalid product type");
            }
        }

    }


    #region Products

    public class Meat : IProduct
    {
        public ProductTypes Type { get; }
        public int Price { get; }

        public Meat()
        {
            Type = ProductTypes.Meat;
            Price = 100;
        }

        public void CreateProduct()
        {
            Console.WriteLine($"{Type} produced");
        }
    }
    public class Milk : IProduct
    {
        public ProductTypes Type { get; }
        public int Price { get;  }
        public Milk()
        {
            Type = ProductTypes.Milk;
            Price = 50;
        }

        public void CreateProduct()
        {
            Console.WriteLine($"{Type} produced");
        }
    }
    public class Egg : IProduct
    {
        public ProductTypes Type { get; }
        public int Price { get; }


        public Egg()
        {
            Price = 30;
            Type = ProductTypes.Egg;
        }

        public void CreateProduct()
        {
            Console.WriteLine($"{Type} produced");
        }
    }

    #endregion Products

}
