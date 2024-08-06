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
            ComboBox AnimalPickComboBox;
            ComboBox AgePickComboBox;
            ChooseAnimalLabel = new Label();
            ChooseAgeLabel = new Label();
            SaveButton = new Button();
            exitButton = new Button();
            AnimalPickComboBox = new ComboBox();
            AgePickComboBox = new ComboBox();
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
            AnimalPickComboBox.Items.AddRange(new object[] { "Cow", "Chicken", "Sheep" });
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
            SaveButton.Location = new Point(211, 162);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(115, 29);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Save";
            SaveButton.TextAlign = ContentAlignment.BottomCenter;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ActiveCaption;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(524, 235);
            exitButton.Margin = new Padding(4, 3, 4, 3);
            exitButton.Name = "exitButton";
            exitButton.Padding = new Padding(12, 0, 0, 0);
            exitButton.Size = new Size(73, 29);
            exitButton.TabIndex = 14;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.MiddleLeft;
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // AddNewAnimal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 405);
            Controls.Add(exitButton);
            Controls.Add(SaveButton);
            Controls.Add(AgePickComboBox);
            Controls.Add(ChooseAgeLabel);
            Controls.Add(ChooseAnimalLabel);
            Controls.Add(AnimalPickComboBox);
            Font = new Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddNewAnimal";
            StartPosition = FormStartPosition.CenterScreen;
            Load += AddNewAnimal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox AnimalPickComboBox;
        private Label ChooseAnimalLabel;
        private Label ChooseAgeLabel;
        private Button SaveButton;
        private Button exitButton;
    }
}