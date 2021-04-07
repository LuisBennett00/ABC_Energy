﻿namespace ABCEnergy.Forms
{
    partial class FormProducts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deptSelectButton = new System.Windows.Forms.Button();
            this.catgSelectButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.DeptCombobox = new System.Windows.Forms.ComboBox();
            this.CatgCombobox = new System.Windows.Forms.ComboBox();
            this.CheckoutGridView = new System.Windows.Forms.DataGridView();
            this.priceLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 216);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(665, 309);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // deptSelectButton
            // 
            this.deptSelectButton.Location = new System.Drawing.Point(62, 138);
            this.deptSelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.deptSelectButton.Name = "deptSelectButton";
            this.deptSelectButton.Size = new System.Drawing.Size(169, 70);
            this.deptSelectButton.TabIndex = 16;
            this.deptSelectButton.Text = "Select";
            this.deptSelectButton.UseVisualStyleBackColor = true;
            this.deptSelectButton.Click += new System.EventHandler(this.deptSelectButton_Click);
            // 
            // catgSelectButton
            // 
            this.catgSelectButton.Location = new System.Drawing.Point(444, 138);
            this.catgSelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.catgSelectButton.Name = "catgSelectButton";
            this.catgSelectButton.Size = new System.Drawing.Size(169, 70);
            this.catgSelectButton.TabIndex = 15;
            this.catgSelectButton.Text = "Select";
            this.catgSelectButton.UseVisualStyleBackColor = true;
            this.catgSelectButton.Click += new System.EventHandler(this.catgSelectButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(255, 533);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(169, 70);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add to cart";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // DeptCombobox
            // 
            this.DeptCombobox.FormattingEnabled = true;
            this.DeptCombobox.Location = new System.Drawing.Point(18, 89);
            this.DeptCombobox.Name = "DeptCombobox";
            this.DeptCombobox.Size = new System.Drawing.Size(253, 24);
            this.DeptCombobox.TabIndex = 27;
            // 
            // CatgCombobox
            // 
            this.CatgCombobox.FormattingEnabled = true;
            this.CatgCombobox.Location = new System.Drawing.Point(405, 89);
            this.CatgCombobox.Name = "CatgCombobox";
            this.CatgCombobox.Size = new System.Drawing.Size(250, 24);
            this.CatgCombobox.TabIndex = 28;
            // 
            // CheckoutGridView
            // 
            this.CheckoutGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckoutGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CheckoutGridView.Location = new System.Drawing.Point(18, 611);
            this.CheckoutGridView.Margin = new System.Windows.Forms.Padding(4);
            this.CheckoutGridView.Name = "CheckoutGridView";
            this.CheckoutGridView.ReadOnly = true;
            this.CheckoutGridView.RowHeadersWidth = 51;
            this.CheckoutGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CheckoutGridView.Size = new System.Drawing.Size(665, 146);
            this.CheckoutGridView.TabIndex = 29;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(441, 828);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(74, 17);
            this.priceLabel.TabIndex = 30;
            this.priceLabel.Text = "Total cost:";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(72, 801);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(169, 70);
            this.removeButton.TabIndex = 31;
            this.removeButton.Text = "Remove item";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 869);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.CheckoutGridView);
            this.Controls.Add(this.CatgCombobox);
            this.Controls.Add(this.DeptCombobox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.deptSelectButton);
            this.Controls.Add(this.catgSelectButton);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormProducts";
            this.Text = "FormProducts";
            this.Load += new System.EventHandler(this.FormProducts_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckoutGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button deptSelectButton;
        private System.Windows.Forms.Button catgSelectButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox DeptCombobox;
        private System.Windows.Forms.ComboBox CatgCombobox;
        private System.Windows.Forms.DataGridView CheckoutGridView;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button removeButton;
    }
}