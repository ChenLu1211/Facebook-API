using System.Xml.Serialization;
using System.IO;

namespace C20_EX01_Shiraz_206093189_Chen_312608417
{
    public class AppSettings
    {
        private static string m_FileLocation = @"D:\UserData.xml";

        public bool RememberUser
        {
            get;
            set;
        }

        public string LastAccessToken
        {
            get;
            set;
        }

        public AppSettings()
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings userSetting = new AppSettings();

            if (File.Exists(m_FileLocation))
            {
                using (Stream stream = new FileStream(m_FileLocation, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    userSetting = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return userSetting;
        }

        public void SaveToFile()
        {
            if (!File.Exists(m_FileLocation))
            {
                Stream stream = new FileStream(m_FileLocation, FileMode.Create);
                stream.Dispose();
            }

            using (Stream stream = new FileStream(m_FileLocation, FileMode.Truncate))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
