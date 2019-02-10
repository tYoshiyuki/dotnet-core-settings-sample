using DotNetCoreSettings.Configs;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace DotNetCoreSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 設定ファイルの読み込み
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // 設定値の取得
            var appConfig = new AppConfig();
            config.Bind(appConfig);

            // 取得した設定値の確認
            Console.WriteLine("TimeOut:" + appConfig.Storage.TimeOut);
            foreach(var blob in appConfig.Storage.Blobs)
            {
                Console.WriteLine("Name:" + blob.Name);
                Console.WriteLine("Url:" + blob.Url);
            }
        }
    }
}
