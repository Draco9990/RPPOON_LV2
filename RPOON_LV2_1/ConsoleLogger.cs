using System;
using System.Collections.Generic;
using System.Text;

namespace RPOON_LV2_1
{
    class ConsoleLogger : ILogger
    {
        void ILogger.Log(ILogable data)
        {
            Console.WriteLine(data.ToString());
        }
    }
}
