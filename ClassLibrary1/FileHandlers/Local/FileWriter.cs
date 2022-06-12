using System;
using System.Collections.Generic;
using System.IO;
using Shared.FileHandlers.Logger;

namespace Shared.FileHandlers.Local
{
    public static class FileWriter
    {
        public static void WriteFile(string name, string contents)
        {
            try
            {
                using (StreamWriter sw = File.CreateText(FileHandlersCfg.FilePathRacesFile))
                {
                    sw.Write(contents);
                }
            }
            catch (Exception e)
            {
                new JsonLogger().LogError(e);
            }
        }

        public static void WriteFile(string name, object o)
        {
            WriteFile(name, Newtonsoft.Json.JsonConvert.SerializeObject(o));
        }

        public static void WriteFile(string name, IEnumerable<object> ieo)
        {
            WriteFile(name, Newtonsoft.Json.JsonConvert.SerializeObject(ieo));
        }
    }
}
