using System;
using System.Drawing;

namespace PortTextReader.Models
{
    public class PiniClass : IDisposable
    {
        public int PinNumber { get; set; }
        public Color NetColor { get; set; }
        public string NetName { get; set; }
        public string MergedNetName { get; set; }
        public string InOutType { get; set; }
        public string SignalType { get; set; }

        public void Dispose()
        {
            //....
            //アンマネージドメンバーなし
            //....
        }
    }

}
