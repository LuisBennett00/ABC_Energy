﻿namespace ABCEnergy.Forms
{
    partial class FormQuotes
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.dataGridView_quote = new System.Windows.Forms.DataGridView();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dateTimePicker_DD = new System.Windows.Forms.DateTimePicker();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Item = new System.Windows.Forms.TextBox();
            this.textBox_PON = new System.Windows.Forms.TextBox();
            this.PO_label_editor = new System.Windows.Forms.Label();
            this.textBox_IN = new System.Windows.Forms.TextBox();
            this.labelasdf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quote)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(35, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Delivery Date";
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(322, 337);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(89, 39);
            this.btn_Search.TabIndex = 38;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click_1);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(227, 337);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 39);
            this.btn_delete.TabIndex = 37;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(129, 337);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 39);
            this.btn_update.TabIndex = 36;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click_1);
            // 
            // dataGridView_quote
            // 
            this.dataGridView_quote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_quote.Location = new System.Drawing.Point(12, 395);
            this.dataGridView_quote.Name = "dataGridView_quote";
            this.dataGridView_quote.Size = new System.Drawing.Size(506, 271);
            this.dataGridView_quote.TabIndex = 35;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(41, 152);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(450, 58);
            this.btn_Insert.TabIndex = 34;
            this.btn_Insert.Text = "Reqeust Quote";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // dateTimePicker_DD
            // 
            this.dateTimePicker_DD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker_DD.Location = new System.Drawing.Point(256, 119);
            this.dateTimePicker_DD.Name = "dateTimePicker_DD";
            this.dateTimePicker_DD.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker_DD.TabIndex = 31;
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_Supplier.Location = new System.Drawing.Point(257, 9);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(235, 30);
            this.textBox_Supplier.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(36, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Supplier";
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_Quantity.Location = new System.Drawing.Point(256, 83);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(235, 30);
            this.textBox_Quantity.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(35, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(36, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Item";
            // 
            // textBox_Item
            // 
            this.textBox_Item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_Item.Location = new System.Drawing.Point(256, 47);
            this.textBox_Item.Name = "textBox_Item";
            this.textBox_Item.Size = new System.Drawing.Size(235, 30);
            this.textBox_Item.TabIndex = 41;
            // 
            // textBox_PON
            // 
            this.textBox_PON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_PON.Location = new System.Drawing.Point(256, 221);
            this.textBox_PON.Name = "textBox_PON";
            this.textBox_PON.Size = new System.Drawing.Size(235, 30);
            this.textBox_PON.TabIndex = 43;
            // 
            // PO_label_editor
            // 
            this.PO_label_editor.AutoSize = true;
            this.PO_label_editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PO_label_editor.Location = new System.Drawing.Point(35, 221);
            this.PO_label_editor.Name = "PO_label_editor";
            this.PO_label_editor.Size = new System.Drawing.Size(224, 25);
            this.PO_label_editor.TabIndex = 42;
            this.PO_label_editor.Text = "Purchase Order Number";
            // 
            // textBox_IN
            // 
            this.textBox_IN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_IN.Location = new System.Drawing.Point(257, 266);
            this.textBox_IN.Name = "textBox_IN";
            this.textBox_IN.Size = new System.Drawing.Size(235, 30);
            this.textBox_IN.TabIndex = 45;
            // 
            // labelasdf
            // 
            this.labelasdf.AutoSize = true;
            this.labelasdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelasdf.Location = new System.Drawing.Point(36, 266);
            this.labelasdf.Name = "labelasdf";
            this.labelasdf.Size = new System.Drawing.Size(148, 25);
            this.labelasdf.TabIndex = 44;
            this.labelasdf.Text = "Invoice Number";
            // 
            // FormQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 706);
            this.Controls.Add(this.textBox_IN);
            this.Controls.Add(this.labelasdf);
            this.Controls.Add(this.textBox_PON);
            this.Controls.Add(this.PO_label_editor);
            this.Controls.Add(this.textBox_Item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dataGridView_quote);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.dateTimePicker_DD);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.label2);
            this.Name = "FormQuotes";
            this.Text = "FormQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dataGridView_quote;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DD;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Item;
        private System.Windows.Forms.TextBox textBox_PON;
        private System.Windows.Forms.Label PO_label_editor;
        private System.Windows.Forms.TextBox textBox_IN;
        private System.Windows.Forms.Label labelasdf;
    }
}