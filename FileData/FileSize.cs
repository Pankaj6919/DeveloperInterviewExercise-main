using System.Collections.Generic;
using System.Linq;

namespace FileData
{
    internal static class FileSize
    {
        static List<string> FileSizes = new List<string>();
        static FileSize()
        {
            FileSizes.Add("-s");
            FileSizes.Add("--s");
            FileSizes.Add("/s");
            FileSizes.Add("--size");
        }

        public static bool IsFileSizeExists(string size)
        {
            if (FileSizes.Any(x => x == size))
            {
                return true;
            }
            return false;
        }
    }
}
