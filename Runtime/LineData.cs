using System;

namespace NmiEditor
{
    [Serializable]
    public class LineData
    {
        public string InputNodeGUID;
        public string OutputNodeGUID;
        public string PortName;
    }
}