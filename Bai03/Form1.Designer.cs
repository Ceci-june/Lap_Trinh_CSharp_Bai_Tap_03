namespace Bai03
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelHome = new System.Windows.Forms.Label();
            this.labelLove = new System.Windows.Forms.Label();
            this.labelPlaylist = new System.Windows.Forms.Label();
            this.richTextBoxSearch = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxKpop = new System.Windows.Forms.CheckBox();
            this.checkBoxUsuk = new System.Windows.Forms.CheckBox();
            this.checkBoxVpop = new System.Windows.Forms.CheckBox();
            this.labelHistory = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.flowLayoutPanelComment = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelCmt1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownStar = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBoxCmt = new System.Windows.Forms.RichTextBox();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.labelComposer = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelStar = new System.Windows.Forms.Label();
            this.labelSinger = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelLyric = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.flowLayoutPanelComment.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStar)).BeginInit();
            this.groupBoxInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 108);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 751);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.Black;
            this.labelHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.Red;
            this.labelHome.Location = new System.Drawing.Point(55, 146);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(82, 29);
            this.labelHome.TabIndex = 2;
            this.labelHome.Text = "Home";
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // labelLove
            // 
            this.labelLove.AutoSize = true;
            this.labelLove.BackColor = System.Drawing.Color.Black;
            this.labelLove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLove.ForeColor = System.Drawing.Color.White;
            this.labelLove.Location = new System.Drawing.Point(55, 203);
            this.labelLove.Name = "labelLove";
            this.labelLove.Size = new System.Drawing.Size(137, 29);
            this.labelLove.TabIndex = 3;
            this.labelLove.Text = "Love Song";
            this.labelLove.Click += new System.EventHandler(this.labelLove_Click);
            // 
            // labelPlaylist
            // 
            this.labelPlaylist.AutoSize = true;
            this.labelPlaylist.BackColor = System.Drawing.Color.Black;
            this.labelPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaylist.ForeColor = System.Drawing.Color.White;
            this.labelPlaylist.Location = new System.Drawing.Point(55, 263);
            this.labelPlaylist.Name = "labelPlaylist";
            this.labelPlaylist.Size = new System.Drawing.Size(97, 29);
            this.labelPlaylist.TabIndex = 5;
            this.labelPlaylist.Text = "Playlist";
            this.labelPlaylist.Click += new System.EventHandler(this.label4_Click);
            // 
            // richTextBoxSearch
            // 
            this.richTextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxSearch.Location = new System.Drawing.Point(1004, 12);
            this.richTextBoxSearch.Name = "richTextBoxSearch";
            this.richTextBoxSearch.Size = new System.Drawing.Size(343, 28);
            this.richTextBoxSearch.TabIndex = 13;
            this.richTextBoxSearch.Text = "";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(1346, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tìm kiếm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1004, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 72);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.checkBoxKpop, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxUsuk, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxVpop, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(454, 48);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // checkBoxKpop
            // 
            this.checkBoxKpop.AutoSize = true;
            this.checkBoxKpop.ForeColor = System.Drawing.Color.White;
            this.checkBoxKpop.Location = new System.Drawing.Point(305, 3);
            this.checkBoxKpop.Name = "checkBoxKpop";
            this.checkBoxKpop.Size = new System.Drawing.Size(77, 24);
            this.checkBoxKpop.TabIndex = 19;
            this.checkBoxKpop.Text = "KPOP";
            this.checkBoxKpop.UseVisualStyleBackColor = true;
            this.checkBoxKpop.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxUsuk
            // 
            this.checkBoxUsuk.AutoSize = true;
            this.checkBoxUsuk.ForeColor = System.Drawing.Color.White;
            this.checkBoxUsuk.Location = new System.Drawing.Point(154, 3);
            this.checkBoxUsuk.Name = "checkBoxUsuk";
            this.checkBoxUsuk.Size = new System.Drawing.Size(77, 24);
            this.checkBoxUsuk.TabIndex = 18;
            this.checkBoxUsuk.Text = "USUK";
            this.checkBoxUsuk.UseVisualStyleBackColor = true;
            this.checkBoxUsuk.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBoxVpop
            // 
            this.checkBoxVpop.AutoSize = true;
            this.checkBoxVpop.ForeColor = System.Drawing.Color.White;
            this.checkBoxVpop.Location = new System.Drawing.Point(3, 3);
            this.checkBoxVpop.Name = "checkBoxVpop";
            this.checkBoxVpop.Size = new System.Drawing.Size(77, 24);
            this.checkBoxVpop.TabIndex = 17;
            this.checkBoxVpop.Text = "VPOP";
            this.checkBoxVpop.UseVisualStyleBackColor = true;
            this.checkBoxVpop.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.BackColor = System.Drawing.Color.Black;
            this.labelHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistory.ForeColor = System.Drawing.Color.White;
            this.labelHistory.Location = new System.Drawing.Point(55, 316);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(94, 29);
            this.labelHistory.TabIndex = 15;
            this.labelHistory.Text = "History";
            this.labelHistory.Click += new System.EventHandler(this.labelHistory_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1004, 124);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(476, 627);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(235, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(748, 492);
            this.axWindowsMediaPlayer1.TabIndex = 34;
            // 
            // flowLayoutPanelComment
            // 
            this.flowLayoutPanelComment.BackColor = System.Drawing.Color.DarkCyan;
            this.flowLayoutPanelComment.Controls.Add(this.flowLayoutPanelCmt1);
            this.flowLayoutPanelComment.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanelComment.Location = new System.Drawing.Point(235, 542);
            this.flowLayoutPanelComment.Name = "flowLayoutPanelComment";
            this.flowLayoutPanelComment.Size = new System.Drawing.Size(748, 209);
            this.flowLayoutPanelComment.TabIndex = 41;
            this.flowLayoutPanelComment.Visible = false;
            this.flowLayoutPanelComment.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelComment_Paint);
            // 
            // flowLayoutPanelCmt1
            // 
            this.flowLayoutPanelCmt1.AutoScroll = true;
            this.flowLayoutPanelCmt1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelCmt1.Name = "flowLayoutPanelCmt1";
            this.flowLayoutPanelCmt1.Size = new System.Drawing.Size(437, 206);
            this.flowLayoutPanelCmt1.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label1);
            this.flowLayoutPanel3.Controls.Add(this.textBoxName);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.numericUpDownStar);
            this.flowLayoutPanel3.Controls.Add(this.button4);
            this.flowLayoutPanel3.Controls.Add(this.richTextBoxCmt);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(446, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(296, 200);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(72, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(3, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Star:   ";
            // 
            // numericUpDownStar
            // 
            this.numericUpDownStar.Location = new System.Drawing.Point(77, 31);
            this.numericUpDownStar.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownStar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStar.Name = "numericUpDownStar";
            this.numericUpDownStar.Size = new System.Drawing.Size(77, 22);
            this.numericUpDownStar.TabIndex = 4;
            this.numericUpDownStar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(160, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "Post";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBoxCmt
            // 
            this.richTextBoxCmt.Location = new System.Drawing.Point(3, 69);
            this.richTextBoxCmt.Name = "richTextBoxCmt";
            this.richTextBoxCmt.Size = new System.Drawing.Size(293, 136);
            this.richTextBoxCmt.TabIndex = 6;
            this.richTextBoxCmt.Text = "";
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.BackColor = System.Drawing.Color.LightPink;
            this.groupBoxInformation.Controls.Add(this.labelComposer);
            this.groupBoxInformation.Controls.Add(this.labelName);
            this.groupBoxInformation.Controls.Add(this.labelStar);
            this.groupBoxInformation.Controls.Add(this.labelSinger);
            this.groupBoxInformation.ForeColor = System.Drawing.Color.LightPink;
            this.groupBoxInformation.Location = new System.Drawing.Point(234, 542);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(749, 209);
            this.groupBoxInformation.TabIndex = 40;
            this.groupBoxInformation.TabStop = false;
            // 
            // labelComposer
            // 
            this.labelComposer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComposer.ForeColor = System.Drawing.Color.Black;
            this.labelComposer.Location = new System.Drawing.Point(6, 150);
            this.labelComposer.Name = "labelComposer";
            this.labelComposer.Size = new System.Drawing.Size(737, 39);
            this.labelComposer.TabIndex = 3;
            this.labelComposer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Crimson;
            this.labelName.Location = new System.Drawing.Point(6, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(737, 39);
            this.labelName.TabIndex = 0;
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStar
            // 
            this.labelStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStar.ForeColor = System.Drawing.Color.Yellow;
            this.labelStar.Location = new System.Drawing.Point(6, 51);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(737, 51);
            this.labelStar.TabIndex = 1;
            this.labelStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSinger
            // 
            this.labelSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSinger.ForeColor = System.Drawing.Color.Black;
            this.labelSinger.Location = new System.Drawing.Point(6, 110);
            this.labelSinger.Name = "labelSinger";
            this.labelSinger.Size = new System.Drawing.Size(737, 39);
            this.labelSinger.TabIndex = 2;
            this.labelSinger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkCyan;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(416, 516);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 31);
            this.button3.TabIndex = 39;
            this.button3.Text = "Comment";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(325, 516);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 31);
            this.button2.TabIndex = 38;
            this.button2.Text = "Lyric";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(234, 516);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 31);
            this.button1.TabIndex = 37;
            this.button1.Text = "Information";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanelLyric
            // 
            this.flowLayoutPanelLyric.AutoScroll = true;
            this.flowLayoutPanelLyric.BackColor = System.Drawing.Color.SteelBlue;
            this.flowLayoutPanelLyric.Location = new System.Drawing.Point(235, 546);
            this.flowLayoutPanelLyric.Name = "flowLayoutPanelLyric";
            this.flowLayoutPanelLyric.Size = new System.Drawing.Size(748, 205);
            this.flowLayoutPanelLyric.TabIndex = 36;
            this.flowLayoutPanelLyric.Visible = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBoxSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPlaylist);
            this.Controls.Add(this.labelLove);
            this.Controls.Add(this.labelHome);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.flowLayoutPanelComment);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.flowLayoutPanelLyric);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.flowLayoutPanelComment.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStar)).EndInit();
            this.groupBoxInformation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelLove;
        private System.Windows.Forms.Label labelPlaylist;
        private System.Windows.Forms.RichTextBox richTextBoxSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxKpop;
        private System.Windows.Forms.CheckBox checkBoxUsuk;
        private System.Windows.Forms.CheckBox checkBoxVpop;
        private System.Windows.Forms.Label labelHistory;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelComment;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.Label labelComposer;
        private System.Windows.Forms.Label labelSinger;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLyric;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCmt1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownStar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBoxCmt;
    }
}

