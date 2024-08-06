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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmManagementApp.Forms
{
    public partial class ListAnimals : Form
    {
        private AnimalService AnimalService;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;

        public ListAnimals()
        {
            InitializeComponent();
            AnimalService = new AnimalService();

            InitializeDataGridView();
            LoadInitialData();
            BindDataToDataGridView();
            InitializeTimer();
            InitializeProgressBar();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InitializeDataGridView()
        {
            dataGridViewAnimals.AutoGenerateColumns = true;
            dataGridViewAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewAnimals.MultiSelect = false;
            dataGridViewAnimals.AllowUserToAddRows = false;
            dataGridViewAnimals.AllowUserToDeleteRows = false;
            dataGridViewAnimals.Font = new Font("Microsoft JhengHei UI", 9, FontStyle.Regular);
            dataGridViewAnimals.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewAnimals.DefaultCellStyle.SelectionBackColor = dataGridViewAnimals.DefaultCellStyle.BackColor;
            dataGridViewAnimals.DefaultCellStyle.SelectionForeColor = dataGridViewAnimals.DefaultCellStyle.ForeColor;
            
        }

        private void LoadInitialData()
        {
            AnimalService.AddAnimal(AnimalTypes.Cow);
            AnimalService.AddAnimal(AnimalTypes.Sheep);
            AnimalService.AddAnimal(AnimalTypes.Chicken);
        }

        private void BindDataToDataGridView()
        {
            var random = new Random();
            dataGridViewAnimals.DataSource = AnimalService.GetAnimals().Select(a => new
            {
                Type = a.GetType().Name,
                //Age = a.Age,
                Age = random.Next(1, 15),
                Lifespan = a.LifeSpan,
                //Gender = a.Gender,
               // Lifespan = random.Next(5, 20), // Random lifespan between 5 and 20
                Gender = random.Next(2) == 0 ? "Male" : "Female" // Randomly generates true or false


            }).ToList();
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 60000; // Age animals every 60 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            AnimalService.AgeAllAnimalsOneYear();
            BindDataToDataGridView();
            UpdateProgressBar();
        }

        private void InitializeProgressBar()
        {
            progressBar = new System.Windows.Forms.ProgressBar();
            progressBar.Minimum = 0;
            progressBar.Maximum = 100;
            progressBar.Step = 1;
            progressBar.Value = 0;
            progressBar.Location = new Point(12, 410);
            progressBar.Size = new Size(776, 23);
            Controls.Add(progressBar);
        }

        private void UpdateProgressBar()
        {
            int totalAnimals = AnimalService.GetAnimals().Count;
            int agedAnimals = AnimalService.GetAnimals().Count(a => a.Age > 0);
            progressBar.Value = totalAnimals > 0 ? (agedAnimals * 100 / totalAnimals) : 0;
        }

        
    }
}
