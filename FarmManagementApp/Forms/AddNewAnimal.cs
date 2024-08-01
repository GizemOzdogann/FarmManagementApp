using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FarmManagementApp.Forms
{
    public partial class AddNewAnimal : Form
    {
        public AddNewAnimal()
        {
            InitializeComponent();
            InitializeAnimalPickComboBox();
            //InitializeBreedPickComboBox();

        }
        private void InitializeAnimalPickComboBox()
        {
            AnimalPickComboBox.Items.AddRange(new[] { "Cow", "Sheep", "Chicken" });
        }
        private void InitializeBreedPickComboBox()
        {
            BreedPickComboBox.Items.AddRange(new[] { "Breed A", "Breed B" });
        }






        private void AddNewAnimal_Load(object sender, EventArgs e)
        {

        }

        private void AddNewAnimal_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


      
    }
}
