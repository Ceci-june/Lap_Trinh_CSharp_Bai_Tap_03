using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AxWMPLib;
using Bai03.Properties;
using System.Runtime.InteropServices.ComTypes;
using WMPLib;

namespace Bai03
{
    public partial class Form2 : Form
    {
        private DataRow dt;
        public Form2(DataRow dr)
        {
            InitializeComponent();
            DirectoryInfo d = new DirectoryInfo("resource//playlist");
            FileInfo[] Files = d.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                CheckBox cb = new CheckBox();
                cb.Text = file.Name.Split('.')[0];
                cb.Size = new Size(160, 30);
                cb.ForeColor = Color.Black;
                flowLayoutPanel1.Controls.Add(cb);
            }
            dt = dr;

        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

      

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

    

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in flowLayoutPanel1.Controls)
            {
                if (cb.Checked)
                {
                    string filePath = "resource//playlist//" + cb.Text + ".txt";
                    List<string> lines = new List<string>();
                    lines = File.ReadAllLines(filePath).ToList();
                    lines.Add(dt["id"].ToString() + "*" + dt["name"].ToString() + "*" + dt["singer"].ToString() + "*" + dt["composer"].ToString() + "*" + dt["type"].ToString() + "*" + Convert.ToInt32(dt["love"]) + "*" + Convert.ToInt32(dt["star"]));
                    File.WriteAllLines(filePath, lines);
                }
            }
            if (textBox1.Text != "")
            {
                string filePath = "resource//playlist//" + textBox1.Text + ".txt";
                List<string> lines = new List<string>();
                lines.Add("id*name*singer*composer*type*love*star");
                lines.Add(dt["id"].ToString() + "*" + dt["name"].ToString() + "*" + dt["singer"].ToString() + "*" + dt["composer"].ToString() + "*" + dt["type"].ToString() + "*" + Convert.ToInt32(dt["love"]) + "*" + Convert.ToInt32(dt["star"]));
                File.WriteAllLines(filePath, lines);
            }
            this.Close();
        }
    }
}
