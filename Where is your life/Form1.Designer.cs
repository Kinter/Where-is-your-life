﻿namespace Where_is_your_life
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lTweets = new System.Windows.Forms.Label();
            this.lFollowings = new System.Windows.Forms.Label();
            this.lFollowers = new System.Windows.Forms.Label();
            this.textTweets = new System.Windows.Forms.Label();
            this.textFollowers = new System.Windows.Forms.Label();
            this.textFollowings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 31);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(100, 21);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 29);
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
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Write your username";
            // 
            // lTweets
            // 
            this.lTweets.AutoSize = true;
            this.lTweets.Location = new System.Drawing.Point(30, 65);
            this.lTweets.Name = "lTweets";
            this.lTweets.Size = new System.Drawing.Size(50, 12);
            this.lTweets.TabIndex = 3;
            this.lTweets.Text = "lTweets";
            // 
            // lFollowings
            // 
            this.lFollowings.AutoSize = true;
            this.lFollowings.Location = new System.Drawing.Point(30, 95);
            this.lFollowings.Name = "lFollowings";
            this.lFollowings.Size = new System.Drawing.Size(66, 12);
            this.lFollowings.TabIndex = 4;
            this.lFollowings.Text = "Followings";
            // 
            // lFollowers
            // 
            this.lFollowers.AutoSize = true;
            this.lFollowers.Location = new System.Drawing.Point(30, 125);
            this.lFollowers.Name = "lFollowers";
            this.lFollowers.Size = new System.Drawing.Size(60, 12);
            this.lFollowers.TabIndex = 5;
            this.lFollowers.Text = "Followers";
            // 
            // textTweets
            // 
            this.textTweets.AutoSize = true;
            this.textTweets.Location = new System.Drawing.Point(116, 65);
            this.textTweets.Name = "textTweets";
            this.textTweets.Size = new System.Drawing.Size(11, 12);
            this.textTweets.TabIndex = 6;
            this.textTweets.Text = "0";
            // 
            // textFollowers
            // 
            this.textFollowers.AutoSize = true;
            this.textFollowers.Location = new System.Drawing.Point(116, 125);
            this.textFollowers.Name = "textFollowers";
            this.textFollowers.Size = new System.Drawing.Size(11, 12);
            this.textFollowers.TabIndex = 7;
            this.textFollowers.Text = "0";
            // 
            // textFollowings
            // 
            this.textFollowings.AutoSize = true;
            this.textFollowings.Location = new System.Drawing.Point(116, 95);
            this.textFollowings.Name = "textFollowings";
            this.textFollowings.Size = new System.Drawing.Size(11, 12);
            this.textFollowings.TabIndex = 8;
            this.textFollowings.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 305);
            this.Controls.Add(this.textFollowings);
            this.Controls.Add(this.textFollowers);
            this.Controls.Add(this.textTweets);
            this.Controls.Add(this.lFollowers);
            this.Controls.Add(this.lFollowings);
            this.Controls.Add(this.lTweets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

