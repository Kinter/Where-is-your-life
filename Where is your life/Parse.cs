using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Where_is_your_life
{
    class Parse
    {
        private string _username;
        private string _url;
        HtmlDocument mydoc = new HtmlDocument();
        
        private int _tweets;
        private int _follows;
        private int _followers;

        /// <summary>
        /// 생성자임ㅋ
        /// </summary>
        /// <param name="username">You can find user name twitter.com/"here"</param>
        public Parse(string username)
        {
            _username = username;

            _url = @"https://twitter.com/" + _username+ @"?lang=en-gb";
        }

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
            var index = html.IndexOf("statnum");

            //Console.WriteLine(html.Substring(index+9, 15));
            return true;
        }
    }
}
