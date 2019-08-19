using HRSystem.Models;
using Newtonsoft.Json;
using System.IO;

namespace HRSystem.Helper
{
    public class ConfigJSON
    {
        private static string _path = "config.json";

        public static Config Read()
        {
            using (StreamReader r = new StreamReader(_path))
            {
                string json = r.ReadToEnd();
                Config config = JsonConvert.DeserializeObject<Config>(json);
                return config;
            }
        }

        public static void Write(Config model)
        {
            string json = JsonConvert.SerializeObject(model, Formatting.Indented);
            File.WriteAllText(_path, json);
        }

        public static string GetURL(Config model, string actionName)
        {
            string url = model.Integration_Setup.Base_URL + '/'
                + model.Integration_Setup.Service_Instance + '/'
                + model.Integration_Setup.Integration_Name + '/'
                + model.Default_Config.Company_Name + '/'
                + model.Default_Config.Type + '/'
                + actionName;

            return url;
        }
    }
}
