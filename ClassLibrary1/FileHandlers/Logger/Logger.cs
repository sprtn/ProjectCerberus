using System;
using System.IO;
using System.Text;
using Shared.FileHandlers.Logger.Models;

namespace Shared.FileHandlers.Logger
{
    public class JsonLogger
    {
        private enum LogType
        {
            Error,
            Debug
        }

        #region Loggers with overrides
        public void LogDebug()
        {
            Log(LogType.Debug, DateTime.Now.ToShortDateString());
        }

        public void LogDebug(string logObject)
        {
            Log(LogType.Debug, new LogObject(logObject));
        }

        public void LogDebug(LogObject logObject)
        {
            Log(LogType.Debug, logObject);
        }

        public void LogError()
        {
            Log(LogType.Error, DateTime.Now.ToShortDateString());
        }

        public void LogError(Exception e)
        {
            Log(LogType.Error, new LogObject(e.Message));
        }

        public void LogError(string logObject)
        {
            Log(LogType.Error, new LogObject(logObject));
        }

        public void LogError(LogObject logObject)
        {
            Log(LogType.Error, logObject);
        }

        private static void Log(LogType logType, string s)
        {
            Log(logType, new LogObject(s));
        }
        #endregion

        private static void Log(LogType logType, LogObject obj)
        {
            try
            {
                SetPaths(logType, out StringBuilder dirPath, out string path);

                if (!Directory.Exists(dirPath.ToString()))
                {
                    Directory.CreateDirectory(dirPath.ToString());
                }

                string fileInfo;

                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        fileInfo = sr.ReadToEnd();
                    }
                }
                else
                {
                    fileInfo = "";
                }

                Log logObjects = new Log();

                try
                {
                    logObjects = Newtonsoft.Json.JsonConvert.DeserializeObject<Log>(fileInfo) ?? new Log();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + ":" + e.StackTrace);
                }
                finally
                {
                    logObjects.LogObjects.Add(obj);

                    using (StreamWriter sw = File.CreateText(path))
                    {
                        if (logObjects.LogObjects.Count == 0)
                        {
                            logObjects.LogObjects.Add(new LogObject("Could not add logObjects. Is there a difference in versioning? Overwriting previous log."));
                        }

                        string json = Newtonsoft.Json.JsonConvert.SerializeObject(logObjects);

                        sw.Write(json);
                    }
                }
            }
            catch (Exception e)
            {
                new JsonLogger().LogError(e.Message);
            }
        }

        private static void SetPaths(LogType logType, out StringBuilder dirPath, out string path)
        {
            dirPath = new StringBuilder(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            dirPath.Append("\\Cerberus");

            switch (logType)
            {
                case LogType.Debug:
                    path = dirPath + "\\Debug.txt";
                    break;
                case LogType.Error:
                    path = dirPath + "\\Error.txt";
                    break;
                default:
                    path = dirPath + "\\Log.txt";
                    break;
            }
        }
    }
}
