using System;
using System.IO;
using System.Globalization;

namespace ATM
{
    public class Log : ILog
    {
        private StreamWriter _log;
        private string _path = "../../ATM_Log" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
        

        Log(string newData)
        {
            _log.WriteLineAsync(newData);

            _log.AutoFlush = true;
        }

        public void CreateLog()
        {
            _log = new StreamWriter(_path, true);
        }
    }
}
