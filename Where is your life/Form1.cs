using System;
using System.Windows.Forms;

namespace Where_is_your_life
{
    public partial class Form1 : Form
    {
        HtmlParse _p;
        JsonParse _j;

        // 현재 입력되어 수집중인 유저의 데이터
        (int date, int tweets, int followers, int followings)[] _nowUserdata;
        string username;

        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new Timer();
            timer1.Interval = 600;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();


            _j = new JsonParse();
            label2.Text = "인생이 트위터인 아주 위험한 상황입니다.\n 이곳을 눌러 빨리 구원받으세요.";
        }

        void button1_Click(object sender, EventArgs e)
        {

            username = textBoxInput.Text.ToLower();

            _p = new HtmlParse(username);
            _p.ParseData();

            textTweets.Text = _p.Tweets;
            textFollowers.Text = _p.Followers;
            textFollowings.Text = _p.Followings;

            if (_p.Tweets == null || _p.Followers == null || _p.Followings == null)
            {
                MessageBox.Show("아이디가 제대로 입력되었는지 확인하여 주십시오.", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_j.AddData(username,
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
                ListLoad(username);
            }
        }

        void ListLoad(string username)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            _nowUserdata = _j.GetData(username);
            foreach (var a in _nowUserdata)
            {
                listBox1.Items.Add(FormattingDate(a.Item1.ToString()));
                listBox2.Items.Add(FormattingDate(a.Item1.ToString()));
            }
        }

        

        void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(null, null);
        }

        void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://kr.battle.net/heroes/ko");
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = !label2.Visible;
            timer1.Stop();
            timer1.Start();
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelonListBox1.Text = listBox1.SelectedItem.ToString();
            ShowTap2Label();
        }

        void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelonListBox2.Text = listBox2.SelectedItem.ToString();
            ShowTap2Label();
        }

        bool IsAllListBoxSelected()
        {
            if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1)
            {
                return false;
            }
            else return true;
        }

        void ShowTap2Label()
        {
            // 두 리스트 박스 모두 선택 되어 있어야 합니다.
            if (!IsAllListBoxSelected())
            {
                return;
            }

            labelCTweets.Text =
                (_j.GetData(username, _nowUserdata[listBox2.SelectedIndex].date).Item1 -
                 _j.GetData(username, _nowUserdata[listBox1.SelectedIndex].date).Item1).ToString();
            labelCFers.Text =
                (_j.GetData(username, _nowUserdata[listBox2.SelectedIndex].date).Item2 -
                 _j.GetData(username, _nowUserdata[listBox1.SelectedIndex].date).Item2).ToString();
            labelCFings.Text =
                (_j.GetData(username, _nowUserdata[listBox2.SelectedIndex].date).Item3 -
                 _j.GetData(username, _nowUserdata[listBox1.SelectedIndex].date).Item3).ToString();
        }

        /// <summary>
        /// yyMMddhhss -> yy년 MM월 dd일 hh시 ss분으로 변환합니다.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        string FormattingDate(string date)
        {
            date = date.Insert(2, "년 ");
            date = date.Insert(6, "월 ");
            date = date.Insert(10, "일 ");
            date = date.Insert(14, "시 ");
            date = date.Insert(18, "분 ");
            return date;
        }
    }
}
