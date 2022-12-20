namespace Bai03.Custom
{
    partial class UserControl3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl3));
            this.labelSong = new System.Windows.Forms.Label();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.labelSinger = new System.Windows.Forms.Label();
            this.pictureBoxShare = new System.Windows.Forms.PictureBox();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.pictureDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSong
            // 
            this.labelSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSong.ForeColor = System.Drawing.Color.Black;
            this.labelSong.Location = new System.Drawing.Point(7, 169);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(287, 34);
            this.labelSong.TabIndex = 3;
            this.labelSong.Text = "label1";
            this.labelSong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(3, 5);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(295, 158);
            this.pictureBoxPic.TabIndex = 2;
            this.pictureBoxPic.TabStop = false;
            this.pictureBoxPic.Click += new System.EventHandler(this.pictureBoxPic_Click);
            // 
            // labelSinger
            // 
            this.labelSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinger.ForeColor = System.Drawing.Color.DimGray;
            this.labelSinger.Location = new System.Drawing.Point(3, 203);
            this.labelSinger.Name = "labelSinger";
            this.labelSinger.Size = new System.Drawing.Size(196, 40);
            this.labelSinger.TabIndex = 9;
            this.labelSinger.Text = "singer";
            this.labelSinger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxShare
            // 
            this.pictureBoxShare.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShare.Image")));
            this.pictureBoxShare.Location = new System.Drawing.Point(236, 212);
            this.pictureBoxShare.Name = "pictureBoxShare";
            this.pictureBoxShare.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShare.TabIndex = 8;
            this.pictureBoxShare.TabStop = false;
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDown.Image")));
            this.pictureBoxDown.Location = new System.Drawing.Point(267, 212);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDown.TabIndex = 7;
            this.pictureBoxDown.TabStop = false;
            this.pictureBoxDown.Click += new System.EventHandler(this.pictureBoxDown_Click);
            // 
            // pictureDelete
            // 
            this.pictureDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictureDelete.Image")));
            this.pictureDelete.Location = new System.Drawing.Point(205, 212);
            this.pictureDelete.Name = "pictureDelete";
            this.pictureDelete.Size = new System.Drawing.Size(25, 25);
            this.pictureDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDelete.TabIndex = 10;
            this.pictureDelete.TabStop = false;
            this.pictureDelete.Click += new System.EventHandler(this.pictureDelete_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureDelete);
            this.Controls.Add(this.labelSinger);
            this.Controls.Add(this.pictureBoxShare);
            this.Controls.Add(this.pictureBoxDown);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.pictureBoxPic);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(301, 245);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.Label labelSinger;
        private System.Windows.Forms.PictureBox pictureBoxShare;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.PictureBox pictureDelete;
    }
}
