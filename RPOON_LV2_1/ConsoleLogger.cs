using System;
using System.Collections.Generic;
using System.Text;

namespace RPOON_LV2_1
{
    class ConsoleLogger : ILogger
    {
        public void Log(ILogable data)
        {
            Console.WriteLine(data.ToString());
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
