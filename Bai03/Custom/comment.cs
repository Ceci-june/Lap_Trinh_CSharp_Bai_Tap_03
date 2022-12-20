using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03.Custom
{
    public partial class comment : UserControl
    {
        public comment(DataRow dr)
        {
            InitializeComponent();
            labelName.Text = dr["name"].ToString();
            labelStar.Text= string.Concat(Enumerable.Repeat(Form1.star, Convert.ToInt32(dr["star"])));
            labelComment.Text = dr["cmt"].ToString();
        }
    }
}
