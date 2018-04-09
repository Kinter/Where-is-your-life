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
        HtmlDocument mydoc = new HtmlDocument();

        /// <summary>
        /// 생성자임ㅋ
        /// </summary>
        /// <param name="username">You can find user name twitter.com/"here"</param>
        Parse(string username)
        {
            _username = username;
        }

        public bool parseData()
        {

            return true;
        }
    }
}
