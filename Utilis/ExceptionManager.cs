using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PortTextReader.Utilis
{
    public class ExceptionManager
    {
        public static void ShowExceptionDetail(Exception e)
        {
            StackTrace trace = new StackTrace(e, true);
            StackFrame frame = trace.GetFrame(trace.FrameCount - 1);

            //エラー行取得
            int errorLine = frame.GetFileLineNumber();
            //エラーメソッド取得
            string errorMethod = frame.GetMethod().Name;
            //エラーファイル取得
            string errorFile = frame.GetFileName();

            string errorMessage =
                e.Message + "\n\n" +
                "{@ line } : " + errorLine.ToString() + "\n" +
                "{@ method } : " + errorMethod + "\n" +
                "{@ file } : " + errorFile; 

            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
