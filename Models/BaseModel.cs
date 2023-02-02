using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace PortTextReader.Models
{
    public static class BaseModel
    {
        //Settingフォルダーパス
        private static string settingDir = string.Empty;
        public static string SettingDir
        {
            get
            {
                return settingDir;
            }
            set
            {
                settingDir = value;
            }
        }

        //.piniファイルパス
        private static string piniFilePath = string.Empty;
        public static string PiniFilePath
        {
            get
            {
                return piniFilePath;
            }
            set
            {
                piniFilePath = value;
            }
        }

        //portTextファイルパス
        private static string portTextFilepath;
        public static string PortTextFilePath
        {
            get
            {
                return portTextFilepath;
            }
            set
            {
                portTextFilepath = value;
            }
        }


        //pini読み込みデータ格納
        private static List<PiniClass> piniData = new List<PiniClass>();
        public static List<PiniClass> PiniData
        {
            get
            {
                return piniData;
            }
            set
            {
                piniData = value;
            }
        }

        //portText読み込みデータ格納
        private static List<PortTextClass> portTextData = new List<PortTextClass>();
        public static List<PortTextClass> PortTextData
        {
            get
            {
                return portTextData;
            }
            set
            {
                portTextData = value;
            }
        }

    }
}
