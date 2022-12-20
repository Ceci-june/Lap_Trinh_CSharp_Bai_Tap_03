namespace Bai03.Custom
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.labelSong = new System.Windows.Forms.Label();
            this.pictureBoxDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxShare = new System.Windows.Forms.PictureBox();
            this.pictureBoxSave = new System.Windows.Forms.PictureBox();
            this.pictureBoxHeart = new System.Windows.Forms.PictureBox();
            this.labelSinger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(3, 4);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(295, 158);
            this.pictureBoxPic.TabIndex = 0;
            this.pictureBoxPic.TabStop = false;
            this.pictureBoxPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelSong
            // 
            this.labelSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSong.ForeColor = System.Drawing.Color.Black;
            this.labelSong.Location = new System.Drawing.Point(7, 168);
            this.labelSong.Name = "labelSong";
            this.labelSong.Size = new System.Drawing.Size(287, 34);
            this.labelSong.TabIndex = 1;
            this.labelSong.Text = "label1";
            this.labelSong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxDown
            // 
            this.pictureBoxDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDown.Image")));
            this.pictureBoxDown.Location = new System.Drawing.Point(271, 212);
            this.pictureBoxDown.Name = "pictureBoxDown";
            this.pictureBoxDown.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDown.TabIndex = 2;
            this.pictureBoxDown.TabStop = false;
            this.pictureBoxDown.Click += new System.EventHandler(this.pictureBoxDown_Click);
            // 
            // pictureBoxShare
            // 
            this.pictureBoxShare.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShare.Image")));
            this.pictureBoxShare.Location = new System.Drawing.Point(240, 212);
            this.pictureBoxShare.Name = "pictureBoxShare";
            this.pictureBoxShare.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxShare.TabIndex = 3;
            this.pictureBoxShare.TabStop = false;
            // 
            // pictureBoxSave
            // 
            this.pictureBoxSave.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSave.Image")));
            this.pictureBoxSave.Location = new System.Drawing.Point(209, 212);
            this.pictureBoxSave.Name = "pictureBoxSave";
            this.pictureBoxSave.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSave.TabIndex = 4;
            this.pictureBoxSave.TabStop = false;
            this.pictureBoxSave.Click += new System.EventHandler(this.pictureBoxSave_Click);
            // 
            // pictureBoxHeart
            // 
            this.pictureBoxHeart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHeart.Image")));
            this.pictureBoxHeart.Location = new System.Drawing.Point(178, 212);
            this.pictureBoxHeart.Name = "pictureBoxHeart";
            this.pictureBoxHeart.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxHeart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHeart.TabIndex = 5;
            this.pictureBoxHeart.TabStop = false;
            this.pictureBoxHeart.Click += new System.EventHandler(this.pictureBoxHeart_Click);
            // 
            // labelSinger
            // 
            this.labelSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinger.ForeColor = System.Drawing.Color.DimGray;
            this.labelSinger.Location = new System.Drawing.Point(7, 203);
            this.labelSinger.Name = "labelSinger";
            this.labelSinger.Size = new System.Drawing.Size(165, 40);
            this.labelSinger.TabIndex = 6;
            this.labelSinger.Text = "singer";
            this.labelSinger.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.labelSinger);
            this.Controls.Add(this.pictureBoxHeart);
            this.Controls.Add(this.pictureBoxSave);
            this.Controls.Add(this.pictureBoxShare);
            this.Controls.Add(this.pictureBoxDown);
            this.Controls.Add(this.labelSong);
            this.Controls.Add(this.pictureBoxPic);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(301, 245);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHeart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.Label labelSong;
        private System.Windows.Forms.PictureBox pictureBoxDown;
        private System.Windows.Forms.PictureBox pictureBoxShare;
        private System.Windows.Forms.PictureBox pictureBoxSave;
        private System.Windows.Forms.PictureBox pictureBoxHeart;
        private System.Windows.Forms.Label labelSinger;
    }
}
