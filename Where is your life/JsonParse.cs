using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Where_is_your_life
{
    class JsonParse
    {
        JObject jObject;
        public JsonParse()
        {
            if (File.Exists(System.Windows.Forms.Application.StartupPath + "ParseData.json"))
            {

            }
            else
            {
                jObject = new JObject();
            }
        }
        static public bool LoadData()
        {
            return true;
        }
    }
}
