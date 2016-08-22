Environment Config
==================
Environment Config is a dead simple somewhat opinionated .NET library that allows you to pull configuration from environment variables and fall back to web.config/app.config using `ConfigurationManager`.

Install
=======
    PM> Install-Package EnvironmentConfig
    
Usage
=====
Environment Config will look, first, for the environment variable `PREFIX.MYSETTING` where `PREFIX` is equal to the uppercased value of the first index of an array created from `.Split('.')` on the full assembly name. Ex: If you had an assembly named `MyProject.Common` the prefix for the environment variable would be `MYPROJECT`. The full path to an environment variable, when fetching for the value `mySetting` would be `MYPROJECT.MYSETTING`. Alternatively, you can set the appSetting `EnvironmentConfigPrefix` value to manually set the prefix.

    using EnvironmentConfig;
    
    namespace MyProject.Common.SomeNamespace
    {
        public class SomeClass
        {
            private string mySetting = Config.GetAppSetting("mySetting");
        }
    }
    
And in your `web.config` or `app.config`

    <appSettings>
        <add key="mySetting" value="myValue" />
    </appSettings>