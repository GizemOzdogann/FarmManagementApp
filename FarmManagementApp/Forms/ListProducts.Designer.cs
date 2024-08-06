namespace FarmManagementApp.Forms
{
    partial class ListProducts
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
            dataGridViewProducts = new DataGridView();
            ListProductsLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AccessibleRole = AccessibleRole.List;
            dataGridViewProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProducts.BackgroundColor = SystemColors.HighlightText;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(12, 47);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.Size = new Size(776, 391);
            dataGridViewProducts.TabIndex = 16;
            // 
            // ListProductsLabel
            // 
            ListProductsLabel.AutoSize = true;
            ListProductsLabel.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListProductsLabel.ForeColor = SystemColors.ActiveCaptionText;
            ListProductsLabel.Location = new Point(12, 16);
            ListProductsLabel.Name = "ListProductsLabel";
            ListProductsLabel.Size = new Size(92, 19);
            ListProductsLabel.TabIndex = 17;
            ListProductsLabel.Text = "Product List";
            // 
            // ListProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListProductsLabel);
            Controls.Add(dataGridViewProducts);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListProducts";
            Text = "ListProducts";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridViewProducts;
        private Label ListProductsLabel;
    }
}