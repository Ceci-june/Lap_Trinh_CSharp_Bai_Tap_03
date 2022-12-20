using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        public static DataTable data = new DataTable();
        public static DataTable history = new DataTable();
        public static DataTable playlist = new DataTable();
        public static DataTable cmt = new DataTable();
        public static DataRow id;
        public string s;
        public static string star = "★";
        public static Label lyric = new Label();
        public static TextBox temp= new TextBox();
        public static TextBox temp2 = new TextBox();
        public Form1()
        {
            InitializeComponent();
            //data.Columns.Add("id",typeof(string));
            //data.Columns.Add("name",typeof(string));
            //data.Columns.Add("singer", typeof(string));
            //data.Columns.Add("composer", typeof(string));
            //data.Columns.Add("type", typeof(string));
            //data.Columns.Add("love", typeof(int));
            //data.Columns.Add("star", typeof(int));
            //data.Rows.Add("blankspace", "Blank Space", "Staylor Swift", "Staylor Swift", "USUK",0,5);
            //data.Rows.Add("sugar", "Sugar", "Maroon 5", "Mike Posner, Adam Levine, Dr. Luke, Jacob Kasher Hindlin","USUK", 0, 4);
            //data.Rows.Add("muonroimasaocon", "Muộn rồi mà sao còn", "Sơn Tùng M-TP", "Sơn Tùng M-TP","VPOP", 0, 5);
            //data.Rows.Add("pinkvenom", "Pink Venom", "Black Pink", "Teddy, 24, R. Tee, Ido","KPOP", 0, 5);
            //data.Rows.Add("emla", "Em Là", "Mono", "Nguyễn Ngọc Hoàng Anh, Nguyễn Việt Hoàng","VPOP", 0, 4);
            //data.Rows.Add("dusktilldawn", "Dusk Till Dawn", "Zayn, Sia", "Zayn Malik, Sia Furler, Alex Oriet, David Phelan, Greg Kurstin","USUK", 0, 5);
            //data.Rows.Add("hetyeuthatsao", "Hết Yêu Thật Sao", "JSOL", "JSOL, ViruSs","VPOP", 0, 5);
            //data.Rows.Add("afterlike", "After Like", "IVE", "Ryan S. Jhun, Anders Nilsen, André Jensen, Iselin Solheim", "KPOP", 0, 3);
            //data.Rows.Add("thelazysong", "The Lazy Song", "Bruno Marsy", "Bruno Mars, Philip Lawrence, Ari Levine, K'naan", "USUK", 0, 5);
            //data.Rows.Add("rude", "Rude", "Magic!", "Nasri Atweh, Adam Messinger, Mark Pellizzer, Ben Spivak, Alex Tanas", "USUK", 0, 5);
            //data.Rows.Add("_906090", "906090","Tóc Tiên, Mew Amazing", "Tóc Tiên, Mew Amazing", "VPOP", 0, 5);
            //data.Rows.Add("lavieenrose", "La Vie En Rose", "IZ*ONE", "", "KPOP", 0, 3);
            ////data.Rows.Add("loveshot", "Love Shot", "EXO", "", "KPOP",0, 3);
            //data.Rows.Add("hypeboy", "Hype Boy", "NewJeans", "", "KPOP", 0, 4);
            //data.Rows.Add("buayeu", "Bùa Yêu", "Bích Phương", "", "VPOP", 0, 4);
            //data.Rows.Add("trentinhbanduoitinhyeu", "Trên Tình Bạn Dưới Tình Yêu", "Min", "", "VPOP", 0, 3);
            //data.Rows.Add("bbombbom", "BBom BBom", "Momoland", "", "KPOP", 0, 2);
            //data.Rows.Add("nextlevel", "Next Level", "Aespa", "", "KPOP", 0, 4);
            //data.Rows.Add("howyoulikethat", "How You Like That", "Black Pink", "", "KPOP", 0, 5);
            //data.Rows.Add("heatwaves", "Heat Waves", "Glass Animals", "", "USUK", 0, 5);
            //data.Rows.Add("youngblood", "Youngblood", "5 Seconds of Summer", "", "USUK", 0, 5);
            ////data.Rows.Add("lightswitch", "Light Switch", "Charlie Puth", "Charlie Puth", "USUK",0, 5);
            //data.Rows.Add("_1congtocmai", "1 Cộng Tóc Mai", "Tóc Tiên", "", "VPOP", 0, 5);
            //data.Rows.Add("gaidocthan", "Gái Độc Thân", "Tlinh", "", "VPOP", 0, 5);
            //data.Rows.Add("sangmatchua", "Sáng Mắt Chưa", "Trúc Nhân", "", "VPOP", 0, 5);
            //data.Rows.Add("peekaboo", "Peek A Boo", "Red Velvet", "", "KPOP", 0, 5);
            //data.Rows.Add("energetic", "Energetic", "Wanna One", "", "KPOP", 0, 5);
            //data.Rows.Add("senorita", "Senorita", "Shawn Mendes, Camila Cabello", "", "USUK", 0, 5);
            //data.Rows.Add("tetdongday", "Tết Đông Đầy", "Kay Trần", "", "VPOP", 0, 5);
            //data.Rows.Add("takemetochurch", "Take Me To Church", "Hozier", "Hozier", "USUK", 0, 5);
            loadData(ref data, "resource//data.txt"); 
            loadData(ref history,"resource//history.txt");
            ShowItem(data);
            lyric.AutoSize=true;
            flowLayoutPanelLyric.Controls.Add(lyric);
            lyric.Text = "";
            lyric.TextChanged += new EventHandler(Changed);
            this.Controls.Add(temp);
            temp.Visible = false;
            temp.Text = "abc";
            temp.TextChanged+= new EventHandler(OpenPlaylist);
            temp2.Visible = false;
            temp2.Text = "abc";
            this.Controls.Add(temp2);
            temp2.TextChanged += new EventHandler(ReloadPlaylist);

        }
        private void OpenPlaylist(object sender, EventArgs e)
        { 
            if (temp.Text=="")
            {
                ShowPlaylist();
            }
            else if (temp.Text !="abc")
            {
                string s = "resource//playlist//" + temp.Text + ".txt";
                loadData(ref playlist, s);
                addPlaylistSong();
            }
            

        }
        private void ReloadPlaylist(object sender, EventArgs e)
        {
            string s = "resource//playlist//" + temp.Text + ".txt";
            loadData(ref playlist, s);
            addPlaylistSong();
        }
        private void Changed(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer1.URL = null;

            string link = "resource\\mv\\" + Form1.id["id"].ToString() + ".mp4";
            labelName.Text = Form1.id["name"].ToString();
            labelStar.Text = string.Concat(Enumerable.Repeat(Form1.star, Convert.ToInt32(Form1.id["star"])));
            labelSinger.Text = "Singer: " + Form1.id["singer"].ToString();
            labelComposer.Text = "Composer: " + Form1.id["composer"].ToString();
            axWindowsMediaPlayer1.URL = link;
            LoadCmt();

        }
        private void LoadCmt()
        {
            flowLayoutPanelCmt1.Controls.Clear();
            string link = "resource\\cmt\\" + Form1.id["id"].ToString() + ".txt";
            loadData(ref cmt, link);
            foreach (DataRow row in cmt.Rows)
            {

                Custom.comment it = new Custom.comment(row);
                flowLayoutPanelCmt1.Controls.Add(it);
            }
        }
        private void ShowItem(DataTable table)
        {
            flowLayoutPanel1.Controls.Clear();
            DataRow[] foundRows;
            if (checkBoxKpop.Checked && !checkBoxVpop.Checked && !checkBoxUsuk.Checked)
            {
                foundRows = table.Select("type = 'kpop'");
            }
            else if (checkBoxKpop.Checked && checkBoxVpop.Checked && !checkBoxUsuk.Checked)
            {
                foundRows = table.Select("type = 'kpop' or type = 'vpop'");
            }
            else if (!checkBoxKpop.Checked && checkBoxVpop.Checked && !checkBoxUsuk.Checked)
            {
                foundRows = table.Select("type = 'vpop'");
            }
            else if (!checkBoxKpop.Checked && !checkBoxVpop.Checked && checkBoxUsuk.Checked)
            {
                foundRows = table.Select("type = 'usuk'");
            }
            else if (!checkBoxKpop.Checked && checkBoxVpop.Checked && checkBoxUsuk.Checked)
            {
                foundRows = table.Select("type = 'vpop' or type = 'usuk'");
            }
            else if (checkBoxKpop.Checked && !checkBoxVpop.Checked && checkBoxUsuk.Checked)
            {
                foundRows = table.Select("type = 'kpop' or type = 'usuk'");
            }
            else
            {
                foundRows = table.Select();
            }
            add(foundRows);
        }
        private void add(DataRow[] foundRows)
        {
            foreach (DataRow row in foundRows)
            {

                Custom.UserControl1 it = new Custom.UserControl1(row);
                flowLayoutPanel1.Controls.Add(it);
            }
        }
        private void ShowItemHistory()
        {
            flowLayoutPanel1.Controls.Clear();
            DataRow[] foundRows;
            if (checkBoxKpop.Checked && !checkBoxVpop.Checked && !checkBoxUsuk.Checked)
            {
                foundRows = history.Select("type = 'kpop'");
            }
            else if (checkBoxKpop.Checked && checkBoxVpop.Checked && !checkBoxUsuk.Checked)
            {
                foundRows = history.Select("type = 'kpop' or type = 'vpop'");
            }
            else if (!checkBoxKpop.Checked && checkBoxVpop.Checked && !checkBoxUsuk.Checked)
            {
                foundRows = history.Select("type = 'vpop'");
            }
            else if (!checkBoxKpop.Checked && !checkBoxVpop.Checked && checkBoxUsuk.Checked)
            {
                foundRows = history.Select("type = 'usuk'");
            }
            else if (!checkBoxKpop.Checked && checkBoxVpop.Checked && checkBoxUsuk.Checked)
            {
                foundRows = history.Select("type = 'vpop' or type = 'usuk'");
            }
            else if (checkBoxKpop.Checked && !checkBoxVpop.Checked && checkBoxUsuk.Checked)
            {
                foundRows = history.Select("type = 'kpop' or type = 'usuk'");
            }
            else
            {
                foundRows = history.Select();
            }
            addHistory(foundRows);
        }
        private void addHistory(DataRow[] foundRows)
        {
            foreach (DataRow row in foundRows)
            {

                Custom.UserControl2 it = new Custom.UserControl2(row);
                flowLayoutPanel1.Controls.Add(it);
            }
        }
        private void addPlaylistSong()
        {
            flowLayoutPanel1.Controls.Clear();
            DataRow[] foundRows = playlist.Select();
            foreach (DataRow row in foundRows)
            {

                Custom.UserControl3 it = new Custom.UserControl3(row);
                flowLayoutPanel1.Controls.Add(it);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ShowItem(data);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            ShowItem(data);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            ShowItem(data);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            DataRow[] dr = data.Select("name like '%" + richTextBoxSearch.Text + "%' or singer like '%" + richTextBoxSearch.Text + "%'");
            add(dr);
        }
        private void loadData(ref DataTable table, string link)
        {
            table = new DataTable();
            using (StreamReader sr = new StreamReader(link))
            {
                string[] headers = sr.ReadLine().Split('*');
                foreach (string header in headers)
                {
                    table.Columns.Add(header);
                }
                table.Columns[0].DataType = typeof(string);
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split('*');
                    DataRow dr = table.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    table.Rows.Add(dr);
                }
            }
        }

        private void labelHistory_Click(object sender, EventArgs e)
        {
            labelHistory.ForeColor = Color.Red;
            labelHome.ForeColor = Color.White;
            labelPlaylist.ForeColor = Color.White;
            temp.Text = "abc";
            temp2.Text = "abc";
            labelLove.ForeColor = Color.White;
            ShowItemHistory();
            groupBox1.Visible = true;

        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            labelHome.ForeColor = Color.Red;
            labelHistory.ForeColor = Color.White;
            labelPlaylist.ForeColor = Color.White;
            
            labelLove.ForeColor = Color.White;
            temp.Text = "abc";
            temp2.Text = "abc";
            groupBox1.Visible = true;

            ShowItem(data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBoxInformation.Visible = true;
            flowLayoutPanelLyric.Visible = false;
            flowLayoutPanelComment.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxInformation.Visible = false;
            flowLayoutPanelLyric.Visible = true;
            flowLayoutPanelComment.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBoxInformation.Visible = false;
            flowLayoutPanelLyric.Visible = false;
            flowLayoutPanelComment.Visible = true;
            

        }

        private void flowLayoutPanelComment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveData(history,"resource//history.txt");
            saveData(data, "resource//data.txt");
        }
        public static void saveData(DataTable tb, string link)
        {
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = tb.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join("*", columnNames));

            foreach (DataRow row in tb.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join("*", fields));
            }
            System.IO.File.WriteAllText(link, sb.ToString(), System.Text.Encoding.UTF8);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
            labelPlaylist.ForeColor = Color.Red;
            labelHistory.ForeColor = Color.White;
            labelHome.ForeColor = Color.White;
            labelLove.ForeColor = Color.White;
            temp.Text = "abc";
            temp2.Text = "abc";
            ShowPlaylist();
            groupBox1.Visible = false;


        }
        private void ShowPlaylist()
        {
            flowLayoutPanel1.Controls.Clear();
            DirectoryInfo d = new DirectoryInfo("resource//playlist");
            FileInfo[] Files = d.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                //CheckBox cb = new CheckBox();
                string s = file.Name.Split('.')[0];
                Custom.playlist it = new Custom.playlist(s);
                flowLayoutPanel1.Controls.Add(it);

            }
        }
        private void labelLove_Click(object sender, EventArgs e)
        {
            labelPlaylist.ForeColor = Color.White;
            labelHistory.ForeColor = Color.White;
            labelHome.ForeColor = Color.White;
            labelLove.ForeColor = Color.Red;
            temp.Text = "abc";
            temp2.Text = "abc";
            groupBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && richTextBoxCmt.Text != "")
            {
                string filePath = "resource//cmt//" + Form1.id["id"].ToString() + ".txt";
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();
                lines.Add(textBoxName.Text + "*" + numericUpDownStar.Value.ToString() + "*" + richTextBoxCmt.Text);
                File.WriteAllLines(filePath, lines);
                LoadCmt();
                textBoxName.Text = "";
                richTextBoxCmt.Text = "";
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            
        }
    }
}
