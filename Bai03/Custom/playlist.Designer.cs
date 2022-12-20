namespace Bai03.Custom
{
    partial class playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playlist));
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.labelPlaylist = new System.Windows.Forms.Label();
            this.pictureDelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxPic.BackgroundImage")));
            this.pictureBoxPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPic.Location = new System.Drawing.Point(38, 5);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(224, 166);
            this.pictureBoxPic.TabIndex = 1;
            this.pictureBoxPic.TabStop = false;
            this.pictureBoxPic.Click += new System.EventHandler(this.pictureBoxPic_Click);
            // 
            // labelPlaylist
            // 
            this.labelPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaylist.ForeColor = System.Drawing.Color.Black;
            this.labelPlaylist.Location = new System.Drawing.Point(3, 174);
            this.labelPlaylist.Name = "labelPlaylist";
            this.labelPlaylist.Size = new System.Drawing.Size(287, 34);
            this.labelPlaylist.TabIndex = 2;
            this.labelPlaylist.Text = "label1";
            this.labelPlaylist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureDelete
            // 
            this.pictureDelete.Image = ((System.Drawing.Image)(resources.GetObject("pictureDelete.Image")));
            this.pictureDelete.Location = new System.Drawing.Point(133, 212);
            this.pictureDelete.Name = "pictureDelete";
            this.pictureDelete.Size = new System.Drawing.Size(25, 25);
            this.pictureDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDelete.TabIndex = 6;
            this.pictureDelete.TabStop = false;
            this.pictureDelete.Click += new System.EventHandler(this.pictureDelete_Click);
            // 
            // playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureDelete);
            this.Controls.Add(this.labelPlaylist);
            this.Controls.Add(this.pictureBoxPic);
            this.Name = "playlist";
            this.Size = new System.Drawing.Size(300, 241);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPic;
        private System.Windows.Forms.Label labelPlaylist;
        private System.Windows.Forms.PictureBox pictureDelete;
    }
}
