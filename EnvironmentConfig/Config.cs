using System;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace EnvironmentConfig
{
    public static class Config
    {
        private static string prefix = Assembly.GetEntryAssembly().GetName().Name.Split('.').FirstOrDefault().ToUpper();

        public static string GetAppSetting(string name)
        {
            return Environment.GetEnvironmentVariable(prefix + '.' + name.ToUpper())
                ?? ConfigurationManager.AppSettings.Get(name);
        }
    }
}
