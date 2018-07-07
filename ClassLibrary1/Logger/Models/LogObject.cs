using System;

namespace ToolLibrary.Logger.Models
{
    public class LogObject
    {
        public string Message;
        public string CreateDate;
        public string CreateTime;

        public LogObject(Exception e)
        {
            Message = e.Message;
            SetCreateDateTime();
        }

        public LogObject(string s)
        {
            Message = s;
            SetCreateDateTime();
        }

        public LogObject()
        {
            SetCreateDateTime();
        }

        private void SetCreateDateTime()
        {
            CreateDate = DateTime.Now.ToLongDateString();
            CreateTime = DateTime.Now.ToLongTimeString();
        }
    }
}
