using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ToolLibrary.Logger.Models;

namespace ToolLibrary.Logger
{
    public class JsonLogger
    {
        private enum LogType
        {
            Error,
            Debug
        }

        public void LogDebug()
        {
            Log(LogType.Debug, DateTime.Now.ToShortDateString());
        }

        public void LogDebug(string logObject)
        {
            Log(LogType.Debug, logObject);
        }

        public void LogDebug(LogObject logObject)
        {
            Log(LogType.Debug, logObject);
        }

        public void LogError()
        {
            Log(LogType.Error, DateTime.Now.ToShortDateString());
        }

        public void LogError(string logObject)
        {
            Log(LogType.Error, logObject);
        }

        public void LogError(LogObject logObject)
        {
            Log(LogType.Error, logObject);
        }

        private static void Log(LogType logType, string s)
        {
            Log(logType, new LogObject(s));
        }

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

                using (StreamReader sr = new StreamReader(path))
                {
                    fileInfo = sr.ReadToEnd();
                }

                if (string.IsNullOrEmpty(fileInfo))
                {
                    return;
                }

                List<LogObject> logObjects = new List<LogObject>();

                try
                {
                    logObjects =
                        Newtonsoft.Json.JsonConvert.DeserializeObject<List<LogObject>>(fileInfo);

                    logObjects.Add(obj);
                }
                catch
                {
                    logObjects = new List<LogObject>
                    {
                        obj
                    };
                }
                finally
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        if (logObjects.Count == 0)
                        {
                            logObjects.Add(new LogObject("Could not add logObjects. Is there a difference in versioning? Overwriting previous log."));
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
