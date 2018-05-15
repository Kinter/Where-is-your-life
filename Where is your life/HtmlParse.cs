using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace Where_is_your_life
{
    class HtmlParse
    {
        private string _url;
        HtmlDocument mydoc = new HtmlDocument();
        
        /// <summary>
        /// 생성자임ㅋ
        /// </summary>
        /// <param name="username">You can find user name twitter.com/"here"</param>
        public HtmlParse(string username)
        {
            Username = username;
            
            _url = $"https://twitter.com/{username}?lang=en-gb";
        }

        public string Username { get; private set; }
        public string Tweets { get; private set; }
        public string Followings { get; private set; }
        public string Followers { get; private set; }


        /// <summary>
        /// Parse twitter data
        /// </summary>
        /// <returns>Success = true, Fail = false</returns>
        public bool ParseData()
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
            foreach (Match mm in resultColl)
            {
                // 잡것들 포함된 mm에서 숫자만 다시 뺌
                Match resultCollNum = regnum.Match(mm.ToString());

                switch (i)
                {
                    case 0:
                        Tweets = resultCollNum.ToString();
                        break;
                    case 1:
                        Followings = resultCollNum.ToString();
                        break;
                    case 2:
                        Followers = resultCollNum.ToString();
                        break;
                    default:
                        break;
                }
                i++;
            }
            return true;
        }
    }
}
