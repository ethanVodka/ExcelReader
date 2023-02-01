using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PortTextReader
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Models.BaseModel.PiniFilePath == string.Empty)
                {
                    return;
                }
                else
                {
                    ReadPiniFile();
                    SetPiniDataToDgv();
                }
            }
            catch (Exception ex)
            {
                Utilis.ExceptionManager.ShowExceptionDetail(ex);
                return;
            }
        }

        //PiniDataをデータグリッドビューへ表示
        private void SetPiniDataToDgv()
        {

        }

        //piniファイル読み込み
        private void ReadPiniFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(Models.BaseModel.PiniFilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] splitLine = line.Split(',');

                        using (Models.PiniClass piniClass = new Models.PiniClass())
                        {
                            for (int i = 0; i < splitLine.Length; i++)
                            {
                                piniClass.PinNumber = int.Parse(splitLine[0]);
                                piniClass.NetColor = ColorTranslator.FromHtml(splitLine[1]);
                                piniClass.NetName = splitLine[2];
                                piniClass.MergedNetName = splitLine[3];
                                piniClass.InOutType = splitLine[4];
                                piniClass.SignalType = splitLine[5];
                            }

                            Models.BaseModel.PiniData.Add(piniClass);
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                Utilis.ExceptionManager.ShowExceptionDetail(ex);
            }
        }

        //ポートテキスト読み込み
        //エクセルファイル読み込み、piniDataへ格納
        //その後Mainデータグリッドビューへ出力
        private void ReadPortTextButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "ポートテキストファイル|*.xlx;*.xlxm;*.xlsx|すべてのファイル(*.*)|*.*";
                    openFileDialog.Title = "ポートテキストを開く";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //ファイル名読み込んでPortTextFormを開く
                        Models.BaseModel.PortTextFilePath = openFileDialog.FileName;

                        PortTextForms.PortTextForm portTextForm = new PortTextForms.PortTextForm();
                        portTextForm.ShowDialog();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Utilis.ExceptionManager.ShowExceptionDetail (ex);
            }
        }

        private void ReadPiniButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "piniファイル|*.pini";
                    openFileDialog.Title = "piniファイルを開く";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        //読み込んでデータグリッドビューに表示
                        ReadPiniFile();
                        SetPiniDataToDgv();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Utilis.ExceptionManager.ShowExceptionDetail(ex);
            }
        }
    }
}
