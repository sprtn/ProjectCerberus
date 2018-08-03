using System;
using System.Collections.Generic;
using System.IO;
using ToolLibrary.FileHandlers.Logger;

namespace ToolLibrary.FileHandlers.Local
{
    public static class FileWriter
    {
        public static void WriteFile(string path, string contents)
        {
            try
            {
                if (!Directory.Exists(FileHandlersCfg.FolderPath))
                    Directory.CreateDirectory(FileHandlersCfg.FolderPath);

                if (string.IsNullOrEmpty(path))
                    path = $"Cerberus_{DateTime.Now.ToLongTimeString()}{DateTime.Now.ToBinary()}";

                path = $"{FileHandlersCfg.FolderPath}\\{path}";

                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(contents);
                }
            }
            catch (Exception e)
            {
                new JsonLogger().LogError(e);
            }
        }

        public static void WriteFile(string path, object o)
        {
            WriteFile(path, Newtonsoft.Json.JsonConvert.SerializeObject(o));
        }

        public static void WriteFile(string path, IEnumerable<object> ieo)
        {
            WriteFile(path, Newtonsoft.Json.JsonConvert.SerializeObject(ieo));
        }
    }
}
