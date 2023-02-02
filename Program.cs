using System;
using PortTextReader.Models;
using System.Windows.Forms;

namespace PortTextReader
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 0 || args[0].Length == 0 || args[1].Length == 0)
                {
                    //debug
                    BaseModel.SettingDir = @"C:\Users\pikas\OneDrive\デスクトップ";
                    BaseModel.PiniFilePath = @"C:\Users\pikas\OneDrive\デスクトップ\portText.pini";
                    //throw new ArgumentException("illegle arguments");
                }
                else
                {
                    BaseModel.SettingDir = args[0];
                    BaseModel.PiniFilePath = args[1];
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
            catch (Exception ex)
            {
                Utilis.ExceptionManager.ShowExceptionDetail(ex);
            }
        }
    }
}
