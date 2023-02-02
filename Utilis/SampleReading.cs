using PortTextReader.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortTextReader.Utilis
{
    public class SampleReading
    {
        void ReadPortText()
        {
            try
            {
                //データ設定する
                int starRow = 10;
                int endRow = 100;

                //Dgvとする
                string[,] DgvSampele = new string[,] { };


                int pinCol        = 0;
                int netColorCol   = 0;
                int netNameCol    = 0;
                int mergeNetCol   = 0;
                int inOutCol      = 0;
                int SIgnalTypeCol = 0;

                //data該当行探索
                for (int i = 0; i < 100; i++)
                {
                    if (DgvSampele[0, i] == "PinNumber")    pinCol = i;
                    if (DgvSampele[0, i] == "NetColor")     netColorCol = i;
                    if (DgvSampele[0, i] == "netName")      netNameCol = i;
                    if (DgvSampele[0, i] == "MergeNetName") mergeNetCol = i;
                    if (DgvSampele[0, i] == "InOutType")    inOutCol = i;
                    if (DgvSampele[0, i] == "SignalType")   SIgnalTypeCol = i;
                    else continue;
                }

                for (int i = starRow; i <= endRow; i++)
                {

                    using (PortTextClass portText = new PortTextClass())
                    {
                        if (int.TryParse(DgvSampele[i, pinCol], out int num))
                        {
                            portText.PinNumber      = num;
                            portText.NetColor       = ColorTranslator.FromHtml(DgvSampele[i, netColorCol]);
                            portText.NetName        = DgvSampele[i, netNameCol];
                            portText.MergedNetName  = DgvSampele[i, mergeNetCol];
                            portText.InOutType      = DgvSampele[i, inOutCol];
                            portText.SignalType     = DgvSampele[i, SIgnalTypeCol];
                        }
                        else
                        {
                            //...
                            //pinNumber列数字変換できる場合のみデータ格納する
                            //...
                        }

                        BaseModel.PortTextData.Add(portText);
                    }

                }


            }
            catch (Exception e)
            {
                ExceptionManager.ShowExceptionDetail(e);
            }
        }
    }
}
