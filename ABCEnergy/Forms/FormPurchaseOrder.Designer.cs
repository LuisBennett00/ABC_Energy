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
            this.btn_speak = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_resume = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.trackBar_SpeechRate = new System.Windows.Forms.TrackBar();
            this.trackBar_Volume = new System.Windows.Forms.TrackBar();
            this.label_speechRate = new System.Windows.Forms.Label();
            this.label_volume = new System.Windows.Forms.Label();
            this.ddlVoices = new System.Windows.Forms.ComboBox();
            this.btn_listen = new System.Windows.Forms.Button();
            this.btn_stop_listen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SpeechRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
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
            this.PO_label_editor.Click += new System.EventHandler(this.PO_label_editor_Click);
            // 
            // textBox_PON
            // 
            this.textBox_PON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_PON.Location = new System.Drawing.Point(227, 22);
            this.textBox_PON.Name = "textBox_PON";
            this.textBox_PON.Size = new System.Drawing.Size(235, 30);
            this.textBox_PON.TabIndex = 2;
            this.textBox_PON.TextChanged += new System.EventHandler(this.TextBox_PON_TextChanged);
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
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_Quantity.Location = new System.Drawing.Point(227, 190);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(235, 30);
            this.textBox_Quantity.TabIndex = 6;
            this.textBox_Quantity.TextChanged += new System.EventHandler(this.TextBox_Quantity_TextChanged);
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
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_Supplier.Location = new System.Drawing.Point(227, 238);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(235, 30);
            this.textBox_Supplier.TabIndex = 8;
            this.textBox_Supplier.TextChanged += new System.EventHandler(this.TextBox_Supplier_TextChanged);
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
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // dateTimePicker_POD
            // 
            this.dateTimePicker_POD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker_POD.Location = new System.Drawing.Point(227, 92);
            this.dateTimePicker_POD.Name = "dateTimePicker_POD";
            this.dateTimePicker_POD.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker_POD.TabIndex = 10;
            this.dateTimePicker_POD.ValueChanged += new System.EventHandler(this.DateTimePicker_POD_ValueChanged);
            // 
            // dateTimePicker_DD
            // 
            this.dateTimePicker_DD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker_DD.Location = new System.Drawing.Point(227, 143);
            this.dateTimePicker_DD.Name = "dateTimePicker_DD";
            this.dateTimePicker_DD.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker_DD.TabIndex = 12;
            this.dateTimePicker_DD.ValueChanged += new System.EventHandler(this.DateTimePicker_DD_ValueChanged);
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
            this.comboBox_Approval.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Approval_SelectedIndexChanged);
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
            this.label6.Click += new System.EventHandler(this.Label6_Click);
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
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
            this.label4.Click += new System.EventHandler(this.Label4_Click_1);
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
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btn_speak
            // 
            this.btn_speak.Location = new System.Drawing.Point(534, 22);
            this.btn_speak.Name = "btn_speak";
            this.btn_speak.Size = new System.Drawing.Size(75, 23);
            this.btn_speak.TabIndex = 22;
            this.btn_speak.Text = "Speak";
            this.btn_speak.UseVisualStyleBackColor = true;
            this.btn_speak.Click += new System.EventHandler(this.Btn_speak_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(534, 51);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 23;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(615, 22);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(75, 23);
            this.btn_resume.TabIndex = 24;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.Btn_resume_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(615, 51);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 25;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.Btn_pause_Click);
            // 
            // trackBar_SpeechRate
            // 
            this.trackBar_SpeechRate.Location = new System.Drawing.Point(534, 108);
            this.trackBar_SpeechRate.Name = "trackBar_SpeechRate";
            this.trackBar_SpeechRate.Size = new System.Drawing.Size(183, 45);
            this.trackBar_SpeechRate.TabIndex = 26;
            this.trackBar_SpeechRate.Scroll += new System.EventHandler(this.TrackBar_SpeechRate_Scroll);
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Location = new System.Drawing.Point(534, 190);
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(183, 45);
            this.trackBar_Volume.TabIndex = 27;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.TrackBar_Volume_Scroll);
            // 
            // label_speechRate
            // 
            this.label_speechRate.AutoSize = true;
            this.label_speechRate.Location = new System.Drawing.Point(531, 92);
            this.label_speechRate.Name = "label_speechRate";
            this.label_speechRate.Size = new System.Drawing.Size(93, 13);
            this.label_speechRate.TabIndex = 28;
            this.label_speechRate.Text = "label_speechRate";
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Location = new System.Drawing.Point(531, 174);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(35, 13);
            this.label_volume.TabIndex = 29;
            this.label_volume.Text = "label8";
            // 
            // ddlVoices
            // 
            this.ddlVoices.FormattingEnabled = true;
            this.ddlVoices.Location = new System.Drawing.Point(534, 247);
            this.ddlVoices.Name = "ddlVoices";
            this.ddlVoices.Size = new System.Drawing.Size(121, 21);
            this.ddlVoices.TabIndex = 30;
            // 
            // btn_listen
            // 
            this.btn_listen.Location = new System.Drawing.Point(580, 390);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(75, 23);
            this.btn_listen.TabIndex = 31;
            this.btn_listen.Text = "Listen";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.Btn_listen_Click);
            // 
            // btn_stop_listen
            // 
            this.btn_stop_listen.Location = new System.Drawing.Point(679, 390);
            this.btn_stop_listen.Name = "btn_stop_listen";
            this.btn_stop_listen.Size = new System.Drawing.Size(167, 23);
            this.btn_stop_listen.TabIndex = 32;
            this.btn_stop_listen.Text = "Stop Listening";
            this.btn_stop_listen.UseVisualStyleBackColor = true;
            this.btn_stop_listen.Click += new System.EventHandler(this.Btn_stop_listen_Click);
            // 
            // FormPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 706);
            this.Controls.Add(this.btn_stop_listen);
            this.Controls.Add(this.btn_listen);
            this.Controls.Add(this.ddlVoices);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.label_speechRate);
            this.Controls.Add(this.trackBar_Volume);
            this.Controls.Add(this.trackBar_SpeechRate);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_speak);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SpeechRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).EndInit();
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
        private System.Windows.Forms.Button btn_speak;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_resume;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.TrackBar trackBar_SpeechRate;
        private System.Windows.Forms.TrackBar trackBar_Volume;
        private System.Windows.Forms.Label label_speechRate;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.ComboBox ddlVoices;
        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.Button btn_stop_listen;
    }
}