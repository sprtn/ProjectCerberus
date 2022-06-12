using System;
using System.IO;

namespace Shared.FileHandlers
{
    public static class FileHandlersCfg
    {
        public static string FolderPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Cerberus";
        public const string RacesFolder = "\\Races";

        public static string FilePathRacesFile = $"{FolderPath}\\{RacesFolder}\\Races.txt";

        public static void GenerateFolders()
        {
            CheckFolderExistAndGenerate(FolderPath);
            CheckFolderExistAndGenerate(FolderPath + RacesFolder);
        }

        private static void CheckFolderExistAndGenerate(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
