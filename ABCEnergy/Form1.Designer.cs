namespace ABCEnergy
{
    partial class Form1
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnContracts = new System.Windows.Forms.Button();
            this.btnPurchaseOrder = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnContracts);
            this.panelMenu.Controls.Add(this.btnPurchaseOrder);
            this.panelMenu.Controls.Add(this.btnQuote);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(177, 1003);
            this.panelMenu.TabIndex = 0;
            // 
            // btnContracts
            // 
            this.btnContracts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContracts.FlatAppearance.BorderSize = 0;
            this.btnContracts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContracts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnContracts.Image = global::ABCEnergy.Properties.Resources.value;
            this.btnContracts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.Location = new System.Drawing.Point(0, 320);
            this.btnContracts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContracts.Name = "btnContracts";
            this.btnContracts.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnContracts.Size = new System.Drawing.Size(177, 74);
            this.btnContracts.TabIndex = 4;
            this.btnContracts.Text = "Contracts";
            this.btnContracts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContracts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnContracts.UseVisualStyleBackColor = true;
            this.btnContracts.Click += new System.EventHandler(this.BtnContracts_Click);
            // 
            // btnPurchaseOrder
            // 
            this.btnPurchaseOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchaseOrder.FlatAppearance.BorderSize = 0;
            this.btnPurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPurchaseOrder.Image = global::ABCEnergy.Properties.Resources.shopping_list;
            this.btnPurchaseOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrder.Location = new System.Drawing.Point(0, 246);
            this.btnPurchaseOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPurchaseOrder.Name = "btnPurchaseOrder";
            this.btnPurchaseOrder.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnPurchaseOrder.Size = new System.Drawing.Size(177, 74);
            this.btnPurchaseOrder.TabIndex = 3;
            this.btnPurchaseOrder.Text = "Purchase Orders";
            this.btnPurchaseOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnPurchaseOrder.Click += new System.EventHandler(this.BtnPurchaseOrder_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuote.FlatAppearance.BorderSize = 0;
            this.btnQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuote.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuote.Image = global::ABCEnergy.Properties.Resources.bar_chart;
            this.btnQuote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuote.Location = new System.Drawing.Point(0, 172);
            this.btnQuote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnQuote.Size = new System.Drawing.Size(177, 74);
            this.btnQuote.TabIndex = 2;
            this.btnQuote.Text = "Quotes";
            this.btnQuote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuote.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.BtnQuote_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.Image = global::ABCEnergy.Properties.Resources.shopping_cart__1_;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 98);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(177, 74);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.BtnProducts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(177, 98);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelLogo_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABCEnergy";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(177, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(712, 98);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitleBar_Paint);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::ABCEnergy.Properties.Resources.cross_out__2_;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(100, 98);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.BtnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(235, 34);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(177, 98);
            this.panelDesktopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(712, 905);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(889, 1003);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnContracts;
        private System.Windows.Forms.Button btnPurchaseOrder;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}

