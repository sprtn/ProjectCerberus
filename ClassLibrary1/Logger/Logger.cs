using System;
using System.IO;
using System.Text;

namespace ToolLibrary.Logger
{
    public static class Logger
    {
        public static void SetLogfolder(string path)
        {
            _logFolder = path.EndsWith("\\") ? path : $"{path}\\";

            if (!Directory.Exists(_logFolder))
            {
                Directory.CreateDirectory(_logFolder);
            }
        }

        private static string _logFolder = "";

        #region ErrorLog with override
        public static void ErrorLog(string input)
        {
            LogMetaHandler(LogType.Error, input: input);
        }

        public static void ErrorLog(Exception exception)
        {
            LogMetaHandler(LogType.Error, exception: exception);
        }

        public static void ErrorLog(string input = "", Exception exception = null)
        {
            LogMetaHandler(LogType.Error, input, exception);
        }
        #endregion

        #region DebugLog with override
        public static void DebugLog(string input)
        {
            LogMetaHandler(LogType.Debug, input: input);
        }

        public static void DebugLog(Exception exception)
        {
            LogMetaHandler(LogType.Debug, exception: exception);
        }

        public static void DebugLog(string input = "", Exception exception = null)
        {
            LogMetaHandler(LogType.Debug, input, exception);
        }
        #endregion

        private static void LogMetaHandler(LogType logType, string input = "", Exception exception = null)
        {
            if (exception == null && string.IsNullOrEmpty(input))
            {
                LogWorker(LogType.Debug, "Trying to log data which isn't provided");
            }
            else if (exception == null)
            {
                LogWorker(LogType.Debug, input: input);
            }
            else if (string.IsNullOrEmpty(input))
            {
                LogWorker(LogType.Debug, exception: exception);
            }
        }

        private static void LogWorker(LogType logType, string input = "", Exception exception = null)
        {
            try
            {
                StringBuilder fileName = new StringBuilder();

                fileName.Append(_logFolder);
                fileName.Append(logType);
                fileName.Append("_Log_");
                fileName.Append(DateTime.Today);
                fileName.Append(".txt");

                using (StreamWriter w = File.AppendText(fileName.ToString()))
                {
                    w.Write("\r\nLog Entry : ");
                    w.WriteLine($"{DateTime.Now.ToShortTimeString()} : ");
                    w.WriteLine(input);
                    w.WriteLine("-------------------------------");

                    // Handle possible incoming Exception
                    if (exception == null)
                        return;

                    w.WriteLine("Exception message : ");
                    w.WriteLine(exception.Message);
                    w.WriteLine("Exception stacktrace : ");
                    w.WriteLine(exception.StackTrace);
                    w.WriteLine("-------------------------------");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception not handled");
            }
        }

        private enum LogType
        {
            Error,
            Debug
        }
    }
}
