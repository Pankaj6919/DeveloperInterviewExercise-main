using System.Collections.Generic;
using System.Linq;

namespace FileData
{
    internal static class FileVersion
    {
        static List<string> FileVersions = new List<string>();
        static FileVersion()
        {
            FileVersions.Add("-v");
            FileVersions.Add("--v");
            FileVersions.Add("/v");
            FileVersions.Add("--version");
        }

        public static bool IsFileVersionExists(string version)
        {
            if (FileVersions.Any(x => x == version))
            {
                return true;
            }
            return false;
        }
    }
}
