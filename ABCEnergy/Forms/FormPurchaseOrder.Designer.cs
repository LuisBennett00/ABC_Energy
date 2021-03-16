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
            this.label7 = new System.Windows.Forms.Label();
            this.btn_stopListening_POD = new System.Windows.Forms.Button();
            this.btn_Listen_POD = new System.Windows.Forms.Button();
            this.btn_stopListening_DD = new System.Windows.Forms.Button();
            this.btn_Listen_DD = new System.Windows.Forms.Button();
            this.btn_stopListening_Quantity = new System.Windows.Forms.Button();
            this.btn_Listen_Quantity = new System.Windows.Forms.Button();
            this.btn_stopListening_Supplier = new System.Windows.Forms.Button();
            this.btn_Listen_Supplier = new System.Windows.Forms.Button();
            this.btn_stopListening_OrderTotal = new System.Windows.Forms.Button();
            this.btn_Listen_OrderTotal = new System.Windows.Forms.Button();
            this.btn_stopListening_Approval = new System.Windows.Forms.Button();
            this.btn_Listen_Approval = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_SpeechRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // PO_label_editor
            // 
            this.PO_label_editor.AutoSize = true;
            this.PO_label_editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PO_label_editor.Location = new System.Drawing.Point(6, 31);
            this.PO_label_editor.Name = "PO_label_editor";
            this.PO_label_editor.Size = new System.Drawing.Size(224, 25);
            this.PO_label_editor.TabIndex = 1;
            this.PO_label_editor.Text = "Purchase Order Number";
            this.PO_label_editor.Click += new System.EventHandler(this.PO_label_editor_Click);
            // 
            // textBox_PON
            // 
            this.textBox_PON.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_PON.Location = new System.Drawing.Point(227, 31);
            this.textBox_PON.Name = "textBox_PON";
            this.textBox_PON.Size = new System.Drawing.Size(235, 30);
            this.textBox_PON.TabIndex = 2;
            this.textBox_PON.TextChanged += new System.EventHandler(this.TextBox_PON_TextChanged);
            // 
            // textBox_OrderTotal
            // 
            this.textBox_OrderTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_OrderTotal.Location = new System.Drawing.Point(227, 347);
            this.textBox_OrderTotal.Name = "textBox_OrderTotal";
            this.textBox_OrderTotal.Size = new System.Drawing.Size(235, 30);
            this.textBox_OrderTotal.TabIndex = 4;
            this.textBox_OrderTotal.TextChanged += new System.EventHandler(this.TextBox_OrderTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(6, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Order Total(GPB)";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_Quantity.Location = new System.Drawing.Point(227, 222);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(235, 30);
            this.textBox_Quantity.TabIndex = 6;
            this.textBox_Quantity.TextChanged += new System.EventHandler(this.TextBox_Quantity_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(6, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox_Supplier.Location = new System.Drawing.Point(227, 283);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(235, 30);
            this.textBox_Supplier.TabIndex = 8;
            this.textBox_Supplier.TextChanged += new System.EventHandler(this.TextBox_Supplier_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(6, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // dateTimePicker_POD
            // 
            this.dateTimePicker_POD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker_POD.Location = new System.Drawing.Point(227, 96);
            this.dateTimePicker_POD.Name = "dateTimePicker_POD";
            this.dateTimePicker_POD.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker_POD.TabIndex = 10;
            this.dateTimePicker_POD.ValueChanged += new System.EventHandler(this.DateTimePicker_POD_ValueChanged);
            // 
            // dateTimePicker_DD
            // 
            this.dateTimePicker_DD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dateTimePicker_DD.Location = new System.Drawing.Point(227, 160);
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
            this.comboBox_Approval.Location = new System.Drawing.Point(227, 412);
            this.comboBox_Approval.Name = "comboBox_Approval";
            this.comboBox_Approval.Size = new System.Drawing.Size(235, 33);
            this.comboBox_Approval.TabIndex = 13;
            this.comboBox_Approval.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Approval_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(6, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Approval";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(76, 619);
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 682);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 240);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(171, 619);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 58);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.Btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(266, 619);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(89, 58);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(361, 619);
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
            this.label4.Location = new System.Drawing.Point(6, 168);
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
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Purchase Order Date";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btn_speak
            // 
            this.btn_speak.Location = new System.Drawing.Point(76, 579);
            this.btn_speak.Name = "btn_speak";
            this.btn_speak.Size = new System.Drawing.Size(374, 23);
            this.btn_speak.TabIndex = 22;
            this.btn_speak.Text = "Read Aloud";
            this.btn_speak.UseVisualStyleBackColor = true;
            this.btn_speak.Click += new System.EventHandler(this.Btn_speak_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(265, 752);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 23;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.Btn_stop_Click);
            // 
            // btn_resume
            // 
            this.btn_resume.Location = new System.Drawing.Point(346, 723);
            this.btn_resume.Name = "btn_resume";
            this.btn_resume.Size = new System.Drawing.Size(75, 23);
            this.btn_resume.TabIndex = 24;
            this.btn_resume.Text = "Resume";
            this.btn_resume.UseVisualStyleBackColor = true;
            this.btn_resume.Click += new System.EventHandler(this.Btn_resume_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(346, 752);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 25;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.Btn_pause_Click);
            // 
            // trackBar_SpeechRate
            // 
            this.trackBar_SpeechRate.Location = new System.Drawing.Point(77, 528);
            this.trackBar_SpeechRate.Name = "trackBar_SpeechRate";
            this.trackBar_SpeechRate.Size = new System.Drawing.Size(183, 45);
            this.trackBar_SpeechRate.TabIndex = 26;
            this.trackBar_SpeechRate.Scroll += new System.EventHandler(this.TrackBar_SpeechRate_Scroll);
            // 
            // trackBar_Volume
            // 
            this.trackBar_Volume.Location = new System.Drawing.Point(266, 528);
            this.trackBar_Volume.Name = "trackBar_Volume";
            this.trackBar_Volume.Size = new System.Drawing.Size(183, 45);
            this.trackBar_Volume.TabIndex = 27;
            this.trackBar_Volume.Scroll += new System.EventHandler(this.TrackBar_Volume_Scroll);
            // 
            // label_speechRate
            // 
            this.label_speechRate.AutoSize = true;
            this.label_speechRate.Location = new System.Drawing.Point(73, 512);
            this.label_speechRate.Name = "label_speechRate";
            this.label_speechRate.Size = new System.Drawing.Size(70, 13);
            this.label_speechRate.TabIndex = 28;
            this.label_speechRate.Text = "Speech Rate";
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Location = new System.Drawing.Point(263, 512);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(42, 13);
            this.label_volume.TabIndex = 29;
            this.label_volume.Text = "Volume";
            // 
            // ddlVoices
            // 
            this.ddlVoices.FormattingEnabled = true;
            this.ddlVoices.Location = new System.Drawing.Point(147, 485);
            this.ddlVoices.Name = "ddlVoices";
            this.ddlVoices.Size = new System.Drawing.Size(302, 21);
            this.ddlVoices.TabIndex = 30;
            // 
            // btn_listen
            // 
            this.btn_listen.Location = new System.Drawing.Point(227, 64);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(75, 23);
            this.btn_listen.TabIndex = 31;
            this.btn_listen.Text = "Listen";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.Btn_listen_Click);
            // 
            // btn_stop_listen
            // 
            this.btn_stop_listen.Location = new System.Drawing.Point(308, 64);
            this.btn_stop_listen.Name = "btn_stop_listen";
            this.btn_stop_listen.Size = new System.Drawing.Size(154, 23);
            this.btn_stop_listen.TabIndex = 32;
            this.btn_stop_listen.Text = "Stop Listening";
            this.btn_stop_listen.UseVisualStyleBackColor = true;
            this.btn_stop_listen.Click += new System.EventHandler(this.Btn_stop_listen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 488);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Select Voice";
            // 
            // btn_stopListening_POD
            // 
            this.btn_stopListening_POD.Location = new System.Drawing.Point(308, 129);
            this.btn_stopListening_POD.Name = "btn_stopListening_POD";
            this.btn_stopListening_POD.Size = new System.Drawing.Size(154, 23);
            this.btn_stopListening_POD.TabIndex = 35;
            this.btn_stopListening_POD.Text = "Stop Listening";
            this.btn_stopListening_POD.UseVisualStyleBackColor = true;
            this.btn_stopListening_POD.Click += new System.EventHandler(this.Btn_stopListening_POD_Click);
            // 
            // btn_Listen_POD
            // 
            this.btn_Listen_POD.Location = new System.Drawing.Point(227, 129);
            this.btn_Listen_POD.Name = "btn_Listen_POD";
            this.btn_Listen_POD.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen_POD.TabIndex = 34;
            this.btn_Listen_POD.Text = "Listen";
            this.btn_Listen_POD.UseVisualStyleBackColor = true;
            this.btn_Listen_POD.Click += new System.EventHandler(this.Btn_Listen_POD_Click);
            // 
            // btn_stopListening_DD
            // 
            this.btn_stopListening_DD.Location = new System.Drawing.Point(308, 192);
            this.btn_stopListening_DD.Name = "btn_stopListening_DD";
            this.btn_stopListening_DD.Size = new System.Drawing.Size(154, 23);
            this.btn_stopListening_DD.TabIndex = 37;
            this.btn_stopListening_DD.Text = "Stop Listening";
            this.btn_stopListening_DD.UseVisualStyleBackColor = true;
            this.btn_stopListening_DD.Click += new System.EventHandler(this.Btn_stopListening_DD_Click);
            // 
            // btn_Listen_DD
            // 
            this.btn_Listen_DD.Location = new System.Drawing.Point(227, 192);
            this.btn_Listen_DD.Name = "btn_Listen_DD";
            this.btn_Listen_DD.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen_DD.TabIndex = 36;
            this.btn_Listen_DD.Text = "Listen";
            this.btn_Listen_DD.UseVisualStyleBackColor = true;
            this.btn_Listen_DD.Click += new System.EventHandler(this.Btn_Listen_DD_Click);
            // 
            // btn_stopListening_Quantity
            // 
            this.btn_stopListening_Quantity.Location = new System.Drawing.Point(308, 254);
            this.btn_stopListening_Quantity.Name = "btn_stopListening_Quantity";
            this.btn_stopListening_Quantity.Size = new System.Drawing.Size(154, 23);
            this.btn_stopListening_Quantity.TabIndex = 39;
            this.btn_stopListening_Quantity.Text = "Stop Listening";
            this.btn_stopListening_Quantity.UseVisualStyleBackColor = true;
            this.btn_stopListening_Quantity.Click += new System.EventHandler(this.Btn_stopListening_Quantity_Click);
            // 
            // btn_Listen_Quantity
            // 
            this.btn_Listen_Quantity.Location = new System.Drawing.Point(227, 254);
            this.btn_Listen_Quantity.Name = "btn_Listen_Quantity";
            this.btn_Listen_Quantity.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen_Quantity.TabIndex = 38;
            this.btn_Listen_Quantity.Text = "Listen";
            this.btn_Listen_Quantity.UseVisualStyleBackColor = true;
            this.btn_Listen_Quantity.Click += new System.EventHandler(this.Btn_Listen_Quantity_Click);
            // 
            // btn_stopListening_Supplier
            // 
            this.btn_stopListening_Supplier.Location = new System.Drawing.Point(308, 316);
            this.btn_stopListening_Supplier.Name = "btn_stopListening_Supplier";
            this.btn_stopListening_Supplier.Size = new System.Drawing.Size(154, 23);
            this.btn_stopListening_Supplier.TabIndex = 41;
            this.btn_stopListening_Supplier.Text = "Stop Listening";
            this.btn_stopListening_Supplier.UseVisualStyleBackColor = true;
            this.btn_stopListening_Supplier.Click += new System.EventHandler(this.Btn_stopListening_Supplier_Click);
            // 
            // btn_Listen_Supplier
            // 
            this.btn_Listen_Supplier.Location = new System.Drawing.Point(227, 316);
            this.btn_Listen_Supplier.Name = "btn_Listen_Supplier";
            this.btn_Listen_Supplier.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen_Supplier.TabIndex = 40;
            this.btn_Listen_Supplier.Text = "Listen";
            this.btn_Listen_Supplier.UseVisualStyleBackColor = true;
            this.btn_Listen_Supplier.Click += new System.EventHandler(this.Btn_Listen_Supplier_Click);
            // 
            // btn_stopListening_OrderTotal
            // 
            this.btn_stopListening_OrderTotal.Location = new System.Drawing.Point(308, 379);
            this.btn_stopListening_OrderTotal.Name = "btn_stopListening_OrderTotal";
            this.btn_stopListening_OrderTotal.Size = new System.Drawing.Size(154, 23);
            this.btn_stopListening_OrderTotal.TabIndex = 43;
            this.btn_stopListening_OrderTotal.Text = "Stop Listening";
            this.btn_stopListening_OrderTotal.UseVisualStyleBackColor = true;
            this.btn_stopListening_OrderTotal.Click += new System.EventHandler(this.Btn_stopListening_OrderTotal_Click);
            // 
            // btn_Listen_OrderTotal
            // 
            this.btn_Listen_OrderTotal.Location = new System.Drawing.Point(227, 379);
            this.btn_Listen_OrderTotal.Name = "btn_Listen_OrderTotal";
            this.btn_Listen_OrderTotal.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen_OrderTotal.TabIndex = 42;
            this.btn_Listen_OrderTotal.Text = "Listen";
            this.btn_Listen_OrderTotal.UseVisualStyleBackColor = true;
            this.btn_Listen_OrderTotal.Click += new System.EventHandler(this.Btn_Listen_OrderTotal_Click);
            // 
            // btn_stopListening_Approval
            // 
            this.btn_stopListening_Approval.Location = new System.Drawing.Point(308, 448);
            this.btn_stopListening_Approval.Name = "btn_stopListening_Approval";
            this.btn_stopListening_Approval.Size = new System.Drawing.Size(154, 23);
            this.btn_stopListening_Approval.TabIndex = 45;
            this.btn_stopListening_Approval.Text = "Stop Listening";
            this.btn_stopListening_Approval.UseVisualStyleBackColor = true;
            this.btn_stopListening_Approval.Click += new System.EventHandler(this.Btn_stopListening_Approval_Click);
            // 
            // btn_Listen_Approval
            // 
            this.btn_Listen_Approval.Location = new System.Drawing.Point(227, 448);
            this.btn_Listen_Approval.Name = "btn_Listen_Approval";
            this.btn_Listen_Approval.Size = new System.Drawing.Size(75, 23);
            this.btn_Listen_Approval.TabIndex = 44;
            this.btn_Listen_Approval.Text = "Listen";
            this.btn_Listen_Approval.UseVisualStyleBackColor = true;
            this.btn_Listen_Approval.Click += new System.EventHandler(this.Btn_Listen_Approval_Click);
            // 
            // FormPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(532, 938);
            this.Controls.Add(this.btn_stopListening_Approval);
            this.Controls.Add(this.btn_Listen_Approval);
            this.Controls.Add(this.btn_stopListening_OrderTotal);
            this.Controls.Add(this.btn_Listen_OrderTotal);
            this.Controls.Add(this.btn_stopListening_Supplier);
            this.Controls.Add(this.btn_Listen_Supplier);
            this.Controls.Add(this.btn_stopListening_Quantity);
            this.Controls.Add(this.btn_Listen_Quantity);
            this.Controls.Add(this.btn_stopListening_DD);
            this.Controls.Add(this.btn_Listen_DD);
            this.Controls.Add(this.btn_stopListening_POD);
            this.Controls.Add(this.btn_Listen_POD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_stop_listen);
            this.Controls.Add(this.btn_listen);
            this.Controls.Add(this.ddlVoices);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.label_speechRate);
            this.Controls.Add(this.trackBar_Volume);
            this.Controls.Add(this.trackBar_SpeechRate);
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
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_resume);
            this.Controls.Add(this.btn_stop);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_stopListening_POD;
        private System.Windows.Forms.Button btn_Listen_POD;
        private System.Windows.Forms.Button btn_stopListening_DD;
        private System.Windows.Forms.Button btn_Listen_DD;
        private System.Windows.Forms.Button btn_stopListening_Quantity;
        private System.Windows.Forms.Button btn_Listen_Quantity;
        private System.Windows.Forms.Button btn_stopListening_Supplier;
        private System.Windows.Forms.Button btn_Listen_Supplier;
        private System.Windows.Forms.Button btn_stopListening_OrderTotal;
        private System.Windows.Forms.Button btn_Listen_OrderTotal;
        private System.Windows.Forms.Button btn_stopListening_Approval;
        private System.Windows.Forms.Button btn_Listen_Approval;
    }
}