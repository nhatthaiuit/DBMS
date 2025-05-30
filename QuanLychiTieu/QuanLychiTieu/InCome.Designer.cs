namespace QuanLychiTieu
{
    partial class InCome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InCome));
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.cbMoney = new System.Windows.Forms.ComboBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtGridIn = new System.Windows.Forms.DataGridView();
            this.dateIncome = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddType = new System.Windows.Forms.Button();
            this.cbInType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.LinkColor = System.Drawing.Color.Gray;
            this.linkLabel1.Location = new System.Drawing.Point(80, 267);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(77, 16);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click to add";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel1.MouseEnter += new System.EventHandler(this.linkLabel1_MouseEnter);
            this.linkLabel1.MouseLeave += new System.EventHandler(this.linkLabel1_MouseLeave);
            // 
            // cbMoney
            // 
            this.cbMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMoney.FormattingEnabled = true;
            this.cbMoney.Location = new System.Drawing.Point(253, 237);
            this.cbMoney.Name = "cbMoney";
            this.cbMoney.Size = new System.Drawing.Size(262, 24);
            this.cbMoney.TabIndex = 25;
            this.cbMoney.SelectedIndexChanged += new System.EventHandler(this.cbMoney_SelectedIndexChanged);
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoney.Location = new System.Drawing.Point(80, 237);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(63, 18);
            this.lbMoney.TabIndex = 24;
            this.lbMoney.Text = "Money:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 27;
            // 
            // dtGridIn
            // 
            this.dtGridIn.AllowUserToAddRows = false;
            this.dtGridIn.AllowUserToDeleteRows = false;
            this.dtGridIn.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtGridIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colInType,
            this.colMoney,
            this.colDate,
            this.colNote});
            this.dtGridIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtGridIn.Location = new System.Drawing.Point(5, 292);
            this.dtGridIn.MultiSelect = false;
            this.dtGridIn.Name = "dtGridIn";
            this.dtGridIn.ReadOnly = true;
            this.dtGridIn.RowHeadersWidth = 51;
            this.dtGridIn.RowTemplate.Height = 24;
            this.dtGridIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridIn.Size = new System.Drawing.Size(754, 345);
            this.dtGridIn.TabIndex = 23;
            this.dtGridIn.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridIn_CellDoubleClick);
            this.dtGridIn.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dtGridIn_SortCompare);
            // 
            // dateIncome
            // 
            this.dateIncome.Location = new System.Drawing.Point(253, 190);
            this.dateIncome.Name = "dateIncome";
            this.dateIncome.Size = new System.Drawing.Size(262, 22);
            this.dateIncome.TabIndex = 22;
            this.dateIncome.CloseUp += new System.EventHandler(this.dateIncome_CloseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Date Income:";
            // 
            // btnAddType
            // 
            this.btnAddType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddType.Location = new System.Drawing.Point(571, 144);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(104, 30);
            this.btnAddType.TabIndex = 20;
            this.btnAddType.Text = "Add type";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // cbInType
            // 
            this.cbInType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbInType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbInType.FormattingEnabled = true;
            this.cbInType.Location = new System.Drawing.Point(253, 144);
            this.cbInType.Name = "cbInType";
            this.cbInType.Size = new System.Drawing.Size(262, 24);
            this.cbInType.TabIndex = 19;
            this.cbInType.SelectedIndexChanged += new System.EventHandler(this.cbInType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Income Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 46);
            this.label1.TabIndex = 16;
            this.label1.Text = "Income";
            // 
            // picLoad
            // 
            this.picLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoad.Image = global::QuanLychiTieu.Properties.Resources.work_in_progress_static;
            this.picLoad.Location = new System.Drawing.Point(587, 203);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(51, 41);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoad.TabIndex = 26;
            this.picLoad.TabStop = false;
            this.picLoad.Click += new System.EventHandler(this.picLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLychiTieu.Properties.Resources.income;
            this.pictureBox1.Location = new System.Drawing.Point(43, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.Location = new System.Drawing.Point(536, 267);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(0, 15);
            this.lbTotalMoney.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Total money this year:";
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.MinimumWidth = 6;
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Width = 50;
            // 
            // colInType
            // 
            this.colInType.HeaderText = "Income type";
            this.colInType.MinimumWidth = 6;
            this.colInType.Name = "colInType";
            this.colInType.ReadOnly = true;
            this.colInType.Width = 125;
            // 
            // colMoney
            // 
            this.colMoney.HeaderText = "Money (VND)";
            this.colMoney.MinimumWidth = 6;
            this.colMoney.Name = "colMoney";
            this.colMoney.ReadOnly = true;
            this.colMoney.Width = 125;
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            this.colDate.Width = 125;
            // 
            // colNote
            // 
            this.colNote.HeaderText = "Note";
            this.colNote.MinimumWidth = 6;
            this.colNote.Name = "colNote";
            this.colNote.ReadOnly = true;
            this.colNote.Width = 200;
            // 
            // InCome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLychiTieu.Properties.Resources.z4812252816823_4e536b64a092c02ebc7603f5e36effb4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(761, 641);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.picLoad);
            this.Controls.Add(this.cbMoney);
            this.Controls.Add(this.lbMoney);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtGridIn);
            this.Controls.Add(this.dateIncome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.cbInType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InCome";
            this.Text = "Income";
            this.Load += new System.EventHandler(this.InCome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox picLoad;
        private System.Windows.Forms.ComboBox cbMoney;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtGridIn;
        private System.Windows.Forms.DateTimePicker dateIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.ComboBox cbInType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNote;
    }
}