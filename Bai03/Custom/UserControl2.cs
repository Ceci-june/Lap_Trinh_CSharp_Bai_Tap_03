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
using AxWMPLib;

namespace Bai03.Custom
{
    public partial class UserControl2 : UserControl
    {
        private DataRow dt;
        public UserControl2(DataRow dr)
        {
            InitializeComponent();
            pictureBoxPic.Image = (Image)Resource1.ResourceManager.GetObject(dr["id"].ToString());
            pictureBoxPic.SizeMode = PictureBoxSizeMode.StretchImage;
            labelSong.Text = dr["name"].ToString();
            labelSinger.Text = "Ca sĩ: "+dr["singer"].ToString();
            labelWatch.Text = "Số lần xem: " + dr["watch"].ToString();
            labelTime.Text = "Thời gian gần nhất: " + dr["time"].ToString();
            dt = dr;
        }

        private void pictureBoxPic_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = null;
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


            //Form2.video.URL = link;

            DataRow find = Form1.history.AsEnumerable().SingleOrDefault(r => r.Field<string>("id") == dt["id"].ToString());

            if (find == null)
            {
                Form1.history.Rows.Add(dt["id"].ToString(), dt["name"].ToString(), dt["singer"].ToString(), dt["composer"].ToString(), dt["type"].ToString(), Convert.ToBoolean(dt["love"]), Convert.ToInt32(dt["star"]), 1, DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            }
            else
            {
                int index = Form1.history.Rows.IndexOf(find);
                Form1.history.Rows[index]["watch"] = Convert.ToInt32(Form1.history.Rows[index]["watch"]) + 1;
                Form1.history.Rows[index]["time"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }

        }
    }
}
