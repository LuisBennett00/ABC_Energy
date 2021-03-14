namespace ABCEnergy.Forms
{
    partial class FormPurchaseOrder
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
            this.PO_label_editor = new System.Windows.Forms.Label();
            this.textBox_PON = new System.Windows.Forms.TextBox();
            this.textBox_OrderTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_POD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DD = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Approval = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PO_label_editor
            // 
            this.PO_label_editor.AutoSize = true;
            this.PO_label_editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PO_label_editor.Location = new System.Drawing.Point(6, 22);
            this.PO_label_editor.Name = "PO_label_editor";
            this.PO_label_editor.Size = new System.Drawing.Size(224, 25);
            this.PO_label_editor.TabIndex = 1;
            this.PO_label_editor.Text = "Purchase Order Number";
            // 
            // textBox_PON
            // 
            this.textBox_PON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_PON.Location = new System.Drawing.Point(227, 22);
            this.textBox_PON.Name = "textBox_PON";
            this.textBox_PON.Size = new System.Drawing.Size(235, 30);
            this.textBox_PON.TabIndex = 2;
            // 
            // textBox_OrderTotal
            // 
            this.textBox_OrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_OrderTotal.Location = new System.Drawing.Point(227, 287);
            this.textBox_OrderTotal.Name = "textBox_OrderTotal";
            this.textBox_OrderTotal.Size = new System.Drawing.Size(235, 30);
            this.textBox_OrderTotal.TabIndex = 4;
            this.textBox_OrderTotal.TextChanged += new System.EventHandler(this.TextBox_OrderTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(6, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Total(GPB)";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_Quantity.Location = new System.Drawing.Point(227, 190);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(235, 30);
            this.textBox_Quantity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(6, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_Supplier.Location = new System.Drawing.Point(227, 238);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(235, 30);
            this.textBox_Supplier.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(6, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier";
            // 
            // dateTimePicker_POD
            // 
            this.dateTimePicker_POD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker_POD.Location = new System.Drawing.Point(227, 92);
            this.dateTimePicker_POD.Name = "dateTimePicker_POD";
            this.dateTimePicker_POD.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker_POD.TabIndex = 10;
            // 
            // dateTimePicker_DD
            // 
            this.dateTimePicker_DD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker_DD.Location = new System.Drawing.Point(227, 143);
            this.dateTimePicker_DD.Name = "dateTimePicker_DD";
            this.dateTimePicker_DD.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker_DD.TabIndex = 12;
            // 
            // comboBox_Approval
            // 
            this.comboBox_Approval.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.comboBox_Approval.FormattingEnabled = true;
            this.comboBox_Approval.Items.AddRange(new object[] {
            "Approved",
            "Not Approved"});
            this.comboBox_Approval.Location = new System.Drawing.Point(227, 334);
            this.comboBox_Approval.Name = "comboBox_Approval";
            this.comboBox_Approval.Size = new System.Drawing.Size(235, 33);
            this.comboBox_Approval.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(6, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Approval";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(76, 390);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(89, 58);
            this.btn_Insert.TabIndex = 15;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 454);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 240);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(171, 390);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 58);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(266, 390);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 58);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(361, 390);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(89, 58);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(6, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Delivery Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Purchase Order Date";
            // 
            // FormPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 706);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Approval);
            this.Controls.Add(this.dateTimePicker_DD);
            this.Controls.Add(this.dateTimePicker_POD);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_OrderTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PON);
            this.Controls.Add(this.PO_label_editor);
            this.Name = "FormPurchaseOrder";
            this.Text = "FormPurchaseOrder";
            this.Load += new System.EventHandler(this.FormPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label PO_label_editor;
        private System.Windows.Forms.TextBox textBox_PON;
        private System.Windows.Forms.TextBox textBox_OrderTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_POD;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DD;
        private System.Windows.Forms.ComboBox comboBox_Approval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}