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
        Parse(string username)
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

            return true;
        }
    }
}
