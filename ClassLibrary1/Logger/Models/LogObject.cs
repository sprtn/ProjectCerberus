using System;

namespace ToolLibrary.Logger.Models
{
    public class LogObject
    {
        public string Message;

        public LogObject(Exception e)
        {
            Message = e.Message;
        }

        public LogObject(string s)
        {
            Message = s;
        }
    }
}
