using System;
using System.IO;

namespace QUp.Framework.Helpers
{
    public class LogHelpers
    {
        private static string _logFileName = string.Format("{0:yyyymmddhhmmss}", DateTime.Now);
        private static StreamWriter _streamw = null;

        //Create log file 
        public static void CreateLogFile()
        {
            string dir = @"C:\Dev\QUp.Automation.Framework\";
            if(Directory.Exists(dir))
            {
                _streamw = File.AppendText(dir + _logFileName + ".log");
            }
            else
            {
                Directory.CreateDirectory(dir);
                _streamw = File.AppendText(dir + _logFileName + ".log");
            }
        }

        //Streamwriter write method to log date and log message to file
        public static void Write(string logMessage)
        {
            _streamw.Write("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            _streamw.WriteLine("    {0}", logMessage);
            _streamw.Flush();
        }
    }
}
