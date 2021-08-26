using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public class SetOfTasks
    {
        string _Version = "v";
        FileDetails fileDetails = new FileDetails();
        public string TaskOne(string[] args)
        {
            string result ="";
            try
            {
                if (args.Count() > 1)
                {
                    string version = args[0];
                    if (version.ToUpper().Contains(_Version.ToUpper()))
                    {
                        string filePath = args[1];
                        result=  fileDetails.Version(filePath);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public string TaskSecond(string[] args)
        {
            string result = "";
            try
            {
                if (args.Count() > 0)
                {
                    string version = args[0];
                    if (FileVersion.IsFileVersionExists(version))
                    {
                        string filePath = args[1];
                        result=fileDetails.Version(filePath);
                    }
                    else if (FileSize.IsFileSizeExists(version))
                    {
                        string filePath = args[1];
                        result =fileDetails.Size(filePath).ToString() ;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
