using Newtonsoft.Json.Linq;
using System.IO;
using System.Windows.Forms;

namespace Where_is_your_life
{
    class JsonParse
    {
        JObject jObject;

        public string Data { get; private set; }
        public bool isLoaded { get; private set; }

        public JsonParse()
        {
            isLoaded = LoadData();
        }

        private static string LoadData(out bool error)
        {
            error = false;
            try
            {
                if (File.Exists(Application.StartupPath + "ParseData.json"))
                {
                    return File.ReadAllText(Application.StartupPath + @"\ParseData.json");

                }
                else
                {
                    File.WriteAllText(Application.StartupPath + @"\ParseData.json", "0");
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


        private bool LoadData()
        {
            var data = LoadData(out var error);
            if (!error)
                Data = data;
            return !error;
        }
    }
}
