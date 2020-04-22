using System;
using System.Collections.Generic;
using System.Text;

namespace RPOON_LV2_1
{
    interface ILogger
    {
        void Log(string message);
        void Log(ILogable data);
    }
}
