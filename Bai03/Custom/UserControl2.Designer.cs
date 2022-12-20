namespace Bai03.Custom
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.labelSong = new System.Windows.Forms.Label();
            this.labelSinger = new System.Windows.Forms.Label();
            this.labelWatch = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(4, 3);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(215, 129);
            this.pictureBoxPic.TabIndex = 0;
            this.pictureBoxPic.TabStop = false;
            this.pictureBoxPic.Click += new System.EventHandler(this.pictureBoxPic_Click);
            // 
            // labelSong
            // 
            this.labelSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSong.ForeColor = System.Drawing.Color.Black;
            this.labelSong.Location = new System.Drawing.Point(220, 3);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(409, 38);
            this.labelSong.TabIndex = 2;
            this.labelSong.Text = "label1          ";
            // 
            // labelSinger
            // 
            this.labelSinger.BackColor = System.Drawing.Color.Snow;
            this.labelSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinger.ForeColor = System.Drawing.Color.DimGray;
            this.labelSinger.Location = new System.Drawing.Point(218, 41);
            this.labelSinger.Name = "labelSinger";
            this.labelSinger.Size = new System.Drawing.Size(396, 29);
            this.labelSinger.TabIndex = 3;
            this.labelSinger.Text = "Ca sĩ: Sơn Tùng M-TP";
            this.labelSinger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWatch
            // 
            this.labelWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWatch.ForeColor = System.Drawing.Color.DimGray;
            this.labelWatch.Location = new System.Drawing.Point(217, 70);
            this.labelWatch.Name = "labelWatch";
            this.labelWatch.Size = new System.Drawing.Size(412, 34);
            this.labelWatch.TabIndex = 4;
            this.labelWatch.Text = "Số lần xem: 5";
            this.labelWatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.DimGray;
            this.labelTime.Location = new System.Drawing.Point(215, 104);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(396, 34);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Thời gian gần nhất:";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.pictureBoxPic);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelWatch);
            this.Controls.Add(this.labelSinger);
            this.Controls.Add(this.labelSong);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(621, 139);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.Label labelSinger;
        private System.Windows.Forms.Label labelWatch;
        private System.Windows.Forms.Label labelTime;
    }
}
