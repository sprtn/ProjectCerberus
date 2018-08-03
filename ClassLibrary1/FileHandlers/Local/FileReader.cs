using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.IO;

namespace ToolLibrary.FileHandlers.Local
{
    public static class FileReader
    {
        public static string ReadFile(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                new Logger.JsonLogger().LogError(e);
            }

            return string.Empty;
        }
    }
}
