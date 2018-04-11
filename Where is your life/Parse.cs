using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace Where_is_your_life
{
    class Parse
    {
        private string _username;
        private string _url;
        HtmlDocument mydoc = new HtmlDocument();
        
        private string _tweets;
        private string _followings;
        private string _followers;

        /// <summary>
        /// 생성자임ㅋ
        /// </summary>
        /// <param name="username">You can find user name twitter.com/"here"</param>
        public Parse(string username)
        {
            _username = username;

            _url = @"https://twitter.com/" + _username+ @"?lang=en-gb";
        }

        public string Tweets { get => _tweets; set => _tweets = value; }
        public string Followings { get => _followings; set => _followings = value; }
        public string Followers { get => _followers; set => _followers = value; }


        /// <summary>
        /// Parse twitter data
        /// </summary>
        /// <returns>Success = true, Fail = false</returns>
        public bool parseData()
        {
            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(_url);
            
            string html = new string('0', 1200);
            html = htmlDoc.ParsedText.ToString();
            // 정보들 숫자 가져옴.
            Regex reg = new Regex("m\">[0-9,]*<");
            MatchCollection resultColl = reg.Matches(html);

            // 숫자만 따로 뺌.
            Regex regnum = new Regex("[0-9,]+");
            foreach(Match mm in resultColl)
            {
                int i = 0;
                MatchCollection resultCollNum = regnum.Matches(mm.ToString());
                foreach (Match mmm in resultCollNum)
                {
                    switch (i)
                    {
                        case 0:
                            _tweets = mmm.ToString();
                            break;
                        case 1:
                            _followings = mmm.ToString();
                            break;
                        case 2:
                            _followers = mmm.ToString();
                            break;
                    }
                    i++;
                }
            }
            return true;
        }
    }
}
