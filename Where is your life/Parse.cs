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
        
        /// <summary>
        /// 생성자임ㅋ
        /// </summary>
        /// <param name="username">You can find user name twitter.com/"here"</param>
        public Parse(string username)
        {
            _username = username;
            
            _url = $"https://twitter.com/{username}?lang=en-gb";
        }

        public string Tweets { get; private set; }
        public string Followings { get; private set; }
        public string Followers { get; private set; }


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

            // 숫자만 따로 뺄 정규식.
            Regex regnum = new Regex("[0-9,]+");

            int i = 0;

            // 잡것들 포함된거 빼온다.
            foreach(Match mm in resultColl)
            {
                // 잡것들 포함된 mm에서 숫자만 다시 뺌
                MatchCollection resultCollNum = regnum.Matches(mm.ToString());

                // 원소가 하나가 나올텐데 foreach 말고 뺄수 있는 방법이 있는지 모르겠음...
                foreach (Match mmm in resultCollNum)
                {
                    // 이 부분이 제일 문제임 뭔가 개선 가능할 거 같은데...
                    switch (i)
                    {
                        case 0:
                            Tweets = mmm.ToString();
                            break;
                        case 1:
                            Followings = mmm.ToString();
                            break;
                        case 2:
                            Followers = mmm.ToString();
                            break;
                        default:
                            break;
                    }
                    i++;
                }
            }
            return true;
        }
    }
}
