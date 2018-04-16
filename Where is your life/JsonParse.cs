using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows.Forms;

namespace Where_is_your_life
{
    class JsonParse
    {
        private JObject jsonData;

        public string Data { get; private set; }
        public bool IsLoaded { get; private set; }

        public JsonParse()
        {
            IsLoaded = LoadData();
        }

        private static string LoadData(out bool error)
        {
            error = false;
            try
            {
                if (File.Exists(Application.StartupPath + "ParseData.json"))
                {
                    // 파일이 존재하면 불러옴
                    return File.ReadAllText(Application.StartupPath + @"\ParseData.json");
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
            JObject tempObject = new JObject();
            tempObject.Add("user", username);

            JObject addObject = new JObject();
            
            addObject.Add("tweets", tweets);
            addObject.Add("followers", followers);
            addObject.Add("followings", followings);

            tempObject.Add(addObject);
            jsonData.Add(System.DateTime.Now.ToString("yyyyMMddHHmm"));
        }

        private bool LoadData()
        {
            var data = LoadData(out var error);
            if (!error)
                Data = data;
            return !error;
        }
    }
}
