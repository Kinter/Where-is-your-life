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
        private string _follows;
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
        public string Follows { get => _follows; set => _follows = value; }
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
            Regex reg = new Regex("start[0-9]*div");
            MatchCollection resultColl = reg.Matches(html);

            //_tweets = html.Substring(index + 9, 6);
            //_tweets = Int32.Parse(html.Substring(index + 9, 3));
            return true;
        }
    }
}
