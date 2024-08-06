namespace FarmManagementApp.Forms
{
    partial class ListAnimals
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
            ListAnimalsLabel = new Label();
            dataGridViewAnimals = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimals).BeginInit();
            SuspendLayout();
            // 
            // ListAnimalsLabel
            // 
            ListAnimalsLabel.AutoSize = true;
            ListAnimalsLabel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListAnimalsLabel.ForeColor = SystemColors.WindowFrame;
            ListAnimalsLabel.Location = new Point(12, 16);
            ListAnimalsLabel.Name = "ListAnimalsLabel";
            ListAnimalsLabel.Size = new Size(120, 19);
            ListAnimalsLabel.TabIndex = 16;
            ListAnimalsLabel.Text = "Display Animals";
            // 
            // dataGridViewAnimals
            // 
            dataGridViewAnimals.AccessibleRole = AccessibleRole.List;
            dataGridViewAnimals.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewAnimals.BackgroundColor = SystemColors.Control;
            dataGridViewAnimals.BorderStyle = BorderStyle.None;
            dataGridViewAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnimals.Location = new Point(12, 47);
            dataGridViewAnimals.Name = "dataGridViewAnimals";
            dataGridViewAnimals.RowHeadersWidth = 51;
            dataGridViewAnimals.Size = new Size(776, 391);
            dataGridViewAnimals.TabIndex = 0;
            // 
            // ListAnimals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListAnimalsLabel);
            Controls.Add(dataGridViewAnimals);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListAnimals";
            Text = "List of Animals";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnimals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ListAnimalsLabel;
        private DataGridView dataGridViewAnimals;
    }
}