namespace FarmManagementApp.Forms
{
    partial class CashStatus
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
            TotalCashLabel = new Label();
            MeatLabel = new Label();
            MilkLabel = new Label();
            EggLabel = new Label();
            TotalTextBox = new TextBox();
            MeatTextBox = new TextBox();
            MilkTextBox = new TextBox();
            EggTextBox = new TextBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TotalCashLabel
            // 
            TotalCashLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TotalCashLabel.AutoSize = true;
            TotalCashLabel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalCashLabel.Location = new Point(31, 34);
            TotalCashLabel.Name = "TotalCashLabel";
            TotalCashLabel.Size = new Size(81, 19);
            TotalCashLabel.TabIndex = 0;
            TotalCashLabel.Text = "Total Cash";
            // 
            // MeatLabel
            // 
            MeatLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MeatLabel.AutoSize = true;
            MeatLabel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MeatLabel.Location = new Point(70, 70);
            MeatLabel.Name = "MeatLabel";
            MeatLabel.Size = new Size(44, 19);
            MeatLabel.TabIndex = 1;
            MeatLabel.Text = "Meat";
            // 
            // MilkLabel
            // 
            MilkLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MilkLabel.AutoSize = true;
            MilkLabel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MilkLabel.Location = new Point(75, 108);
            MilkLabel.Name = "MilkLabel";
            MilkLabel.Size = new Size(39, 19);
            MilkLabel.TabIndex = 2;
            MilkLabel.Text = "Milk";
            // 
            // EggLabel
            // 
            EggLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EggLabel.AutoSize = true;
            EggLabel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EggLabel.Location = new Point(75, 147);
            EggLabel.Name = "EggLabel";
            EggLabel.Size = new Size(37, 19);
            EggLabel.TabIndex = 3;
            EggLabel.Text = "Egg";
            // 
            // TotalTextBox
            // 
            TotalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TotalTextBox.BackColor = SystemColors.Control;
            TotalTextBox.BorderStyle = BorderStyle.None;
            TotalTextBox.Font = new Font("Microsoft JhengHei UI", 9F);
            TotalTextBox.Location = new Point(138, 33);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.Size = new Size(125, 20);
            TotalTextBox.TabIndex = 1;
            // 
            // MeatTextBox
            // 
            MeatTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MeatTextBox.BackColor = SystemColors.Control;
            MeatTextBox.BorderStyle = BorderStyle.None;
            MeatTextBox.Font = new Font("Microsoft JhengHei UI", 9F);
            MeatTextBox.Location = new Point(138, 66);
            MeatTextBox.Name = "MeatTextBox";
            MeatTextBox.Size = new Size(125, 20);
            MeatTextBox.TabIndex = 5;
            // 
            // MilkTextBox
            // 
            MilkTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            MilkTextBox.BackColor = SystemColors.Control;
            MilkTextBox.BorderStyle = BorderStyle.None;
            MilkTextBox.Font = new Font("Microsoft JhengHei UI", 9F);
            MilkTextBox.Location = new Point(138, 104);
            MilkTextBox.Name = "MilkTextBox";
            MilkTextBox.Size = new Size(125, 20);
            MilkTextBox.TabIndex = 6;
            // 
            // EggTextBox
            // 
            EggTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            EggTextBox.BackColor = SystemColors.Control;
            EggTextBox.BorderStyle = BorderStyle.None;
            EggTextBox.Font = new Font("Microsoft JhengHei UI", 9F);
            EggTextBox.Location = new Point(138, 146);
            EggTextBox.Name = "EggTextBox";
            EggTextBox.Size = new Size(125, 20);
            EggTextBox.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(EggTextBox);
            panel1.Controls.Add(MilkTextBox);
            panel1.Controls.Add(MeatTextBox);
            panel1.Controls.Add(TotalTextBox);
            panel1.Controls.Add(EggLabel);
            panel1.Controls.Add(MilkLabel);
            panel1.Controls.Add(MeatLabel);
            panel1.Controls.Add(TotalCashLabel);
            panel1.Location = new Point(161, 105);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 201);
            panel1.TabIndex = 8;
            // 
            // CashStatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CashStatus";
            Text = "CashStatus";
            Load += CashStatus_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TotalCashLabel;
        private Label MeatLabel;
        private Label MilkLabel;
        private Label EggLabel;
        private TextBox TotalTextBox;
        private TextBox MeatTextBox;
        private TextBox MilkTextBox;
        private TextBox EggTextBox;
        private Panel panel1;
    }
}