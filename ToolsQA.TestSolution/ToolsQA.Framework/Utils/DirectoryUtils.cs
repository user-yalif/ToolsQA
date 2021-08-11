namespace ToolsQA.Framework.Utils
{
    using System.IO;

    public static class DirectoryUtils
    {
        public static void CreateDirectoryIfDoNotExist(string pathToDirectory)
        {
            if (!Directory.Exists(pathToDirectory))
            {
                Directory.CreateDirectory(pathToDirectory);
            }
        }
    }
}
