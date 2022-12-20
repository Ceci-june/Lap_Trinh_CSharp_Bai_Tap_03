using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            ShowItem();
            //ShowItem();
        }
        private void ShowItem()
        {
            flowLayoutPanel1.Controls.Clear();
            DataRow[] foundRows;
            if (checkBoxKpop.Checked && !checkBoxVpop.Checked && !checkBoxUsuk.Checked)
            {
                foundRows = Form1.data.Select("type = 'kpop'");
            }
            else if (checkBoxKpop.Checked && checkBoxVpop.Checked && !checkBoxUsuk.Checked)
            {
                foundRows = Form1.data.Select("type = 'kpop' or type = 'vpop'");
            }
            else if (!checkBoxKpop.Checked && checkBoxVpop.Checked && !checkBoxUsuk.Checked)
            {
                foundRows = Form1.data.Select("type = 'vpop'");
            }
            else if (!checkBoxKpop.Checked && !checkBoxVpop.Checked && checkBoxUsuk.Checked)
            {
                foundRows = Form1.data.Select("type = 'usuk'");
            }
            else if (!checkBoxKpop.Checked && checkBoxVpop.Checked && checkBoxUsuk.Checked)
            {
                foundRows = Form1.data.Select("type = 'vpop' or type = 'usuk'");
            }
            else if (checkBoxKpop.Checked && !checkBoxVpop.Checked && checkBoxUsuk.Checked)
            {
                foundRows = Form1.data.Select("type = 'kpop' or type = 'usuk'");
            }
            else
            {
                foundRows = Form1.data.Select();
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
    }
}
