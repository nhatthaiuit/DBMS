namespace QuanLychiTieu
{
    partial class Statistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.pnStatistc = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.dateFill = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFill = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lkIncome = new System.Windows.Forms.LinkLabel();
            this.lkExpenses = new System.Windows.Forms.LinkLabel();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnStatistc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnStatistc
            // 
            this.pnStatistc.BackColor = System.Drawing.Color.Transparent;
            this.pnStatistc.BackgroundImage = global::QuanLychiTieu.Properties.Resources.z4812254013250_530f7a4de9348d2221bfb204a57d3f61;
            this.pnStatistc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnStatistc.Controls.Add(this.groupBox1);
            this.pnStatistc.Controls.Add(this.chartMain);
            this.pnStatistc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnStatistc.Location = new System.Drawing.Point(0, 0);
            this.pnStatistc.Name = "pnStatistc";
            this.pnStatistc.Size = new System.Drawing.Size(761, 641);
            this.pnStatistc.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picLoad);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.cbValue);
            this.groupBox1.Controls.Add(this.dateFill);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFill);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lkIncome);
            this.groupBox1.Controls.Add(this.lkExpenses);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 117);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // picLoad
            // 
            this.picLoad.BackColor = System.Drawing.Color.Transparent;
            this.picLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoad.Image = global::QuanLychiTieu.Properties.Resources.work_in_progress_static;
            this.picLoad.Location = new System.Drawing.Point(470, 85);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(35, 29);
            this.picLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoad.TabIndex = 16;
            this.picLoad.TabStop = false;
            this.picLoad.Click += new System.EventHandler(this.picLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLychiTieu.Properties.Resources.financial_statement;
            this.pictureBox1.Location = new System.Drawing.Point(36, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cbValue
            // 
            this.cbValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(578, 42);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(142, 24);
            this.cbValue.TabIndex = 7;
            // 
            // dateFill
            // 
            this.dateFill.CustomFormat = "MM-yyyy";
            this.dateFill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFill.Location = new System.Drawing.Point(229, 21);
            this.dateFill.Name = "dateFill";
            this.dateFill.Size = new System.Drawing.Size(300, 22);
            this.dateFill.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date:";
            // 
            // cbFill
            // 
            this.cbFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFill.FormattingEnabled = true;
            this.cbFill.Location = new System.Drawing.Point(229, 58);
            this.cbFill.Name = "cbFill";
            this.cbFill.Size = new System.Drawing.Size(300, 24);
            this.cbFill.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fill:";
            // 
            // lkIncome
            // 
            this.lkIncome.AutoSize = true;
            this.lkIncome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkIncome.LinkColor = System.Drawing.Color.Gray;
            this.lkIncome.Location = new System.Drawing.Point(362, 93);
            this.lkIncome.Name = "lkIncome";
            this.lkIncome.Size = new System.Drawing.Size(57, 16);
            this.lkIncome.TabIndex = 1;
            this.lkIncome.TabStop = true;
            this.lkIncome.Text = "Income";
            this.lkIncome.Click += new System.EventHandler(this.lkIncome_Click);
            this.lkIncome.MouseEnter += new System.EventHandler(this.lkIncome_MouseEnter_1);
            this.lkIncome.MouseLeave += new System.EventHandler(this.lkIncome_MouseLeave_1);
            // 
            // lkExpenses
            // 
            this.lkExpenses.AutoSize = true;
            this.lkExpenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lkExpenses.LinkColor = System.Drawing.Color.Gray;
            this.lkExpenses.Location = new System.Drawing.Point(226, 93);
            this.lkExpenses.Name = "lkExpenses";
            this.lkExpenses.Size = new System.Drawing.Size(75, 16);
            this.lkExpenses.TabIndex = 0;
            this.lkExpenses.TabStop = true;
            this.lkExpenses.Text = "Expenses";
            this.lkExpenses.Click += new System.EventHandler(this.lkExpenses_Click);
            // 
            // chartMain
            // 
            this.chartMain.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartMain.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            legend2.Title = "Statistics";
            this.chartMain.Legends.Add(legend2);
            this.chartMain.Location = new System.Drawing.Point(8, 135);
            this.chartMain.Name = "chartMain";
            series3.ChartArea = "ChartArea1";
            series3.EmptyPointStyle.Name = "Expenses";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Expenses";
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Income";
            this.chartMain.Series.Add(series3);
            this.chartMain.Series.Add(series4);
            this.chartMain.Size = new System.Drawing.Size(750, 494);
            this.chartMain.TabIndex = 2;
            this.chartMain.Text = "chart1";
            title2.Name = "Statistics";
            this.chartMain.Titles.Add(title2);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::QuanLychiTieu.Properties.Resources.z4812254013250_530f7a4de9348d2221bfb204a57d3f61;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(761, 641);
            this.Controls.Add(this.pnStatistc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.Statistics_Load);
            this.pnStatistc.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnStatistc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.DateTimePicker dateFill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lkIncome;
        private System.Windows.Forms.LinkLabel lkExpenses;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picLoad;
    }
}