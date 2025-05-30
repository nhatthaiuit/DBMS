namespace QuanLychiTieu
{
    partial class Register
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtConfPass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picEyeHide2 = new System.Windows.Forms.PictureBox();
            this.picEyeShow2 = new System.Windows.Forms.PictureBox();
            this.picEyeShow1 = new System.Windows.Forms.PictureBox();
            this.picEyeHide1 = new System.Windows.Forms.PictureBox();
            this.picRegister = new System.Windows.Forms.PictureBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Full Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(215, 146);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(198, 22);
            this.txtName.TabIndex = 4;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "ConfirmPass:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(215, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(198, 22);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(215, 267);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(198, 22);
            this.txtPass.TabIndex = 7;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtConfPass
            // 
            this.txtConfPass.Location = new System.Drawing.Point(215, 311);
            this.txtConfPass.Name = "txtConfPass";
            this.txtConfPass.PasswordChar = '*';
            this.txtConfPass.Size = new System.Drawing.Size(198, 22);
            this.txtConfPass.TabIndex = 8;
            this.txtConfPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtConfPass_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLychiTieu.Properties.Resources.add_group;
            this.pictureBox1.Location = new System.Drawing.Point(163, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // picEyeHide2
            // 
            this.picEyeHide2.BackColor = System.Drawing.Color.White;
            this.picEyeHide2.Image = global::QuanLychiTieu.Properties.Resources.hide;
            this.picEyeHide2.Location = new System.Drawing.Point(389, 313);
            this.picEyeHide2.Name = "picEyeHide2";
            this.picEyeHide2.Size = new System.Drawing.Size(20, 18);
            this.picEyeHide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeHide2.TabIndex = 14;
            this.picEyeHide2.TabStop = false;
            this.picEyeHide2.Click += new System.EventHandler(this.picEyeHide2_Click);
            // 
            // picEyeShow2
            // 
            this.picEyeShow2.BackColor = System.Drawing.Color.White;
            this.picEyeShow2.Image = global::QuanLychiTieu.Properties.Resources.view;
            this.picEyeShow2.Location = new System.Drawing.Point(389, 313);
            this.picEyeShow2.Name = "picEyeShow2";
            this.picEyeShow2.Size = new System.Drawing.Size(20, 18);
            this.picEyeShow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeShow2.TabIndex = 13;
            this.picEyeShow2.TabStop = false;
            this.picEyeShow2.Click += new System.EventHandler(this.picEyeShow2_Click);
            // 
            // picEyeShow1
            // 
            this.picEyeShow1.BackColor = System.Drawing.Color.White;
            this.picEyeShow1.Image = global::QuanLychiTieu.Properties.Resources.view;
            this.picEyeShow1.Location = new System.Drawing.Point(390, 269);
            this.picEyeShow1.Name = "picEyeShow1";
            this.picEyeShow1.Size = new System.Drawing.Size(20, 18);
            this.picEyeShow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeShow1.TabIndex = 12;
            this.picEyeShow1.TabStop = false;
            this.picEyeShow1.Click += new System.EventHandler(this.picEyeShow1_Click);
            // 
            // picEyeHide1
            // 
            this.picEyeHide1.BackColor = System.Drawing.Color.White;
            this.picEyeHide1.Image = global::QuanLychiTieu.Properties.Resources.hide;
            this.picEyeHide1.Location = new System.Drawing.Point(390, 269);
            this.picEyeHide1.Name = "picEyeHide1";
            this.picEyeHide1.Size = new System.Drawing.Size(20, 18);
            this.picEyeHide1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeHide1.TabIndex = 11;
            this.picEyeHide1.TabStop = false;
            this.picEyeHide1.Click += new System.EventHandler(this.picEyeHide1_Click);
            // 
            // picRegister
            // 
            this.picRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRegister.Image = global::QuanLychiTieu.Properties.Resources.signup;
            this.picRegister.Location = new System.Drawing.Point(154, 347);
            this.picRegister.Name = "picRegister";
            this.picRegister.Size = new System.Drawing.Size(190, 93);
            this.picRegister.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRegister.TabIndex = 9;
            this.picRegister.TabStop = false;
            this.picRegister.Click += new System.EventHandler(this.picRegister_Click);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(215, 227);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(58, 20);
            this.rbMale.TabIndex = 16;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(323, 227);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(74, 20);
            this.rbFemale.TabIndex = 17;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(93, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Gender:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picEyeHide2);
            this.Controls.Add(this.picEyeShow2);
            this.Controls.Add(this.picEyeShow1);
            this.Controls.Add(this.picEyeHide1);
            this.Controls.Add(this.picRegister);
            this.Controls.Add(this.txtConfPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtConfPass;
        private System.Windows.Forms.PictureBox picRegister;
        private System.Windows.Forms.PictureBox picEyeHide1;
        private System.Windows.Forms.PictureBox picEyeShow1;
        private System.Windows.Forms.PictureBox picEyeShow2;
        private System.Windows.Forms.PictureBox picEyeHide2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Label label6;
    }
}