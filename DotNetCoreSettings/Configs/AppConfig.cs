using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreSettings.Configs
{
    public class AppConfig
    {
        public Storage Storage { get; set; }
    }

    public class Storage
    {
        public int TimeOut { get; set; }
        public BlobSettings[] Blobs { get; set; }
    }

    public class BlobSettings
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
