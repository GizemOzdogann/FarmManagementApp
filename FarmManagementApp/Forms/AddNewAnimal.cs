using FarmManagementApp.Data;
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
        public AnimalTypes SelectedAnimalType { get; private set; }


        private AnimalService animalService = new AnimalService();

        public AddNewAnimal()
        {
            InitializeComponent();
        }

        private void InitializeAnimalPickComboBox()
        {
            AnimalPickComboBox.DataSource = Enum.GetValues(typeof(AnimalTypes));
        }

        private void AddNewAnimal_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (AnimalPickComboBox.SelectedItem is AnimalTypes selectedAnimalType)
            {
                SelectedAnimalType = selectedAnimalType; 
                animalService.AddAnimal(selectedAnimalType);
                DialogResult = DialogResult.OK;
                Close();
                UpdateAnimalList();
            }
        }

        private void UpdateAnimalList()
        {

        }
    }
}
