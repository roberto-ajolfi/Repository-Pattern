using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Repository.Client.Helpers
{
    public class Config
    {
        private static IConfigurationRoot Instance = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                                .Build();

        public static string GetConnectionString(string connStringName)
        {
            return Instance.GetConnectionString(connStringName);
        }
    }
}
