using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai03.Custom
{
    public partial class playlist : UserControl
    {
        public playlist(string s)
        {
            InitializeComponent();
            labelPlaylist.Text = s;
        }

        private void pictureBoxPic_Click(object sender, EventArgs e)
        {
            Form1.temp.Text = labelPlaylist.Text;
        }

        private void pictureDelete_Click(object sender, EventArgs e)
        {
            string link = "resource//playlist//" + labelPlaylist.Text + ".txt";
            File.Delete(link);
            this.Visible = false;
            //Form1.temp.Text = "";
        }
    }
}
