
namespace FarmManagementApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidePanel = new Panel();
            salesSubPanel = new Panel();
            SellProductsButton = new Button();
            CashStatusButton = new Button();
            SalesButton = new Button();
            productsSubPanel = new Panel();
            ShowProductsButton = new Button();
            ProductsButton = new Button();
            animalsSubPanel = new Panel();
            AddAnimalsButton = new Button();
            ListAnimalsButton = new Button();
            exitButton = new Button();
            AnimalsButton = new Button();
            logoPanel = new Panel();
            sidePanel.SuspendLayout();
            salesSubPanel.SuspendLayout();
            productsSubPanel.SuspendLayout();
            animalsSubPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.AutoScroll = true;
            sidePanel.BackColor = Color.RoyalBlue;
            sidePanel.Controls.Add(salesSubPanel);
            sidePanel.Controls.Add(SalesButton);
            sidePanel.Controls.Add(productsSubPanel);
            sidePanel.Controls.Add(ProductsButton);
            sidePanel.Controls.Add(animalsSubPanel);
            sidePanel.Controls.Add(exitButton);
            sidePanel.Controls.Add(AnimalsButton);
            sidePanel.Controls.Add(logoPanel);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.ForeColor = SystemColors.Window;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(248, 540);
            sidePanel.TabIndex = 0;
            // 
            // salesSubPanel
            // 
            salesSubPanel.Controls.Add(SellProductsButton);
            salesSubPanel.Controls.Add(CashStatusButton);
            salesSubPanel.Dock = DockStyle.Top;
            salesSubPanel.Location = new Point(0, 386);
            salesSubPanel.Name = "salesSubPanel";
            salesSubPanel.Size = new Size(248, 109);
            salesSubPanel.TabIndex = 10;
            // 
            // SellProductsButton
            // 
            SellProductsButton.Dock = DockStyle.Top;
            SellProductsButton.FlatAppearance.BorderSize = 0;
            SellProductsButton.FlatStyle = FlatStyle.Flat;
            SellProductsButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SellProductsButton.ForeColor = SystemColors.Window;
            SellProductsButton.ImageAlign = ContentAlignment.MiddleRight;
            SellProductsButton.Location = new Point(0, 53);
            SellProductsButton.Name = "SellProductsButton";
            SellProductsButton.Padding = new Padding(26, 0, 0, 0);
            SellProductsButton.Size = new Size(248, 53);
            SellProductsButton.TabIndex = 7;
            SellProductsButton.Text = "Sell Products";
            SellProductsButton.TextAlign = ContentAlignment.MiddleLeft;
            SellProductsButton.UseVisualStyleBackColor = true;
            // 
            // CashStatusButton
            // 
            CashStatusButton.Dock = DockStyle.Top;
            CashStatusButton.FlatAppearance.BorderSize = 0;
            CashStatusButton.FlatStyle = FlatStyle.Flat;
            CashStatusButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            CashStatusButton.ForeColor = SystemColors.Window;
            CashStatusButton.ImageAlign = ContentAlignment.MiddleRight;
            CashStatusButton.Location = new Point(0, 0);
            CashStatusButton.Name = "CashStatusButton";
            CashStatusButton.Padding = new Padding(26, 0, 0, 0);
            CashStatusButton.Size = new Size(248, 53);
            CashStatusButton.TabIndex = 6;
            CashStatusButton.Text = "Cash Status";
            CashStatusButton.TextAlign = ContentAlignment.MiddleLeft;
            CashStatusButton.UseVisualStyleBackColor = true;
            // 
            // SalesButton
            // 
            SalesButton.Dock = DockStyle.Top;
            SalesButton.FlatAppearance.BorderSize = 0;
            SalesButton.FlatStyle = FlatStyle.Flat;
            SalesButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SalesButton.ForeColor = SystemColors.Window;
            SalesButton.Location = new Point(0, 333);
            SalesButton.Name = "SalesButton";
            SalesButton.Padding = new Padding(10, 0, 0, 0);
            SalesButton.Size = new Size(248, 53);
            SalesButton.TabIndex = 9;
            SalesButton.Text = "Sales";
            SalesButton.TextAlign = ContentAlignment.MiddleLeft;
            SalesButton.UseVisualStyleBackColor = true;
            // 
            // productsSubPanel
            // 
            productsSubPanel.Controls.Add(ShowProductsButton);
            productsSubPanel.Dock = DockStyle.Top;
            productsSubPanel.Location = new Point(0, 280);
            productsSubPanel.Name = "productsSubPanel";
            productsSubPanel.Size = new Size(248, 53);
            productsSubPanel.TabIndex = 8;
            // 
            // ShowProductsButton
            // 
            ShowProductsButton.Dock = DockStyle.Top;
            ShowProductsButton.FlatAppearance.BorderSize = 0;
            ShowProductsButton.FlatStyle = FlatStyle.Flat;
            ShowProductsButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ShowProductsButton.ForeColor = SystemColors.Window;
            ShowProductsButton.ImageAlign = ContentAlignment.MiddleRight;
            ShowProductsButton.Location = new Point(0, 0);
            ShowProductsButton.Name = "ShowProductsButton";
            ShowProductsButton.Padding = new Padding(26, 0, 0, 0);
            ShowProductsButton.Size = new Size(248, 53);
            ShowProductsButton.TabIndex = 5;
            ShowProductsButton.Text = "Show Product List";
            ShowProductsButton.TextAlign = ContentAlignment.MiddleLeft;
            ShowProductsButton.UseVisualStyleBackColor = true;
            // 
            // ProductsButton
            // 
            ProductsButton.Dock = DockStyle.Top;
            ProductsButton.FlatAppearance.BorderSize = 0;
            ProductsButton.FlatStyle = FlatStyle.Flat;
            ProductsButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ProductsButton.ForeColor = SystemColors.Window;
            ProductsButton.Location = new Point(0, 227);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Padding = new Padding(10, 0, 0, 0);
            ProductsButton.Size = new Size(248, 53);
            ProductsButton.TabIndex = 7;
            ProductsButton.Text = "Products";
            ProductsButton.TextAlign = ContentAlignment.MiddleLeft;
            ProductsButton.UseVisualStyleBackColor = true;
            // 
            // animalsSubPanel
            // 
            animalsSubPanel.Controls.Add(AddAnimalsButton);
            animalsSubPanel.Controls.Add(ListAnimalsButton);
            animalsSubPanel.Dock = DockStyle.Top;
            animalsSubPanel.Location = new Point(0, 118);
            animalsSubPanel.Name = "animalsSubPanel";
            animalsSubPanel.Size = new Size(248, 109);
            animalsSubPanel.TabIndex = 6;
            // 
            // AddAnimalsButton
            // 
            AddAnimalsButton.Dock = DockStyle.Top;
            AddAnimalsButton.FlatAppearance.BorderSize = 0;
            AddAnimalsButton.FlatStyle = FlatStyle.Flat;
            AddAnimalsButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AddAnimalsButton.ForeColor = SystemColors.Window;
            AddAnimalsButton.ImageAlign = ContentAlignment.MiddleRight;
            AddAnimalsButton.Location = new Point(0, 53);
            AddAnimalsButton.Name = "AddAnimalsButton";
            AddAnimalsButton.Padding = new Padding(26, 0, 0, 0);
            AddAnimalsButton.Size = new Size(248, 56);
            AddAnimalsButton.TabIndex = 6;
            AddAnimalsButton.Text = "Add New Animal";
            AddAnimalsButton.TextAlign = ContentAlignment.MiddleLeft;
            AddAnimalsButton.UseVisualStyleBackColor = true;
            // 
            // ListAnimalsButton
            // 
            ListAnimalsButton.Dock = DockStyle.Top;
            ListAnimalsButton.FlatAppearance.BorderSize = 0;
            ListAnimalsButton.FlatStyle = FlatStyle.Flat;
            ListAnimalsButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ListAnimalsButton.ForeColor = SystemColors.Window;
            ListAnimalsButton.ImageAlign = ContentAlignment.MiddleRight;
            ListAnimalsButton.Location = new Point(0, 0);
            ListAnimalsButton.Name = "ListAnimalsButton";
            ListAnimalsButton.Padding = new Padding(26, 0, 0, 0);
            ListAnimalsButton.Size = new Size(248, 53);
            ListAnimalsButton.TabIndex = 5;
            ListAnimalsButton.Text = "List Animals";
            ListAnimalsButton.TextAlign = ContentAlignment.MiddleLeft;
            ListAnimalsButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Bottom;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            exitButton.Location = new Point(0, 495);
            exitButton.Name = "exitButton";
            exitButton.Padding = new Padding(10, 0, 0, 0);
            exitButton.Size = new Size(248, 45);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = true;
            // 
            // AnimalsButton
            // 
            AnimalsButton.BackColor = Color.RoyalBlue;
            AnimalsButton.Dock = DockStyle.Top;
            AnimalsButton.FlatAppearance.BorderSize = 0;
            AnimalsButton.FlatStyle = FlatStyle.Flat;
            AnimalsButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AnimalsButton.ForeColor = SystemColors.Window;
            AnimalsButton.Location = new Point(0, 65);
            AnimalsButton.Name = "AnimalsButton";
            AnimalsButton.Padding = new Padding(10, 0, 0, 0);
            AnimalsButton.Size = new Size(248, 53);
            AnimalsButton.TabIndex = 1;
            AnimalsButton.Text = "Animals";
            AnimalsButton.TextAlign = ContentAlignment.MiddleLeft;
            AnimalsButton.UseVisualStyleBackColor = false;
            // 
            // logoPanel
            // 
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(248, 65);
            logoPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 540);
            Controls.Add(sidePanel);
            ForeColor = SystemColors.Window;
            Name = "MainForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Farm Manager";
            Load += MainForm_Load;
            Click += MainForm_Load;
            sidePanel.ResumeLayout(false);
            salesSubPanel.ResumeLayout(false);
            productsSubPanel.ResumeLayout(false);
            animalsSubPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidePanel;
        private Panel logoPanel;
        private Button AnimalsButton;
        private Button exitButton;
        private Panel animalsSubPanel;
        private Button ListAnimalsButton;
        private Button AddAnimalsButton;
        private Panel productsSubPanel;
        private Button ShowProductsButton;
        private Button SalesButton;
        private Panel salesSubPanel;
        private Button SellProductsButton;
        private Button CashStatusButton;
        private Button ProductsButton;
    }
}
