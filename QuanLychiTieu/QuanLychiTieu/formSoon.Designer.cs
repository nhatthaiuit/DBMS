namespace QuanLychiTieu
{
    partial class formSoon
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
            this.picSoon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSoon)).BeginInit();
            this.SuspendLayout();
            // 
            // picSoon
            // 
            this.picSoon.Image = global::QuanLychiTieu.Properties.Resources.soon;
            this.picSoon.Location = new System.Drawing.Point(269, 249);
            this.picSoon.Name = "picSoon";
            this.picSoon.Size = new System.Drawing.Size(215, 109);
            this.picSoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSoon.TabIndex = 3;
            this.picSoon.TabStop = false;
            // 
            // formSoon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 641);
            this.Controls.Add(this.picSoon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSoon";
            this.Text = "formSoon";
            ((System.ComponentModel.ISupportInitialize)(this.picSoon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSoon;
    }
}