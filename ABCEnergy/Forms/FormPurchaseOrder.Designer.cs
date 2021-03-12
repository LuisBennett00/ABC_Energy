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
            this.PO_Label = new System.Windows.Forms.Label();
            this.PO_label_editor = new System.Windows.Forms.Label();
            this.textBox_PON = new System.Windows.Forms.TextBox();
            this.textBox_OrderTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_POD = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_DD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_Approval = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PO_Label
            // 
            this.PO_Label.AutoSize = true;
            this.PO_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PO_Label.Location = new System.Drawing.Point(240, 9);
            this.PO_Label.Name = "PO_Label";
            this.PO_Label.Size = new System.Drawing.Size(213, 24);
            this.PO_Label.TabIndex = 0;
            this.PO_Label.Text = "Purchase Order Form";
            // 
            // PO_label_editor
            // 
            this.PO_label_editor.AutoSize = true;
            this.PO_label_editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PO_label_editor.Location = new System.Drawing.Point(57, 81);
            this.PO_label_editor.Name = "PO_label_editor";
            this.PO_label_editor.Size = new System.Drawing.Size(153, 16);
            this.PO_label_editor.TabIndex = 1;
            this.PO_label_editor.Text = "Purchase Order Number";
            // 
            // textBox_PON
            // 
            this.textBox_PON.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_PON.Location = new System.Drawing.Point(216, 80);
            this.textBox_PON.Name = "textBox_PON";
            this.textBox_PON.Size = new System.Drawing.Size(100, 22);
            this.textBox_PON.TabIndex = 2;
            // 
            // textBox_OrderTotal
            // 
            this.textBox_OrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_OrderTotal.Location = new System.Drawing.Point(215, 236);
            this.textBox_OrderTotal.Name = "textBox_OrderTotal";
            this.textBox_OrderTotal.Size = new System.Drawing.Size(100, 22);
            this.textBox_OrderTotal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Total(GPB)";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_Quantity.Location = new System.Drawing.Point(215, 169);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(100, 22);
            this.textBox_Quantity.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBox_Supplier.Location = new System.Drawing.Point(215, 197);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(100, 22);
            this.textBox_Supplier.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Purchase Order Date";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // dateTimePicker_POD
            // 
            this.dateTimePicker_POD.Location = new System.Drawing.Point(216, 108);
            this.dateTimePicker_POD.Name = "dateTimePicker_POD";
            this.dateTimePicker_POD.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_POD.TabIndex = 10;
            // 
            // dateTimePicker_DD
            // 
            this.dateTimePicker_DD.Location = new System.Drawing.Point(215, 134);
            this.dateTimePicker_DD.Name = "dateTimePicker_DD";
            this.dateTimePicker_DD.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_DD.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Delivery Date";
            // 
            // comboBox_Approval
            // 
            this.comboBox_Approval.FormattingEnabled = true;
            this.comboBox_Approval.Items.AddRange(new object[] {
            "Approved",
            "Not Approved"});
            this.comboBox_Approval.Location = new System.Drawing.Point(215, 276);
            this.comboBox_Approval.Name = "comboBox_Approval";
            this.comboBox_Approval.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Approval.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Approval";
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(215, 329);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 15;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 195);
            this.dataGridView1.TabIndex = 16;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(296, 329);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(378, 329);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(601, 329);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 19;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // FormPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 584);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_Approval);
            this.Controls.Add(this.dateTimePicker_DD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker_POD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_OrderTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_PON);
            this.Controls.Add(this.PO_label_editor);
            this.Controls.Add(this.PO_Label);
            this.Name = "FormPurchaseOrder";
            this.Text = "FormPurchaseOrder";
            this.Load += new System.EventHandler(this.FormPurchaseOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PO_Label;
        private System.Windows.Forms.Label PO_label_editor;
        private System.Windows.Forms.TextBox textBox_PON;
        private System.Windows.Forms.TextBox textBox_OrderTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker_POD;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_Approval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_Search;
    }
}