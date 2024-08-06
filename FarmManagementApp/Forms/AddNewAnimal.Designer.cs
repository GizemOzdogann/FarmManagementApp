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
            label1 = new Label();
            MaleButton = new RadioButton();
            FemaleButton = new RadioButton();
            AnimalPickComboBox = new ComboBox();
            AgePickComboBox = new ComboBox();
            SuspendLayout();
            // 
            // AnimalPickComboBox
            // 
            AnimalPickComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AnimalPickComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AnimalPickComboBox.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AnimalPickComboBox.FormattingEnabled = true;
            AnimalPickComboBox.ImeMode = ImeMode.On;
            AnimalPickComboBox.IntegralHeight = false;
            AnimalPickComboBox.ItemHeight = 20;
            AnimalPickComboBox.Items.AddRange(new object[] { "Cow", "Chicken", "Sheep" });
            AnimalPickComboBox.Location = new Point(217, 70);
            AnimalPickComboBox.Name = "AnimalPickComboBox";
            AnimalPickComboBox.Size = new Size(169, 28);
            AnimalPickComboBox.TabIndex = 1;
            // 
            // AgePickComboBox
            // 
            AgePickComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AgePickComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AgePickComboBox.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AgePickComboBox.FormattingEnabled = true;
            AgePickComboBox.ImeMode = ImeMode.On;
            AgePickComboBox.IntegralHeight = false;
            AgePickComboBox.ItemHeight = 20;
            AgePickComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            AgePickComboBox.Location = new Point(217, 114);
            AgePickComboBox.Name = "AgePickComboBox";
            AgePickComboBox.Size = new Size(169, 28);
            AgePickComboBox.TabIndex = 3;
            // 
            // ChooseAnimalLabel
            // 
            ChooseAnimalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ChooseAnimalLabel.AutoSize = true;
            ChooseAnimalLabel.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseAnimalLabel.ForeColor = SystemColors.WindowFrame;
            ChooseAnimalLabel.Location = new Point(66, 78);
            ChooseAnimalLabel.Name = "ChooseAnimalLabel";
            ChooseAnimalLabel.Size = new Size(145, 20);
            ChooseAnimalLabel.TabIndex = 4;
            ChooseAnimalLabel.Text = "Choose Animal Type";
            // 
            // ChooseAgeLabel
            // 
            ChooseAgeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ChooseAgeLabel.AutoSize = true;
            ChooseAgeLabel.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ChooseAgeLabel.ForeColor = SystemColors.WindowFrame;
            ChooseAgeLabel.Location = new Point(175, 122);
            ChooseAgeLabel.Name = "ChooseAgeLabel";
            ChooseAgeLabel.Size = new Size(36, 20);
            ChooseAgeLabel.TabIndex = 9;
            ChooseAgeLabel.Text = "Age";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = SystemColors.Control;
            SaveButton.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveButton.ForeColor = SystemColors.WindowFrame;
            SaveButton.Location = new Point(217, 171);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(115, 29);
            SaveButton.TabIndex = 13;
            SaveButton.Text = "Save";
            SaveButton.TextAlign = ContentAlignment.BottomCenter;
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.WindowFrame;
            label1.Location = new Point(418, 70);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 15;
            label1.Text = "Gender";
            // 
            // MaleButton
            // 
            MaleButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MaleButton.AutoSize = true;
            MaleButton.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MaleButton.ForeColor = SystemColors.WindowFrame;
            MaleButton.Location = new Point(494, 98);
            MaleButton.Name = "MaleButton";
            MaleButton.Size = new Size(63, 24);
            MaleButton.TabIndex = 16;
            MaleButton.TabStop = true;
            MaleButton.Text = "Male";
            MaleButton.UseVisualStyleBackColor = true;
            // 
            // FemaleButton
            // 
            FemaleButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            FemaleButton.AutoSize = true;
            FemaleButton.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FemaleButton.ForeColor = SystemColors.WindowFrame;
            FemaleButton.Location = new Point(494, 68);
            FemaleButton.Name = "FemaleButton";
            FemaleButton.Size = new Size(78, 24);
            FemaleButton.TabIndex = 17;
            FemaleButton.TabStop = true;
            FemaleButton.Text = "Female";
            FemaleButton.UseVisualStyleBackColor = true;
            // 
            // AddNewAnimal
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 405);
            Controls.Add(FemaleButton);
            Controls.Add(MaleButton);
            Controls.Add(label1);
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
        private Label label1;
        private RadioButton MaleButton;
        private RadioButton FemaleButton;
    }
}