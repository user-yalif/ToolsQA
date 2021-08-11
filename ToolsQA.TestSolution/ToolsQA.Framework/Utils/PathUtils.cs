namespace ToolsQA.Framework.Utils
{
    using System;
    using System.IO;

    public static class PathUtils
    {
        public static string CreatePathFromAppBaseDirectory(string pathToCombine) =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, pathToCombine);
    }
}
