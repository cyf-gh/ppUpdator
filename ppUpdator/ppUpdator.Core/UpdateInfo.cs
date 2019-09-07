using System;
using System.Collections.Generic;
using System.Text;

namespace ppUpdator.Core
{
    public class UpdateInfoModel
    {
        public string DownloadUrl { get; set; }
        public string DownloadZipType { get; set; }
        public List<string> IgnoreCopyFileNames { get; set; }

        public string RunAfterUpdate { get; set; }
        public string BaseFolderName { get; set; }
    }
}
