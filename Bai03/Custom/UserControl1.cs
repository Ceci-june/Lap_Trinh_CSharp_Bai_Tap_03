using AxWMPLib;
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
using static System.Windows.Forms.LinkLabel;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace Bai03.Custom
{
    public partial class UserControl1 : UserControl
    {
        private DataRow dt;
        public UserControl1(DataRow dr)
        {
            InitializeComponent();
            //pictureBox1.Image = (Image)Bai03.Properties.Resources.ResourceManager.GetObject(dr["id"].ToString());
            pictureBoxPic.Image = (Image)Resource1.ResourceManager.GetObject(dr["id"].ToString());
            pictureBoxPic.SizeMode = PictureBoxSizeMode.StretchImage;
            labelSong.Text = dr["name"].ToString();
            labelSinger.Text = dr["singer"].ToString();
            if (dr["love"].ToString() == "1")
            {
                pictureBoxHeart.Image = Bai03.Properties.Resources.heart2;
            }
            dt = dr;
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            Form1.id = dt;
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //string link = "resource\\mv\\" + dt["id"].ToString() + ".mp4";
            //Form1.axWindowsMediaPlayer1.URL = link;
            //Form2.
            Form1.id = dt;
            //if (Application.OpenForms.OfType<Form2>().Count() == 0)
            //{
            //    Form2 form2 = new Form2();
            //    form2.ShowDialog();
            //}
            //else
            //{
            //    string link = "resource\\lyrics\\" + Form1.id["id"].ToString() + ".txt";
            //    Form2.lyric.Text = File.ReadAllText(link);
            //}
            string link = "resource\\lyrics\\" + Form1.id["id"].ToString() + ".txt";
            Form1.lyric.Text = File.ReadAllText(link);

            DataRow find = Form1.history.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == dt["id"].ToString());

            if (find == null)
            {
                Form1.history.Rows.Add(dt["id"].ToString(), dt["name"].ToString(), dt["singer"].ToString(), dt["composer"].ToString(), dt["type"].ToString(), Convert.ToInt32(dt["love"]), Convert.ToInt32(dt["star"]),  1, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            }
            else
            {
                int index = Form1.history.Rows.IndexOf(find);
                Form1.history.Rows[index]["watch"] = Convert.ToInt32(Form1.history.Rows[index]["watch"]) + 1;
                Form1.history.Rows[index]["time"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }

        }

        private void pictureBoxHeart_Click(object sender, EventArgs e)
        {
            int index = Form1.data.Rows.IndexOf(dt);
            if (Convert.ToInt32(Form1.data.Rows[index]["love"]) != 1)
            {
                Form1.data.Rows[index]["love"] = 1;
                pictureBoxHeart.Image = Bai03.Properties.Resources.heart2;
            }
            else
            {
                Form1.data.Rows[index]["love"] = 0;
                pictureBoxHeart.Image = Bai03.Properties.Resources.heart1;
            }
            dt = Form1.data.Rows[index];
        }

        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Video|*.mp4;";
            //ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string link = "resource\\mv\\" + dt["id"].ToString() + ".mp4";
                System.IO.File.Copy(link, sfd.FileName);
            }
        }

        private void pictureBoxSave_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(dt);
            form2.ShowDialog();
        }
    }
}
