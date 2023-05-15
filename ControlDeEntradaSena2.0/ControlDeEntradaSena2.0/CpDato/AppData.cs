using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeEntradaSena2._0.CpDato
{
    public class AppData
    {
        public const int MaxFingers = 10;

        public int EnrrolledFingerMask = 0;
        public int MaxEnrrolledFingerCount = MaxFingers;
        public bool IsEventHandlerSucceeds = true;
        public bool IsFeatureSetMatched = false;
        public int FalseAcceptRate = 0;

        public DPFP.Template[] Templates = new DPFP.Template[MaxFingers];
    }
}
