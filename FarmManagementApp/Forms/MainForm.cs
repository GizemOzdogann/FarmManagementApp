using System.Drawing.Text;
using System.Data.SqlClient;

namespace FarmManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        
        
        
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
            HideSubMenu();
        }

        private void AddAnimalsButton_Click(object sender, EventArgs e)
        {
            //...
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