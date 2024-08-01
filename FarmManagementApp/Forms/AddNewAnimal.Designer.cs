namespace FarmManagementApp.Forms
{
    partial class AddNewAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ComboBox AnimalPickComboBox;
            ComboBox AgePickComboBox;
            panel1 = new Panel();
            exitButton = new Button();
            PageLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            ProductNameLabel = new Label();
            ChooseAnimalLabel = new Label();
            label2 = new Label();
            ChooseAgeLabel = new Label();
            SaveButton = new Button();
            AnimalPickComboBox = new ComboBox();
            AgePickComboBox = new ComboBox();
            panel1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // AnimalPickComboBox
            // 
            AnimalPickComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AnimalPickComboBox.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalPickComboBox.FormattingEnabled = true;
            AnimalPickComboBox.ImeMode = ImeMode.On;
            AnimalPickComboBox.IntegralHeight = false;
            AnimalPickComboBox.ItemHeight = 20;
            AnimalPickComboBox.Location = new Point(211, 72);
            AnimalPickComboBox.Name = "AnimalPickComboBox";
            AnimalPickComboBox.Size = new Size(169, 28);
            AnimalPickComboBox.TabIndex = 1;
            // 
            // AgePickComboBox
            // 
            AgePickComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AgePickComboBox.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgePickComboBox.FormattingEnabled = true;
            AgePickComboBox.ImeMode = ImeMode.On;
            AgePickComboBox.IntegralHeight = false;
            AgePickComboBox.ItemHeight = 20;
            AgePickComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            AgePickComboBox.Location = new Point(211, 116);
            AgePickComboBox.Name = "AgePickComboBox";
            AgePickComboBox.Size = new Size(169, 28);
            AgePickComboBox.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(PageLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 35);
            panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(827, 3);
            exitButton.Margin = new Padding(4, 3, 4, 3);
            exitButton.Name = "exitButton";
            exitButton.Padding = new Padding(12, 0, 0, 0);
            exitButton.Size = new Size(73, 29);
            exitButton.TabIndex = 14;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // PageLabel
            // 
            PageLabel.AutoSize = true;
            PageLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PageLabel.ForeColor = SystemColors.HighlightText;
            PageLabel.Location = new Point(12, 9);
            PageLabel.Name = "PageLabel";
            PageLabel.Size = new Size(132, 20);
            PageLabel.TabIndex = 10;
            PageLabel.Text = "Add New Animal";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(212, 28);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(211, 24);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(14, 69);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(0, 18);
            ProductNameLabel.TabIndex = 2;
            // 
            // ChooseAnimalLabel
            // 
            ChooseAnimalLabel.AutoSize = true;
            ChooseAnimalLabel.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseAnimalLabel.ForeColor = SystemColors.WindowFrame;
            ChooseAnimalLabel.Location = new Point(60, 75);
            ChooseAnimalLabel.Name = "ChooseAnimalLabel";
            ChooseAnimalLabel.Size = new Size(145, 20);
            ChooseAnimalLabel.TabIndex = 4;
            ChooseAnimalLabel.Text = "Choose Animal Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowFrame;
            label2.Location = new Point(264, 52);
            label2.Name = "label2";
            label2.Size = new Size(0, 18);
            label2.TabIndex = 5;
            // 
            // ChooseAgeLabel
            // 
            ChooseAgeLabel.AutoSize = true;
            ChooseAgeLabel.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseAgeLabel.ForeColor = SystemColors.WindowFrame;
            ChooseAgeLabel.Location = new Point(169, 119);
            ChooseAgeLabel.Name = "ChooseAgeLabel";
            ChooseAgeLabel.Size = new Size(36, 20);
            ChooseAgeLabel.TabIndex = 9;
            ChooseAgeLabel.Text = "Age";
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = SystemColors.WindowFrame;
            SaveButton.Location = new Point(211, 218);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(115, 29);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Save";
            SaveButton.TextAlign = ContentAlignment.BottomCenter;
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // AddNewAnimal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 405);
            Controls.Add(SaveButton);
            Controls.Add(AgePickComboBox);
            Controls.Add(ChooseAgeLabel);
            Controls.Add(label2);
            Controls.Add(ChooseAnimalLabel);
            Controls.Add(AnimalPickComboBox);
            Controls.Add(ProductNameLabel);
            Controls.Add(panel1);
            Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddNewAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddNewAnimal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Label ProductNameLabel;
        private ComboBox AnimalPickComboBox;
        private Label ChooseAnimalLabel;
        private Label label2;
        private Label ChooseAgeLabel;
        private Label PageLabel;
        private Button SaveButton;
        private Button exitButton;
    }
}