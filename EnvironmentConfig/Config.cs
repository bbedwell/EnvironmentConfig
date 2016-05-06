using System;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace EnvironmentConfig
{
    public static class Config
    {
        public static string GetAppSetting(string name)
        {
            var prefix = Assembly.GetCallingAssembly().GetName().Name.Split('.').FirstOrDefault().ToUpper();
            return Environment.GetEnvironmentVariable(prefix + '.' + name.ToUpper())
                ?? ConfigurationManager.AppSettings.Get(name);
        }
    }
}
