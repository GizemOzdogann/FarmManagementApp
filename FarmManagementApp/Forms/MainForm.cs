using System.Drawing.Text;
using System.Data.SqlClient;
using System.Data;
using FarmManagementApp.Forms;
using FarmManagementApp.Data;

namespace FarmManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
            
        }

        public void LoadForm(Form form)
        {
            if (this.MainPanel == null)
            {
                throw new InvalidOperationException("MainPanel is not initialized.");
            }

            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            // Check if the form is valid
            if (form == null)
            {
                throw new ArgumentNullException(nameof(form), "The form parameter cannot be null.");
            }

            // Set form properties
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            // Add form to MainPanel
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;

            // Show the form
            form.Show();
        }


        //SqlConnection conn = new("Data Source=GIZEM\\SQLEXPRESS;Integrated Security=True; Initial Catalog=FarmDatabase");

        /*public void DisplayData(string data)
        {
            SqlDataAdapter adapter = new(data,conn);
            DataSet dataSet = new();
            adapter.Fill(dataSet);
        
        }*/

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void CustomizeDesign()
        {
            animalsSubPanel.Visible = false;
            productsSubPanel.Visible = false;
            salesSubPanel.Visible = false;
        }

        private void HideSubMenu()
        {
            if (animalsSubPanel.Visible) animalsSubPanel.Visible = false;
            if (salesSubPanel.Visible) salesSubPanel.Visible = false;
            if (productsSubPanel.Visible) productsSubPanel.Visible = false;
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }

        private void AnimalsButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(animalsSubPanel);
        }

        #region AnimalsSubMenu
        private void ListAnimalsButton_Click(object sender, EventArgs e)
        {
            //...
            LoadForm(new ListAnimals());
            HideSubMenu();
        }

        private void AddAnimalsButton_Click(object sender, EventArgs e)
        {
            //...
            LoadForm(new AddNewAnimal());
            HideSubMenu();
        }

        #endregion AnimalsSubMenu

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(productsSubPanel);
        }

        #region ProductsSubMenu

        private void ShowProductsButton_Click(object sender, EventArgs e)
        {
            //...
            LoadForm(new ListProducts());
            HideSubMenu();
        }

        #endregion ProductsSubMenu

        private void SalesButton_Click(object sender, EventArgs e)
        {
            ShowSubMenu(salesSubPanel);
        }

        #region SalesSubMenu

        private void CashStatusButton_Click(object sender, EventArgs e)
        {
            //...
            LoadForm(new CashStatus());
            HideSubMenu();
        }

        private void SellProductsButton_Click(object sender, EventArgs e)
        {
            //...
            HideSubMenu();
        }

        #endregion SalesSubMenu

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}