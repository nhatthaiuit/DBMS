namespace QuanLychiTieu
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.lbStatistics = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.Label();
            this.lbExpense = new System.Windows.Forms.Label();
            this.lbProfile = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnShowMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picHeart = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnShowMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.lbStatistics);
            this.panel1.Controls.Add(this.lbIncome);
            this.panel1.Controls.Add(this.lbExpense);
            this.panel1.Controls.Add(this.lbProfile);
            this.panel1.Controls.Add(this.picAvatar);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 641);
            this.panel1.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(79, 124);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 16);
            this.lbName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hello:";
            // 
            // picLogout
            // 
            this.picLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogout.Image = global::QuanLychiTieu.Properties.Resources.logout;
            this.picLogout.Location = new System.Drawing.Point(-7, 567);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(276, 61);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogout.TabIndex = 4;
            this.picLogout.TabStop = false;
            this.picLogout.Click += new System.EventHandler(this.picLogout_Click);
            this.picLogout.MouseEnter += new System.EventHandler(this.picLogout_MouseEnter);
            this.picLogout.MouseLeave += new System.EventHandler(this.picLogout_MouseLeave);
            // 
            // lbStatistics
            // 
            this.lbStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatistics.Location = new System.Drawing.Point(-4, 451);
            this.lbStatistics.Name = "lbStatistics";
            this.lbStatistics.Size = new System.Drawing.Size(276, 61);
            this.lbStatistics.TabIndex = 3;
            this.lbStatistics.Text = "Statistics";
            this.lbStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbStatistics.Click += new System.EventHandler(this.lbStatistics_Click);
            this.lbStatistics.MouseEnter += new System.EventHandler(this.lbStatistics_MouseEnter);
            this.lbStatistics.MouseLeave += new System.EventHandler(this.lbStatistics_MouseLeave);
            // 
            // lbIncome
            // 
            this.lbIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncome.Location = new System.Drawing.Point(-4, 352);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(276, 61);
            this.lbIncome.TabIndex = 2;
            this.lbIncome.Text = "Income";
            this.lbIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbIncome.Click += new System.EventHandler(this.lbIncome_Click);
            this.lbIncome.MouseEnter += new System.EventHandler(this.lbIncome_MouseEnter);
            this.lbIncome.MouseLeave += new System.EventHandler(this.lbIncome_MouseLeave);
            // 
            // lbExpense
            // 
            this.lbExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpense.Location = new System.Drawing.Point(-4, 255);
            this.lbExpense.Name = "lbExpense";
            this.lbExpense.Size = new System.Drawing.Size(276, 61);
            this.lbExpense.TabIndex = 1;
            this.lbExpense.Text = "Expense";
            this.lbExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExpense.Click += new System.EventHandler(this.lbExpense_Click);
            this.lbExpense.MouseEnter += new System.EventHandler(this.lbExpense_MouseEnter);
            this.lbExpense.MouseLeave += new System.EventHandler(this.lbExpense_MouseLeave);
            // 
            // lbProfile
            // 
            this.lbProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfile.Location = new System.Drawing.Point(-7, 159);
            this.lbProfile.Name = "lbProfile";
            this.lbProfile.Size = new System.Drawing.Size(276, 61);
            this.lbProfile.TabIndex = 0;
            this.lbProfile.Text = "Profile";
            this.lbProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbProfile.Click += new System.EventHandler(this.lbProfile_Click);
            this.lbProfile.MouseEnter += new System.EventHandler(this.lbProfile_MouseEnter);
            this.lbProfile.MouseLeave += new System.EventHandler(this.lbProfile_MouseLeave);
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::QuanLychiTieu.Properties.Resources.man;
            this.picAvatar.Location = new System.Drawing.Point(56, 16);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(145, 97);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // pnShowMain
            // 
            this.pnShowMain.BackColor = System.Drawing.Color.Transparent;
            this.pnShowMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnShowMain.Controls.Add(this.label3);
            this.pnShowMain.Controls.Add(this.label2);
            this.pnShowMain.Controls.Add(this.picHeart);
            this.pnShowMain.Location = new System.Drawing.Point(264, 0);
            this.pnShowMain.Name = "pnShowMain";
            this.pnShowMain.Size = new System.Drawing.Size(771, 637);
            this.pnShowMain.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Have a nice day <3!!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to the expense management app !!";
            // 
            // picHeart
            // 
            this.picHeart.Image = global::QuanLychiTieu.Properties.Resources.heart;
            this.picHeart.Location = new System.Drawing.Point(316, 262);
            this.picHeart.Name = "picHeart";
            this.picHeart.Size = new System.Drawing.Size(176, 96);
            this.picHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeart.TabIndex = 0;
            this.picHeart.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1028, 637);
            this.Controls.Add(this.pnShowMain);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.Shown += new System.EventHandler(this.Home_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnShowMain.ResumeLayout(false);
            this.pnShowMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Panel pnShowMain;
        private System.Windows.Forms.Label lbProfile;
        private System.Windows.Forms.Label lbIncome;
        private System.Windows.Forms.Label lbExpense;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Label lbStatistics;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picHeart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}