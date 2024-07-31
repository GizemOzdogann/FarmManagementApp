
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
            logoLabel = new Label();
            sidePanel.SuspendLayout();
            salesSubPanel.SuspendLayout();
            productsSubPanel.SuspendLayout();
            animalsSubPanel.SuspendLayout();
            logoPanel.SuspendLayout();
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
            sidePanel.Margin = new Padding(4, 3, 4, 3);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(211, 551);
            sidePanel.TabIndex = 0;
            // 
            // salesSubPanel
            // 
            salesSubPanel.Controls.Add(SellProductsButton);
            salesSubPanel.Controls.Add(CashStatusButton);
            salesSubPanel.Dock = DockStyle.Top;
            salesSubPanel.Location = new Point(0, 348);
            salesSubPanel.Margin = new Padding(4, 3, 4, 3);
            salesSubPanel.Name = "salesSubPanel";
            salesSubPanel.Size = new Size(211, 98);
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
            SellProductsButton.Location = new Point(0, 48);
            SellProductsButton.Margin = new Padding(4, 3, 4, 3);
            SellProductsButton.Name = "SellProductsButton";
            SellProductsButton.Padding = new Padding(32, 0, 0, 0);
            SellProductsButton.Size = new Size(211, 48);
            SellProductsButton.TabIndex = 7;
            SellProductsButton.Text = "Sell Products";
            SellProductsButton.TextAlign = ContentAlignment.MiddleLeft;
            SellProductsButton.UseVisualStyleBackColor = true;
            SellProductsButton.Click += SellProductsButton_Click;
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
            CashStatusButton.Margin = new Padding(4, 3, 4, 3);
            CashStatusButton.Name = "CashStatusButton";
            CashStatusButton.Padding = new Padding(32, 0, 0, 0);
            CashStatusButton.Size = new Size(211, 48);
            CashStatusButton.TabIndex = 6;
            CashStatusButton.Text = "Cash Status";
            CashStatusButton.TextAlign = ContentAlignment.MiddleLeft;
            CashStatusButton.UseVisualStyleBackColor = true;
            CashStatusButton.Click += CashStatusButton_Click;
            // 
            // SalesButton
            // 
            SalesButton.Dock = DockStyle.Top;
            SalesButton.FlatAppearance.BorderSize = 0;
            SalesButton.FlatStyle = FlatStyle.Flat;
            SalesButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            SalesButton.ForeColor = SystemColors.Window;
            SalesButton.Location = new Point(0, 300);
            SalesButton.Margin = new Padding(4, 3, 4, 3);
            SalesButton.Name = "SalesButton";
            SalesButton.Padding = new Padding(12, 0, 0, 0);
            SalesButton.Size = new Size(211, 48);
            SalesButton.TabIndex = 9;
            SalesButton.Text = "Sales";
            SalesButton.TextAlign = ContentAlignment.MiddleLeft;
            SalesButton.UseVisualStyleBackColor = true;
            SalesButton.Click += SalesButton_Click;
            // 
            // productsSubPanel
            // 
            productsSubPanel.Controls.Add(ShowProductsButton);
            productsSubPanel.Dock = DockStyle.Top;
            productsSubPanel.Location = new Point(0, 252);
            productsSubPanel.Margin = new Padding(4, 3, 4, 3);
            productsSubPanel.Name = "productsSubPanel";
            productsSubPanel.Size = new Size(211, 48);
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
            ShowProductsButton.Margin = new Padding(4, 3, 4, 3);
            ShowProductsButton.Name = "ShowProductsButton";
            ShowProductsButton.Padding = new Padding(32, 0, 0, 0);
            ShowProductsButton.Size = new Size(211, 48);
            ShowProductsButton.TabIndex = 5;
            ShowProductsButton.Text = "Show Product List";
            ShowProductsButton.TextAlign = ContentAlignment.MiddleLeft;
            ShowProductsButton.UseVisualStyleBackColor = true;
            ShowProductsButton.Click += ShowProductsButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Dock = DockStyle.Top;
            ProductsButton.FlatAppearance.BorderSize = 0;
            ProductsButton.FlatStyle = FlatStyle.Flat;
            ProductsButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ProductsButton.ForeColor = SystemColors.Window;
            ProductsButton.Location = new Point(0, 204);
            ProductsButton.Margin = new Padding(4, 3, 4, 3);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Padding = new Padding(12, 0, 0, 0);
            ProductsButton.Size = new Size(211, 48);
            ProductsButton.TabIndex = 7;
            ProductsButton.Text = "Products";
            ProductsButton.TextAlign = ContentAlignment.MiddleLeft;
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // animalsSubPanel
            // 
            animalsSubPanel.Controls.Add(AddAnimalsButton);
            animalsSubPanel.Controls.Add(ListAnimalsButton);
            animalsSubPanel.Dock = DockStyle.Top;
            animalsSubPanel.Location = new Point(0, 106);
            animalsSubPanel.Margin = new Padding(4, 3, 4, 3);
            animalsSubPanel.Name = "animalsSubPanel";
            animalsSubPanel.Size = new Size(211, 98);
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
            AddAnimalsButton.Location = new Point(0, 48);
            AddAnimalsButton.Margin = new Padding(4, 3, 4, 3);
            AddAnimalsButton.Name = "AddAnimalsButton";
            AddAnimalsButton.Padding = new Padding(32, 0, 0, 0);
            AddAnimalsButton.Size = new Size(211, 50);
            AddAnimalsButton.TabIndex = 6;
            AddAnimalsButton.Text = "Add New Animal";
            AddAnimalsButton.TextAlign = ContentAlignment.MiddleLeft;
            AddAnimalsButton.UseVisualStyleBackColor = true;
            AddAnimalsButton.Click += AddAnimalsButton_Click;
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
            ListAnimalsButton.Margin = new Padding(4, 3, 4, 3);
            ListAnimalsButton.Name = "ListAnimalsButton";
            ListAnimalsButton.Padding = new Padding(32, 0, 0, 0);
            ListAnimalsButton.Size = new Size(211, 48);
            ListAnimalsButton.TabIndex = 5;
            ListAnimalsButton.Text = "List Animals";
            ListAnimalsButton.TextAlign = ContentAlignment.MiddleLeft;
            ListAnimalsButton.UseVisualStyleBackColor = true;
            ListAnimalsButton.Click += ListAnimalsButton_Click;
            // 
            // exitButton
            // 
            exitButton.Dock = DockStyle.Bottom;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            exitButton.Location = new Point(0, 511);
            exitButton.Margin = new Padding(4, 3, 4, 3);
            exitButton.Name = "exitButton";
            exitButton.Padding = new Padding(12, 0, 0, 0);
            exitButton.Size = new Size(211, 40);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // AnimalsButton
            // 
            AnimalsButton.BackColor = Color.RoyalBlue;
            AnimalsButton.Dock = DockStyle.Top;
            AnimalsButton.FlatAppearance.BorderSize = 0;
            AnimalsButton.FlatStyle = FlatStyle.Flat;
            AnimalsButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            AnimalsButton.ForeColor = SystemColors.Window;
            AnimalsButton.Location = new Point(0, 58);
            AnimalsButton.Margin = new Padding(4, 3, 4, 3);
            AnimalsButton.Name = "AnimalsButton";
            AnimalsButton.Padding = new Padding(12, 0, 0, 0);
            AnimalsButton.Size = new Size(211, 48);
            AnimalsButton.TabIndex = 1;
            AnimalsButton.Text = "Animals";
            AnimalsButton.TextAlign = ContentAlignment.MiddleLeft;
            AnimalsButton.UseVisualStyleBackColor = false;
            AnimalsButton.Click += AnimalsButton_Click;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(logoLabel);
            logoPanel.Dock = DockStyle.Top;
            logoPanel.Location = new Point(0, 0);
            logoPanel.Margin = new Padding(4, 3, 4, 3);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(211, 58);
            logoPanel.TabIndex = 0;
            // 
            // logoLabel
            // 
            logoLabel.AutoSize = true;
            logoLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            logoLabel.Location = new Point(13, 21);
            logoLabel.Margin = new Padding(4, 0, 4, 0);
            logoLabel.Name = "logoLabel";
            logoLabel.Size = new Size(117, 20);
            logoLabel.TabIndex = 0;
            logoLabel.Text = "Farm Manager";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 551);
            Controls.Add(sidePanel);
            Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Window;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Farm Manager";
            Load += MainForm_Load;
            Click += MainForm_Load;
            sidePanel.ResumeLayout(false);
            salesSubPanel.ResumeLayout(false);
            productsSubPanel.ResumeLayout(false);
            animalsSubPanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
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
        private Label logoLabel;
    }
}
