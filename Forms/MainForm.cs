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
            HideSubMenu();
            if (!subMenu.Visible) subMenu.Visible = true;
       
            else subMenu.Visible = false;
        }



    }

}
