using System;
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
            timer1 = new Timer();
            timer1.Interval = 600;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            _j = new JsonParse();
            label2.Text= "인생이 트위터인 아주 위험한 상황입니다.\n 이곳을 눌러 빨리 구원받으세요.";
            _j.GetData("adnim_");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _p = new HtmlParse(textBoxInput.Text);
            _p.ParseData();

            textTweets.Text = _p.Tweets;
            textFollowers.Text = _p.Followers;
            textFollowings.Text = _p.Followings;

            if (_p.Tweets == null || _p.Followers == null || _p.Followings == null)
            {
                MessageBox.Show("아이디가 제대로 입력되었는지 확인하여 주십시오.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_j.AddData(_p.Username,
                int.Parse(_p.Tweets, System.Globalization.NumberStyles.AllowThousands),
                int.Parse(_p.Followers, System.Globalization.NumberStyles.AllowThousands),
                int.Parse(_p.Followings, System.Globalization.NumberStyles.AllowThousands))
            )
            {
                MessageBox.Show("데이터 추가 실패", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("데이터 추가 성공", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Tap2Load(textBoxInput.Text);
            }
        }

        

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(null, null);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kr.battle.net/heroes/ko");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
            timer1.Stop();
            timer1.Start();
        }
        
    }
}
