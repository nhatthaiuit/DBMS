namespace QuanLychiTieu
{
    partial class Profile
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.pnUpdatePass = new System.Windows.Forms.Panel();
            this.picEyeHide2 = new System.Windows.Forms.PictureBox();
            this.picEyeShow1 = new System.Windows.Forms.PictureBox();
            this.picEyeHide1 = new System.Windows.Forms.PictureBox();
            this.picEyeShow2 = new System.Windows.Forms.PictureBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.likChangePass = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMoneyIncome = new System.Windows.Forms.Label();
            this.lbMoneyEx = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.pnUpdatePass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "New password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(387, 285);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 22);
            this.txtName.TabIndex = 6;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(387, 332);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(201, 18);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(229, 22);
            this.txtPass.TabIndex = 8;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.Transparent;
            this.rbMale.Location = new System.Drawing.Point(387, 378);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbFemale.Location = new System.Drawing.Point(542, 378);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = false;
            // 
            // pnUpdatePass
            // 
            this.pnUpdatePass.BackColor = System.Drawing.Color.Transparent;
            this.pnUpdatePass.Controls.Add(this.picEyeHide2);
            this.pnUpdatePass.Controls.Add(this.picEyeShow1);
            this.pnUpdatePass.Controls.Add(this.picEyeHide1);
            this.pnUpdatePass.Controls.Add(this.picEyeShow2);
            this.pnUpdatePass.Controls.Add(this.txtConfirmPass);
            this.pnUpdatePass.Controls.Add(this.label6);
            this.pnUpdatePass.Controls.Add(this.txtPass);
            this.pnUpdatePass.Controls.Add(this.label5);
            this.pnUpdatePass.Location = new System.Drawing.Point(186, 451);
            this.pnUpdatePass.Name = "pnUpdatePass";
            this.pnUpdatePass.Size = new System.Drawing.Size(437, 100);
            this.pnUpdatePass.TabIndex = 11;
            // 
            // picEyeHide2
            // 
            this.picEyeHide2.BackColor = System.Drawing.Color.White;
            this.picEyeHide2.Image = global::QuanLychiTieu.Properties.Resources.hide;
            this.picEyeHide2.Location = new System.Drawing.Point(406, 65);
            this.picEyeHide2.Name = "picEyeHide2";
            this.picEyeHide2.Size = new System.Drawing.Size(20, 18);
            this.picEyeHide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeHide2.TabIndex = 17;
            this.picEyeHide2.TabStop = false;
            this.picEyeHide2.Click += new System.EventHandler(this.picEyeHide2_Click);
            // 
            // picEyeShow1
            // 
            this.picEyeShow1.BackColor = System.Drawing.Color.White;
            this.picEyeShow1.Image = global::QuanLychiTieu.Properties.Resources.view;
            this.picEyeShow1.Location = new System.Drawing.Point(405, 20);
            this.picEyeShow1.Name = "picEyeShow1";
            this.picEyeShow1.Size = new System.Drawing.Size(20, 18);
            this.picEyeShow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeShow1.TabIndex = 14;
            this.picEyeShow1.TabStop = false;
            this.picEyeShow1.Click += new System.EventHandler(this.picEyeShow1_Click);
            // 
            // picEyeHide1
            // 
            this.picEyeHide1.BackColor = System.Drawing.Color.White;
            this.picEyeHide1.Image = global::QuanLychiTieu.Properties.Resources.hide;
            this.picEyeHide1.Location = new System.Drawing.Point(405, 20);
            this.picEyeHide1.Name = "picEyeHide1";
            this.picEyeHide1.Size = new System.Drawing.Size(20, 18);
            this.picEyeHide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeHide1.TabIndex = 15;
            this.picEyeHide1.TabStop = false;
            this.picEyeHide1.Click += new System.EventHandler(this.picEyeHide1_Click);
            // 
            // picEyeShow2
            // 
            this.picEyeShow2.BackColor = System.Drawing.Color.White;
            this.picEyeShow2.Image = global::QuanLychiTieu.Properties.Resources.view;
            this.picEyeShow2.Location = new System.Drawing.Point(406, 65);
            this.picEyeShow2.Name = "picEyeShow2";
            this.picEyeShow2.Size = new System.Drawing.Size(20, 18);
            this.picEyeShow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeShow2.TabIndex = 16;
            this.picEyeShow2.TabStop = false;
            this.picEyeShow2.Click += new System.EventHandler(this.picEyeShow2_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(201, 63);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.PasswordChar = '*';
            this.txtConfirmPass.Size = new System.Drawing.Size(229, 22);
            this.txtConfirmPass.TabIndex = 12;
            this.txtConfirmPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfirmPass_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "ConfirmPass:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(351, 568);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 30);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // likChangePass
            // 
            this.likChangePass.AutoSize = true;
            this.likChangePass.BackColor = System.Drawing.Color.Transparent;
            this.likChangePass.LinkColor = System.Drawing.Color.Black;
            this.likChangePass.Location = new System.Drawing.Point(196, 423);
            this.likChangePass.Name = "likChangePass";
            this.likChangePass.Size = new System.Drawing.Size(117, 16);
            this.likChangePass.TabIndex = 13;
            this.likChangePass.TabStop = true;
            this.likChangePass.Text = "Change Password";
            this.likChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likChangePass_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLychiTieu.Properties.Resources.profile;
            this.pictureBox1.Location = new System.Drawing.Point(26, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(187, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = " Total current year income:";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.BackColor = System.Drawing.Color.Transparent;
            this.lable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable1.Location = new System.Drawing.Point(187, 196);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(227, 18);
            this.lable1.TabIndex = 15;
            this.lable1.Text = " Total current year expenses:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(194, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Remaining balance:";
            // 
            // lbMoneyIncome
            // 
            this.lbMoneyIncome.AutoSize = true;
            this.lbMoneyIncome.BackColor = System.Drawing.Color.Transparent;
            this.lbMoneyIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyIncome.Location = new System.Drawing.Point(455, 161);
            this.lbMoneyIncome.Name = "lbMoneyIncome";
            this.lbMoneyIncome.Size = new System.Drawing.Size(58, 16);
            this.lbMoneyIncome.TabIndex = 17;
            this.lbMoneyIncome.Text = "label10";
            // 
            // lbMoneyEx
            // 
            this.lbMoneyEx.AutoSize = true;
            this.lbMoneyEx.BackColor = System.Drawing.Color.Transparent;
            this.lbMoneyEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneyEx.Location = new System.Drawing.Point(455, 198);
            this.lbMoneyEx.Name = "lbMoneyEx";
            this.lbMoneyEx.Size = new System.Drawing.Size(58, 16);
            this.lbMoneyEx.TabIndex = 18;
            this.lbMoneyEx.Text = "label10";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.BackColor = System.Drawing.Color.Transparent;
            this.lbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBalance.Location = new System.Drawing.Point(456, 236);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(58, 16);
            this.lbBalance.TabIndex = 19;
            this.lbBalance.Text = "label10";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLychiTieu.Properties.Resources.z4812271924581_9ea8fa077b401669cc789d0801a981fb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(761, 641);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbMoneyEx);
            this.Controls.Add(this.lbMoneyIncome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.likChangePass);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pnUpdatePass);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.Shown += new System.EventHandler(this.Profile_Shown);
            this.pnUpdatePass.ResumeLayout(false);
            this.pnUpdatePass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Panel pnUpdatePass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel likChangePass;
        private System.Windows.Forms.PictureBox picEyeShow1;
        private System.Windows.Forms.PictureBox picEyeShow2;
        private System.Windows.Forms.PictureBox picEyeHide1;
        private System.Windows.Forms.PictureBox picEyeHide2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMoneyIncome;
        private System.Windows.Forms.Label lbMoneyEx;
        private System.Windows.Forms.Label lbBalance;
    }
}