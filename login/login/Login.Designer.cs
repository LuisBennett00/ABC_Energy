namespace login
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.TextBox();
            this.passInput = new System.Windows.Forms.TextBox();
            this.userType = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.logButton = new System.Windows.Forms.Button();
            this.createaccount = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.showPassCheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(310, 442);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABCEnergy";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(272, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(272, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(272, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "User";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInput.ForeColor = System.Drawing.Color.White;
            this.userInput.Location = new System.Drawing.Point(380, 203);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(157, 20);
            this.userInput.TabIndex = 4;
            // 
            // passInput
            // 
            this.passInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passInput.ForeColor = System.Drawing.Color.White;
            this.passInput.Location = new System.Drawing.Point(380, 262);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(157, 20);
            this.passInput.TabIndex = 5;
            this.passInput.UseSystemPasswordChar = true;
            // 
            // userType
            // 
            this.userType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.userType.ForeColor = System.Drawing.Color.White;
            this.userType.FormattingEnabled = true;
            this.userType.Items.AddRange(new object[] {
            "Public",
            "Staff"});
            this.userType.Location = new System.Drawing.Point(376, 147);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(168, 21);
            this.userType.TabIndex = 6;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(327, 427);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(164, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgotton Username or Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // logButton
            // 
            this.logButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logButton.Location = new System.Drawing.Point(342, 324);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(140, 47);
            this.logButton.TabIndex = 7;
            this.logButton.Text = "Login";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // createaccount
            // 
            this.createaccount.Location = new System.Drawing.Point(342, 377);
            this.createaccount.Name = "createaccount";
            this.createaccount.Size = new System.Drawing.Size(140, 47);
            this.createaccount.TabIndex = 9;
            this.createaccount.Text = "Create Account";
            this.createaccount.UseVisualStyleBackColor = true;
            this.createaccount.Click += new System.EventHandler(this.createaccount_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.DimGray;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.White;
            this.linkLabel2.Location = new System.Drawing.Point(530, 26);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(14, 13);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "X";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // showPassCheck
            // 
            this.showPassCheck.AutoSize = true;
            this.showPassCheck.ForeColor = System.Drawing.Color.White;
            this.showPassCheck.Location = new System.Drawing.Point(380, 288);
            this.showPassCheck.Name = "showPassCheck";
            this.showPassCheck.Size = new System.Drawing.Size(102, 17);
            this.showPassCheck.TabIndex = 11;
            this.showPassCheck.Text = "Show Password";
            this.showPassCheck.UseVisualStyleBackColor = true;
            this.showPassCheck.CheckedChanged += new System.EventHandler(this.showPassCheck_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(371, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.showPassCheck);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.createaccount);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.passInput);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "ABC Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.TextBox passInput;
        private System.Windows.Forms.ComboBox userType;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button createaccount;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox showPassCheck;
        private System.Windows.Forms.Label label5;
    }
}

