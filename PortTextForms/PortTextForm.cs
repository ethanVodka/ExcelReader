using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using PortTextReader.Models;

namespace PortTextReader.PortTextForms
{
    public partial class PortTextForm : Form
    {
        public PortTextForm()
        {
            InitializeComponent();
        }

        private void PortTextForm_Load(object sender, EventArgs e)
        {
            try
            {
                //sheet名取得
            }
            catch (Exception ex)
            {
                Utilis.ExceptionManager.ShowExceptionDetail(ex);
            }
        }

        private void ReadExcelToData(string sheetname)
        {
            //ファイルの読み取り開始
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            using (FileStream stream = File.Open(BaseModel.PortTextFilePath, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader;

                //ファイルの拡張子を確認
                if (BaseModel.PortTextFilePath.EndsWith(".xls") || BaseModel.PortTextFilePath.EndsWith(".xlsx") || BaseModel.PortTextFilePath.EndsWith(".xlsb"))
                {
                    reader = ExcelReaderFactory.CreateReader(stream, new ExcelReaderConfiguration()
                    {
                        //デフォルトのエンコードは西ヨーロッパ言語の為、日本語が文字化けする
                        //オプション設定でエンコードをシフトJISに変更する
                        FallbackEncoding = Encoding.GetEncoding("Shift_JIS")
                    });
                }
                else if (BaseModel.PortTextFilePath.EndsWith(".csv"))
                {
                    reader = ExcelReaderFactory.CreateCsvReader(stream, new ExcelReaderConfiguration()
                    {
                        //デフォルトのエンコードは西ヨーロッパ言語の為、日本語が文字化けする
                        //オプション設定でエンコードをシフトJISに変更する
                        FallbackEncoding = Encoding.GetEncoding("Shift_JIS")
                    });
                }
                else
                {
                    MessageBox.Show("サポート対象外の拡張子です。");
                    return;
                }

                //全シート全セルを読み取り
                DataSet dataset = reader.AsDataSet();

                //シート名を指定
                var worksheet = dataset.Tables[sheetname];

                if (worksheet is null)
                {
                    MessageBox.Show("指定されたワークシート名が存在しません。");
                }
                else
                {
                    //セルの入力文字を読み取り
                    for (var row = 0; row < worksheet.Rows.Count; row++)
                    {
                        for (var col = 0; col < worksheet.Columns.Count; col++)
                        {
                            Debug.WriteLine(worksheet.Rows[row][col]);
                        }
                    }
                }

                reader.Close();
            }
        }

        private void SheetCombox_TextChanged(object sender, EventArgs e)
        {
            string sheetName =SheetCombox.Text;

            ReadExcelToData(sheetName);
        }
    }
}
