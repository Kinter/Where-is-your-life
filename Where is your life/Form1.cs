using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Where_is_your_life
{
    public partial class Form1 : Form
    {
        HtmlParse _p;
        JsonParse _j;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("데이터를 불러옵니다.");
            _j = new JsonParse();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _p = new HtmlParse(textBoxInput.Text);
            _p.parseData();

            textTweets.Text = _p.Tweets;
            textFollowers.Text = _p.Followers;
            textFollowings.Text = _p.Followings;

            _j.AddData(_p.Username, Convert.ToInt32(_p.Tweets), Convert.ToInt32(_p.Followers), Convert.ToInt32(_p.Followings));
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(null, null);
        }
        
    }
}
