using System;
using System.IO;

namespace ATM
{
    public class Log : ILog
    {
        private StreamWriter _log;
        private string _path = "../../ATM_Log" + DateTime.Now.ToString("yyyyMMdd") + ".txt";

        Log(ISeparation sep)
        {
            

            _log.AutoFlush = true;
        }

        public void CreateLog()
        {
            _log = new StreamWriter(_path, true);
        }
    }
}
