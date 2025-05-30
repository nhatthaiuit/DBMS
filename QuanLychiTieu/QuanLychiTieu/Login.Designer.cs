﻿namespace QuanLychiTieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.likRegister = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picEyeHide = new System.Windows.Forms.PictureBox();
            this.picEyeShow = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(171, 125);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 22);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(171, 172);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(183, 22);
            this.txtPass.TabIndex = 4;
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // likRegister
            // 
            this.likRegister.AutoSize = true;
            this.likRegister.LinkColor = System.Drawing.Color.Black;
            this.likRegister.Location = new System.Drawing.Point(168, 213);
            this.likRegister.Name = "likRegister";
            this.likRegister.Size = new System.Drawing.Size(58, 16);
            this.likRegister.TabIndex = 7;
            this.likRegister.TabStop = true;
            this.likRegister.Text = "Register";
            this.likRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.likRegister_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLychiTieu.Properties.Resources.account;
            this.pictureBox1.Location = new System.Drawing.Point(111, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // picEyeHide
            // 
            this.picEyeHide.BackColor = System.Drawing.Color.White;
            this.picEyeHide.Image = global::QuanLychiTieu.Properties.Resources.hide;
            this.picEyeHide.Location = new System.Drawing.Point(329, 175);
            this.picEyeHide.Name = "picEyeHide";
            this.picEyeHide.Size = new System.Drawing.Size(20, 18);
            this.picEyeHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeHide.TabIndex = 10;
            this.picEyeHide.TabStop = false;
            this.picEyeHide.Click += new System.EventHandler(this.picEyeHide_Click);
            // 
            // picEyeShow
            // 
            this.picEyeShow.BackColor = System.Drawing.Color.White;
            this.picEyeShow.Image = global::QuanLychiTieu.Properties.Resources.view;
            this.picEyeShow.Location = new System.Drawing.Point(328, 175);
            this.picEyeShow.Name = "picEyeShow";
            this.picEyeShow.Size = new System.Drawing.Size(20, 18);
            this.picEyeShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEyeShow.TabIndex = 9;
            this.picEyeShow.TabStop = false;
            this.picEyeShow.Click += new System.EventHandler(this.picEyeShow_Click);
            // 
            // picLogin
            // 
            this.picLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogin.Image = global::QuanLychiTieu.Properties.Resources.sign_in;
            this.picLogin.Location = new System.Drawing.Point(131, 242);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(106, 71);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 8;
            this.picLogin.TabStop = false;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            this.picLogin.MouseEnter += new System.EventHandler(this.picLogin_MouseEnter);
            this.picLogin.MouseLeave += new System.EventHandler(this.picLogin_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(382, 343);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picEyeHide);
            this.Controls.Add(this.picEyeShow);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.likRegister);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEyeShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.LinkLabel likRegister;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picEyeShow;
        private System.Windows.Forms.PictureBox picEyeHide;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

