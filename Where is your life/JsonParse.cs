using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows.Forms;

namespace Where_is_your_life
{
    class JsonParse
    {
        JObject jObject;
        string _data;

        public string Data { get => _data; private set => _data = value; }


        public JsonParse()
        {
            if(LoadData())
            {

            }
        }


        private bool LoadData()
        {
            if (File.Exists(System.Windows.Forms.Application.StartupPath + "ParseData.json"))
            {
                Data = File.ReadAllText(System.Windows.Forms.Application.StartupPath + @"\ParseData.json");

            }
            else
            {
                File.WriteAllText(System.Windows.Forms.Application.StartupPath + @"\ParseData.json", "0");
                return true;
            }
            return true;
        }
    }
}
