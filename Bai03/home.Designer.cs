namespace Bai03
{
    partial class home
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxKpop = new System.Windows.Forms.CheckBox();
            this.checkBoxUsuk = new System.Windows.Forms.CheckBox();
            this.checkBoxVpop = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 107);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(921, 477);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(136, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 72);
            this.groupBox1.TabIndex = 15;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 48);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // checkBoxKpop
            // 
            this.checkBoxKpop.AutoSize = true;
            this.checkBoxKpop.ForeColor = System.Drawing.Color.White;
            this.checkBoxKpop.Location = new System.Drawing.Point(291, 3);
            this.checkBoxKpop.Name = "checkBoxKpop";
            this.checkBoxKpop.Size = new System.Drawing.Size(77, 24);
            this.checkBoxKpop.TabIndex = 19;
            this.checkBoxKpop.Text = "KPOP";
            this.checkBoxKpop.UseVisualStyleBackColor = true;
            // 
            // checkBoxUsuk
            // 
            this.checkBoxUsuk.AutoSize = true;
            this.checkBoxUsuk.ForeColor = System.Drawing.Color.White;
            this.checkBoxUsuk.Location = new System.Drawing.Point(147, 3);
            this.checkBoxUsuk.Name = "checkBoxUsuk";
            this.checkBoxUsuk.Size = new System.Drawing.Size(77, 24);
            this.checkBoxUsuk.TabIndex = 18;
            this.checkBoxUsuk.Text = "USUK";
            this.checkBoxUsuk.UseVisualStyleBackColor = true;
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
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 596);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.Text = "home";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxKpop;
        private System.Windows.Forms.CheckBox checkBoxUsuk;
        private System.Windows.Forms.CheckBox checkBoxVpop;
    }
}