using System;
using System.Collections.Generic;
using System.Text;

namespace RPOON_LV2_1
{
    class FileLogger : ILogger
    {
        private string filePath;

        public FileLogger(string filePathIn)
        {
            filePath = filePathIn;
        }

        void ILogger.Log(ILogable data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath))
            {
                writer.WriteLine(data.ToString());
            }
        }
    }
}
