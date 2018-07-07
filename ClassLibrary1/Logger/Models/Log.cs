using System;
using System.Collections.Generic;

namespace ToolLibrary.Logger.Models
{
    public class Log
    {
        public List<LogObject> LogObjects = new List<LogObject>();
        public string CreateTime;

        public Log()
        {
            SetCreateTime();
        }

        public Log(List<LogObject> logObjects)
        {
            foreach (LogObject logObject in logObjects)
            {
                LogObjects.Add(logObject);
            }

            SetCreateTime();
        }

        public Log(LogObject logObject)
        {
            LogObjects.Add(logObject);

            SetCreateTime();
        }

        private void SetCreateTime()
        {
            CreateTime = DateTime.Now.ToLongTimeString();
        }
    }
}
