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
            IsLoaded = FirstLoadData();
        }

        private bool FirstLoadData()
        {
            var data = FirstLoadData(out var error);
            if (!error)
                if (data.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                    jsonData = (JObject)data;

            return !error;
        }

        private static object FirstLoadData(out bool error)
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

        /// <summary>
        /// Json 파일에 사용자 데이터를 저장합니다.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="tweets"></param>
        /// <param name="followers"></param>
        /// <param name="followings"></param>
        /// <returns>저장에 실패할시 false를 반환 합니다.</returns>
        public bool AddData(string username, int tweets, int followers, int followings)
        {
            JArray jArray = new JArray();
            foreach (var fName in jsonData)
            {
                if (fName.Key.ToString() == username)
                {
                    jArray = JArray.Parse(fName.Value.ToString());
                }
            }

            while (!CheckData(jArray))
            {
                var result = MessageBox.Show("Please wait a moment before trying.", "Error",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Asterisk);
                if (result == DialogResult.Cancel) return false;
            }

            jArray.Add(new JObject(
          new JProperty(System.DateTime.Now.ToString("yyMMddhhmm"), new JObject(
              new JProperty("tweets", tweets),
              new JProperty("followers", followers),
              new JProperty("followings", followings)))));

            jsonData[username] = jArray;

            File.WriteAllText(Application.StartupPath + @"\ParseData.json", jsonData.ToString());

            return true;
        }

        /// <summary>
        /// 현재 파일에 추가하려는 데이터의 유효성을 검사하는 코드입니다.
        /// </summary>
        /// <param name="jArray"></param>
        /// <returns> 현재 추가하려는 데이터가 유효하면 true를 반환합니다. </returns>
        private bool CheckData(JArray jArray)
        {
            // 중복 검사
            foreach (var fTime in jArray)
            {
                System.Console.WriteLine(fTime.ToString());
                System.Console.WriteLine(JObject.Parse(fTime.ToString()).ToString());
                if (JObject.Parse(fTime.ToString()).ContainsKey(System.DateTime.Now.ToString("yyMMddhhmm")))
                    return false;
            }
            return true;
        }
        
    }
}
