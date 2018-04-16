using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows.Forms;
using Newtonsoft;
using Newtonsoft.Json;

namespace Where_is_your_life
{
    class JsonParse
    {
        private JObject jsonData;

        public string Data { get; private set; }
        public bool IsLoaded { get; private set; }

        public JsonParse()
        {
            jsonData = new JObject();
            IsLoaded = LoadData();
        }

        private static object LoadData(out bool error)
        {
            error = false;
            try
            {
                if (File.Exists(Application.StartupPath + @"\ParseData.json"))
                {
                    // 파일이 존재하면 불러옴

                    return JObject.Parse(File.ReadAllText(Application.StartupPath + @"\ParseData.json"));
                }
                else
                {
                    // 파일이 존재 안하면 자동 생성
                    File.WriteAllText(Application.StartupPath + @"\ParseData.json", "");
                    return "";
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                error = true;
                return "";
            }
        }

        public void AddData(string username, int tweets, int followers, int followings)
        {
            JArray jArray = new JArray();
            foreach (var fName in jsonData)
            {
                if (fName.Key.ToString() == username)
                {
                    jArray = JArray.Parse(fName.Value.ToString());
                }
            }

        
            jArray.Add(new JObject(
                new JProperty(System.DateTime.Now.ToString("yyMMddhhmm"), new JObject(
                    new JProperty("tweets", tweets),
                    new JProperty("followers", followers),
                    new JProperty("followings", followings)))));

            jsonData[username] = jArray;
            System.Console.WriteLine(jArray);

            File.WriteAllText(Application.StartupPath + @"\ParseData.json", jsonData.ToString());
        }

        private bool LoadData()
        {
            var data = LoadData(out var error);
            if (!error)
                if (data.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                    jsonData = (JObject)data;

            return !error;
        }
    }
}
