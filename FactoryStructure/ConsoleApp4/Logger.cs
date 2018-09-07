using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
    class Logger
    {
        private static Logger log = null;
        private FileStream fsObject;
        private StreamWriter swObject;
        private Logger()
        {
            fsObject = new FileStream("c:\\Logging.txt", FileMode.Append, FileAccess.Write);
            swObject = new StreamWriter(fsObject);

        }
        public static Logger GetInstance()
        {
            if (log == null)
                log = new Logger();
            return log;

        }
        public void LogMessages(String msg)
        {
            swObject.WriteLine(msg);
            swObject.Flush();
        }
        
    }
}
