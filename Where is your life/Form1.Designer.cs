namespace Where_is_your_life
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lTweets = new System.Windows.Forms.Label();
            this.lFollowings = new System.Windows.Forms.Label();
            this.lFollowers = new System.Windows.Forms.Label();
            this.textTweets = new System.Windows.Forms.Label();
            this.textFollowers = new System.Windows.Forms.Label();
            this.textFollowings = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(112, 4);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 21);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write username : ";
            // 
            // lTweets
            // 
            this.lTweets.AutoSize = true;
            this.lTweets.Location = new System.Drawing.Point(19, 20);
            this.lTweets.Name = "lTweets";
            this.lTweets.Size = new System.Drawing.Size(47, 12);
            this.lTweets.TabIndex = 3;
            this.lTweets.Text = "Tweets";
            // 
            // lFollowings
            // 
            this.lFollowings.AutoSize = true;
            this.lFollowings.Location = new System.Drawing.Point(19, 50);
            this.lFollowings.Name = "lFollowings";
            this.lFollowings.Size = new System.Drawing.Size(66, 12);
            this.lFollowings.TabIndex = 4;
            this.lFollowings.Text = "Followings";
            // 
            // lFollowers
            // 
            this.lFollowers.AutoSize = true;
            this.lFollowers.Location = new System.Drawing.Point(19, 80);
            this.lFollowers.Name = "lFollowers";
            this.lFollowers.Size = new System.Drawing.Size(60, 12);
            this.lFollowers.TabIndex = 5;
            this.lFollowers.Text = "Followers";
            // 
            // textTweets
            // 
            this.textTweets.AutoSize = true;
            this.textTweets.Location = new System.Drawing.Point(103, 20);
            this.textTweets.Name = "textTweets";
            this.textTweets.Size = new System.Drawing.Size(11, 12);
            this.textTweets.TabIndex = 6;
            this.textTweets.Text = "0";
            // 
            // textFollowers
            // 
            this.textFollowers.AutoSize = true;
            this.textFollowers.Location = new System.Drawing.Point(103, 80);
            this.textFollowers.Name = "textFollowers";
            this.textFollowers.Size = new System.Drawing.Size(11, 12);
            this.textFollowers.TabIndex = 7;
            this.textFollowers.Text = "0";
            // 
            // textFollowings
            // 
            this.textFollowings.AutoSize = true;
            this.textFollowings.Location = new System.Drawing.Point(103, 50);
            this.textFollowings.Name = "textFollowings";
            this.textFollowings.Size = new System.Drawing.Size(11, 12);
            this.textFollowings.TabIndex = 8;
            this.textFollowings.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 238);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lTweets);
            this.tabPage1.Controls.Add(this.lFollowings);
            this.tabPage1.Controls.Add(this.lFollowers);
            this.tabPage1.Controls.Add(this.textFollowers);
            this.tabPage1.Controls.Add(this.textTweets);
            this.tabPage1.Controls.Add(this.textFollowings);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(303, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "현재 상태";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "인생이 트위터인 아주 위험한 상황입니다. 이곳을 눌러 빨리 구원받으세요.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "과거 열람";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(548, 164);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "원래날짜";
            this.columnHeader1.Width = 192;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "트윗수";
            this.columnHeader2.Width = 57;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "다음날짜";
            this.columnHeader3.Width = 226;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "트윗수";
            this.columnHeader4.Width = 56;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 327);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Where is your life?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lTweets;
        private System.Windows.Forms.Label lFollowings;
        private System.Windows.Forms.Label lFollowers;
        private System.Windows.Forms.Label textTweets;
        private System.Windows.Forms.Label textFollowers;
        private System.Windows.Forms.Label textFollowings;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

