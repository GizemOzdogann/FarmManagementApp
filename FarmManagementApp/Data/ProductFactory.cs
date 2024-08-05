using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FarmManagementApp.Data.ProductFactory;

namespace FarmManagementApp.Data
{
    public enum ProductTypes
    {
        Egg,
        Meat,
        Milk
    }
    public static class ProductFactory
    {
        public static IProduct CreateProduct(ProductTypes type, int price)
        {
            switch (type)
            {
                case ProductTypes.Meat:
                    return new Meat(price);

                case ProductTypes.Milk:
                    return new Milk(price);

                case ProductTypes.Egg:
                    return new Egg(price);

                default:
                    throw new ArgumentException("Invalid product type");
            }
        }

    }
    #region Products

    public class Meat : IProduct
    {
        public ProductTypes Type { get; }
        public int Price { get; set; }

        public Meat(int price)
        {
            Type = ProductTypes.Meat;
            Price = price;
        }

        public void CreateProduct()
        {
            Console.WriteLine($"{Type} produced");
        }
    }
    public class Milk : IProduct
    {
        public ProductTypes Type { get; }
        public int Price { get; set; }
        public Milk(int price)
        {
            Type = ProductTypes.Milk;
            Price = price;
        }

        public void CreateProduct()
        {
            Console.WriteLine($"{Type} produced");
        }
    }
    public class Egg : IProduct
    {
        public ProductTypes Type { get; }
        public int Price { get; set; }


        public Egg(int price)
        {

            Price = price;
            Type = ProductTypes.Egg;
        }

        public void CreateProduct()
        {
            Console.WriteLine($"{Type} produced");
        }
    }

    #endregion Products

}
