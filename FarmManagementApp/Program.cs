using FarmManagementApp.Data;
using FarmManagementApp.Forms;

namespace FarmManagementApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainForm());
            Application.Run(new AddNewAnimal());


            AnimalFactory farmBarn = new FarmBarn();

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
}